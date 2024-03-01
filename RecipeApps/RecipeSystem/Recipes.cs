using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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
            DataTable dt = new DataTable();
            SqlCommand cmd = SQLUtility.GetSqlCommand("RecipeGet");
            cmd.Parameters["@RecipeName"].Value = recipename;
            dt = SQLUtility.GetDataTable(cmd);
            return dt;
        }
        
        public static DataTable RecipeDetails(int recipeid)
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = SQLUtility.GetSqlCommand("RecipeGet");
            cmd.Parameters["@Recipeid"].Value = recipeid;
            dt = SQLUtility.GetDataTable(cmd);
            return dt;
        }
        public static DataTable UserDetails()
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = SQLUtility.GetSqlCommand("UserGet");
            cmd.Parameters["@All"].Value = 1;
            dt = SQLUtility.GetDataTable(cmd);
            return dt;

        }
        public static DataTable CuisineDetails()
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = SQLUtility.GetSqlCommand("CuisineGet");
            cmd.Parameters["@All"].Value = 1;
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
