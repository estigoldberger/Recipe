using System.Data;
using System.Data.SqlClient;
using CPUFramework;

namespace RecipeSystem
{
    public class Recipes
    {
        public static DataTable GetRecipeList(string recipename)
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = SQLUtility.GetSqlCommand("RecipeGet");
            SQLUtility.SetParameterValue(cmd, "@RecipeName", recipename);
            dt = SQLUtility.GetDataTable(cmd);
            return dt;
        }
        
        public static DataTable RecipeDetails(int recipeid)
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = SQLUtility.GetSqlCommand("RecipeGet");
            SQLUtility.SetParameterValue(cmd, "@Recipeid", recipeid);

            dt = SQLUtility.GetDataTable(cmd);
            return dt;
        }
        public static DataTable UserDetails()
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = SQLUtility.GetSqlCommand("StaffGet");
            SQLUtility.SetParameterValue(cmd, "@All", 1);

            dt = SQLUtility.GetDataTable(cmd);
            return dt;

        }
        public static DataTable CuisineDetails()
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = SQLUtility.GetSqlCommand("CuisineGet");
            SQLUtility.SetParameterValue(cmd, "@All", 1);
            dt = SQLUtility.GetDataTable(cmd);
            return dt;

        }
        
       //public static int CountofRecipes(string recipename)
       // {
       //     int n = 0;
       //     DataTable dt = SQLUtility.GetDataTable("select count(*) from recipe where recipename= " + recipename);
       //     int.TryParse(dt.DisplayExpression, out n);
       //     return n;
       // }
        public static void Save(DataTable dtRecipe)
        {
            DataRow r = dtRecipe.Rows[0];
            SQLUtility.SaveDataRow(r, "RecipeUpdate");


        }
        public static void Delete(DataTable dtRecipe)
        {
            int id = (int)dtRecipe.Rows[0]["RecipeId"];
            SqlCommand cmd = SQLUtility.GetSqlCommand("RecipeDelete");
            SQLUtility.SetParameterValue(cmd, "@RecipeId", id);
            SQLUtility.ExecuteSQL(cmd);
        }
    }
}
