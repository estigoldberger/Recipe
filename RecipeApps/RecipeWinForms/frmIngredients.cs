using CPUFramework;
using CPUWindowsFormFramework;
using System.Data;


namespace RecipeWinForms
{
    public partial class frmIngredients : Form
    {
        DataTable dt;
        public frmIngredients()
        {
            InitializeComponent();
            //btnSave.Click += BtnSave_Click;
        }

        

        //public void ShowForm()
        //{

        //    dt = SQLUtility.GetDataTable("select RecipeId, MeasurementId, IngredientId from recipeIngredient");

        //    DataTable dtmeasurements = SQLUtility.GetDataTable("select measurementid, MeasurementType from Measurement");
        //    WindowsFormsUtility.SetListBinding(lstMeasurementType, dtmeasurements, dt, "Measurement");
        //    DataTable dtingredients = SQLUtility.GetDataTable("select Ingredientid, IngredientName from ingredient");
        //    WindowsFormsUtility.SetListBinding(lstIngredientName, dtingredients, dt, "Ingredient");
        //    this.Show();
        //}
        //private void Save()
        //{
        //    DataRow r = dt.Rows[0];
        //    int id = (int)r["RecipeID"];
        //    string sql = "";
        //    if (id > 0)
        //    {
        //        sql = string.Join(Environment.NewLine, $"update RecipeIngredient set",
        //            $"MeasurementId='{r["MeasurementId"]}',",
        //   $"IngredientId= '{r["IngredientId"]}'",
        //   $"where RecipeId = {r["RecipeId"]}");
        //    }
        //    else
        //    {

        //        sql = "insert Recipe(RecipeID, Calorie)";
        //        sql += $"select '{r["RecipeID"]}',{r["Calorie"]}";
        //    }
        //    SQLUtility.ExecuteSQL(sql);
        //    this.Close();
        //}
        //private void BtnSave_Click(object? sender, EventArgs e)
        //{
            
        //}
    }
}
