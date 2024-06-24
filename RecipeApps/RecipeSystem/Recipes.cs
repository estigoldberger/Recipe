namespace RecipeSystem
{
    public class Recipes
    {
        public static DataTable GetRecipeList()
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = SQLUtility.GetSqlCommand("RecipeGet");
            SQLUtility.SetParameterValue(cmd, "@All", 1);
            dt = SQLUtility.GetDataTable(cmd);
            return dt;
        }
        public static DataTable GetRecipeDetails(int recipeid)
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = SQLUtility.GetSqlCommand("RecipeDetailsGet");
            SQLUtility.SetParameterValue(cmd, "@RecipeId",recipeid);

            dt = SQLUtility.GetDataTable(cmd);
            return dt;
        }
      
        public static DataTable UserDetails()
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = SQLUtility.GetSqlCommand("StaffGet");
            SQLUtility.SetParameterValue(cmd, "@All",1 );

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
        public static DataTable RecipeStatusGet(int recipeid)
        {
            DataTable dt = new();

            SqlCommand cmd=  SQLUtility.GetSqlCommand("StatusGet");
            SQLUtility.SetParameterValue(cmd, "@RecipeId", recipeid);
            dt=SQLUtility.GetDataTable(cmd);
            return dt;
        }
     

        public static void ChangeRecipeStatus(int recipeid, string changeto)
        {
            SqlCommand cmd = SQLUtility.GetSqlCommand("ChangeStatus");
            SQLUtility.SetParameterValue(cmd, "@RecipeId", recipeid);
            SQLUtility.SetParameterValue(cmd, "@ChangeTo", changeto);
            SQLUtility.ExecuteSQL(cmd);
        }
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
        public static int CloneRecipe(int recipeid,int baserecipeid)
        {
            SqlCommand cmd = SQLUtility.GetSqlCommand("CloneRecipe");
            SQLUtility.SetParameterValue(cmd, "@RecipeId", recipeid);
            SQLUtility.SetParameterValue(cmd, "@BaseRecipeId", baserecipeid);
            SQLUtility.ExecuteSQL(cmd);
            int newrecipeid = (int)cmd.Parameters["@RecipeId"].Value;
            return newrecipeid;
        }
 

    }
}
