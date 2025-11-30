using MongoDB.Driver;
using EmployeeApp.Models;
using System.Collections.Generic;

namespace EmployeeApp.Services
{
    public class LoanService
    {
        private readonly IMongoCollection<Loan> _loans;

        public LoanService()
        {
            var db = MongoConnection.GetDatabase();
            _loans = db.GetCollection<Loan>("Loans");
        }

        public List<Loan> GetPendingLoans()
        {
            return _loans.Find(l => l.Status == "Pending").ToList();
        }

        public void ApproveLoan(string loanID)
        {
            var update = Builders<Loan>.Update.Set(l => l.Status, "Approved");
            _loans.UpdateOne(l => l.LoanID == loanID, update);
        }

        public void RejectLoan(string loanID)
        {
            var update = Builders<Loan>.Update.Set(l => l.Status, "Rejected");
            _loans.UpdateOne(l => l.LoanID == loanID, update);
        }
    }
}