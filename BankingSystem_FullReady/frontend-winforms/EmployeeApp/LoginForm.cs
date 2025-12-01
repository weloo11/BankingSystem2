using System;
using System.Windows.Forms;

namespace EmployeeApp
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();

            this.WindowState = FormWindowState.Maximized;
            this.Resize += (s, e) => CenterControls();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            CenterControls();
        }

        private void CenterControls()
        {
            int centerX = (this.ClientSize.Width - panelLogin.Width) / 2;
            int centerY = (this.ClientSize.Height - panelLogin.Height) / 2;

            panelLogin.Left = centerX;
            panelLogin.Top = centerY;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string id = txtEmployeeID.Text.Trim();
            string pass = txtPassword.Text.Trim();

            if (id == "" || pass == "")
            {
                MessageBox.Show("Please fill in both fields.");
                return;
            }

            var service = new Services.EmployeeService();
            var emp = service.Login(id, pass);

            if (emp == null)
            {
                MessageBox.Show("Invalid credentials.");
                return;
            }

            EmployeeHomeForm home = new EmployeeHomeForm(emp);
            home.Show();
            this.Hide();
        }
    }
}