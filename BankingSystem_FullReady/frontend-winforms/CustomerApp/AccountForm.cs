using System;
using System.Windows.Forms;
using CustomerApp.Models;
using MongoDB.Driver;
using CustomerApp.Services;

namespace CustomerApp
{
    public partial class AccountForm : Form
    {
        private Customer _customer;
        private Account _account;

        private readonly IMongoCollection<Customer> _customerCollection;

        public AccountForm()
        {
            InitializeComponent();
        }

        public AccountForm(Customer customer, Account account)
        {
            _customer = customer;
            _account = account;

            var db = MongoConnection.GetDatabase();
            _customerCollection = db.GetCollection<Customer>("Customer");

            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            // LEFT PANEL INFO
            lblName.Text = _customer.name;
            lblEmail.Text = _customer.email;
            lblPhone.Text = _customer.phone;
            lblAddress.Text = _customer.address;

            lblBalance.Text = $"{_account.balance:0.00} {_account.currency}";
            lblCurrency.Text = _account.currency;
            lblType.Text = _account.accountType;
            lblStatus.Text = _account.status;
            lblOpenDate.Text = _account.openDate.ToString("yyyy-MM-dd");

            string masked = "**** **** **** " + _account.card.cardNo.Substring(_account.card.cardNo.Length - 4);
            lblCardNo.Text = masked;
            lblCVV.Text = _account.card.cvv;
            lblExpiry.Text = _account.card.expiryDate.ToString("yyyy-MM-dd");
        }

        private async void btnChangePass_Click(object sender, EventArgs e)
        {
            string oldPass = txtOldPass.Text.Trim();
            string newPass = txtNewPass.Text.Trim();
            string confirmPass = txtConfirmPass.Text.Trim();

            if (oldPass != _customer.password)
            {
                MessageBox.Show("Old password is incorrect.");
                return;
            }

            if (newPass.Length < 4)
            {
                MessageBox.Show("Password must be at least 4 characters.");
                return;
            }

            if (newPass != confirmPass)
            {
                MessageBox.Show("New passwords do not match.");
                return;
            }

            // UPDATE IN DATABASE
            var update = Builders<Customer>.Update.Set("password", newPass);
            await _customerCollection.UpdateOneAsync(c => c.customerID == _customer.customerID, update);

            _customer.password = newPass;

            MessageBox.Show("Password updated successfully!");
            txtOldPass.Text = txtNewPass.Text = txtConfirmPass.Text = "";
        }
    }
}
 