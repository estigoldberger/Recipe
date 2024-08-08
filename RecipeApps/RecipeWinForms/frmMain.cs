namespace RecipeWinForms
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            mnuRecipeList.Click += MnuRecipeList_Click;
            mnuNewRecipe.Click += MnuNewRecipe_Click;
            mnuMealList.Click += MnuMealList_Click;
            mnuCookbookList.Click += MnuCookbookList_Click;
            mnuNewCookbook.Click += MnuNewCookbook_Click;
            mnuRecipeClone.Click += MnuCloneARecipe_Click;
            mnuAutoCreate.Click += MnuAutoCreate_Click;
            mnuEdit.Click += MnuEdit_Click;
            mnuCascade.Click += MnuWindowCascade_Click;
            mnuTile.Click += MnuWindowTile_Click;
            mnuDashboard.Click += MnuDashboard_Click;

            this.Shown += FrmMain_Shown;
        }
        private void FrmMain_Shown(object? sender, EventArgs e)
        {
            frmLogin f = new() { StartPosition= FormStartPosition.CenterParent};
            bool b = f.ShowLogin();
            OpenForm(typeof(frmDashboard));
        }
        public void OpenForm(Type frmtype, int pkvalue = 0)
        {
            bool b = WindowsFormsUtility.IsFormOpen(frmtype, pkvalue);

            if (b == false)
            {
                Form? newfrm = null;
                if (frmtype == typeof(frmRecipeDetail))
                {
                    frmRecipeDetail f = new();
                    newfrm = f;
                    f.LoadForm(pkvalue);

                }

                else if (frmtype == typeof(frmMealList))
                {
                    frmMealList f = new();
                    newfrm = f;

                }
                else if (frmtype == typeof(frmMealDetail))
                {
                    frmMealDetail f = new();
                    newfrm = f;
                    f.LoadForm(pkvalue);
                }
                else if (frmtype == typeof(frmCookbookList))
                {
                    frmCookbookList f = new();
                    newfrm = f;



                }
                else if (frmtype == typeof(frmCookbookDetail))
                {
                    frmCookbookDetail f = new();
                    newfrm = f;
                    f.LoadForm(pkvalue);

                }
                else if (frmtype == typeof(frmRecipeList))
                {
                    frmRecipeList f = new();
                    newfrm = f;
                }
                else if (frmtype == typeof(frmRecipeClone))
                {
                    frmRecipeClone f = new();
                    newfrm = f;

                }

                else if (frmtype == typeof(frmAuto_Create))
                {
                    frmAuto_Create f = new();
                    newfrm = f;
                }
                else if (frmtype == typeof(frmDashboard))
                {
                    frmDashboard f = new();
                    newfrm = f;
                }
                else if (frmtype == typeof(frmDataMaintenance))
                {
                    frmDataMaintenance f = new();
                    newfrm = f;
                }
                else if (frmtype == typeof(frmChangeStatus))
                {
                    frmChangeStatus f = new();
                    newfrm = f;
                    f.LoadForm(pkvalue);
                }
                if (newfrm != null)
                {
                    newfrm.MdiParent = this;
                    newfrm.WindowState = FormWindowState.Maximized;
                    newfrm.FormClosed += Frm_FormClosed;
                    newfrm.TextChanged += Newfrm_TextChanged;
                    newfrm.Show();
                }
                WindowsFormsUtility.SetupNav(tsMain);
            }
        }

        private void MnuDashboard_Click(object? sender, EventArgs e)
        {
            OpenForm(typeof(frmDashboard));
        }

        private void MnuWindowTile_Click(object? sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void MnuWindowCascade_Click(object? sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }
        private void Newfrm_TextChanged(object? sender, EventArgs e)
        {
            WindowsFormsUtility.SetupNav(tsMain);
        }

        private void Frm_FormClosed(object? sender, FormClosedEventArgs e)
        {
            WindowsFormsUtility.SetupNav(tsMain);
        }


        private void MnuEdit_Click(object? sender, EventArgs e)
        {
            OpenForm(typeof(frmDataMaintenance));
        }

        private void MnuAutoCreate_Click(object? sender, EventArgs e)
        {
            OpenForm(typeof(frmAuto_Create));
        }

        private void MnuCloneARecipe_Click(object? sender, EventArgs e)
        {
            OpenForm(typeof(frmRecipeClone));
        }

        private void MnuNewCookbook_Click(object? sender, EventArgs e)
        {
            OpenForm(typeof(frmCookbookDetail));
        }

        private void MnuCookbookList_Click(object? sender, EventArgs e)
        {
            OpenForm(typeof(frmCookbookList));
        }

        private void MnuMealList_Click(object? sender, EventArgs e)
        {
            OpenForm(typeof(frmMealList));
        }

        private void MnuNewRecipe_Click(object? sender, EventArgs e)
        {
            OpenForm(typeof(frmRecipeDetail));
        }

        private void MnuRecipeList_Click(object? sender, EventArgs e)
        {

            OpenForm(typeof(frmRecipeList));
        }






    }
}
