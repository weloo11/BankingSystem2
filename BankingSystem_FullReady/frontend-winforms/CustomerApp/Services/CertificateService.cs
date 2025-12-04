using MongoDB.Driver;
using MongoDB.Bson;
using CustomerApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CustomerApp.Services
{
	public class CertificateDisplay
	{
		public string certificateID { get; set; }
		public string accountID { get; set; }
		public DateTime issueDate { get; set; }
		public DateTime expiryDate { get; set; }
		public double amount { get; set; }
		public double interest { get; set; }
		public string status { get; set; }
	}

	public class CertificateService
	{
		private readonly IMongoCollection<Certificate> _certs;

		public CertificateService()
		{
			var db = MongoConnection.GetDatabase();
			_certs = db.GetCollection<Certificate>("BankCertificate");
		}

		public void Insert(Certificate cert)
		{
			_certs.InsertOne(cert);
		}

		public List<CertificateDisplay> GetAll()
		{
			return _certs.Find(_ => true)
				.ToList()
				.Select(c => new CertificateDisplay
				{
					certificateID = c.certificateID,
					accountID = c.accountID,
					issueDate = c.issueDate,
					expiryDate = c.expiryDate,
					amount = c.amount,
					interest = c.interest,
					status = c.status
				})
				.ToList();
		}

		public void UpdateStatus(string certificateID, string status)
		{
			var filter = Builders<Certificate>.Filter.Eq(c => c.certificateID, certificateID);
			var update = Builders<Certificate>.Update.Set(c => c.status, status);
			_certs.UpdateOne(filter, update);
		}

		public void Delete(string certificateID)
		{
			_certs.DeleteOne(c => c.certificateID == certificateID);
		}

		public List<dynamic> CountByStatus()
		{
			var pipeline = new[]
			{
				new BsonDocument("$group", new BsonDocument {
					{ "_id", "$status" },
					{ "count", new BsonDocument("$sum", 1) }
				})
			};

			return _certs.Aggregate<BsonDocument>(pipeline)
				.ToList()
				.Select(x => new
				{
					status = x["_id"].AsString,
					count = x["count"].ToInt32()
				})
				.ToList<dynamic>();
		}

		public double SumApproved()
		{
			var pipeline = new[]
			{
				new BsonDocument("$match", new BsonDocument("status", "Approved")),
				new BsonDocument("$group", new BsonDocument
				{
					{ "_id", "Approved" },
					{ "totalAmount", new BsonDocument("$sum", "$amount") }
				})
			};

			var result = _certs.Aggregate<BsonDocument>(pipeline).FirstOrDefault();
			return result?["totalAmount"].ToDouble() ?? 0;
		}

		public List<CertificateDisplay> ExpiringSoon()
		{
			DateTime now = DateTime.Now;
			DateTime limit = now.AddMonths(6);

			return _certs.Find(c => c.expiryDate <= limit && c.expiryDate >= now)
				.ToList()
				.Select(c => new CertificateDisplay
				{
					certificateID = c.certificateID,
					accountID = c.accountID,
					issueDate = c.issueDate,
					expiryDate = c.expiryDate,
					amount = c.amount,
					interest = c.interest,
					status = c.status
				})
				.ToList();
		}

		public List<dynamic> AvgInterest()
		{
			var pipeline = new[]
			{
				new BsonDocument("$group", new BsonDocument {
					{ "_id", "$accountID" },
					{ "avgInterest", new BsonDocument("$avg", "$interest") }
				})
			};

			return _certs.Aggregate<BsonDocument>(pipeline)
				.ToList()
				.Select(x => new
				{
					accountID = x["_id"].AsString,
					avgInterest = x["avgInterest"].ToDouble()
				})
				.ToList<dynamic>();
		}
	}
}