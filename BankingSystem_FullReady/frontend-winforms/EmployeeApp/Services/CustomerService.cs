using System.Collections.Generic;
using MongoDB.Driver;
using EmployeeApp.Models;

namespace EmployeeApp.Services
{
    public class CustomerService
    {
        private readonly IMongoCollection<Customer> _customers;

        public CustomerService()
        {
            var db = MongoConnection.GetDatabase();
            _customers = db.GetCollection<Customer>("Customer");
        }

        public List<Customer> SearchCustomer(string search)
        {
            if (string.IsNullOrWhiteSpace(search))
            {
                return _customers.Find(FilterDefinition<Customer>.Empty).ToList();
            }

            var filter = Builders<Customer>.Filter.Or(
                Builders<Customer>.Filter.Regex("customerID", search),
                Builders<Customer>.Filter.Regex("name", search),
                Builders<Customer>.Filter.Regex("email", search),
                Builders<Customer>.Filter.Regex("phone", search)
            );

            return _customers.Find(filter).ToList();
        }

        public Customer GetCustomer(string id)
        {
            return _customers.Find(c => c.CustomerID == id).FirstOrDefault();
        }
    }
}