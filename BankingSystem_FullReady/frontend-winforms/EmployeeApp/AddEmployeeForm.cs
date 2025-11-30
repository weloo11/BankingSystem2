using System;
using System.Windows.Forms;
using EmployeeApp.Models;
using EmployeeApp.Services;

namespace EmployeeApp
{
    public partial class AddEmployeeForm : Form
    {
        private readonly EmployeeService _employeeService = new EmployeeService();

        public AddEmployeeForm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string id = txtEmployeeID.Text.Trim();
            string name = txtName.Text.Trim();
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrWhiteSpace(id) ||
                string.IsNullOrWhiteSpace(name) ||
                string.IsNullOrWhiteSpace(email) ||
                string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please fill all fields.");
                return;
            }

            try
            {
                var emp = new Employee
                {
                    EmployeeID = id,
                    Name = name,
                    Email = email,
                    Password = password
                };

                _employeeService.AddEmployee(emp);
                MessageBox.Show("Employee added successfully.");
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding employee: " + ex.Message);
            }
        }

        private void ClearFields()
        {
            txtEmployeeID.Text = "";
            txtName.Text = "";
            txtEmail.Text = "";
            txtPassword.Text = "";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}