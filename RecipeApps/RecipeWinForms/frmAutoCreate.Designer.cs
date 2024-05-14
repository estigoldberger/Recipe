namespace RecipeWinForms
{
    partial class frmAuto_Create
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
            lstUserName = new ComboBox();
            btnCreate = new Button();
            tblMain.SuspendLayout();
            SuspendLayout();
            // 
            // tblMain
            // 
            tblMain.ColumnCount = 2;
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblMain.Controls.Add(lstUserName, 0, 0);
            tblMain.Controls.Add(btnCreate, 1, 0);
            tblMain.Dock = DockStyle.Fill;
            tblMain.Location = new Point(0, 0);
            tblMain.Name = "tblMain";
            tblMain.RowCount = 1;
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tblMain.Size = new Size(610, 235);
            tblMain.TabIndex = 0;
            // 
            // lstUserName
            // 
            lstUserName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lstUserName.FormattingEnabled = true;
            lstUserName.Location = new Point(50, 103);
            lstUserName.Margin = new Padding(50, 3, 50, 3);
            lstUserName.Name = "lstUserName";
            lstUserName.Size = new Size(205, 28);
            lstUserName.TabIndex = 0;
            // 
            // btnCreate
            // 
            btnCreate.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnCreate.AutoSize = true;
            btnCreate.Location = new Point(308, 102);
            btnCreate.Margin = new Padding(3, 3, 110, 3);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(192, 30);
            btnCreate.TabIndex = 1;
            btnCreate.Text = "Create Cookbook";
            btnCreate.UseVisualStyleBackColor = true;
            // 
            // frmAuto_Create
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(610, 235);
            Controls.Add(tblMain);
            Name = "frmAuto_Create";
            Text = "Auto Create a Cookbook";
            tblMain.ResumeLayout(false);
            tblMain.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tblMain;
        private ComboBox lstUserName;
        private Button btnCreate;
    }
}