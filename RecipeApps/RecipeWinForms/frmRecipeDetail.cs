namespace RecipeWinForms
{
    public partial class frmRecipeDetail : Form
    {
        DataTable dtRecipe;
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
            DataTable dtCuisine = Recipes.CuisineDetails();
            DataTable dtUsers = Recipes.UserDetails();            
            if (recipeid == 0)
            {
                dtRecipe.Rows.Add();
            }
            WindowsFormsUtility.SetControlBindings(txtRecipeName, dtRecipe);
            WindowsFormsUtility.SetControlBindings(txtCalorie, dtRecipe);
            WindowsFormsUtility.SetControlBindings(dtpDateDrafted, dtRecipe);
            WindowsFormsUtility.SetControlBindings(txtDatePublished, dtRecipe);
            WindowsFormsUtility.SetControlBindings(txtDateArchived, dtRecipe);
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

            Recipes.Save(dtRecipe);
            this.Close();
        }
        private void Delete()
        {
            Recipes.Delete(dtRecipe);
            this.Close();
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
