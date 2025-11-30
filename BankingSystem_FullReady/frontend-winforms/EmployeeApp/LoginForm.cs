using System;
using System.Windows.Forms;
using EmployeeApp.Services;
using EmployeeApp.Models;

namespace EmployeeApp
{
    public partial class LoginForm : Form
    {
        private readonly EmployeeService _employeeService = new EmployeeService();

        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string id = txtEmployeeID.Text.Trim();
            string pass = txtPassword.Text.Trim();

            if (id == "" || pass == "")
            {
                MessageBox.Show("Please enter both Employee ID and Password.");
                return;
            }

            Employee emp = _employeeService.Login(id, pass);

            if (emp == null)
            {
                MessageBox.Show("Invalid Credentials!");
                return;
            }

            EmployeeHomeForm home = new EmployeeHomeForm(emp);
            home.Show();
            this.Hide();
        }
    }
}