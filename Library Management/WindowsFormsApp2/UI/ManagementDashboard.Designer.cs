namespace WindowsFormsApp2.UI
{
    partial class ManagementDashboard
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlHeader = new Guna.UI2.WinForms.Guna2Panel();
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.pnlSidebar = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.pnlBooksDropdown = new Guna.UI2.WinForms.Guna2Panel();
            this.btnRemoveBook = new Guna.UI2.WinForms.Guna2Button();
            this.btnAddBook = new Guna.UI2.WinForms.Guna2Button();
            this.btnNavBooks = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnLogout = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnNavFines = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnNavUsers = new Guna.UI2.WinForms.Guna2GradientButton();
            this.pnlMainContent = new Guna.UI2.WinForms.Guna2Panel();
            this.dgvData = new Guna.UI2.WinForms.Guna2DataGridView();
            this.pnlHeader.SuspendLayout();
            this.pnlSidebar.SuspendLayout();
            this.pnlBooksDropdown.SuspendLayout();
            this.pnlMainContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.Controls.Add(this.btnClose);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.FillColor = System.Drawing.Color.Transparent;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1250, 29);
            this.pnlHeader.TabIndex = 1;
            // 
            // btnClose
            // 
            this.btnClose.AutoRoundedCorners = true;
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClose.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClose.FillColor = System.Drawing.Color.Transparent;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold);
            this.btnClose.ForeColor = System.Drawing.Color.Red;
            this.btnClose.HoverState.FillColor = System.Drawing.Color.Red;
            this.btnClose.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(1210, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(40, 26);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "X";
            this.btnClose.UseTransparentBackground = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this.pnlHeader;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // pnlSidebar
            // 
            this.pnlSidebar.BackColor = System.Drawing.Color.Black;
            this.pnlSidebar.BackgroundImage = global::WindowsFormsApp2.Properties.Resources.Gemini_Generated_Image_g7atrsg7atrsg7at;
            this.pnlSidebar.BorderColor = System.Drawing.Color.Transparent;
            this.pnlSidebar.BorderRadius = 50;
            this.pnlSidebar.Controls.Add(this.pnlBooksDropdown);
            this.pnlSidebar.Controls.Add(this.btnNavBooks);
            this.pnlSidebar.Controls.Add(this.guna2HtmlLabel1);
            this.pnlSidebar.Controls.Add(this.btnLogout);
            this.pnlSidebar.Controls.Add(this.btnNavFines);
            this.pnlSidebar.Controls.Add(this.btnNavUsers);
            this.pnlSidebar.CustomBorderColor = System.Drawing.Color.Transparent;
            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSidebar.FillColor = System.Drawing.Color.Transparent;
            this.pnlSidebar.FillColor2 = System.Drawing.Color.Transparent;
            this.pnlSidebar.ForeColor = System.Drawing.Color.Transparent;
            this.pnlSidebar.Location = new System.Drawing.Point(0, 29);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Size = new System.Drawing.Size(250, 1005);
            this.pnlSidebar.TabIndex = 2;
            // 
            // pnlBooksDropdown
            // 
            this.pnlBooksDropdown.BackColor = System.Drawing.Color.Transparent;
            this.pnlBooksDropdown.BorderColor = System.Drawing.Color.Black;
            this.pnlBooksDropdown.BorderRadius = 15;
            this.pnlBooksDropdown.BorderThickness = 4;
            this.pnlBooksDropdown.Controls.Add(this.btnRemoveBook);
            this.pnlBooksDropdown.Controls.Add(this.btnAddBook);
            this.pnlBooksDropdown.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBooksDropdown.FillColor = System.Drawing.Color.Transparent;
            this.pnlBooksDropdown.Location = new System.Drawing.Point(0, 270);
            this.pnlBooksDropdown.Name = "pnlBooksDropdown";
            this.pnlBooksDropdown.Size = new System.Drawing.Size(250, 106);
            this.pnlBooksDropdown.TabIndex = 5;
            this.pnlBooksDropdown.Visible = false;
            // 
            // btnRemoveBook
            // 
            this.btnRemoveBook.Animated = true;
            this.btnRemoveBook.AutoRoundedCorners = true;
            this.btnRemoveBook.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRemoveBook.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRemoveBook.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRemoveBook.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRemoveBook.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRemoveBook.FillColor = System.Drawing.Color.Transparent;
            this.btnRemoveBook.Font = new System.Drawing.Font("Perpetua", 9F, System.Drawing.FontStyle.Bold);
            this.btnRemoveBook.ForeColor = System.Drawing.Color.White;
            this.btnRemoveBook.HoverState.FillColor = System.Drawing.Color.Black;
            this.btnRemoveBook.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnRemoveBook.Location = new System.Drawing.Point(0, 50);
            this.btnRemoveBook.Name = "btnRemoveBook";
            this.btnRemoveBook.Size = new System.Drawing.Size(250, 50);
            this.btnRemoveBook.TabIndex = 1;
            this.btnRemoveBook.Text = "-Remove Book";
            this.btnRemoveBook.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnRemoveBook.TextOffset = new System.Drawing.Point(60, 0);
            this.btnRemoveBook.Click += new System.EventHandler(this.btnRemoveBook_Click);
            // 
            // btnAddBook
            // 
            this.btnAddBook.Animated = true;
            this.btnAddBook.AutoRoundedCorners = true;
            this.btnAddBook.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddBook.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddBook.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddBook.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddBook.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddBook.FillColor = System.Drawing.Color.Transparent;
            this.btnAddBook.Font = new System.Drawing.Font("Perpetua", 9F, System.Drawing.FontStyle.Bold);
            this.btnAddBook.ForeColor = System.Drawing.Color.White;
            this.btnAddBook.HoverState.FillColor = System.Drawing.Color.Black;
            this.btnAddBook.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnAddBook.Location = new System.Drawing.Point(0, 0);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(250, 50);
            this.btnAddBook.TabIndex = 0;
            this.btnAddBook.Text = "+ Add New Book";
            this.btnAddBook.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAddBook.TextOffset = new System.Drawing.Point(55, 0);
            this.btnAddBook.Click += new System.EventHandler(this.btnAddBook_Click);
            // 
            // btnNavBooks
            // 
            this.btnNavBooks.Animated = true;
            this.btnNavBooks.BackColor = System.Drawing.Color.Transparent;
            this.btnNavBooks.BorderColor = System.Drawing.Color.Transparent;
            this.btnNavBooks.BorderRadius = 40;
            this.btnNavBooks.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnNavBooks.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnNavBooks.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnNavBooks.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnNavBooks.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnNavBooks.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNavBooks.FillColor = System.Drawing.Color.Transparent;
            this.btnNavBooks.FillColor2 = System.Drawing.Color.Black;
            this.btnNavBooks.Font = new System.Drawing.Font("Perpetua", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnNavBooks.ForeColor = System.Drawing.Color.White;
            this.btnNavBooks.HoverState.FillColor = System.Drawing.Color.Black;
            this.btnNavBooks.HoverState.FillColor2 = System.Drawing.Color.Black;
            this.btnNavBooks.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnNavBooks.Location = new System.Drawing.Point(0, 180);
            this.btnNavBooks.Name = "btnNavBooks";
            this.btnNavBooks.Size = new System.Drawing.Size(250, 90);
            this.btnNavBooks.TabIndex = 0;
            this.btnNavBooks.Text = "Manage Books";
            this.btnNavBooks.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnNavBooks.TextOffset = new System.Drawing.Point(40, 0);
            this.btnNavBooks.Click += new System.EventHandler(this.btnNavBooks_Click);
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Script MT Bold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(12, 698);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(217, 35);
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
            this.btnLogout.Location = new System.Drawing.Point(0, 915);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(250, 90);
            this.btnLogout.TabIndex = 3;
            this.btnLogout.Text = "Logout";
            this.btnLogout.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnLogout.TextOffset = new System.Drawing.Point(77, 0);
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnNavFines
            // 
            this.btnNavFines.Animated = true;
            this.btnNavFines.BackColor = System.Drawing.Color.Transparent;
            this.btnNavFines.BorderColor = System.Drawing.Color.Transparent;
            this.btnNavFines.BorderRadius = 40;
            this.btnNavFines.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnNavFines.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnNavFines.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnNavFines.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnNavFines.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnNavFines.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNavFines.FillColor = System.Drawing.Color.Transparent;
            this.btnNavFines.FillColor2 = System.Drawing.Color.Black;
            this.btnNavFines.Font = new System.Drawing.Font("Perpetua", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnNavFines.ForeColor = System.Drawing.Color.White;
            this.btnNavFines.HoverState.FillColor = System.Drawing.Color.Black;
            this.btnNavFines.HoverState.FillColor2 = System.Drawing.Color.Black;
            this.btnNavFines.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnNavFines.Location = new System.Drawing.Point(0, 90);
            this.btnNavFines.Name = "btnNavFines";
            this.btnNavFines.Size = new System.Drawing.Size(250, 90);
            this.btnNavFines.TabIndex = 2;
            this.btnNavFines.Text = "Fine";
            this.btnNavFines.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnNavFines.TextOffset = new System.Drawing.Point(90, 0);
            // 
            // btnNavUsers
            // 
            this.btnNavUsers.Animated = true;
            this.btnNavUsers.BackColor = System.Drawing.Color.Transparent;
            this.btnNavUsers.BorderColor = System.Drawing.Color.Transparent;
            this.btnNavUsers.BorderRadius = 40;
            this.btnNavUsers.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnNavUsers.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnNavUsers.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnNavUsers.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnNavUsers.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnNavUsers.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNavUsers.FillColor = System.Drawing.Color.Transparent;
            this.btnNavUsers.FillColor2 = System.Drawing.Color.Black;
            this.btnNavUsers.Font = new System.Drawing.Font("Perpetua", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnNavUsers.ForeColor = System.Drawing.Color.White;
            this.btnNavUsers.HoverState.FillColor = System.Drawing.Color.Black;
            this.btnNavUsers.HoverState.FillColor2 = System.Drawing.Color.Black;
            this.btnNavUsers.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnNavUsers.Location = new System.Drawing.Point(0, 0);
            this.btnNavUsers.Name = "btnNavUsers";
            this.btnNavUsers.Size = new System.Drawing.Size(250, 90);
            this.btnNavUsers.TabIndex = 1;
            this.btnNavUsers.Text = "Learners";
            this.btnNavUsers.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnNavUsers.TextOffset = new System.Drawing.Point(70, 0);
            // 
            // pnlMainContent
            // 
            this.pnlMainContent.BackColor = System.Drawing.Color.Transparent;
            this.pnlMainContent.Controls.Add(this.dgvData);
            this.pnlMainContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMainContent.Location = new System.Drawing.Point(250, 29);
            this.pnlMainContent.Name = "pnlMainContent";
            this.pnlMainContent.Size = new System.Drawing.Size(1000, 1005);
            this.pnlMainContent.TabIndex = 3;
            // 
            // dgvData
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.dgvData.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvData.BackgroundColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvData.ColumnHeadersHeight = 4;
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvData.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvData.GridColor = System.Drawing.Color.White;
            this.dgvData.Location = new System.Drawing.Point(0, 0);
            this.dgvData.Name = "dgvData";
            this.dgvData.RowHeadersVisible = false;
            this.dgvData.RowHeadersWidth = 51;
            this.dgvData.RowTemplate.Height = 24;
            this.dgvData.Size = new System.Drawing.Size(1000, 1005);
            this.dgvData.TabIndex = 0;
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
            this.dgvData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvData_CellContentClick);
            // 
            // ManagementDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp2.Properties.Resources.Gemini_Generated_Image_q74blaq74blaq74b;
            this.ClientSize = new System.Drawing.Size(1250, 1034);
            this.Controls.Add(this.pnlMainContent);
            this.Controls.Add(this.pnlSidebar);
            this.Controls.Add(this.pnlHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ManagementDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManagementDashboard";
            this.pnlHeader.ResumeLayout(false);
            this.pnlSidebar.ResumeLayout(false);
            this.pnlSidebar.PerformLayout();
            this.pnlBooksDropdown.ResumeLayout(false);
            this.pnlMainContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Panel pnlHeader;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2GradientPanel pnlSidebar;
        private Guna.UI2.WinForms.Guna2GradientButton btnNavBooks;
        private Guna.UI2.WinForms.Guna2GradientButton btnLogout;
        private Guna.UI2.WinForms.Guna2GradientButton btnNavFines;
        private Guna.UI2.WinForms.Guna2GradientButton btnNavUsers;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2Panel pnlMainContent;
        private Guna.UI2.WinForms.Guna2DataGridView dgvData;
        private Guna.UI2.WinForms.Guna2Panel pnlBooksDropdown;
        private Guna.UI2.WinForms.Guna2Button btnAddBook;
        private Guna.UI2.WinForms.Guna2Button btnRemoveBook;
        private Guna.UI2.WinForms.Guna2Button btnClose;
    }
}