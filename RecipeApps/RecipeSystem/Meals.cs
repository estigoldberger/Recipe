namespace RecipeSystem
{
    public class Meals
    {
        public static DataTable GetMealList()
        {
            SqlCommand cmd = SQLUtility.GetSqlCommand("MealGet");
            
            return SQLUtility.GetDataTable(cmd);
        }
        public static DataTable GetMealDetails(int mealid)
        {
            SqlCommand cmd = SQLUtility.GetSqlCommand("MealDetailsGet");
            SQLUtility.SetParameterValue(cmd, "@MealId", mealid);
            return SQLUtility.GetDataTable(cmd);
        }
    }
}
