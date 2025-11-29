namespace ATMApp.Models {
    public class Transaction {
        public string transactionID { get; set; }
        public string accountID { get; set; }
        public string atmID { get; set; }
        public System.DateTime date { get; set; }
        public double amount { get; set; }
        public string type { get; set; }
    }
}
