using MongoDB.Driver;
using EmployeeApp.Models;
using System.Collections.Generic;

namespace EmployeeApp.Services
{
    public class EmployeeService
    {
        private readonly IMongoCollection<Employee> _employees;

        public EmployeeService()
        {
            var db = MongoConnection.GetDatabase();
            _employees = db.GetCollection<Employee>("Employee");
        }

        public Employee Login(string employeeID, string password)
        {
            return _employees
                .Find(e => e.EmployeeID == employeeID && e.Password == password)
                .FirstOrDefault();
        }

        public void AddEmployee(Employee emp)
        {
            _employees.InsertOne(emp);
        }
    }
}