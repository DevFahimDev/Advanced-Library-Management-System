namespace WindowsFormsApp2.UI
{
    partial class StudentDashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlSidebar = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.btnRemoveWishlist = new Guna.UI2.WinForms.Guna2Button();
            this.btnViewAllBooks = new Guna.UI2.WinForms.Guna2Button();
            this.btnViewWishlist = new Guna.UI2.WinForms.Guna2Button();
            this.btnAddWishlist = new Guna.UI2.WinForms.Guna2Button();
            this.btnNavUsers = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnLogout = new Guna.UI2.WinForms.Guna2GradientButton();
            this.pnlHeader = new Guna.UI2.WinForms.Guna2Panel();
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.dgvData = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.pnlSidebar.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSidebar
            // 
            this.pnlSidebar.BackColor = System.Drawing.Color.Black;
            this.pnlSidebar.BackgroundImage = global::WindowsFormsApp2.Properties.Resources.Gemini_Generated_Image_g7atrsg7atrsg7at;
            this.pnlSidebar.BorderColor = System.Drawing.Color.Transparent;
            this.pnlSidebar.BorderRadius = 50;
            this.pnlSidebar.Controls.Add(this.btnRemoveWishlist);
            this.pnlSidebar.Controls.Add(this.btnViewAllBooks);
            this.pnlSidebar.Controls.Add(this.btnViewWishlist);
            this.pnlSidebar.Controls.Add(this.btnAddWishlist);
            this.pnlSidebar.Controls.Add(this.btnNavUsers);
            this.pnlSidebar.Controls.Add(this.guna2HtmlLabel1);
            this.pnlSidebar.Controls.Add(this.btnLogout);
            this.pnlSidebar.CustomBorderColor = System.Drawing.Color.Transparent;
            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSidebar.FillColor = System.Drawing.Color.Transparent;
            this.pnlSidebar.FillColor2 = System.Drawing.Color.Transparent;
            this.pnlSidebar.ForeColor = System.Drawing.Color.Transparent;
            this.pnlSidebar.Location = new System.Drawing.Point(0, 0);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Size = new System.Drawing.Size(250, 1034);
            this.pnlSidebar.TabIndex = 3;
            // 
            // btnRemoveWishlist
            // 
            this.btnRemoveWishlist.Animated = true;
            this.btnRemoveWishlist.BackColor = System.Drawing.Color.Transparent;
            this.btnRemoveWishlist.BorderRadius = 10;
            this.btnRemoveWishlist.BorderThickness = 3;
            this.btnRemoveWishlist.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRemoveWishlist.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRemoveWishlist.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRemoveWishlist.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRemoveWishlist.FillColor = System.Drawing.Color.Transparent;
            this.btnRemoveWishlist.Font = new System.Drawing.Font("Perpetua", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnRemoveWishlist.ForeColor = System.Drawing.Color.White;
            this.btnRemoveWishlist.Location = new System.Drawing.Point(36, 460);
            this.btnRemoveWishlist.Name = "btnRemoveWishlist";
            this.btnRemoveWishlist.Size = new System.Drawing.Size(180, 48);
            this.btnRemoveWishlist.TabIndex = 8;
            this.btnRemoveWishlist.Text = "❌Remove from Wishlist";
            this.btnRemoveWishlist.Click += new System.EventHandler(this.btnRemoveWishlist_Click);
            // 
            // btnViewAllBooks
            // 
            this.btnViewAllBooks.Animated = true;
            this.btnViewAllBooks.BackColor = System.Drawing.Color.Transparent;
            this.btnViewAllBooks.BorderRadius = 10;
            this.btnViewAllBooks.BorderThickness = 3;
            this.btnViewAllBooks.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnViewAllBooks.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnViewAllBooks.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnViewAllBooks.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnViewAllBooks.FillColor = System.Drawing.Color.Transparent;
            this.btnViewAllBooks.Font = new System.Drawing.Font("Perpetua", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnViewAllBooks.ForeColor = System.Drawing.Color.White;
            this.btnViewAllBooks.Location = new System.Drawing.Point(36, 406);
            this.btnViewAllBooks.Name = "btnViewAllBooks";
            this.btnViewAllBooks.Size = new System.Drawing.Size(180, 48);
            this.btnViewAllBooks.TabIndex = 7;
            this.btnViewAllBooks.Text = "View All Books";
            this.btnViewAllBooks.Click += new System.EventHandler(this.btnViewAllBooks_Click);
            // 
            // btnViewWishlist
            // 
            this.btnViewWishlist.Animated = true;
            this.btnViewWishlist.BackColor = System.Drawing.Color.Transparent;
            this.btnViewWishlist.BorderRadius = 10;
            this.btnViewWishlist.BorderThickness = 3;
            this.btnViewWishlist.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnViewWishlist.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnViewWishlist.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnViewWishlist.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnViewWishlist.FillColor = System.Drawing.Color.Transparent;
            this.btnViewWishlist.Font = new System.Drawing.Font("Perpetua", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnViewWishlist.ForeColor = System.Drawing.Color.White;
            this.btnViewWishlist.Location = new System.Drawing.Point(36, 352);
            this.btnViewWishlist.Name = "btnViewWishlist";
            this.btnViewWishlist.Size = new System.Drawing.Size(180, 48);
            this.btnViewWishlist.TabIndex = 6;
            this.btnViewWishlist.Text = "View My Wishlist";
            this.btnViewWishlist.Click += new System.EventHandler(this.btnViewWishlist_Click);
            // 
            // btnAddWishlist
            // 
            this.btnAddWishlist.Animated = true;
            this.btnAddWishlist.BackColor = System.Drawing.Color.Transparent;
            this.btnAddWishlist.BorderRadius = 10;
            this.btnAddWishlist.BorderThickness = 3;
            this.btnAddWishlist.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddWishlist.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddWishlist.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddWishlist.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddWishlist.FillColor = System.Drawing.Color.Transparent;
            this.btnAddWishlist.Font = new System.Drawing.Font("Perpetua", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnAddWishlist.ForeColor = System.Drawing.Color.White;
            this.btnAddWishlist.Location = new System.Drawing.Point(36, 298);
            this.btnAddWishlist.Name = "btnAddWishlist";
            this.btnAddWishlist.Size = new System.Drawing.Size(180, 48);
            this.btnAddWishlist.TabIndex = 5;
            this.btnAddWishlist.Text = "❤️ Add to Wishlist";
            this.btnAddWishlist.Click += new System.EventHandler(this.btnAddWishlist_Click);
            // 
            // btnNavUsers
            // 
            this.btnNavUsers.Animated = true;
            this.btnNavUsers.AutoRoundedCorners = true;
            this.btnNavUsers.BackColor = System.Drawing.Color.Transparent;
            this.btnNavUsers.BorderColor = System.Drawing.Color.Transparent;
            this.btnNavUsers.BorderRadius = 44;
            this.btnNavUsers.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnNavUsers.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnNavUsers.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnNavUsers.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnNavUsers.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnNavUsers.FillColor = System.Drawing.Color.Transparent;
            this.btnNavUsers.FillColor2 = System.Drawing.Color.Black;
            this.btnNavUsers.Font = new System.Drawing.Font("Perpetua", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnNavUsers.ForeColor = System.Drawing.Color.White;
            this.btnNavUsers.HoverState.FillColor = System.Drawing.Color.Black;
            this.btnNavUsers.HoverState.FillColor2 = System.Drawing.Color.Black;
            this.btnNavUsers.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnNavUsers.Location = new System.Drawing.Point(0, 209);
            this.btnNavUsers.Name = "btnNavUsers";
            this.btnNavUsers.Size = new System.Drawing.Size(250, 90);
            this.btnNavUsers.TabIndex = 1;
            this.btnNavUsers.Text = "Books";
            this.btnNavUsers.UseTransparentBackground = true;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Script MT Bold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(17, 76);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(199, 32);
            this.guna2HtmlLabel1.TabIndex = 4;
            this.guna2HtmlLabel1.Text = "The Bengal Archive";
            // 
            // btnLogout
            // 
            this.btnLogout.Animated = true;
            this.btnLogout.BackColor = System.Drawing.Color.Transparent;
            this.btnLogout.BorderColor = System.Drawing.Color.Transparent;
            this.btnLogout.BorderRadius = 40;
            this.btnLogout.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLogout.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLogout.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLogout.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLogout.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLogout.FillColor = System.Drawing.Color.Transparent;
            this.btnLogout.FillColor2 = System.Drawing.Color.Black;
            this.btnLogout.Font = new System.Drawing.Font("Perpetua", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.HoverState.FillColor = System.Drawing.Color.Black;
            this.btnLogout.HoverState.FillColor2 = System.Drawing.Color.Black;
            this.btnLogout.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(0, 944);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(250, 90);
            this.btnLogout.TabIndex = 3;
            this.btnLogout.Text = "Logout";
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // pnlHeader
            // 
            this.pnlHeader.Controls.Add(this.btnClose);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.FillColor = System.Drawing.Color.Transparent;
            this.pnlHeader.Location = new System.Drawing.Point(250, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1000, 29);
            this.pnlHeader.TabIndex = 4;
            // 
            // btnClose
            // 
            this.btnClose.Animated = true;
            this.btnClose.AutoRoundedCorners = true;
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClose.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClose.FillColor = System.Drawing.Color.Transparent;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.Red;
            this.btnClose.HoverState.FillColor = System.Drawing.Color.Red;
            this.btnClose.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(960, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(40, 29);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "X";
            this.btnClose.UseTransparentBackground = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // dgvData
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.dgvData.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvData.BackgroundColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvData.ColumnHeadersHeight = 4;
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvData.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvData.GridColor = System.Drawing.Color.White;
            this.dgvData.Location = new System.Drawing.Point(250, 29);
            this.dgvData.Name = "dgvData";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvData.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvData.RowHeadersVisible = false;
            this.dgvData.RowHeadersWidth = 51;
            this.dgvData.RowTemplate.Height = 24;
            this.dgvData.Size = new System.Drawing.Size(1000, 1005);
            this.dgvData.TabIndex = 5;
            this.dgvData.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Dark;
            this.dgvData.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.dgvData.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvData.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvData.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvData.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvData.ThemeStyle.BackColor = System.Drawing.Color.Black;
            this.dgvData.ThemeStyle.GridColor = System.Drawing.Color.White;
            this.dgvData.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            this.dgvData.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvData.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvData.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvData.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvData.ThemeStyle.HeaderStyle.Height = 4;
            this.dgvData.ThemeStyle.ReadOnly = false;
            this.dgvData.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.dgvData.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvData.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvData.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.White;
            this.dgvData.ThemeStyle.RowsStyle.Height = 24;
            this.dgvData.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
            this.dgvData.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this.pnlHeader;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // StudentDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp2.Properties.Resources.Gemini_Generated_Image_q74blaq74blaq74b;
            this.ClientSize = new System.Drawing.Size(1250, 1034);
            this.Controls.Add(this.dgvData);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.pnlSidebar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StudentDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StudentDashboard";
            this.pnlSidebar.ResumeLayout(false);
            this.pnlSidebar.PerformLayout();
            this.pnlHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientPanel pnlSidebar;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2GradientButton btnLogout;
        private Guna.UI2.WinForms.Guna2GradientButton btnNavUsers;
        private Guna.UI2.WinForms.Guna2Panel pnlHeader;
        private Guna.UI2.WinForms.Guna2DataGridView dgvData;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2Button btnClose;
        private Guna.UI2.WinForms.Guna2Button btnAddWishlist;
        private Guna.UI2.WinForms.Guna2Button btnViewAllBooks;
        private Guna.UI2.WinForms.Guna2Button btnViewWishlist;
        private Guna.UI2.WinForms.Guna2Button btnRemoveWishlist;
    }
}