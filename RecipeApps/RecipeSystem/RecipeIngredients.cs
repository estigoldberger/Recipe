namespace RecipeSystem
{
    public class RecipeIngredients
    {
        public static DataTable LoadByRecipeId(int recipeid)
        {            
            SqlCommand cmd = SQLUtility.GetSqlCommand("RecipeIngredientsGet");
            cmd.Parameters["@RecipeId"].Value = recipeid;
            return SQLUtility.GetDataTable(cmd);
        }
       
        public static void SaveTable(DataTable dt, int recipeid)
        {
            foreach(DataRow dr in dt.Select("","", DataViewRowState.Added))
            {
                dr["RecipeId"] = recipeid;
            }
            SQLUtility.SaveDataTable(dt, "RecipeIngredientUpdate");
        }
        public static void Delete(int recipeingredientid)
        {
            SqlCommand cmd = SQLUtility.GetSqlCommand("RecipeIngredientsDelete");
            cmd.Parameters["@RecipeIngredientId"].Value = recipeingredientid;
            SQLUtility.ExecuteSQL(cmd);
        }
    }
}
