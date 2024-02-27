
namespace RecipeWinForms
{
    public partial class frmRecipeSearch : Form
    {
        public frmRecipeSearch()
        {
            InitializeComponent();
            btnSearch.Click += BtnSearch_Click;
            gRecipe.CellDoubleClick += GRecipe_CellDoubleClick;
            btnNew.Click += BtnNew_Click;
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

            DataTable dt = Recipes.GetRecipeList(recipename);
            gRecipe.DataSource = dt;
            gRecipe.Columns["RecipeId"].Visible = false;

        }
        private void ShowRecipeDetailForm(int rowindex)
        {
            int id = 0;
            if (rowindex > -1)
            {
                id = (int)gRecipe.Rows[rowindex].Cells["RecipeId"].Value;
            }
            frmRecipeDetail frm = new frmRecipeDetail();
            frm.ShowRecipeDetails(id);
        }
        private void BtnNew_Click(object? sender, EventArgs e)
        {
            ShowRecipeDetailForm(-1);
        }



    }
}
