using CPUFramework;
using System.Data;
using System.Data.SqlClient;

namespace RecipeWinForms
{
    public partial class frmRecipeDetail : Form
    {
        public frmRecipeDetail()
        {
            InitializeComponent();



        }

        public void ShowIngredients(int recipeid)
        {
            string sql =
                        "select recipeName, Calorie from recipe r  where r.recipeId=" + recipeid.ToString();
            //"select recipename, IngredientList = concat(ri.Amount, ' ', m.MeasurementType, ' ', i.IngredientName) , Calorie,   Direction  from recipe r  join recipeIngredient ri on r.recipeId = ri.RecipeId join Ingredient i on i.ingredientId = ri.IngredientId left join measurement m on m.measurementId = ri.measurementId  join recipeDirection rd on r.recipeId= rd.recipeID  where rd.recipeId=" + recipeid.ToString() + "order by rd.directionSequence";
            DataTable dt = SQLUtility.GetDataTable(sql);
            txtName.DataBindings.Add("Text", dt, "RecipeName");
            txtCalories.DataBindings.Add("Text", dt, "Calorie");
            GetIngredientList(recipeid);
            GetDirections(recipeid);


            this.Show();

        }
        private DataTable GetIngredientList(int recId)
        {
            string sql = " select Ingredients = concat(ri.Amount, ' ', m.MeasurementType, ' ', i.IngredientName)  from recipe r join RecipeIngredient ri on r.RecipeId= ri.RecipeID join Ingredient i on i.IngredientID=ri.IngredientID left join Measurement m on m.MeasurementID = ri.MeasurementID where r.recipeid=" + recId.ToString() + "order by ri.RecipeSequence";
            DataTable ing = SQLUtility.GetDataTable(sql);
            dtIng.DataSource = ing;
            return ing;

        }
        private DataTable GetDirections(int directionId)
        {
            string sql = " select  rd.Direction from Recipe r join RecipeDirection rd on r.RecipeId = rd.RecipeID where r.recipeid=" + directionId.ToString() + "order by rd.directionSequence";
            DataTable dir = SQLUtility.GetDataTable(sql);
            dtDirections.DataSource = dir;
            return dir;

        }


    }
}
