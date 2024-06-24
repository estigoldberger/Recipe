namespace RecipeSystem
{
    public class Cookbooks
    {
        public static DataTable GetCookbookList()
        {
            SqlCommand cmd = SQLUtility.GetSqlCommand("CookbookGet");
            SQLUtility.SetParameterValue(cmd, "@All", 1);
            return SQLUtility.GetDataTable(cmd);
        }
        public static DataTable GetCookbookDetails(int cookbookid)
        {
            SqlCommand cmd = SQLUtility.GetSqlCommand("CookbookDetailsGet");
            SQLUtility.SetParameterValue(cmd, "@CookbookId", cookbookid);
            return SQLUtility.GetDataTable(cmd);
        }
        public static void Save(DataTable dtCookbook)
        {
            DataRow r = dtCookbook.Rows[0];
            SQLUtility.SaveDataRow(r, "CookbookUpdate");


        }
        public static void Delete(DataTable dtCookbook)
        {
            int id = (int)dtCookbook.Rows[0]["CookbookId"];
            SqlCommand cmd = SQLUtility.GetSqlCommand("CookbookDelete");
            SQLUtility.SetParameterValue(cmd, "@CookbookId", id);
            SQLUtility.ExecuteSQL(cmd);
        }
        public static int AutoCreateCookbook(int staffid)
        {
            SqlCommand cmd = SQLUtility.GetSqlCommand("AutoCreateCookbook");
            SQLUtility.SetParameterValue(cmd, "@StaffId", staffid);
            SQLUtility.SetParameterValue(cmd, "@CookbookId", 0);
            SQLUtility.ExecuteSQL(cmd);
            int newcookbookid = (int)cmd.Parameters["@CookbookId"].Value;
            return newcookbookid;
        }
    }
}
