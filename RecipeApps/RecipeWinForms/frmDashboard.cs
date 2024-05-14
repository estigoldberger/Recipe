namespace RecipeWinForms
{
    public partial class frmDashboard : Form
    {
        public frmDashboard()
        {
            InitializeComponent();
            btnRecipeList.Click += BtnRecipeList_Click;
            btnMealList.Click += BtnMealList_Click;
            btnCookbookList.Click += BtnCookbookList_Click;
            this.Activated += FrmDashboard_Activated;

        }

        private void ShowForm(Type frm)
        {

            if (this.MdiParent != null && this.MdiParent is frmMain)
            {
                ((frmMain)this.MdiParent).OpenForm(frm);
            }
        }
        private void BtnRecipeList_Click(object? sender, EventArgs e)
        {
            ShowForm(typeof(frmRecipeList));
        }
        private void BtnMealList_Click(object? sender, EventArgs e)
        {
            ShowForm(typeof(frmMealList));
        }
        private void BtnCookbookList_Click(object? sender, EventArgs e)
        {
            ShowForm(typeof(frmCookbookList));
        }
        private void FrmDashboard_Activated(object? sender, EventArgs e)
        {
            dtDashboard.DataSource = DataMaintenance.GetDashboard();
        }
    }
}
