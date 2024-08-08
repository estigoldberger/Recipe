namespace RecipeWinForms
{
    partial class frmLogin
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
            lblUser = new Label();
            lblPassword = new Label();
            tblLogin = new TableLayoutPanel();
            txtUserId = new TextBox();
            txtPassword = new TextBox();
            btnLogin = new Button();
            btnCancel = new Button();
            tblMain.SuspendLayout();
            tblLogin.SuspendLayout();
            SuspendLayout();
            // 
            // tblMain
            // 
            tblMain.ColumnCount = 2;
            tblMain.ColumnStyles.Add(new ColumnStyle());
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblMain.Controls.Add(lblUser, 0, 0);
            tblMain.Controls.Add(lblPassword, 0, 1);
            tblMain.Controls.Add(tblLogin, 1, 2);
            tblMain.Controls.Add(txtUserId, 1, 0);
            tblMain.Controls.Add(txtPassword, 1, 1);
            tblMain.Dock = DockStyle.Fill;
            tblMain.Location = new Point(0, 0);
            tblMain.Name = "tblMain";
            tblMain.RowCount = 4;
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tblMain.Size = new Size(525, 199);
            tblMain.TabIndex = 0;
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Location = new Point(3, 0);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(108, 28);
            lblUser.TabIndex = 0;
            lblUser.Text = "User Name";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(3, 40);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(93, 28);
            lblPassword.TabIndex = 2;
            lblPassword.Text = "Password";
            // 
            // tblLogin
            // 
            tblLogin.ColumnCount = 2;
            tblLogin.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 69.87654F));
            tblLogin.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30.123457F));
            tblLogin.Controls.Add(btnLogin, 0, 0);
            tblLogin.Controls.Add(btnCancel, 1, 0);
            tblLogin.Dock = DockStyle.Fill;
            tblLogin.Location = new Point(117, 83);
            tblLogin.Name = "tblLogin";
            tblLogin.RowCount = 1;
            tblLogin.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblLogin.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tblLogin.Size = new Size(405, 55);
            tblLogin.TabIndex = 4;
            // 
            // txtUserId
            // 
            txtUserId.Dock = DockStyle.Fill;
            txtUserId.Location = new Point(117, 3);
            txtUserId.Name = "txtUserId";
            txtUserId.Size = new Size(405, 34);
            txtUserId.TabIndex = 1;
            // 
            // txtPassword
            // 
            txtPassword.Dock = DockStyle.Fill;
            txtPassword.Location = new Point(117, 43);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(405, 34);
            txtPassword.TabIndex = 3;
            // 
            // btnLogin
            // 
            btnLogin.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnLogin.Location = new Point(158, 3);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(122, 49);
            btnLogin.TabIndex = 0;
            btnLogin.Text = "OK";
            btnLogin.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCancel.AutoSize = true;
            btnCancel.Location = new Point(291, 3);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(111, 49);
            btnCancel.TabIndex = 1;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // frmLogin
            // 
            AcceptButton = btnLogin;
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new Size(525, 199);
            Controls.Add(tblMain);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4, 4, 4, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmLogin";
            Text = "Recipe Login";
            tblMain.ResumeLayout(false);
            tblMain.PerformLayout();
            tblLogin.ResumeLayout(false);
            tblLogin.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tblMain;
        private Label lblUser;
        private Label lblPassword;
        private Button button1;
        private Button button2;
        private TableLayoutPanel tblLogin;
        private TextBox txtUserId;
        private TextBox txtPassword;
        private Button btnLogin;
        private Button btnCancel;
    }
}