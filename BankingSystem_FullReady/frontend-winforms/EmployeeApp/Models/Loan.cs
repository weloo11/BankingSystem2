namespace EmployeeApp.Models {
    public class Loan {
        public string loanID { get; set; }
        public string accountID { get; set; }
        public double amount { get; set; }
        public double interestRate { get; set; }
        public System.DateTime issueDate { get; set; }
        public string status { get; set; }
        public System.DateTime dueDate { get; set; }
    }
}
