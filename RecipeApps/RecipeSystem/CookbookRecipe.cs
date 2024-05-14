namespace RecipeSystem
{
    public class CookbookRecipe
    {
        public static DataTable LoadByCookbookId(int cookbookid)
        {
            SqlCommand cmd = SQLUtility.GetSqlCommand("CookbookRecipeGet");
            cmd.Parameters["@CookbookId"].Value = cookbookid;
            return SQLUtility.GetDataTable(cmd);
        }
        public static void SaveTable(DataTable dt, int cookbookid)
        {
            foreach (DataRow dr in dt.Select("", "", DataViewRowState.Added))
            {
                dr["CookbookId"] = cookbookid;

               
            }
            SQLUtility.SaveDataTable(dt, "CookbookRecipeUpdate");
        }
        public static void Delete(int cookbookrecipeid)
        {
            SqlCommand cmd = SQLUtility.GetSqlCommand("CookbookRecipeDelete");
            cmd.Parameters["@CookbookRecipeId"].Value = cookbookrecipeid;
            SQLUtility.ExecuteSQL(cmd);
        }
    }
}
