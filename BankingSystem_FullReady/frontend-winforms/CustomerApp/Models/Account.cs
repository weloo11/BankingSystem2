namespace CustomerApp.Models {
    public class Account {
        public string accountID { get; set; }
        public string customerID { get; set; }
        public string employeeID { get; set; }
        public double balance { get; set; }
        public string currency { get; set; }
        public System.DateTime openDate { get; set; }
        public string accountType { get; set; }
        public string status { get; set; }
    }
}
