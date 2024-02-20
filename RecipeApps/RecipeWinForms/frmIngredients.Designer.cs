namespace RecipeWinForms
{
    partial class frmIngredients
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
            tableLayoutPanel1 = new TableLayoutPanel();
            tblControl = new TableLayoutPanel();
            txtQuantity = new TextBox();
            lstMeasurementType = new ComboBox();
            lstIngredientName = new ComboBox();
            btnSave = new Button();
            tableLayoutPanel1.SuspendLayout();
            tblControl.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(tblControl, 0, 0);
            tableLayoutPanel1.Controls.Add(btnSave, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 66.6666641F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel1.Size = new Size(460, 381);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tblControl
            // 
            tblControl.ColumnCount = 3;
            tblControl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tblControl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tblControl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tblControl.Controls.Add(txtQuantity, 0, 0);
            tblControl.Controls.Add(lstMeasurementType, 1, 0);
            tblControl.Controls.Add(lstIngredientName, 2, 0);
            tblControl.Dock = DockStyle.Fill;
            tblControl.Location = new Point(3, 3);
            tblControl.Name = "tblControl";
            tblControl.RowCount = 1;
            tblControl.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblControl.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tblControl.Size = new Size(454, 248);
            tblControl.TabIndex = 0;
            // 
            // txtQuantity
            // 
            txtQuantity.Dock = DockStyle.Top;
            txtQuantity.Location = new Point(3, 3);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.PlaceholderText = "Type quantity here";
            txtQuantity.Size = new Size(145, 27);
            txtQuantity.TabIndex = 0;
            // 
            // lstMeasurementType
            // 
            lstMeasurementType.FormattingEnabled = true;
            lstMeasurementType.Location = new Point(154, 3);
            lstMeasurementType.Name = "lstMeasurementType";
            lstMeasurementType.Size = new Size(145, 28);
            lstMeasurementType.TabIndex = 1;
            // 
            // lstIngredientName
            // 
            lstIngredientName.FormattingEnabled = true;
            lstIngredientName.Location = new Point(305, 3);
            lstIngredientName.Name = "lstIngredientName";
            lstIngredientName.Size = new Size(146, 28);
            lstIngredientName.TabIndex = 2;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSave.Location = new Point(363, 349);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 1;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // frmIngredients
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(460, 381);
            Controls.Add(tableLayoutPanel1);
            Name = "frmIngredients";
            Text = "frmIngredients";
            tableLayoutPanel1.ResumeLayout(false);
            tblControl.ResumeLayout(false);
            tblControl.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tblControl;
        private TextBox txtQuantity;
        private ComboBox lstMeasurementType;
        private ComboBox lstIngredientName;
        private Button btnSave;
    }
}