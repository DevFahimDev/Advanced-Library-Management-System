using System;
using System.Windows.Forms;
using AdvancedLibrarySystem.BLL;

namespace WindowsFormsApp2.UI
{
    public partial class LoginForm : Form
    {
        private string currentRole;

        public LoginForm(string role)
        {
            InitializeComponent();
            currentRole = role;
            this.DoubleBuffered = true;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string cleanName = txtUsername.Text.Trim();
            string cleanPass = txtPassword.Text.Trim();

            if (string.IsNullOrWhiteSpace(cleanName) || string.IsNullOrWhiteSpace(cleanPass))
            {
                MessageBox.Show("Please enter both Name and Password.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                LibraryManager manager = new LibraryManager();

                bool isValid = manager.Login(cleanName, cleanPass, currentRole);

                if (isValid)
                {
                    if (currentRole == "Management")
                    {
                        new ManagementDashboard().Show();
                    }
                    else
                    {
                        new StudentDashboard(cleanName).Show();
                    }
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid Entry. Please check your credentials and role.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Connection Error: " + ex.Message, "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            new RegisterForm(currentRole).Show();
            this.Hide();
        }

        private void LoginForm_Load(object sender, EventArgs e) { }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            WelcomeForm welcome = new WelcomeForm();
            welcome.Show();
            this.Hide();
        }
    }
}