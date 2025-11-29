namespace CustomerApp.Models {
    public class Certificate {
        public string certificateID { get; set; }
        public string accountID { get; set; }
        public System.DateTime issueDate { get; set; }
        public System.DateTime expiryDate { get; set; }
        public double amount { get; set; }
        public double interest { get; set; }
    }
}
