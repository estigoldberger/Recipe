using CPUFramework;
using CPUWindowsFormFramework;
using System.Data;
using System.Data.SqlClient;

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

            DataTable dtCuisine = SQLUtility.GetDataTable("select CuisineID, CuisineType from Cuisine");
            DataTable dtUsers = SQLUtility.GetDataTable("select StaffId, UserName from Staff");
            string sql = "select StaffId, CuisineId, RecipeId, recipeName, Calorie from recipe r  where r.recipeId=" + recipeid.ToString();
            dtRecipe = SQLUtility.GetDataTable(sql);
            if (recipeid == 0)
            {
                dtRecipe.Rows.Add();
            }
            WindowsFormsUtility.SetControlBindings(txtRecipeName, dtRecipe);
            WindowsFormsUtility.SetControlBindings(txtCalorie, dtRecipe);
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

            DataRow r = dtRecipe.Rows[0];
            int id = (int)r["RecipeID"];
            string sql = "";
            if (id > 0)
            {
                sql = string.Join(Environment.NewLine, $"update Recipe set",

           $" RecipeName= '{r["RecipeName"]}',",
           $"StaffId= '{r["StaffId"]}',",
           $"CuisineId= '{r["CuisineId"]}',",
           $" Calorie= '{r["Calorie"]}'",
           $"where RecipeId = {r["RecipeId"]}");
            }
            else
            {

                sql = "insert Recipe(RecipeName, Calorie, StaffId, CuisineId)";
                sql += $"select '{r["RecipeName"]}', {r["Calorie"]}, '{r["StaffId"]}', '{r["CuisineId"]}'";
            }
            SQLUtility.ExecuteSQL(sql);
            this.Close();
        }
        private void Delete()
        {
            int id = (int)dtRecipe.Rows[0]["RecipeId"];
            string sql = "Delete recipe where recipeId =" + id;
            SQLUtility.ExecuteSQL(sql);
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
