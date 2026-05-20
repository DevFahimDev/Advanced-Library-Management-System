using System;
using System.Drawing;
using System.Windows.Forms;
using AdvancedLibrarySystem.BLL;

namespace WindowsFormsApp2.UI
{
    public partial class StudentDashboard : Form
    {
        private string loggedInStudent;

        public StudentDashboard(string studentName)
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            loggedInStudent = studentName;

            RefreshGrid();
        }

        private void RefreshGrid()
        {
            LibraryManager manager = new LibraryManager();
            dgvData.DataSource = manager.FetchBooksForDisplay();
        }

       
        private void btnAddWishlist_Click(object sender, EventArgs e)
        {
            Form popup = new Form() { Size = new Size(400, 250), StartPosition = FormStartPosition.CenterParent, FormBorderStyle = FormBorderStyle.FixedDialog, Text = "Add to Wishlist", BackColor = Color.Black, ForeColor = Color.White };

            Label lbl = new Label() { Text = "Select Book to Wishlist:", Location = new Point(50, 30), AutoSize = true, Font = new Font("Segoe UI", 12, FontStyle.Bold) };
            ComboBox cmbBooks = new ComboBox() { Location = new Point(50, 70), Width = 280, Font = new Font("Segoe UI", 10), DropDownStyle = ComboBoxStyle.DropDownList };
            Button btnSubmit = new Button() { Text = "❤️ ADD TO WISHLIST", Location = new Point(50, 120), Width = 280, Height = 45, BackColor = Color.MediumPurple, ForeColor = Color.White, Font = new Font("Segoe UI", 10, FontStyle.Bold), FlatStyle = FlatStyle.Flat };

            LibraryManager manager = new LibraryManager();
            cmbBooks.DataSource = manager.FetchBooksForDisplay();
            cmbBooks.DisplayMember = "Title";
            cmbBooks.ValueMember = "BookID";

            btnSubmit.Click += (s, args) =>
            {
                if (cmbBooks.SelectedValue == null) return;

                int bookId = (int)cmbBooks.SelectedValue;

                string resultMessage = manager.AddBookToWishlist(loggedInStudent, bookId);

                if (resultMessage == "Success")
                {
                    MessageBox.Show("Book added to your wishlist!", "Success");
                    popup.Close();
                }
                else
                {
                    MessageBox.Show(resultMessage, "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            };

            popup.Controls.Add(lbl); popup.Controls.Add(cmbBooks); popup.Controls.Add(btnSubmit);
            popup.ShowDialog();
        }
        
        private void btnViewWishlist_Click(object sender, EventArgs e)
        {
            LibraryManager manager = new LibraryManager();

            dgvData.DataSource = manager.FetchWishlistForDisplay(loggedInStudent);
        }

        
        private void btnViewAllBooks_Click(object sender, EventArgs e)
        {
            RefreshGrid();
        }
       
        private void btnRemoveWishlist_Click(object sender, EventArgs e)
        {
            Form popup = new Form() { Size = new Size(400, 250), StartPosition = FormStartPosition.CenterParent, FormBorderStyle = FormBorderStyle.FixedDialog, Text = "Remove from Wishlist", BackColor = Color.Black, ForeColor = Color.White };

            Label lbl = new Label() { Text = "Select Book to Remove:", Location = new Point(50, 30), AutoSize = true, Font = new Font("Segoe UI", 12, FontStyle.Bold) };
            ComboBox cmbBooks = new ComboBox() { Location = new Point(50, 70), Width = 280, Font = new Font("Segoe UI", 10), DropDownStyle = ComboBoxStyle.DropDownList };
            Button btnSubmit = new Button() { Text = "❌ REMOVE FROM WISHLIST", Location = new Point(50, 120), Width = 280, Height = 45, BackColor = Color.Crimson, ForeColor = Color.White, Font = new Font("Segoe UI", 10, FontStyle.Bold), FlatStyle = FlatStyle.Flat };

            LibraryManager manager = new LibraryManager();

            cmbBooks.DataSource = manager.FetchWishlistForDisplay(loggedInStudent);
            cmbBooks.DisplayMember = "Title";
            cmbBooks.ValueMember = "BookID";

            btnSubmit.Click += (s, args) =>
            {
                if (cmbBooks.SelectedValue == null) return;

                int bookId = (int)cmbBooks.SelectedValue;

                if (manager.RemoveBookFromWishlist(loggedInStudent, bookId))
                {
                    MessageBox.Show("Book removed from your wishlist!", "Success");

                    dgvData.DataSource = manager.FetchWishlistForDisplay(loggedInStudent);

                    popup.Close();
                }
                else
                {
                    MessageBox.Show("Could not remove book. It may have already been deleted.", "Error");
                }
            };

            popup.Controls.Add(lbl); popup.Controls.Add(cmbBooks); popup.Controls.Add(btnSubmit);
            popup.ShowDialog();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            new WelcomeForm().Show();
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}