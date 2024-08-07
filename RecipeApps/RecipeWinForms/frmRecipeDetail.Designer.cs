﻿namespace RecipeWinForms
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
            tblButtons = new TableLayoutPanel();
            btnSave = new Button();
            btnDelete = new Button();
            btnChangeStatus = new Button();
            tblStatus = new TableLayoutPanel();
            lblDrafted = new Label();
            lblPublished = new Label();
            txtDatePublished = new TextBox();
            txtDateArchived = new TextBox();
            lblArchived = new Label();
            txtDateDrafted = new TextBox();
            lblStatus = new Label();
            lblCurrentStatus = new Label();
            txtStatus = new TextBox();
            tbRecipeDetails = new TabControl();
            tbIngredients = new TabPage();
            tblIng = new TableLayoutPanel();
            btnSaveIngredients = new Button();
            gIng = new DataGridView();
            tbSteps = new TabPage();
            tblSteps = new TableLayoutPanel();
            btnSaveSteps = new Button();
            pnlSteps = new Panel();
            gSteps = new DataGridView();
            tblMain.SuspendLayout();
            tblButtons.SuspendLayout();
            tblStatus.SuspendLayout();
            tbRecipeDetails.SuspendLayout();
            tbIngredients.SuspendLayout();
            tblIng.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gIng).BeginInit();
            tbSteps.SuspendLayout();
            tblSteps.SuspendLayout();
            pnlSteps.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gSteps).BeginInit();
            SuspendLayout();
            // 
            // tblMain
            // 
            tblMain.AutoSize = true;
            tblMain.ColumnCount = 4;
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 33F));
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 56F));
            tblMain.Controls.Add(txtRecipeName, 2, 1);
            tblMain.Controls.Add(lblCalories, 1, 2);
            tblMain.Controls.Add(txtCalorie, 2, 2);
            tblMain.Controls.Add(lblCuisine, 1, 3);
            tblMain.Controls.Add(lblUser, 1, 4);
            tblMain.Controls.Add(lstCuisineType, 2, 3);
            tblMain.Controls.Add(lstUserName, 2, 4);
            tblMain.Controls.Add(lblRecipeName, 1, 1);
            tblMain.Controls.Add(tblButtons, 1, 0);
            tblMain.Controls.Add(tblStatus, 2, 5);
            tblMain.Controls.Add(lblStatus, 1, 5);
            tblMain.Controls.Add(lblCurrentStatus, 1, 6);
            tblMain.Controls.Add(txtStatus, 2, 6);
            tblMain.Controls.Add(tbRecipeDetails, 1, 7);
            tblMain.Dock = DockStyle.Fill;
            tblMain.Location = new Point(0, 0);
            tblMain.Name = "tblMain";
            tblMain.RowCount = 8;
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblMain.Size = new Size(770, 834);
            tblMain.TabIndex = 0;
            // 
            // txtRecipeName
            // 
            txtRecipeName.Dock = DockStyle.Fill;
            txtRecipeName.Location = new Point(376, 67);
            txtRecipeName.Name = "txtRecipeName";
            txtRecipeName.Size = new Size(334, 27);
            txtRecipeName.TabIndex = 2;
            // 
            // lblCalories
            // 
            lblCalories.AutoSize = true;
            lblCalories.Dock = DockStyle.Fill;
            lblCalories.Location = new Point(36, 97);
            lblCalories.Name = "lblCalories";
            lblCalories.Size = new Size(334, 33);
            lblCalories.TabIndex = 5;
            lblCalories.Text = "Calories";
            // 
            // txtCalorie
            // 
            txtCalorie.Dock = DockStyle.Fill;
            txtCalorie.Location = new Point(376, 100);
            txtCalorie.Name = "txtCalorie";
            txtCalorie.Size = new Size(334, 27);
            txtCalorie.TabIndex = 7;
            // 
            // lblCuisine
            // 
            lblCuisine.AutoSize = true;
            lblCuisine.Dock = DockStyle.Fill;
            lblCuisine.Location = new Point(36, 130);
            lblCuisine.Name = "lblCuisine";
            lblCuisine.Size = new Size(334, 34);
            lblCuisine.TabIndex = 11;
            lblCuisine.Text = "Cuisine";
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Dock = DockStyle.Fill;
            lblUser.Location = new Point(36, 164);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(334, 34);
            lblUser.TabIndex = 12;
            lblUser.Text = "User";
            // 
            // lstCuisineType
            // 
            lstCuisineType.Dock = DockStyle.Fill;
            lstCuisineType.FormattingEnabled = true;
            lstCuisineType.Location = new Point(376, 133);
            lstCuisineType.Name = "lstCuisineType";
            lstCuisineType.Size = new Size(334, 28);
            lstCuisineType.TabIndex = 13;
            // 
            // lstUserName
            // 
            lstUserName.Dock = DockStyle.Fill;
            lstUserName.FormattingEnabled = true;
            lstUserName.Location = new Point(376, 167);
            lstUserName.Name = "lstUserName";
            lstUserName.Size = new Size(334, 28);
            lstUserName.TabIndex = 14;
            // 
            // lblRecipeName
            // 
            lblRecipeName.AutoSize = true;
            lblRecipeName.Dock = DockStyle.Fill;
            lblRecipeName.Location = new Point(36, 64);
            lblRecipeName.Name = "lblRecipeName";
            lblRecipeName.Size = new Size(334, 33);
            lblRecipeName.TabIndex = 0;
            lblRecipeName.Text = "Recipe Name";
            // 
            // tblButtons
            // 
            tblButtons.AutoSize = true;
            tblButtons.ColumnCount = 3;
            tblMain.SetColumnSpan(tblButtons, 2);
            tblButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 23.20917F));
            tblButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 21.148037F));
            tblButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 55.74018F));
            tblButtons.Controls.Add(btnSave, 0, 0);
            tblButtons.Controls.Add(btnDelete, 1, 0);
            tblButtons.Controls.Add(btnChangeStatus, 2, 0);
            tblButtons.Dock = DockStyle.Fill;
            tblButtons.Location = new Point(36, 3);
            tblButtons.Name = "tblButtons";
            tblButtons.RowCount = 1;
            tblButtons.RowStyles.Add(new RowStyle());
            tblButtons.Size = new Size(674, 58);
            tblButtons.TabIndex = 25;
            // 
            // btnSave
            // 
            btnSave.AutoSize = true;
            btnSave.Dock = DockStyle.Top;
            btnSave.Location = new Point(3, 3);
            btnSave.Margin = new Padding(3, 3, 50, 3);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(103, 52);
            btnSave.TabIndex = 17;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.AutoSize = true;
            btnDelete.Dock = DockStyle.Top;
            btnDelete.Location = new Point(159, 3);
            btnDelete.Margin = new Padding(3, 3, 50, 3);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(89, 52);
            btnDelete.TabIndex = 18;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnChangeStatus
            // 
            btnChangeStatus.AutoSize = true;
            btnChangeStatus.Dock = DockStyle.Top;
            btnChangeStatus.Location = new Point(378, 3);
            btnChangeStatus.Margin = new Padding(80, 3, 3, 3);
            btnChangeStatus.Name = "btnChangeStatus";
            btnChangeStatus.Size = new Size(293, 52);
            btnChangeStatus.TabIndex = 19;
            btnChangeStatus.Text = "Change Status";
            btnChangeStatus.UseVisualStyleBackColor = true;
            // 
            // tblStatus
            // 
            tblStatus.ColumnCount = 3;
            tblStatus.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblStatus.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblStatus.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 105F));
            tblStatus.Controls.Add(lblDrafted, 0, 0);
            tblStatus.Controls.Add(lblPublished, 1, 0);
            tblStatus.Controls.Add(txtDatePublished, 1, 1);
            tblStatus.Controls.Add(txtDateArchived, 2, 1);
            tblStatus.Controls.Add(lblArchived, 2, 0);
            tblStatus.Controls.Add(txtDateDrafted, 0, 1);
            tblStatus.Dock = DockStyle.Fill;
            tblStatus.Location = new Point(376, 201);
            tblStatus.Name = "tblStatus";
            tblStatus.RowCount = 2;
            tblStatus.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblStatus.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblStatus.Size = new Size(334, 63);
            tblStatus.TabIndex = 26;
            // 
            // lblDrafted
            // 
            lblDrafted.AutoSize = true;
            lblDrafted.Location = new Point(3, 0);
            lblDrafted.Name = "lblDrafted";
            lblDrafted.Size = new Size(60, 20);
            lblDrafted.TabIndex = 0;
            lblDrafted.Text = "Drafted";
            // 
            // lblPublished
            // 
            lblPublished.AutoSize = true;
            lblPublished.Location = new Point(117, 0);
            lblPublished.Name = "lblPublished";
            lblPublished.Size = new Size(73, 20);
            lblPublished.TabIndex = 1;
            lblPublished.Text = "Published";
            // 
            // txtDatePublished
            // 
            txtDatePublished.Enabled = false;
            txtDatePublished.Location = new Point(117, 34);
            txtDatePublished.Name = "txtDatePublished";
            txtDatePublished.ReadOnly = true;
            txtDatePublished.Size = new Size(100, 27);
            txtDatePublished.TabIndex = 4;
            // 
            // txtDateArchived
            // 
            txtDateArchived.Enabled = false;
            txtDateArchived.Location = new Point(231, 34);
            txtDateArchived.Name = "txtDateArchived";
            txtDateArchived.ReadOnly = true;
            txtDateArchived.Size = new Size(99, 27);
            txtDateArchived.TabIndex = 5;
            // 
            // lblArchived
            // 
            lblArchived.AutoSize = true;
            lblArchived.Location = new Point(231, 0);
            lblArchived.Name = "lblArchived";
            lblArchived.Size = new Size(67, 20);
            lblArchived.TabIndex = 2;
            lblArchived.Text = "Archived";
            // 
            // txtDateDrafted
            // 
            txtDateDrafted.Enabled = false;
            txtDateDrafted.Location = new Point(3, 34);
            txtDateDrafted.Name = "txtDateDrafted";
            txtDateDrafted.ReadOnly = true;
            txtDateDrafted.Size = new Size(100, 27);
            txtDateDrafted.TabIndex = 3;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(36, 198);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(91, 20);
            lblStatus.TabIndex = 19;
            lblStatus.Text = "Status Dates";
            // 
            // lblCurrentStatus
            // 
            lblCurrentStatus.AutoSize = true;
            lblCurrentStatus.Location = new Point(36, 267);
            lblCurrentStatus.Name = "lblCurrentStatus";
            lblCurrentStatus.Size = new Size(101, 20);
            lblCurrentStatus.TabIndex = 27;
            lblCurrentStatus.Text = "Current Status";
            // 
            // txtStatus
            // 
            txtStatus.Enabled = false;
            txtStatus.Location = new Point(376, 270);
            txtStatus.Name = "txtStatus";
            txtStatus.ReadOnly = true;
            txtStatus.Size = new Size(125, 27);
            txtStatus.TabIndex = 28;
            // 
            // tbRecipeDetails
            // 
            tblMain.SetColumnSpan(tbRecipeDetails, 2);
            tbRecipeDetails.Controls.Add(tbIngredients);
            tbRecipeDetails.Controls.Add(tbSteps);
            tbRecipeDetails.Dock = DockStyle.Fill;
            tbRecipeDetails.Location = new Point(36, 303);
            tbRecipeDetails.Margin = new Padding(3, 3, 3, 10);
            tbRecipeDetails.Name = "tbRecipeDetails";
            tbRecipeDetails.SelectedIndex = 0;
            tbRecipeDetails.Size = new Size(674, 521);
            tbRecipeDetails.TabIndex = 29;
            // 
            // tbIngredients
            // 
            tbIngredients.AutoScroll = true;
            tbIngredients.AutoScrollMargin = new Size(3, 3);
            tbIngredients.Controls.Add(tblIng);
            tbIngredients.Location = new Point(4, 29);
            tbIngredients.Name = "tbIngredients";
            tbIngredients.Padding = new Padding(3);
            tbIngredients.Size = new Size(666, 488);
            tbIngredients.TabIndex = 0;
            tbIngredients.Text = "Ingredients";
            tbIngredients.UseVisualStyleBackColor = true;
            // 
            // tblIng
            // 
            tblIng.AutoScroll = true;
            tblIng.AutoSize = true;
            tblIng.ColumnCount = 1;
            tblIng.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblIng.Controls.Add(btnSaveIngredients, 0, 0);
            tblIng.Controls.Add(gIng, 0, 2);
            tblIng.Dock = DockStyle.Fill;
            tblIng.Location = new Point(3, 3);
            tblIng.Name = "tblIng";
            tblIng.RowCount = 3;
            tblIng.RowStyles.Add(new RowStyle());
            tblIng.RowStyles.Add(new RowStyle());
            tblIng.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tblIng.Size = new Size(660, 482);
            tblIng.TabIndex = 0;
            // 
            // btnSaveIngredients
            // 
            btnSaveIngredients.Location = new Point(3, 3);
            btnSaveIngredients.Name = "btnSaveIngredients";
            btnSaveIngredients.Size = new Size(94, 29);
            btnSaveIngredients.TabIndex = 0;
            btnSaveIngredients.Text = "Save";
            btnSaveIngredients.UseVisualStyleBackColor = true;
            // 
            // gIng
            // 
            gIng.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            gIng.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            gIng.BackgroundColor = SystemColors.Control;
            gIng.BorderStyle = BorderStyle.None;
            gIng.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gIng.Dock = DockStyle.Fill;
            gIng.Location = new Point(3, 38);
            gIng.Name = "gIng";
            gIng.RowHeadersWidth = 51;
            gIng.RowTemplate.Height = 29;
            gIng.Size = new Size(654, 441);
            gIng.TabIndex = 1;
            // 
            // tbSteps
            // 
            tbSteps.AutoScroll = true;
            tbSteps.AutoScrollMargin = new Size(5, 5);
            tbSteps.Controls.Add(tblSteps);
            tbSteps.Location = new Point(4, 29);
            tbSteps.Name = "tbSteps";
            tbSteps.Padding = new Padding(3);
            tbSteps.Size = new Size(666, 488);
            tbSteps.TabIndex = 1;
            tbSteps.Text = "Steps";
            tbSteps.UseVisualStyleBackColor = true;
            // 
            // tblSteps
            // 
            tblSteps.AutoSize = true;
            tblSteps.ColumnCount = 1;
            tblSteps.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblSteps.Controls.Add(btnSaveSteps, 0, 0);
            tblSteps.Controls.Add(pnlSteps, 0, 2);
            tblSteps.Dock = DockStyle.Fill;
            tblSteps.Location = new Point(3, 3);
            tblSteps.Name = "tblSteps";
            tblSteps.RowCount = 3;
            tblSteps.RowStyles.Add(new RowStyle());
            tblSteps.RowStyles.Add(new RowStyle());
            tblSteps.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tblSteps.Size = new Size(660, 482);
            tblSteps.TabIndex = 0;
            // 
            // btnSaveSteps
            // 
            btnSaveSteps.Location = new Point(3, 3);
            btnSaveSteps.Name = "btnSaveSteps";
            btnSaveSteps.Size = new Size(94, 29);
            btnSaveSteps.TabIndex = 0;
            btnSaveSteps.Text = "Save";
            btnSaveSteps.UseVisualStyleBackColor = true;
            // 
            // pnlSteps
            // 
            pnlSteps.AutoScroll = true;
            pnlSteps.Controls.Add(gSteps);
            pnlSteps.Dock = DockStyle.Fill;
            pnlSteps.Location = new Point(3, 38);
            pnlSteps.Name = "pnlSteps";
            pnlSteps.Size = new Size(654, 441);
            pnlSteps.TabIndex = 1;
            // 
            // gSteps
            // 
            gSteps.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            gSteps.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            gSteps.BackgroundColor = SystemColors.Control;
            gSteps.BorderStyle = BorderStyle.None;
            gSteps.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gSteps.Dock = DockStyle.Fill;
            gSteps.Location = new Point(0, 0);
            gSteps.Name = "gSteps";
            gSteps.RowHeadersWidth = 51;
            gSteps.RowTemplate.Height = 29;
            gSteps.Size = new Size(654, 441);
            gSteps.TabIndex = 0;
            // 
            // frmRecipeDetail
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            AutoSize = true;
            ClientSize = new Size(770, 834);
            Controls.Add(tblMain);
            Name = "frmRecipeDetail";
            Text = "Recipe Details";
            tblMain.ResumeLayout(false);
            tblMain.PerformLayout();
            tblButtons.ResumeLayout(false);
            tblButtons.PerformLayout();
            tblStatus.ResumeLayout(false);
            tblStatus.PerformLayout();
            tbRecipeDetails.ResumeLayout(false);
            tbIngredients.ResumeLayout(false);
            tbIngredients.PerformLayout();
            tblIng.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gIng).EndInit();
            tbSteps.ResumeLayout(false);
            tbSteps.PerformLayout();
            tblSteps.ResumeLayout(false);
            pnlSteps.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gSteps).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
        private Label lblStatus;
        private TableLayoutPanel tblButtons;
        private Button btnChangeStatus;
        private TableLayoutPanel tblStatus;
        private Label lblDrafted;
        private Label lblPublished;
        private TextBox txtDatePublished;
        private TextBox txtDateArchived;
        private Label lblArchived;
        private TextBox txtDateDrafted;
        private Label lblCurrentStatus;
        private TextBox txtStatus;
        private TabControl tbRecipeDetails;
        private TabPage tbIngredients;
        private TabPage tbSteps;
        private TableLayoutPanel tblSteps;
        private Button btnSaveSteps;
        private TableLayoutPanel tblIng;
        private Button btnSaveIngredients;
        private DataGridView gIng;
        private Panel pnlSteps;
        private DataGridView gSteps;
    }
}