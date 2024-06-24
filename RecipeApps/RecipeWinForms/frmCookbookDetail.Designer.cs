namespace RecipeWinForms
{
    partial class frmCookbookDetail
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
            tblMain = new TableLayoutPanel();
            btnSave = new Button();
            btnDelete = new Button();
            lblName = new Label();
            lblUser = new Label();
            lblPrice = new Label();
            lblStatus = new Label();
            txtCookbookName = new TextBox();
            lstUserName = new ComboBox();
            ckActive = new CheckBox();
            tblDetails = new TableLayoutPanel();
            txtPrice = new TextBox();
            txtDateCreated = new TextBox();
            lblDate = new Label();
            tblEdit = new TableLayoutPanel();
            btnSaveRecipes = new Button();
            gCookbook = new DataGridView();
            tblMain.SuspendLayout();
            tblDetails.SuspendLayout();
            tblEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gCookbook).BeginInit();
            SuspendLayout();
            // 
            // tblMain
            // 
            tblMain.ColumnCount = 2;
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 19.90909F));
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80.09091F));
            tblMain.Controls.Add(btnSave, 0, 0);
            tblMain.Controls.Add(btnDelete, 1, 0);
            tblMain.Controls.Add(lblName, 0, 1);
            tblMain.Controls.Add(lblUser, 0, 2);
            tblMain.Controls.Add(lblPrice, 0, 3);
            tblMain.Controls.Add(lblStatus, 0, 4);
            tblMain.Controls.Add(txtCookbookName, 1, 1);
            tblMain.Controls.Add(lstUserName, 1, 2);
            tblMain.Controls.Add(ckActive, 1, 4);
            tblMain.Controls.Add(tblDetails, 1, 3);
            tblMain.Controls.Add(tblEdit, 0, 5);
            tblMain.Dock = DockStyle.Fill;
            tblMain.Location = new Point(0, 0);
            tblMain.Name = "tblMain";
            tblMain.RowCount = 6;
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.Size = new Size(1100, 630);
            tblMain.TabIndex = 0;
            // 
            // btnSave
            // 
            btnSave.AutoSize = true;
            btnSave.Location = new Point(30, 3);
            btnSave.Margin = new Padding(30, 3, 3, 3);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 38);
            btnSave.TabIndex = 0;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.AutoSize = true;
            btnDelete.Location = new Point(222, 3);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 38);
            btnDelete.TabIndex = 1;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(3, 44);
            lblName.Name = "lblName";
            lblName.Size = new Size(161, 28);
            lblName.TabIndex = 2;
            lblName.Text = "Cookbook Name";
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Location = new Point(3, 84);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(51, 28);
            lblUser.TabIndex = 3;
            lblUser.Text = "User";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(3, 126);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(54, 28);
            lblPrice.TabIndex = 4;
            lblPrice.Text = "Price";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(3, 182);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(66, 28);
            lblStatus.TabIndex = 5;
            lblStatus.Text = "Active";
            // 
            // txtCookbookName
            // 
            txtCookbookName.Dock = DockStyle.Fill;
            txtCookbookName.Location = new Point(222, 47);
            txtCookbookName.Margin = new Padding(3, 3, 50, 3);
            txtCookbookName.Name = "txtCookbookName";
            txtCookbookName.Size = new Size(828, 34);
            txtCookbookName.TabIndex = 7;
            // 
            // lstUserName
            // 
            lstUserName.Dock = DockStyle.Fill;
            lstUserName.FormattingEnabled = true;
            lstUserName.Location = new Point(222, 87);
            lstUserName.Margin = new Padding(3, 3, 50, 3);
            lstUserName.Name = "lstUserName";
            lstUserName.Size = new Size(828, 36);
            lstUserName.TabIndex = 8;
            // 
            // ckActive
            // 
            ckActive.AutoSize = true;
            ckActive.Location = new Point(222, 185);
            ckActive.Name = "ckActive";
            ckActive.Size = new Size(18, 17);
            ckActive.TabIndex = 9;
            ckActive.UseVisualStyleBackColor = true;
            // 
            // tblDetails
            // 
            tblDetails.ColumnCount = 2;
            tblDetails.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblDetails.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblDetails.Controls.Add(txtPrice, 0, 1);
            tblDetails.Controls.Add(txtDateCreated, 1, 1);
            tblDetails.Controls.Add(lblDate, 1, 0);
            tblDetails.Dock = DockStyle.Fill;
            tblDetails.Location = new Point(222, 129);
            tblDetails.Name = "tblDetails";
            tblDetails.RowCount = 2;
            tblDetails.RowStyles.Add(new RowStyle());
            tblDetails.RowStyles.Add(new RowStyle());
            tblDetails.Size = new Size(875, 50);
            tblDetails.TabIndex = 10;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(3, 20);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(185, 34);
            txtPrice.TabIndex = 0;
            // 
            // txtDateCreated
            // 
            txtDateCreated.Dock = DockStyle.Fill;
            txtDateCreated.Location = new Point(440, 20);
            txtDateCreated.Margin = new Padding(3, 3, 150, 3);
            txtDateCreated.Name = "txtDateCreated";
            txtDateCreated.ReadOnly = true;
            txtDateCreated.Size = new Size(285, 34);
            txtDateCreated.TabIndex = 1;
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblDate.Location = new Point(440, 0);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(88, 17);
            lblDate.TabIndex = 2;
            lblDate.Text = "Date Created:";
            // 
            // tblEdit
            // 
            tblEdit.ColumnCount = 2;
            tblMain.SetColumnSpan(tblEdit, 2);
            tblEdit.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tblEdit.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 83.3333359F));
            tblEdit.Controls.Add(btnSaveRecipes, 0, 0);
            tblEdit.Controls.Add(gCookbook, 0, 1);
            tblEdit.Dock = DockStyle.Fill;
            tblEdit.Location = new Point(3, 213);
            tblEdit.Name = "tblEdit";
            tblEdit.RowCount = 2;
            tblEdit.RowStyles.Add(new RowStyle(SizeType.Percent, 18.0327873F));
            tblEdit.RowStyles.Add(new RowStyle(SizeType.Percent, 81.96722F));
            tblEdit.Size = new Size(1094, 414);
            tblEdit.TabIndex = 11;
            // 
            // btnSaveRecipes
            // 
            btnSaveRecipes.AutoSize = true;
            btnSaveRecipes.Dock = DockStyle.Fill;
            btnSaveRecipes.Location = new Point(3, 3);
            btnSaveRecipes.Name = "btnSaveRecipes";
            btnSaveRecipes.Size = new Size(176, 68);
            btnSaveRecipes.TabIndex = 0;
            btnSaveRecipes.Text = "Save";
            btnSaveRecipes.UseVisualStyleBackColor = true;
            // 
            // gCookbook
            // 
            gCookbook.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            gCookbook.BackgroundColor = SystemColors.Control;
            gCookbook.BorderStyle = BorderStyle.None;
            gCookbook.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tblEdit.SetColumnSpan(gCookbook, 2);
            gCookbook.Dock = DockStyle.Fill;
            gCookbook.Location = new Point(3, 77);
            gCookbook.Name = "gCookbook";
            gCookbook.RowHeadersWidth = 51;
            gCookbook.RowTemplate.Height = 29;
            gCookbook.Size = new Size(1088, 334);
            gCookbook.TabIndex = 1;
            // 
            // frmCookbookDetail
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1100, 630);
            Controls.Add(tblMain);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "frmCookbookDetail";
            Text = "Cookbook";
            tblMain.ResumeLayout(false);
            tblMain.PerformLayout();
            tblDetails.ResumeLayout(false);
            tblDetails.PerformLayout();
            tblEdit.ResumeLayout(false);
            tblEdit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gCookbook).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tblMain;
        private Button btnSave;
        private Button btnDelete;
        private Label lblName;
        private Label lblUser;
        private Label lblPrice;
        private Label lblStatus;
        private TextBox txtCookbookName;
        private ComboBox lstUserName;
        private CheckBox ckActive;
        private TableLayoutPanel tblDetails;
        private TextBox txtPrice;
        private TextBox txtDateCreated;
        private Label lblDate;
        private TableLayoutPanel tblEdit;
        private Button btnSaveRecipes;
        private DataGridView gCookbook;
    }
}