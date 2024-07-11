using RecipeSystem;
using System.Net.NetworkInformation;

namespace RecipeWinForms
{
    public partial class frmCookbookDetail : Form
    {
        DataTable dtCookbook = new();
        BindingSource bindsource = new();
        DataTable dtRecipes = new();
        string delete = "delete";
        int cookbookid = 0;
        public frmCookbookDetail()
        {
            InitializeComponent();
            btnSave.Click += BtnSave_Click;
            btnDelete.Click += BtnDelete_Click;
            this.FormClosing += FrmCookbookDetail_FormClosing;
            btnSaveRecipes.Click += BtnSaveRecipes_Click;
            gCookbook.CellContentClick += GCookbook_CellContentClick;
            this.Shown += FrmCookbookDetail_Shown;
        }

        private void FrmCookbookDetail_Shown(object? sender, EventArgs e)
        {
            LoadRecipes();
        }

        public void LoadForm(int cookbookval)
        {
            cookbookid = cookbookval;
            this.Tag = cookbookid;
            dtCookbook = Cookbooks.GetCookbookDetails(cookbookid);
            bindsource.DataSource = dtCookbook;
            if (cookbookid == 0)
            {
                dtCookbook.Rows.Add();
            }
            DataTable dtUsers = Recipes.UserDetails();
            WindowsFormsUtility.SetControlBindings(txtCookbookName, bindsource);
            WindowsFormsUtility.SetControlBindings(txtPrice, bindsource);
            WindowsFormsUtility.SetControlBindings(txtDateCreated, bindsource);
            WindowsFormsUtility.SetListBinding(lstUserName, dtUsers, dtCookbook, "Staff");

            SetButtonsEnabled();

        }

        private void LoadRecipes()
        {
            gCookbook.Columns.Clear();
            dtRecipes = CookbookRecipe.LoadByCookbookId(cookbookid);
            gCookbook.DataSource = dtRecipes;
            ckActive.DataBindings.Add("Checked", dtCookbook, "CookbookStatus", true, DataSourceUpdateMode.OnPropertyChanged);
            WindowsFormsUtility.AddComboBoxToGrid(gCookbook, DataMaintenance.GetDataList("Recipe"), "Recipe", "RecipeName");
            WindowsFormsUtility.FormatGridForEdit(gCookbook, "CookbookRecipe");
            WindowsFormsUtility.AddDeleteButtonToGrid(gCookbook, delete);
            this.Text = GetCookbookDesc();
        }
        private string GetCookbookDesc()
        {
            string value = "New Cookbook";
            int pkvalue = SQLUtility.GetValueFromFirstRowAsInt(dtCookbook, "CookbookId");
            if (pkvalue > 0)
            {
                value = "Cookbook - " + SQLUtility.GetValueFromFirstRowAsString(dtCookbook, "CookbookName").ToString();
            }
            return value;
        }
        private void SetButtonsEnabled()
        {
            bool b = cookbookid == 0 ? false : true;
            btnDelete.Enabled = b;
            btnSaveRecipes.Enabled = b;

        }
        private bool Save()
        {
            bool b = false;
            Application.UseWaitCursor = true;
            if (cookbookid == 0)
            {
                txtDateCreated.Text = DateTime.Now.ToString();

            }
            try
            {

                Cookbooks.Save(dtCookbook);
                b = true;
                bindsource.ResetBindings(false);
                cookbookid = SQLUtility.GetValueFromFirstRowAsInt(dtCookbook, "CookbookId");
                this.Tag = cookbookid;
                this.Text = GetCookbookDesc();
                SetButtonsEnabled();


            }
            catch (Exception ex)
            {


                MessageBox.Show(ex.Message, "Cookbook");
            }
            finally
            {
                Application.UseWaitCursor = false;
            }
            return b;
        }
        private void Delete()
        {
            var response = MessageBox.Show("Are you sure you want to delete this cookbook?", "Cookbook", MessageBoxButtons.YesNo);
            if (response == DialogResult.No)
            {
                return;
            }
            Application.UseWaitCursor = true;
            try
            {
                Cookbooks.Delete(dtCookbook);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Recipe");
            }
            finally
            {
                Application.UseWaitCursor = false;
            }

        }
        private void SaveRecipes()
        {

            try
            {
                CookbookRecipe.SaveTable(dtRecipes, cookbookid);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName);
            }

        }
        private void DeleteRecipe(int rowindex)
        {

            int id = WindowsFormsUtility.GetIdFromGrid(gCookbook, rowindex, "CookbookRecipeId");

            if (id > 0)
            {
                try
                {
                    CookbookRecipe.Delete(id);
                    dtRecipes = CookbookRecipe.LoadByCookbookId(cookbookid);
                    gCookbook.DataSource = dtRecipes;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, Application.ProductName);
                }
            }
            else if (id < gCookbook.Rows.Count)
            {
                gCookbook.Rows.RemoveAt(rowindex);
            }


        }

        private void BtnSave_Click(object? sender, EventArgs e)
        {
            Save();
        }
        private void BtnDelete_Click(object? sender, EventArgs e)
        {
            Delete();
        }
        private void BtnSaveRecipes_Click(object? sender, EventArgs e)
        {
            SaveRecipes();

        }
        private void GCookbook_CellContentClick(object? sender, DataGridViewCellEventArgs e)
        {

            if (gCookbook.Columns[e.ColumnIndex].Name == delete && gCookbook.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                var response = MessageBox.Show("Are you sure you want to delete this recipe?", "Cookbook", MessageBoxButtons.YesNo);
                if (response == DialogResult.No)
                {
                    return;
                }
                Application.UseWaitCursor = true;
                try
                {
                    DeleteRecipe(e.RowIndex);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Cookbook");
                }
                finally
                {
                    Application.UseWaitCursor = false;
                }

            }
        }

        private void FrmCookbookDetail_FormClosing(object? sender, FormClosingEventArgs e)
        {
            bindsource.EndEdit();
            if (SQLUtility.TableHasChanges(dtCookbook))
            {
                var res = MessageBox.Show($"Do you want to save changes to {this.Text} before closing?", Application.ProductName, MessageBoxButtons.YesNoCancel);
                switch (res)
                {
                    case DialogResult.Yes:
                        bool b = Save();
                        if (b == false)
                        {
                            e.Cancel = true;
                            this.Activate();

                        }
                        break;
                    case DialogResult.No:
                        return;
                    case DialogResult.Cancel:
                        e.Cancel = true;
                        this.Activate();
                        break;

                }
            }
        }
    }
}
