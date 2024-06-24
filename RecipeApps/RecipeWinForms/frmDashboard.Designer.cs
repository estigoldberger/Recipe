namespace RecipeWinForms
{
    partial class frmDashboard
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            tblMain = new TableLayoutPanel();
            lblHeader = new Label();
            lblDesc = new Label();
            dtDashboard = new DataGridView();
            tblButton = new TableLayoutPanel();
            btnMealList = new Button();
            btnCookbookList = new Button();
            btnRecipeList = new Button();
            tblMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtDashboard).BeginInit();
            tblButton.SuspendLayout();
            SuspendLayout();
            // 
            // tblMain
            // 
            tblMain.AutoSize = true;
            tblMain.ColumnCount = 1;
            tblMain.ColumnStyles.Add(new ColumnStyle());
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tblMain.Controls.Add(lblHeader, 0, 0);
            tblMain.Controls.Add(lblDesc, 0, 1);
            tblMain.Controls.Add(dtDashboard, 0, 2);
            tblMain.Controls.Add(tblButton, 0, 3);
            tblMain.Dock = DockStyle.Fill;
            tblMain.Location = new Point(0, 0);
            tblMain.Name = "tblMain";
            tblMain.RowCount = 4;
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 211F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 79F));
            tblMain.Size = new Size(1466, 729);
            tblMain.TabIndex = 0;
            // 
            // lblHeader
            // 
            lblHeader.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblHeader.AutoSize = true;
            lblHeader.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblHeader.Location = new Point(300, 30);
            lblHeader.Margin = new Padding(300, 30, 3, 0);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(1216, 41);
            lblHeader.TabIndex = 0;
            lblHeader.Text = "Hearty Hearth Desktop App";
            lblHeader.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblDesc
            // 
            lblDesc.AutoSize = true;
            lblDesc.Dock = DockStyle.Fill;
            lblDesc.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblDesc.Location = new Point(200, 151);
            lblDesc.Margin = new Padding(200, 80, 3, 50);
            lblDesc.Name = "lblDesc";
            lblDesc.Size = new Size(1316, 75);
            lblDesc.TabIndex = 1;
            lblDesc.Text = "Welcome to the Hearty Hearth desktop App. In this app, you can view our many recipes, meals,\r\nand cookbooks to find ones that suit your appetite. You can also create and edit recipes\r\nand cookbooks.\r\n";
            lblDesc.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dtDashboard
            // 
            dtDashboard.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dtDashboard.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dtDashboard.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dtDashboard.BackgroundColor = SystemColors.Control;
            dtDashboard.BorderStyle = BorderStyle.None;
            dtDashboard.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.NullValue = null;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dtDashboard.DefaultCellStyle = dataGridViewCellStyle2;
            dtDashboard.Location = new Point(300, 276);
            dtDashboard.Margin = new Padding(300, 0, 100, 3);
            dtDashboard.Name = "dtDashboard";
            dtDashboard.RowHeadersWidth = 51;
            dtDashboard.RowTemplate.Height = 29;
            dtDashboard.Size = new Size(1119, 208);
            dtDashboard.TabIndex = 2;
            // 
            // tblButton
            // 
            tblButton.ColumnCount = 3;
            tblButton.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 29.7422333F));
            tblButton.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.756114F));
            tblButton.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 57.50165F));
            tblButton.Controls.Add(btnMealList, 1, 0);
            tblButton.Controls.Add(btnCookbookList, 2, 0);
            tblButton.Controls.Add(btnRecipeList, 0, 0);
            tblButton.Dock = DockStyle.Fill;
            tblButton.Location = new Point(3, 490);
            tblButton.Name = "tblButton";
            tblButton.RowCount = 1;
            tblButton.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblButton.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tblButton.Size = new Size(1513, 236);
            tblButton.TabIndex = 8;
            // 
            // btnMealList
            // 
            btnMealList.AutoSize = true;
            btnMealList.Location = new Point(453, 3);
            btnMealList.Name = "btnMealList";
            btnMealList.Size = new Size(99, 38);
            btnMealList.TabIndex = 1;
            btnMealList.Text = "Meal List";
            btnMealList.UseVisualStyleBackColor = true;
            // 
            // btnCookbookList
            // 
            btnCookbookList.AutoSize = true;
            btnCookbookList.Location = new Point(646, 3);
            btnCookbookList.Name = "btnCookbookList";
            btnCookbookList.Size = new Size(148, 38);
            btnCookbookList.TabIndex = 2;
            btnCookbookList.Text = "Cookbook List";
            btnCookbookList.UseVisualStyleBackColor = true;
            // 
            // btnRecipeList
            // 
            btnRecipeList.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnRecipeList.AutoSize = true;
            btnRecipeList.Location = new Point(217, 3);
            btnRecipeList.Margin = new Padding(70, 3, 120, 3);
            btnRecipeList.Name = "btnRecipeList";
            btnRecipeList.Size = new Size(113, 38);
            btnRecipeList.TabIndex = 0;
            btnRecipeList.Text = "Recipe List";
            btnRecipeList.UseVisualStyleBackColor = true;
            // 
            // frmDashboard
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1466, 729);
            Controls.Add(tblMain);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "frmDashboard";
            Text = "Dashboard";
            tblMain.ResumeLayout(false);
            tblMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtDashboard).EndInit();
            tblButton.ResumeLayout(false);
            tblButton.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tblMain;
        private Label lblHeader;
        private Label lblDesc;
        private DataGridView dtDashboard;
        private TableLayoutPanel tblButtons;
        private Button btnCookbookList;
        private Button btnRecipeList;
        private Button btnMealList;
        private TableLayoutPanel tblButton;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}