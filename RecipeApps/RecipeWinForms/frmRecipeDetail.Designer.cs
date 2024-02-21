namespace RecipeWinForms
{
    partial class frmRecipeDetail
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
            txtRecipeName = new TextBox();
            lblCalories = new Label();
            txtCalorie = new TextBox();
            lblCuisine = new Label();
            lblUser = new Label();
            lstCuisineType = new ComboBox();
            lstUserName = new ComboBox();
            lblRecipeName = new Label();
            btnSave = new Button();
            btnDelete = new Button();
            lblDateDrafted = new Label();
            dtpDateDrafted = new DateTimePicker();
            lblDatePublished = new Label();
            lblDateArchived = new Label();
            txtDatePublished = new TextBox();
            txtDateArchived = new TextBox();
            tblMain.SuspendLayout();
            SuspendLayout();
            // 
            // tblMain
            // 
            tblMain.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tblMain.ColumnCount = 2;
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblMain.Controls.Add(txtRecipeName, 1, 0);
            tblMain.Controls.Add(lblCalories, 0, 1);
            tblMain.Controls.Add(txtCalorie, 1, 1);
            tblMain.Controls.Add(lblCuisine, 0, 2);
            tblMain.Controls.Add(lblUser, 0, 3);
            tblMain.Controls.Add(lstCuisineType, 1, 2);
            tblMain.Controls.Add(lstUserName, 1, 3);
            tblMain.Controls.Add(lblRecipeName, 0, 0);
            tblMain.Controls.Add(btnSave, 0, 7);
            tblMain.Controls.Add(btnDelete, 1, 7);
            tblMain.Controls.Add(lblDateDrafted, 0, 4);
            tblMain.Controls.Add(dtpDateDrafted, 1, 4);
            tblMain.Controls.Add(lblDatePublished, 0, 5);
            tblMain.Controls.Add(lblDateArchived, 0, 6);
            tblMain.Controls.Add(txtDatePublished, 1, 5);
            tblMain.Controls.Add(txtDateArchived, 1, 6);
            tblMain.Location = new Point(0, 0);
            tblMain.Name = "tblMain";
            tblMain.RowCount = 8;
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tblMain.Size = new Size(761, 524);
            tblMain.TabIndex = 0;
            // 
            // txtRecipeName
            // 
            txtRecipeName.Dock = DockStyle.Fill;
            txtRecipeName.Location = new Point(383, 3);
            txtRecipeName.Name = "txtRecipeName";
            txtRecipeName.Size = new Size(375, 27);
            txtRecipeName.TabIndex = 2;
            // 
            // lblCalories
            // 
            lblCalories.AutoSize = true;
            lblCalories.Dock = DockStyle.Fill;
            lblCalories.Location = new Point(3, 65);
            lblCalories.Name = "lblCalories";
            lblCalories.Size = new Size(374, 65);
            lblCalories.TabIndex = 5;
            lblCalories.Text = "Calories";
            // 
            // txtCalorie
            // 
            txtCalorie.Dock = DockStyle.Fill;
            txtCalorie.Location = new Point(383, 68);
            txtCalorie.Name = "txtCalorie";
            txtCalorie.Size = new Size(375, 27);
            txtCalorie.TabIndex = 7;
            // 
            // lblCuisine
            // 
            lblCuisine.AutoSize = true;
            lblCuisine.Dock = DockStyle.Fill;
            lblCuisine.Location = new Point(3, 130);
            lblCuisine.Name = "lblCuisine";
            lblCuisine.Size = new Size(374, 65);
            lblCuisine.TabIndex = 11;
            lblCuisine.Text = "Cuisine";
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Dock = DockStyle.Fill;
            lblUser.Location = new Point(3, 195);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(374, 65);
            lblUser.TabIndex = 12;
            lblUser.Text = "User";
            // 
            // lstCuisineType
            // 
            lstCuisineType.Dock = DockStyle.Fill;
            lstCuisineType.FormattingEnabled = true;
            lstCuisineType.Location = new Point(383, 133);
            lstCuisineType.Name = "lstCuisineType";
            lstCuisineType.Size = new Size(375, 28);
            lstCuisineType.TabIndex = 13;
            // 
            // lstUserName
            // 
            lstUserName.Dock = DockStyle.Fill;
            lstUserName.FormattingEnabled = true;
            lstUserName.Location = new Point(383, 198);
            lstUserName.Name = "lstUserName";
            lstUserName.Size = new Size(375, 28);
            lstUserName.TabIndex = 14;
            // 
            // lblRecipeName
            // 
            lblRecipeName.AutoSize = true;
            lblRecipeName.Dock = DockStyle.Fill;
            lblRecipeName.Location = new Point(3, 0);
            lblRecipeName.Name = "lblRecipeName";
            lblRecipeName.Size = new Size(374, 65);
            lblRecipeName.TabIndex = 0;
            lblRecipeName.Text = "Recipe Name";
            // 
            // btnSave
            // 
            btnSave.Dock = DockStyle.Fill;
            btnSave.Location = new Point(3, 458);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(374, 63);
            btnSave.TabIndex = 17;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Dock = DockStyle.Fill;
            btnDelete.Location = new Point(383, 458);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(375, 63);
            btnDelete.TabIndex = 18;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // lblDateDrafted
            // 
            lblDateDrafted.AutoSize = true;
            lblDateDrafted.Location = new Point(3, 260);
            lblDateDrafted.Name = "lblDateDrafted";
            lblDateDrafted.Size = new Size(96, 20);
            lblDateDrafted.TabIndex = 19;
            lblDateDrafted.Text = "Date Drafted";
            // 
            // dtpDateDrafted
            // 
            dtpDateDrafted.Dock = DockStyle.Fill;
            dtpDateDrafted.Format = DateTimePickerFormat.Short;
            dtpDateDrafted.Location = new Point(383, 263);
            dtpDateDrafted.Name = "dtpDateDrafted";
            dtpDateDrafted.Size = new Size(375, 27);
            dtpDateDrafted.TabIndex = 20;
            // 
            // lblDatePublished
            // 
            lblDatePublished.AutoSize = true;
            lblDatePublished.Location = new Point(3, 325);
            lblDatePublished.Name = "lblDatePublished";
            lblDatePublished.Size = new Size(109, 20);
            lblDatePublished.TabIndex = 21;
            lblDatePublished.Text = "Date Published";
            // 
            // lblDateArchived
            // 
            lblDateArchived.AutoSize = true;
            lblDateArchived.Location = new Point(3, 390);
            lblDateArchived.Name = "lblDateArchived";
            lblDateArchived.Size = new Size(103, 20);
            lblDateArchived.TabIndex = 22;
            lblDateArchived.Text = "Date Archived";
            // 
            // txtDatePublished
            // 
            txtDatePublished.Dock = DockStyle.Fill;
            txtDatePublished.Location = new Point(383, 328);
            txtDatePublished.Name = "txtDatePublished";
            txtDatePublished.Size = new Size(375, 27);
            txtDatePublished.TabIndex = 23;
            // 
            // txtDateArchived
            // 
            txtDateArchived.Dock = DockStyle.Fill;
            txtDateArchived.Location = new Point(383, 393);
            txtDateArchived.Name = "txtDateArchived";
            txtDateArchived.Size = new Size(375, 27);
            txtDateArchived.TabIndex = 24;
            // 
            // frmRecipeDetail
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(765, 523);
            Controls.Add(tblMain);
            Name = "frmRecipeDetail";
            Text = "Recipe Details";
            tblMain.ResumeLayout(false);
            tblMain.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tblMain;
        private TextBox txtRecipeName;
        private Label lblCalories;
        private Label lblRecipeName;
        private TextBox txtCalorie;
        private Label lblCuisine;
        private Label lblUser;
        private ComboBox lstCuisineType;
        private ComboBox lstUserName;
        private Button btnSave;
        private Button btnDelete;
        private Label lblDateDrafted;
        private DateTimePicker dtpDateDrafted;
        private Label lblDatePublished;
        private Label lblDateArchived;
        private TextBox txtDatePublished;
        private TextBox txtDateArchived;
    }
}