namespace RecipeWinForms
{
    partial class frmChangeStatus
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
            lblRecipeName = new Label();
            lblCurrentStatus = new Label();
            tblDates = new TableLayoutPanel();
            lblStatusDates = new Label();
            lblDrafted = new Label();
            lblPublished = new Label();
            lblArchived = new Label();
            txtDateDrafted = new TextBox();
            txtDatePublished = new TextBox();
            txtDateArchived = new TextBox();
            tblButtons = new TableLayoutPanel();
            btnDraft = new Button();
            btnArchive = new Button();
            btnPublish = new Button();
            lblRecipeStatus = new Label();
            tblMain.SuspendLayout();
            tblDates.SuspendLayout();
            tblButtons.SuspendLayout();
            SuspendLayout();
            // 
            // tblMain
            // 
            tblMain.ColumnCount = 2;
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblMain.Controls.Add(lblRecipeName, 0, 0);
            tblMain.Controls.Add(lblCurrentStatus, 0, 1);
            tblMain.Controls.Add(tblDates, 0, 2);
            tblMain.Controls.Add(tblButtons, 0, 3);
            tblMain.Controls.Add(lblRecipeStatus, 1, 1);
            tblMain.Dock = DockStyle.Fill;
            tblMain.Location = new Point(0, 0);
            tblMain.Name = "tblMain";
            tblMain.RowCount = 4;
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 89F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 26F));
            tblMain.Size = new Size(800, 450);
            tblMain.TabIndex = 0;
            // 
            // lblRecipeName
            // 
            lblRecipeName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblRecipeName.AutoSize = true;
            tblMain.SetColumnSpan(lblRecipeName, 2);
            lblRecipeName.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblRecipeName.Location = new Point(50, 30);
            lblRecipeName.Margin = new Padding(50, 30, 50, 0);
            lblRecipeName.Name = "lblRecipeName";
            lblRecipeName.Size = new Size(700, 38);
            lblRecipeName.TabIndex = 0;
            lblRecipeName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblCurrentStatus
            // 
            lblCurrentStatus.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblCurrentStatus.AutoSize = true;
            lblCurrentStatus.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblCurrentStatus.Location = new Point(234, 118);
            lblCurrentStatus.Margin = new Padding(3, 50, 3, 80);
            lblCurrentStatus.Name = "lblCurrentStatus";
            lblCurrentStatus.Size = new Size(163, 31);
            lblCurrentStatus.TabIndex = 1;
            lblCurrentStatus.Text = "Current Status:";
            // 
            // tblDates
            // 
            tblDates.ColumnCount = 4;
            tblMain.SetColumnSpan(tblDates, 2);
            tblDates.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblDates.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblDates.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 135F));
            tblDates.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 246F));
            tblDates.Controls.Add(lblStatusDates, 0, 1);
            tblDates.Controls.Add(lblDrafted, 1, 0);
            tblDates.Controls.Add(lblPublished, 2, 0);
            tblDates.Controls.Add(lblArchived, 3, 0);
            tblDates.Controls.Add(txtDateDrafted, 1, 1);
            tblDates.Controls.Add(txtDatePublished, 2, 1);
            tblDates.Controls.Add(txtDateArchived, 3, 1);
            tblDates.Dock = DockStyle.Fill;
            tblDates.Location = new Point(3, 229);
            tblDates.Margin = new Padding(3, 0, 3, 3);
            tblDates.Name = "tblDates";
            tblDates.RowCount = 2;
            tblDates.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tblDates.RowStyles.Add(new RowStyle(SizeType.Percent, 75F));
            tblDates.Size = new Size(794, 86);
            tblDates.TabIndex = 3;
            // 
            // lblStatusDates
            // 
            lblStatusDates.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblStatusDates.AutoSize = true;
            lblStatusDates.Location = new Point(112, 21);
            lblStatusDates.Margin = new Padding(50, 0, 3, 0);
            lblStatusDates.Name = "lblStatusDates";
            lblStatusDates.Size = new Size(91, 20);
            lblStatusDates.TabIndex = 0;
            lblStatusDates.Text = "Status Dates";
            // 
            // lblDrafted
            // 
            lblDrafted.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblDrafted.AutoSize = true;
            lblDrafted.Location = new Point(332, 0);
            lblDrafted.Margin = new Padding(50, 0, 20, 0);
            lblDrafted.Name = "lblDrafted";
            lblDrafted.Size = new Size(60, 20);
            lblDrafted.TabIndex = 1;
            lblDrafted.Text = "Drafted";
            // 
            // lblPublished
            // 
            lblPublished.AutoSize = true;
            lblPublished.Location = new Point(432, 0);
            lblPublished.Margin = new Padding(20, 0, 3, 0);
            lblPublished.Name = "lblPublished";
            lblPublished.Size = new Size(73, 20);
            lblPublished.TabIndex = 2;
            lblPublished.Text = "Published";
            // 
            // lblArchived
            // 
            lblArchived.AutoSize = true;
            lblArchived.Location = new Point(550, 0);
            lblArchived.Name = "lblArchived";
            lblArchived.Size = new Size(67, 20);
            lblArchived.TabIndex = 3;
            lblArchived.Text = "Archived";
            // 
            // txtDateDrafted
            // 
            txtDateDrafted.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtDateDrafted.Location = new Point(267, 24);
            txtDateDrafted.Margin = new Padding(3, 3, 20, 3);
            txtDateDrafted.Name = "txtDateDrafted";
            txtDateDrafted.ReadOnly = true;
            txtDateDrafted.Size = new Size(125, 27);
            txtDateDrafted.TabIndex = 4;
            // 
            // txtDatePublished
            // 
            txtDatePublished.Location = new Point(415, 24);
            txtDatePublished.Name = "txtDatePublished";
            txtDatePublished.ReadOnly = true;
            txtDatePublished.Size = new Size(125, 27);
            txtDatePublished.TabIndex = 5;
            // 
            // txtDateArchived
            // 
            txtDateArchived.Location = new Point(550, 24);
            txtDateArchived.Name = "txtDateArchived";
            txtDateArchived.ReadOnly = true;
            txtDateArchived.Size = new Size(125, 27);
            txtDateArchived.TabIndex = 6;
            // 
            // tblButtons
            // 
            tblButtons.ColumnCount = 3;
            tblMain.SetColumnSpan(tblButtons, 2);
            tblButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 56.9642868F));
            tblButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 43.0357132F));
            tblButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 234F));
            tblButtons.Controls.Add(btnDraft, 0, 0);
            tblButtons.Controls.Add(btnArchive, 2, 0);
            tblButtons.Controls.Add(btnPublish, 1, 0);
            tblButtons.Dock = DockStyle.Fill;
            tblButtons.Location = new Point(3, 321);
            tblButtons.Name = "tblButtons";
            tblButtons.RowCount = 1;
            tblButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblButtons.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tblButtons.Size = new Size(794, 126);
            tblButtons.TabIndex = 4;
            // 
            // btnDraft
            // 
            btnDraft.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnDraft.Location = new Point(222, 3);
            btnDraft.Margin = new Padding(50, 3, 3, 3);
            btnDraft.Name = "btnDraft";
            btnDraft.Size = new Size(94, 29);
            btnDraft.TabIndex = 0;
            btnDraft.Text = "Draft";
            btnDraft.UseVisualStyleBackColor = true;
            // 
            // btnArchive
            // 
            btnArchive.Location = new Point(560, 3);
            btnArchive.Margin = new Padding(0, 3, 3, 3);
            btnArchive.Name = "btnArchive";
            btnArchive.Size = new Size(94, 29);
            btnArchive.TabIndex = 2;
            btnArchive.Text = "Archive";
            btnArchive.UseVisualStyleBackColor = true;
            // 
            // btnPublish
            // 
            btnPublish.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnPublish.Location = new Point(396, 3);
            btnPublish.Margin = new Padding(3, 3, 70, 3);
            btnPublish.Name = "btnPublish";
            btnPublish.Size = new Size(94, 29);
            btnPublish.TabIndex = 1;
            btnPublish.Text = "Publish";
            btnPublish.UseVisualStyleBackColor = true;
            // 
            // lblRecipeStatus
            // 
            lblRecipeStatus.AutoSize = true;
            lblRecipeStatus.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblRecipeStatus.Location = new Point(403, 118);
            lblRecipeStatus.Margin = new Padding(3, 50, 3, 80);
            lblRecipeStatus.Name = "lblRecipeStatus";
            lblRecipeStatus.Size = new Size(0, 28);
            lblRecipeStatus.TabIndex = 5;
            // 
            // frmChangeStatus
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tblMain);
            Name = "frmChangeStatus";
            Text = "Change Status";
            tblMain.ResumeLayout(false);
            tblMain.PerformLayout();
            tblDates.ResumeLayout(false);
            tblDates.PerformLayout();
            tblButtons.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tblMain;
        private Label lblRecipeName;
        private Label lblCurrentStatus;
        private TableLayoutPanel tblDates;
        private Label lblStatusDates;
        private Label lblDrafted;
        private Label lblPublished;
        private Label lblArchived;
        private TextBox txtDateDrafted;
        private TextBox txtDatePublished;
        private TextBox txtDateArchived;
        private TableLayoutPanel tblButtons;
        private Button btnDraft;
        private Button btnPublish;
        private Button btnArchive;
        private Label lblRecipeStatus;
    }
}