namespace RecipeSystem
{
    public class RecipeDirections
    {
        public static DataTable LoadByRecipeId(int recipeid)
        {
            DataTable dt = new();
            SqlCommand cmd = SQLUtility.GetSqlCommand("RecipeDirectionsGet");
            cmd.Parameters["@RecipeId"].Value = recipeid;
            dt= SQLUtility.GetDataTable(cmd);
            return dt;
        }
        public static void SaveTable(DataTable dt, int recipeid)
        {
            foreach (DataRow dr in dt.Select("", "", DataViewRowState.Added))
            {
                dr["RecipeId"] = recipeid;
               
            }
            SQLUtility.SaveDataTable(dt, "RecipeDirectionsUpdate");
        }
        public static void Delete(int directionid)
        {
            SqlCommand cmd = SQLUtility.GetSqlCommand("RecipeDirectionsDelete");
            cmd.Parameters ["@RecipeDirectionID"].Value = directionid;
            
            SQLUtility.ExecuteSQL(cmd);
        }
    }
}
