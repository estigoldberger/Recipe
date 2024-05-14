namespace RecipeWinForms
{
    partial class frmMealDetail
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
            gMeal = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)gMeal).BeginInit();
            SuspendLayout();
            // 
            // gMeal
            // 
            gMeal.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gMeal.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            gMeal.BackgroundColor = Color.White;
            gMeal.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gMeal.Location = new Point(0, 0);
            gMeal.Name = "gMeal";
            gMeal.RowHeadersWidth = 51;
            gMeal.RowTemplate.Height = 29;
            gMeal.Size = new Size(1100, 630);
            gMeal.TabIndex = 0;
            // 
            // frmMealDetail
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1100, 630);
            Controls.Add(gMeal);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "frmMealDetail";
            Text = "Meal Details";
            ((System.ComponentModel.ISupportInitialize)gMeal).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView gMeal;
    }
}