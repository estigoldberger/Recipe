using CPUFramework;
using System.Data;

namespace RecipeTest
{
    public class RecipeTests
    {
        [SetUp]
        public void Setup()
        {
            DBManager.SetConnectionString("Server=.\\SQLExpress;Database=HeartyHearthDB;Trusted_Connection=true");

        }
        [Test]
        [TestCase("Creamed ", 120, "08-04-2023", "02-26-2024")] 
        [TestCase("Applesauce", 300, "01-12-2024", "02-01-2024")]

        public void InsertNewRecipe(string recipename, int Calorie, DateTime datedrafted, DateTime datepublished
            )
        {
            DataTable dt = SQLUtility.GetDataTable("select * from Recipe r where Recipeid= 0");
            DataRow r = dt.Rows.Add();
            Assume.That(dt.Rows.Count == 1);
            int userid = SQLUtility.GetFirstColumnFirstRowValue("select top 1 staffid from staff s");
            int cuisineid = SQLUtility.GetFirstColumnFirstRowValue("select top 1 cuisineid from cuisine c");
            int recipeid = SQLUtility.GetFirstColumnFirstRowValue("select top 1 recipeid from recipe order by recipeid desc");
            TestContext.WriteLine("userid= " + userid + " cuisineid= " + cuisineid );
            Assume.That(userid > 0, "can't run test, no users or cuisines in db");
            
            TestContext.WriteLine("insert recipe with name= " + recipename);
            r["recipeid"] = recipeid + 1;
            r["staffid"] = userid;
            r["cuisineid"] = cuisineid;
            r["recipename"] = recipename + DateTime.Now.ToString();
            r["Calorie"] = Calorie;
            r["dateDrafted"] = datedrafted;
            r["DatePublished"] = datepublished;
            Recipes.Save(dt);
            int newid = SQLUtility.GetFirstColumnFirstRowValue("select * from recipe where recipeid= " + recipeid);
            Assert.IsTrue(newid > 0, "recipe with recipename= " + recipename + " is not found in db");
            TestContext.WriteLine("recipe with " + recipename + " is found in db with pk value= " + newid);
        }
        [Test]
     
        public void ChangeRecipeDatePublished()
        {
            int recipeid = GetExistingRecipeId();
            Assume.That(recipeid > 0, "No recipes exist in DB, can't run test");
            DateTime DatePublished = Recipes.DatePublished("select datepublished from recipe where recipeid= " + recipeid);
            TestContext.WriteLine("DatePublished for recipeid " + recipeid + " is " + DatePublished);
            DatePublished = DatePublished.AddDays(1);
            TestContext.WriteLine("change DatePublished to " + DatePublished);
            DataTable dt = Recipes.RecipeDetails(recipeid);
            dt.Rows[0]["DatePublished"] = DatePublished;
            Recipes.Save(dt); ;
            DateTime newDatePublished = Recipes.DatePublished("select datepublished from recipe where recipeid= " + recipeid);
            Assert.IsTrue(newDatePublished == DatePublished, "DatePublished for president (" + recipeid + ") = " + newDatePublished);
            TestContext.WriteLine("DatePublished for recipe (" + recipeid + ") = " + newDatePublished);
        }
        [Test]
        public void DeleteRecipe()
        {
            DataTable dt = SQLUtility.GetDataTable("select  top  1 r.RecipeId, r.RecipeName from Recipe r left join RecipeIngredient ri on r.RecipeId= ri.RecipeID where ri.RecipeIngredientID is null");
            int recipeid = 0;
            string recipedesc = "";
            if (dt.Rows.Count > 0)
            {
                recipeid = (int)dt.Rows[0]["recipeid"];
                recipedesc =  dt.Rows[0]["RecipeName"].ToString();
            }
            Assume.That(recipeid > 0, "No recipes without related records in DB, can't run test");
            TestContext.Write("Existing recipe without related records with id= " + recipeid + " " + recipedesc);
            TestContext.WriteLine(" ensure that app can delete this recipe" + recipedesc);
            Recipes.Delete(dt);
            DataTable dtafterdelete = SQLUtility.GetDataTable("select * from recipe where recipeid = " + recipeid);
            Assert.IsTrue(dtafterdelete.Rows.Count == 0, "record with recipeid " + recipeid + "exists in db");
            TestContext.WriteLine("Record with recipeid " +recipeid + " does not exist in DB");
        }

        [Test]

        public void LoadRecipe()
        {
            int recipeid = GetExistingRecipeId();
            Assume.That(recipeid > 0, "No recipes in DB, can't run test");
            TestContext.WriteLine("existing recipe with id= " + recipeid);
            TestContext.WriteLine("Ensure that app loads recipe " + recipeid);
            DataTable dt = Recipes.RecipeDetails(recipeid);
            int loadedid = (int)dt.Rows[0]["recipeid"];
            Assert.IsTrue(loadedid == recipeid, loadedid + "<>" + recipeid);
            TestContext.WriteLine("Loaded recipe(" + recipeid + ")");
        }
        [Test]
        public void GetUserList()
        {
            int usercount = SQLUtility.GetFirstColumnFirstRowValue("select total=count(*) from staff");
            Assume.That(usercount > 0, "No parties in DB, can't test");
            TestContext.WriteLine("Num of users in DB= " + usercount);
            TestContext.WriteLine("Ensure that num of rows return by app matches " + usercount);
            DataTable dt = Recipes.UserDetails();
            Assert.IsTrue(dt.Rows.Count == usercount, dt.Rows.Count + "<>" + usercount);
            TestContext.WriteLine("Number of rows in staff returned by app=" + dt.Rows.Count);
        }
        [Test]
        public void GetCuisineList()
        {
            int cuisinecount = SQLUtility.GetFirstColumnFirstRowValue("select total=count(*) from cuisine");
            Assume.That(cuisinecount > 0, "No cuisines in DB, can't test");
            TestContext.WriteLine("Num of cuisines in DB= " + cuisinecount);
            TestContext.WriteLine("Ensure that num of rows return by app matches " + cuisinecount);
            DataTable dt = Recipes.CuisineDetails();
            Assert.IsTrue(dt.Rows.Count == cuisinecount, dt.Rows.Count + "<>" + cuisinecount);
            TestContext.WriteLine("Number of rows in cuisine returned by app=" + dt.Rows.Count);
        }
        private int GetExistingRecipeId()
        {
            return SQLUtility.GetFirstColumnFirstRowValue("select top 1 recipeid from recipe");

        }
    }
}