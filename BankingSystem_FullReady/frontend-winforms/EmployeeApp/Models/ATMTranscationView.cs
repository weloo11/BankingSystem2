namespace EmployeeApp.Models
{
    public class ATMTransactionView
    {
        public string atmID { get; set; }
        public string status { get; set; }
        public string transactionID { get; set; }
        public string accountID { get; set; }
        public double amount { get; set; }
        public string type { get; set; }
    }
}
