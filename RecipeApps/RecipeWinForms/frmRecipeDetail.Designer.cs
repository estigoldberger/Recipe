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
            lblRecipeName = new Label();
            lblIngredients = new Label();
            txtName = new TextBox();
            lblDirections = new Label();
            lblCalories = new Label();
            txtCalories = new TextBox();
            dtIng = new DataGridView();
            dtDirections = new DataGridView();
            tblMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtIng).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtDirections).BeginInit();
            SuspendLayout();
            // 
            // tblMain
            // 
            tblMain.AutoSize = true;
            tblMain.ColumnCount = 2;
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblMain.Controls.Add(lblRecipeName, 0, 0);
            tblMain.Controls.Add(lblIngredients, 0, 1);
            tblMain.Controls.Add(txtName, 1, 0);
            tblMain.Controls.Add(lblDirections, 0, 2);
            tblMain.Controls.Add(lblCalories, 0, 3);
            tblMain.Controls.Add(txtCalories, 1, 3);
            tblMain.Controls.Add(dtIng, 1, 1);
            tblMain.Controls.Add(dtDirections, 1, 2);
            tblMain.Location = new Point(76, 12);
            tblMain.Name = "tblMain";
            tblMain.RowCount = 4;
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.Size = new Size(682, 426);
            tblMain.TabIndex = 0;
            // 
            // lblRecipeName
            // 
            lblRecipeName.AutoSize = true;
            lblRecipeName.Location = new Point(3, 0);
            lblRecipeName.Name = "lblRecipeName";
            lblRecipeName.Size = new Size(98, 20);
            lblRecipeName.TabIndex = 0;
            lblRecipeName.Text = "Recipe Name";
            // 
            // lblIngredients
            // 
            lblIngredients.AutoSize = true;
            lblIngredients.Location = new Point(3, 33);
            lblIngredients.Name = "lblIngredients";
            lblIngredients.Size = new Size(83, 20);
            lblIngredients.TabIndex = 1;
            lblIngredients.Text = "Ingredients";
            // 
            // txtName
            // 
            txtName.Dock = DockStyle.Fill;
            txtName.Location = new Point(344, 3);
            txtName.Name = "txtName";
            txtName.Size = new Size(335, 27);
            txtName.TabIndex = 2;
            // 
            // lblDirections
            // 
            lblDirections.AutoSize = true;
            lblDirections.Location = new Point(3, 227);
            lblDirections.Name = "lblDirections";
            lblDirections.Size = new Size(76, 20);
            lblDirections.TabIndex = 4;
            lblDirections.Text = "Directions";
            // 
            // lblCalories
            // 
            lblCalories.AutoSize = true;
            lblCalories.Location = new Point(3, 387);
            lblCalories.Name = "lblCalories";
            lblCalories.Size = new Size(62, 20);
            lblCalories.TabIndex = 5;
            lblCalories.Text = "Calories";
            // 
            // txtCalories
            // 
            txtCalories.Location = new Point(344, 390);
            txtCalories.Name = "txtCalories";
            txtCalories.Size = new Size(125, 27);
            txtCalories.TabIndex = 7;
            // 
            // dtIng
            // 
            dtIng.AllowUserToAddRows = false;
            dtIng.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtIng.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dtIng.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtIng.Dock = DockStyle.Fill;
            dtIng.Location = new Point(344, 36);
            dtIng.Name = "dtIng";
            dtIng.RowHeadersWidth = 51;
            dtIng.RowTemplate.Height = 29;
            dtIng.Size = new Size(335, 188);
            dtIng.TabIndex = 8;
            // 
            // dtDirections
            // 
            dtDirections.AllowUserToAddRows = false;
            dtDirections.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtDirections.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dtDirections.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtDirections.Dock = DockStyle.Fill;
            dtDirections.Location = new Point(344, 230);
            dtDirections.Name = "dtDirections";
            dtDirections.RowHeadersWidth = 51;
            dtDirections.RowTemplate.Height = 29;
            dtDirections.Size = new Size(335, 154);
            dtDirections.TabIndex = 9;
            // 
            // frmRecipeDetail
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tblMain);
            Name = "frmRecipeDetail";
            Text = "Recipe Details";
            tblMain.ResumeLayout(false);
            tblMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtIng).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtDirections).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tblMain;
        private Label lblIngredients;
        private TextBox txtName;
        private Label lblDirections;
        private Label lblCalories;
        private Label lblRecipeName;
        private DataGridView dtIng;
        private TextBox txtCalories;
        private DataGridView dtDirections;
    }
}