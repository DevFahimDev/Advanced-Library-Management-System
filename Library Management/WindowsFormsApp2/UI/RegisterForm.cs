using System;
using System.Windows.Forms;
using AdvancedLibrarySystem.BLL;

namespace WindowsFormsApp2.UI
{
    public partial class RegisterForm : Form
    {
        private string roleToRegister;

        public RegisterForm(string role)
        {
            InitializeComponent();
            roleToRegister = role;
            this.DoubleBuffered = true;
        }

        private void btnSubmitRegister_Click(object sender, EventArgs e)
        {
            string newName = txtUsername.Text.Trim();
            string newPass = txtPassword.Text.Trim();

            if (string.IsNullOrWhiteSpace(newName) || string.IsNullOrWhiteSpace(newPass))
            {
                MessageBox.Show("Please fill in all fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                LibraryManager manager = new LibraryManager();
                bool success = manager.RegisterNewUser(newName, newPass, roleToRegister);

                if (success)
                {
                    MessageBox.Show($"Account Created Successfully as {roleToRegister}! Please login.", "Success");
                    LoginForm login = new LoginForm(roleToRegister);
                    login.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Database error. Could not create account.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Connection Error: " + ex.Message, "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBackToLogin_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm(roleToRegister);
            login.Show();
            this.Hide();
        }

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

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}