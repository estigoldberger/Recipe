using System.Windows.Forms;

namespace RecipeWinForms
{
    public partial class frmRecipeDetail : Form
    {
        DataTable dtRecipe = new();
        DataTable dtIngredients = new();
        DataTable dtDirections = new();
        BindingSource bindsource = new BindingSource();
        string deletecol = "deletcol";
        int recipeid = 0;

        public frmRecipeDetail()
        {
            InitializeComponent();
            this.Shown += FrmRecipeDetail_Shown;
            btnSave.Click += BtnSave_Click;
            btnDelete.Click += BtnDelete_Click;
            btnChangeStatus.Click += BtnChangeStatus_Click;
            gIng.CellContentClick += GIng_CellContentClick;
            gSteps.CellContentClick += GSteps_CellContentClick;
            btnSaveIngredients.Click += BtnSaveIngredients_Click;
            btnSaveSteps.Click += BtnSaveSteps_Click;
            this.FormClosing += FrmRecipeDetail_FormClosing;

        }

        private void FrmRecipeDetail_Shown(object? sender, EventArgs e)
        {
            LoadIngredients();
            LoadDirections();
        }



        public void LoadForm(int recipeidval)
        {
            recipeid = recipeidval;
            this.Tag = recipeid;
            dtRecipe = Recipes.GetRecipeDetails(recipeid);

            bindsource.DataSource = dtRecipe;

            if (recipeid == 0)
            {
                dtRecipe.Rows.Add();
            }
            DataTable dtCuisine = Recipes.CuisineDetails();
            DataTable dtUsers = Recipes.UserDetails();
            WindowsFormsUtility.SetControlBindings(txtRecipeName, bindsource);
            WindowsFormsUtility.SetControlBindings(txtCalorie, bindsource);
            WindowsFormsUtility.SetControlBindings(txtDateArchived, bindsource);
            WindowsFormsUtility.SetControlBindings(txtDatePublished, bindsource);
            WindowsFormsUtility.SetControlBindings(txtDateDrafted, bindsource);
            WindowsFormsUtility.SetListBinding(lstCuisineType, dtCuisine, dtRecipe, "Cuisine");
            WindowsFormsUtility.SetListBinding(lstUserName, dtUsers, dtRecipe, "Staff");
            WindowsFormsUtility.SetControlBindings(txtStatus, bindsource);
            this.Text = GetRecipeDesc();
            SetButtonsEnabled();

        }

        private void LoadIngredients()
        {
            gIng.Columns.Clear();
            dtIngredients = RecipeIngredients.LoadByRecipeId(recipeid);
            gIng.DataSource = dtIngredients;
            WindowsFormsUtility.AddDeleteButtonToGrid(gIng, deletecol);
            WindowsFormsUtility.AddComboBoxToGrid(gIng, DataMaintenance.GetDataList("Ingredient"), "Ingredient", "IngredientName");
            WindowsFormsUtility.AddComboBoxToGrid(gIng, DataMaintenance.GetDataList("Measurement"), "Measurement", "MeasurementType");
            WindowsFormsUtility.FormatGridForEdit(gIng, "RecipeIngredient");


        }



