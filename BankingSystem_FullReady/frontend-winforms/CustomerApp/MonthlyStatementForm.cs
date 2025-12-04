using System;
using System.Windows.Forms;
using CustomerApp.Services;
using CustomerApp.Models;

namespace CustomerApp
{
    public partial class MonthlyStatementForm : Form
    {
        private readonly MonthlyStatementService _service = new MonthlyStatementService();
        private readonly string _accountID;

        public MonthlyStatementForm(string accountID)
        {
            InitializeComponent();
            _accountID = accountID;
        }

        private void MonthlyStatementForm_Load(object sender, EventArgs e)
        {
            // Fill months
            comboMonth.Items.AddRange(new string[]
            {
                "January","February","March","April","May","June",
                "July","August","September","October","November","December"
            });
            comboMonth.SelectedIndex = DateTime.Now.Month - 1;

            // Fill years
            for (int year = DateTime.Now.Year - 5; year <= DateTime.Now.Year; year++)
                comboYear.Items.Add(year.ToString());
            comboYear.Text = DateTime.Now.Year.ToString();

            LoadStatements();
        }

        private void LoadStatements()
        {
            dataGridView1.DataSource = _service.GetStatements(_accountID);
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            if (comboMonth.SelectedIndex < 0 || string.IsNullOrEmpty(comboYear.Text))
            {
                MessageBox.Show("Please select month and year.");
                return;
            }

            int month = comboMonth.SelectedIndex + 1;
            int year = int.Parse(comboYear.Text);

            var s = _service.GenerateStatement(_accountID, year, month);

            lblDeposited.Text = s.totalDeposited.ToString("0.00");
            lblWithdrawn.Text = s.totalWithdrawn.ToString("0.00");
            lblBalance.Text = s.accountBalance.ToString("0.00");

            LoadStatements();
            MessageBox.Show("Monthly Statement Generated");
        }
    }
}