namespace RecipeWinForms
{
    partial class frmDataMaintenance
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
            pnlRadioButtons = new Panel();
            gData = new DataGridView();
            btnSave = new Button();
            rbUsers = new RadioButton();
            rbCuisines = new RadioButton();
            rbIngredients = new RadioButton();
            rbMeasurements = new RadioButton();
            rbCourses = new RadioButton();
            tblMain.SuspendLayout();
            pnlRadioButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gData).BeginInit();
            SuspendLayout();
            // 
            // tblMain
            // 
            tblMain.ColumnCount = 2;
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 27.272728F));
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 72.72727F));
            tblMain.Controls.Add(pnlRadioButtons, 0, 0);
            tblMain.Controls.Add(gData, 1, 0);
            tblMain.Controls.Add(btnSave, 1, 1);
            tblMain.Dock = DockStyle.Fill;
            tblMain.Location = new Point(0, 0);
            tblMain.Name = "tblMain";
            tblMain.RowCount = 2;
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 81.42857F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 18.5714283F));
            tblMain.Size = new Size(1100, 630);
            tblMain.TabIndex = 0;
            // 
            // pnlRadioButtons
            // 
            pnlRadioButtons.Controls.Add(rbCourses);
            pnlRadioButtons.Controls.Add(rbMeasurements);
            pnlRadioButtons.Controls.Add(rbIngredients);
            pnlRadioButtons.Controls.Add(rbCuisines);
            pnlRadioButtons.Controls.Add(rbUsers);
            pnlRadioButtons.Dock = DockStyle.Fill;
            pnlRadioButtons.Location = new Point(3, 3);
            pnlRadioButtons.Name = "pnlRadioButtons";
            pnlRadioButtons.Size = new Size(294, 507);
            pnlRadioButtons.TabIndex = 0;
            // 
            // gData
            // 
            gData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gData.Dock = DockStyle.Fill;
            gData.Location = new Point(303, 3);
            gData.Name = "gData";
            gData.RowHeadersWidth = 51;
            gData.RowTemplate.Height = 29;
            gData.Size = new Size(794, 507);
            gData.TabIndex = 1;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSave.BackColor = SystemColors.ButtonFace;
            btnSave.Location = new Point(1003, 533);
            btnSave.Margin = new Padding(3, 20, 3, 3);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 38);
            btnSave.TabIndex = 2;
            btnSave.Text = "&Save";
            btnSave.UseVisualStyleBackColor = false;
            // 
            // rbUsers
            // 
            rbUsers.AutoSize = true;
            rbUsers.Checked = true;
            rbUsers.Location = new Point(22, 51);
            rbUsers.Name = "rbUsers";
            rbUsers.Size = new Size(80, 32);
            rbUsers.TabIndex = 0;
            rbUsers.TabStop = true;
            rbUsers.Text = "Users";
            rbUsers.UseVisualStyleBackColor = true;
            // 
            // rbCuisines
            // 
            rbCuisines.AutoSize = true;
            rbCuisines.Location = new Point(22, 109);
            rbCuisines.Name = "rbCuisines";
            rbCuisines.Size = new Size(103, 32);
            rbCuisines.TabIndex = 1;
            rbCuisines.Text = "Cuisines";
            rbCuisines.UseVisualStyleBackColor = true;
            // 
            // rbIngredients
            // 
            rbIngredients.AutoSize = true;
            rbIngredients.Location = new Point(22, 172);
            rbIngredients.Name = "rbIngredients";
            rbIngredients.Size = new Size(131, 32);
            rbIngredients.TabIndex = 2;
            rbIngredients.Text = "Ingredients";
            rbIngredients.UseVisualStyleBackColor = true;
            // 
            // rbMeasurements
            // 
            rbMeasurements.AutoSize = true;
            rbMeasurements.Location = new Point(22, 234);
            rbMeasurements.Name = "rbMeasurements";
            rbMeasurements.Size = new Size(160, 32);
            rbMeasurements.TabIndex = 3;
            rbMeasurements.Text = "Measurements";
            rbMeasurements.UseVisualStyleBackColor = true;
            // 
            // rbCourses
            // 
            rbCourses.AutoSize = true;
            rbCourses.Location = new Point(22, 300);
            rbCourses.Name = "rbCourses";
            rbCourses.Size = new Size(101, 32);
            rbCourses.TabIndex = 4;
            rbCourses.Text = "Courses";
            rbCourses.UseVisualStyleBackColor = true;
            // 
            // frmDataMaintenance
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1100, 630);
            Controls.Add(tblMain);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4, 4, 4, 4);
            Name = "frmDataMaintenance";
            Text = "Data Maintenance";
            tblMain.ResumeLayout(false);
            pnlRadioButtons.ResumeLayout(false);
            pnlRadioButtons.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gData).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tblMain;
        private Panel pnlRadioButtons;
        private RadioButton rbCourses;
        private RadioButton rbMeasurements;
        private RadioButton rbIngredients;
        private RadioButton rbCuisines;
        private RadioButton rbUsers;
        private DataGridView gData;
        private Button btnSave;
    }
}