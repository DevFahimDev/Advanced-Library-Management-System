using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AdvancedLibrarySystem.BLL;

namespace WindowsFormsApp2.UI
{
    public partial class ManagementDashboard : Form
    {
        public ManagementDashboard()
        {
            InitializeComponent();
            this.DoubleBuffered = true;

            this.DoubleBuffered = true;

            RefreshGrid();
        }

        private void RefreshGrid()
        {
            LibraryManager manager = new LibraryManager();

            
            dgvData.DataSource = manager.FetchBooksForDisplay();
        }
       
        private void btnAddBook_Click(object sender, EventArgs e)
        {
            Form popup = new Form() { Size = new Size(400, 250), StartPosition = FormStartPosition.CenterParent, FormBorderStyle = FormBorderStyle.FixedDialog, Text = "Add New Book", BackColor = Color.Black, ForeColor = Color.White };

            Label lbl = new Label() { Text = "Enter Book Name:", Location = new Point(50, 40), AutoSize = true, Font = new Font("Segoe UI", 12, FontStyle.Bold) };
            TextBox txtName = new TextBox() { Location = new Point(50, 80), Width = 280, Font = new Font("Segoe UI", 12) };
            Button btnSubmit = new Button() { Text = "ADD BOOK", Location = new Point(50, 130), Width = 280, Height = 45, BackColor = Color.FromArgb(245, 189, 2), ForeColor = Color.Black, Font = new Font("Segoe UI", 10, FontStyle.Bold), FlatStyle = FlatStyle.Flat };

            btnSubmit.Click += (s, args) =>
            {
                string newTitle = txtName.Text.Trim();
                if (string.IsNullOrWhiteSpace(newTitle)) { MessageBox.Show("Please enter a book name."); return; }

                LibraryManager manager = new LibraryManager();
                if (manager.AddNewBook(newTitle))
                {
                    MessageBox.Show("Book added successfully!", "Success");
                    RefreshGrid(); 
                    popup.Close();
                }
            };

            popup.Controls.Add(lbl); popup.Controls.Add(txtName); popup.Controls.Add(btnSubmit);
            popup.ShowDialog();
        }

       
        private void btnRemoveBook_Click(object sender, EventArgs e)
        {
            Form popup = new Form() { Size = new Size(400, 250), StartPosition = FormStartPosition.CenterParent, FormBorderStyle = FormBorderStyle.FixedDialog, Text = "Remove Book", BackColor = Color.Black, ForeColor = Color.White };

            Label lbl = new Label() { Text = "Select Book to Remove:", Location = new Point(50, 30), AutoSize = true, Font = new Font("Segoe UI", 12, FontStyle.Bold) };
            ComboBox cmbBooks = new ComboBox() { Location = new Point(50, 70), Width = 280, Font = new Font("Segoe UI", 10), DropDownStyle = ComboBoxStyle.DropDownList };

            Button btnSubmit = new Button() { Text = "❌ REMOVE BOOK", Location = new Point(50, 120), Width = 280, Height = 45, BackColor = Color.Crimson, ForeColor = Color.White, Font = new Font("Segoe UI", 10, FontStyle.Bold), FlatStyle = FlatStyle.Flat };

            LibraryManager manager = new LibraryManager();
            cmbBooks.DataSource = manager.FetchBooksForDisplay();
            cmbBooks.DisplayMember = "Title"; 
            cmbBooks.ValueMember = "BookID"; 

            btnSubmit.Click += (s, args) =>
            {
                if (cmbBooks.SelectedValue == null) return;

                int bookId = (int)cmbBooks.SelectedValue;
                if (manager.RemoveBook(bookId))
                {
                    MessageBox.Show("Book removed forever!", "Success");
                    RefreshGrid(); 
                    popup.Close();
                }
            };

            popup.Controls.Add(lbl); popup.Controls.Add(cmbBooks); popup.Controls.Add(btnSubmit);
            popup.ShowDialog();
        }

        private void btnNavBooks_Click(object sender, EventArgs e)
        {
           
            if (pnlBooksDropdown.Visible == false)
            {
                pnlBooksDropdown.Visible = true;
            }
            else
            {
                pnlBooksDropdown.Visible = false;
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            WelcomeForm welcome = new WelcomeForm();
            welcome.Show();

            this.Close();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dgvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}