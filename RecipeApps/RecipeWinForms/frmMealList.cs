namespace RecipeWinForms
{
    public partial class frmMealList : Form
    {
        public frmMealList()
        {
            InitializeComponent();
            this.Activated += FrmMealList_Activated;
            gData.CellDoubleClick += GData_CellDoubleClick;
            gData.KeyDown += GData_KeyDown;
        }

      
        private void BindData()
        {
            gData.DataSource = Meals.GetMealList();
            WindowsFormsUtility.FormatGridForSearchResults(gData, "Meal");
        }
        private void ShowMealForm(int rowindex)
        {
            int id = 0;
            if (rowindex > -1)
            {
                id = WindowsFormsUtility.GetIdFromGrid(gData, rowindex, "MealId");

            }
            if (this.MdiParent != null && this.MdiParent is frmMain)
            {
                ((frmMain)this.MdiParent).OpenForm(typeof(frmMealDetail), id);
            }

        }
        private void GData_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
        {
            ShowMealForm(e.RowIndex);
        }

        private void FrmMealList_Activated(object? sender, EventArgs e)
        {
            BindData();
        }
        private void GData_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && gData.SelectedRows.Count > 0)
            {
                ShowMealForm(gData.SelectedRows[0].Index);
            }
        }

    }
}
