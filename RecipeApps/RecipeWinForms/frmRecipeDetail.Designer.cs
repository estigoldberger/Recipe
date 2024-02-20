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
            btnSave = new Button();
            btnDelete = new Button();
            lblRecipeName = new Label();
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
            tblMain.Controls.Add(btnSave, 0, 4);
            tblMain.Controls.Add(btnDelete, 1, 4);
            tblMain.Controls.Add(lblRecipeName, 0, 0);
            tblMain.Location = new Point(0, 0);
            tblMain.Name = "tblMain";
            tblMain.RowCount = 5;
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tblMain.Size = new Size(647, 437);
            tblMain.TabIndex = 0;
            // 
            // txtRecipeName
            // 
            txtRecipeName.Dock = DockStyle.Fill;
            txtRecipeName.Location = new Point(326, 3);
            txtRecipeName.Name = "txtRecipeName";
            txtRecipeName.Size = new Size(318, 27);
            txtRecipeName.TabIndex = 2;
            // 
            // lblCalories
            // 
            lblCalories.AutoSize = true;
            lblCalories.Dock = DockStyle.Fill;
            lblCalories.Location = new Point(3, 87);
            lblCalories.Name = "lblCalories";
            lblCalories.Size = new Size(317, 87);
            lblCalories.TabIndex = 5;
            lblCalories.Text = "Calories";
            // 
            // txtCalorie
            // 
            txtCalorie.Dock = DockStyle.Fill;
            txtCalorie.Location = new Point(326, 90);
            txtCalorie.Name = "txtCalorie";
            txtCalorie.Size = new Size(318, 27);
            txtCalorie.TabIndex = 7;
            // 
            // lblCuisine
            // 
            lblCuisine.AutoSize = true;
            lblCuisine.Dock = DockStyle.Fill;
            lblCuisine.Location = new Point(3, 174);
            lblCuisine.Name = "lblCuisine";
            lblCuisine.Size = new Size(317, 87);
            lblCuisine.TabIndex = 11;
            lblCuisine.Text = "Cuisine";
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Dock = DockStyle.Fill;
            lblUser.Location = new Point(3, 261);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(317, 87);
            lblUser.TabIndex = 12;
            lblUser.Text = "User";
            // 
            // lstCuisineType
            // 
            lstCuisineType.Dock = DockStyle.Fill;
            lstCuisineType.FormattingEnabled = true;
            lstCuisineType.Location = new Point(326, 177);
            lstCuisineType.Name = "lstCuisineType";
            lstCuisineType.Size = new Size(318, 28);
            lstCuisineType.TabIndex = 13;
            // 
            // lstUserName
            // 
            lstUserName.Dock = DockStyle.Fill;
            lstUserName.FormattingEnabled = true;
            lstUserName.Location = new Point(326, 264);
            lstUserName.Name = "lstUserName";
            lstUserName.Size = new Size(318, 28);
            lstUserName.TabIndex = 14;
            // 
            // btnSave
            // 
            btnSave.Dock = DockStyle.Fill;
            btnSave.Location = new Point(3, 351);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(317, 83);
            btnSave.TabIndex = 15;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Dock = DockStyle.Fill;
            btnDelete.Location = new Point(326, 351);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(318, 83);
            btnDelete.TabIndex = 16;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // lblRecipeName
            // 
            lblRecipeName.AutoSize = true;
            lblRecipeName.Dock = DockStyle.Fill;
            lblRecipeName.Location = new Point(3, 0);
            lblRecipeName.Name = "lblRecipeName";
            lblRecipeName.Size = new Size(317, 87);
            lblRecipeName.TabIndex = 0;
            lblRecipeName.Text = "Recipe Name";
            // 
            // frmRecipeDetail
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(647, 437);
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
    }
}