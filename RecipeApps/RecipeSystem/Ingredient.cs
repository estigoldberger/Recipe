namespace RecipeSystem
{
    internal class Ingredient
    {
        public static DataTable GetIngredientDetail(int cookbookid)
        {
            SqlCommand cmd = SQLUtility.GetSqlCommand("CookbookDetailsGet");
            SQLUtility.SetParameterValue(cmd, "@CookbookId", cookbookid);
            return SQLUtility.GetDataTable(cmd);
        }
    }
}
