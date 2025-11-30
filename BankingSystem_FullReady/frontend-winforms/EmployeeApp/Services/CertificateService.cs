using MongoDB.Driver;
using EmployeeApp.Models;
using System.Collections.Generic;

namespace EmployeeApp.Services
{
    public class CertificateService
    {
        private readonly IMongoCollection<BankCertificate> _certs;

        public CertificateService()
        {
            var db = MongoConnection.GetDatabase();
            _certs = db.GetCollection<BankCertificate>("BankCertificate");
        }

        public List<BankCertificate> GetPendingCertificates()
        {
            return _certs.Find(c => c.Status == "Pending").ToList();
        }

        public void ApproveCertificate(string certID)
        {
            var update = Builders<BankCertificate>.Update.Set(c => c.Status, "Approved");
            _certs.UpdateOne(c => c.CertificateID == certID, update);
        }

        public void RejectCertificate(string certID)
        {
            var update = Builders<BankCertificate>.Update.Set(c => c.Status, "Rejected");
            _certs.UpdateOne(c => c.CertificateID == certID, update);
        }
    }
}