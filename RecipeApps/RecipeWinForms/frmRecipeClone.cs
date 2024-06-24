namespace RecipeWinForms
{
    public partial class frmRecipeClone : Form
    {
        
        int recipeid = 0;
        public frmRecipeClone()
        {
            InitializeComponent();
            BindData();
            btnClone.Click += BtnClone_Click;
            
        }
 
        private void BindData()
        {
            WindowsFormsUtility.SetListBinding(lstRecipeName, DataMaintenance.GetDataList("Recipe"), null, "Recipe");
        }
        private void CloneRecipe()
        {
            recipeid = WindowsFormsUtility.GetIdFromComboBox(lstRecipeName);
            int baseid = WindowsFormsUtility.GetIdFromComboBox(lstRecipeName);
           
            Cursor = Cursors.WaitCursor;
            try
            {
                int newid=  Recipes.CloneRecipe(recipeid,baseid);

                if (this.MdiParent != null && this.MdiParent is frmMain)
                {
                    ((frmMain)this.MdiParent).OpenForm(typeof(frmRecipeDetail),newid);

                }
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName);
            }
            finally
            {
                Cursor = Cursors.Default;
            }

        }
        private void BtnClone_Click(object? sender, EventArgs e)
        {
            CloneRecipe();
           

        }
    }
}
