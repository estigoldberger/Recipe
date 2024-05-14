namespace RecipeWinForms
{
    public partial class frmCookbookList : Form
    {
        public frmCookbookList()
        {
            InitializeComponent();
            this.Activated += FrmCookbooks_Activated;
            btnNew.Click += BtnNew_Click;
            gData.CellDoubleClick += GData_CellDoubleClick;
            gData.KeyDown += GData_KeyDown;
        }

       

        private void BindData()
        {
            gData.DataSource = Cookbooks.GetCookbookList();
            WindowsFormsUtility.FormatGridForSearchResults(gData, "Cookbook");


        }
        public void ShowCookbookForm(int rowindex)
        {
            int id = 0;
            if (rowindex > -1)
            {
                id = WindowsFormsUtility.GetIdFromGrid(gData, rowindex, "CookbookId");

            }
            if (this.MdiParent != null && this.MdiParent is frmMain)
            {
                ((frmMain)this.MdiParent).OpenForm(typeof(frmCookbookDetail), id);
            }
        }
        private void BtnNew_Click(object? sender, EventArgs e)
        {
            ShowCookbookForm(-1);
        }
        private void GData_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && gData.SelectedRows.Count > 0)
            {
                ShowCookbookForm(gData.SelectedRows[0].Index);
            }
        }

        private void GData_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
        {
            ShowCookbookForm(e.RowIndex);
        }

        private void FrmCookbooks_Activated(object? sender, EventArgs e)
        {
            BindData();
        }
    }
}
