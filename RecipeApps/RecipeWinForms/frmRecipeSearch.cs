using CPUFramework;
using System.Data;

namespace RecipeWinForms
{
    public partial class frmRecipeSearch : Form
    {
        public frmRecipeSearch()
        {
            InitializeComponent();
            btnSearch.Click += BtnSearch_Click;
            gRecipe.CellDoubleClick += GRecipe_CellDoubleClick;
            FormatGrid();
        }
        private void BtnSearch_Click(object? sender, EventArgs e)
        {
            RecipeSearch(txtRecipe.Text);
        }
        private void FormatGrid()
        {
            gRecipe.AllowUserToAddRows = false;
            gRecipe.ReadOnly = true;
            gRecipe.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            gRecipe.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void GRecipe_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
        {
            ShowRecipeDetailForm(e.RowIndex);
        }

        private void RecipeSearch(string recipename)
        {

            string sql = "Select r.recipeID, r.RecipeName, r.Calorie from recipe r where r.recipename like '%" + recipename + "%'";

            DataTable dt = SQLUtility.GetDataTable(sql);
            gRecipe.DataSource = dt;
            gRecipe.Columns["RecipeId"].Visible = false;

        }
        private void ShowRecipeDetailForm(int rowindex)
        {
            int id = (int)gRecipe.Rows[rowindex].Cells["RecipeId"].Value;
            frmRecipeDetail frm = new frmRecipeDetail();
            frm.ShowIngredients(id);
            
            
        }
        
       
        
    }
}
