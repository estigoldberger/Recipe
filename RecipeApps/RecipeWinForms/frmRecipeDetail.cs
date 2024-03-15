namespace RecipeWinForms
{
    public partial class frmRecipeDetail : Form
    {
        DataTable dtRecipe;
        BindingSource bindsource = new BindingSource();
        public frmRecipeDetail()
        {
            InitializeComponent();
            btnSave.Click += BtnSave_Click;
            btnDelete.Click += BtnDelete_Click;

            //dtIng.CellDoubleClick += DtIng_CellDoubleClick;

        }



        public void ShowRecipeDetails(int recipeid)
        {
            dtRecipe = Recipes.RecipeDetails(recipeid);
            bindsource.DataSource = dtRecipe;
            DataTable dtCuisine = Recipes.CuisineDetails();
            DataTable dtUsers = Recipes.UserDetails();
            if (recipeid == 0)
            {
                dtRecipe.Rows.Add();
            }
            WindowsFormsUtility.SetControlBindings(txtRecipeName, bindsource);
            WindowsFormsUtility.SetControlBindings(txtCalorie, bindsource);
            WindowsFormsUtility.SetControlBindings(dtpDateDrafted, bindsource);
            WindowsFormsUtility.SetControlBindings(txtDatePublished, bindsource);
            WindowsFormsUtility.SetControlBindings(txtDateArchived, bindsource);
            WindowsFormsUtility.SetListBinding(lstCuisineType, dtCuisine, dtRecipe, "Cuisine");
            WindowsFormsUtility.SetListBinding(lstUserName, dtUsers, dtRecipe, "Staff");
            //GetIngredientList(recipeid);
            //GetDirections(recipeid);

            this.Show();

        }
        //private DataTable GetIngredientList(int recId)
        //{
        //    string sql = " select Ingredients = concat(ri.Amount, ' ', m.MeasurementType, ' ', i.IngredientName)  from recipe r join RecipeIngredient ri on r.RecipeId= ri.RecipeID join Ingredient i on i.IngredientID=ri.IngredientID left join Measurement m on m.MeasurementID = ri.MeasurementID where r.recipeid=" + recId.ToString() + "order by ri.RecipeSequence";
        //    DataTable ing = SQLUtility.GetDataTable(sql);
        //    dtIng.DataSource = ing;
        //    return ing;

        //}
        //private DataTable GetDirections(int directionId)
        //{
        //    string sql = " select  rd.Direction from Recipe r join RecipeDirection rd on r.RecipeId = rd.RecipeID where r.recipeid=" + directionId.ToString() + " order by rd.directionSequence";
        //    DataTable dir = SQLUtility.GetDataTable(sql);
        //    dtDirections.DataSource = dir;
        //    return dir;

        //}
        private void Save()
        {
            Application.UseWaitCursor = true;
            try
            {

                Recipes.Save(dtRecipe);
                bindsource.ResetBindings(false);
                this.Close();
            }
            catch (Exception ex)
            {


                MessageBox.Show(ex.Message, "Recipe");
            }
            finally
            {
                Application.UseWaitCursor = false;
            }

        }
        private void Delete()
        {
            var response = MessageBox.Show("Are you sure you want to delete this recipe?", "Recipe", MessageBoxButtons.YesNo);
            if (response == DialogResult.No)
            {
                return;
            }
            Application.UseWaitCursor = true;
            try
            {
                Recipes.Delete(dtRecipe);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Recipe");
            }
            finally
            {
                Application.UseWaitCursor = false;
            }

        }
        private void BtnDelete_Click(object? sender, EventArgs e)
        {
            Delete();
        }

        private void BtnSave_Click(object? sender, EventArgs e)
        {
            Save();
        }




    }
}
