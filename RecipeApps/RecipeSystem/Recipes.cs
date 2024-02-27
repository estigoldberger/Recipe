using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CPUFramework;

namespace RecipeSystem
{
    public class Recipes
    {
        public static DataTable GetRecipeList(string recipename)
        {
            string sql = "Select r.recipeID, r.RecipeName, r.Calorie from recipe r where r.recipename like '%" + recipename + "%'";
            
            return SQLUtility.GetDataTable(sql);
        }
        public static DataTable RecipeDetails(int recipeid)
        {
            string sql = "select StaffId, CuisineId, RecipeId, recipeName, Calorie, DateDrafted, dateArchived, DatePublished from recipe r  where r.recipeId=" + recipeid.ToString();
           return SQLUtility.GetDataTable(sql);
        }
        public static DataTable UserDetails()
        {
            return SQLUtility.GetDataTable("select StaffId, UserName from Staff");

        }
        public static DataTable CuisineDetails()
        {
            return SQLUtility.GetDataTable("select CuisineID, CuisineType from Cuisine");

        }
        public static DateTime DatePublished(string sql)
        {
            DateTime d = new DateTime();
            DataTable dt = SQLUtility.GetDataTable(sql);
            if (dt.Rows.Count > 0 && dt.Columns.Count > 0)
            {
                if (dt.Rows[0][0] != DBNull.Value)
                {

                    DateTime.TryParse(dt.Rows[0][0].ToString(), out d);
                }
            }
            return d;
        }
       public static int CountofRecipes(string recipename)
        {
            int n = 0;
            DataTable dt = SQLUtility.GetDataTable("select count(*) from recipe where recipename= " + recipename);
            int.TryParse(dt.DisplayExpression, out n);
            return n;
        }
        public static void Save(DataTable dtRecipe)
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
           $" Calorie= '{r["Calorie"]}',",
           $"DateDrafted= '{r["DateDrafted"]}',",
           $"DatePublished= '{r["DatePublished"]}',",
           $"DateArchived= '{r["DateArchived"]}'",
           $"where RecipeId = {r["RecipeId"]}");
            }
            else
            {

                sql = "insert Recipe(RecipeName, Calorie, StaffId, CuisineId, DateDrafted, DatePublished, dateArchived)";
                sql += $"select '{r["RecipeName"]}', {r["Calorie"]}, '{r["StaffId"]}', '{r["CuisineId"]}', '{r["DateDrafted"]}', '{r["DatePublished"]}', '{r["DateArchived"]}' ";
            }
            SQLUtility.ExecuteSQL(sql);
            
        }
        public static void Delete(DataTable dtRecipe)
        {
            int id = (int)dtRecipe.Rows[0]["RecipeId"];
            string sql = "Delete recipe where recipeId =" + id;
            SQLUtility.ExecuteSQL(sql);
        }
    }
}