        private void LoadDirections()
        {
            gSteps.Columns.Clear();
            dtDirections = RecipeDirections.LoadByRecipeId(recipeid);
            gSteps.DataSource = dtDirections;
            WindowsFormsUtility.AddDeleteButtonToGrid(gSteps, deletecol);
            WindowsFormsUtility.FormatGridForEdit(gSteps, "RecipeDirection");

        }
        private void SetButtonsEnabled()
        {
            bool b = recipeid == 0 ? false : true;
            btnDelete.Enabled = b;
            btnSaveIngredients.Enabled = b;
            btnSaveSteps.Enabled = b;
            btnChangeStatus.Enabled = b;


        }
        private string GetRecipeDesc()
        {
            string value = "New Recipe";
            int pkvalue = SQLUtility.GetValueFromFirstRowAsInt(dtRecipe, "RecipeId");
            if (pkvalue > 0)
            {
                value = "Recipe - " + SQLUtility.GetValueFromFirstRowAsString(dtRecipe, "RecipeName").ToString();
            }
            return value;
        }
        private bool Save()
        {
            bool b = false;
            Application.UseWaitCursor = true;

            try
            {

                Recipes.Save(dtRecipe);

                b = true;
                bindsource.ResetBindings(false);
                recipeid = SQLUtility.GetValueFromFirstRowAsInt(dtRecipe, "RecipeId");
                this.Tag = recipeid;
                this.Text = GetRecipeDesc();
                SetButtonsEnabled();


            }
            catch (Exception ex)
            {


                MessageBox.Show(ex.Message, "Recipe");
            }
            finally
            {
                Application.UseWaitCursor = false;
            }
            return b;
        }
        private void Delete()
        {
            var response = MessageBox.Show("Are you sure you want to delete this recipe?", "Recipe", MessageBoxButtons.YesNo);
            if (response == DialogResult.No)
            {
                return;
            }
            Application.UseWaitCursor = true;
            try
            {
                Recipes.Delete(dtRecipe);
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

        private void SaveRecipeIngredient()
        {
            try
            {

                RecipeIngredients.SaveTable(dtIngredients, recipeid);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName);
            }

        }
        private void SaveRecipeDirection()
        {
            try
            {
                RecipeDirections.SaveTable(dtDirections, recipeid);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName);
            }

        }
        private void DeleteIngredients(int rowindex)
        {
            int id = WindowsFormsUtility.GetIdFromGrid(gIng, rowindex, "RecipeIngredientId");
            if (id > 0 && rowindex > 0)
            {
                try
                {


                    RecipeIngredients.Delete(id);
                    LoadIngredients();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, Application.ProductName);
                }
            }
            else if (id < gIng.Rows.Count)
            {
                gIng.Rows.RemoveAt(rowindex);
            }

        }
        private void DeleteSteps(int rowindex)
        {
            int id = WindowsFormsUtility.GetIdFromGrid(gSteps, rowindex, "RecipeDirectionId");

            if (id > 0)
            {
                try
                {


                    RecipeDirections.Delete(id);
                    LoadDirections();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, Application.ProductName);
                }
            }
            else if (id < gSteps.Rows.Count)
            {
                gSteps.Rows.RemoveAt(rowindex);
            }
        }

        private void BtnSaveIngredients_Click(object? sender, EventArgs e)
        {
            SaveRecipeIngredient();
        }
        private void BtnDelete_Click(object? sender, EventArgs e)
        {
            Delete();
        }

        private void BtnSave_Click(object? sender, EventArgs e)
        {
            if (recipeid == 0)
            {
                txtDateDrafted.Text = DateTime.Now.ToString();
                txtStatus.Text = "Drafted";
            }
            Save();
        }
        private void BtnChangeStatus_Click(object? sender, EventArgs e)
        {
            if (this.MdiParent != null && this.MdiParent is frmMain)
            {
                ((frmMain)this.MdiParent).OpenForm(typeof(frmChangeStatus), recipeid);
                this.Close();
            }

        }

        private void BtnSaveSteps_Click(object? sender, EventArgs e)
        {
            SaveRecipeDirection();
        }
        private void GIng_CellContentClick(object? sender, DataGridViewCellEventArgs e)
        {

            if (gIng.Columns[e.ColumnIndex].Name == deletecol && gIng.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                var response = MessageBox.Show("Are you sure you want to delete this ingredient?", "Recipe", MessageBoxButtons.YesNo);
                if (response == DialogResult.No)
                {
                    return;
                }
                Application.UseWaitCursor = true;
                try
                {
                    DeleteIngredients(e.RowIndex);
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
        }
        private void GSteps_CellContentClick(object? sender, DataGridViewCellEventArgs e)
        {

            if (gSteps.Columns[e.ColumnIndex].Name == deletecol && gSteps.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                var response = MessageBox.Show("Are you sure you want to delete this step?", "Recipe", MessageBoxButtons.YesNo);
                if (response == DialogResult.No)
                {
                    return;
                }
                Application.UseWaitCursor = true;
                try
                {
                    DeleteSteps(e.RowIndex);
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
        }
        private void FrmRecipeDetail_FormClosing(object? sender, FormClosingEventArgs e)
        {
            bindsource.EndEdit();
            if (SQLUtility.TableHasChanges(dtRecipe))
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
