using CPUFramework;

namespace RecipeWinForms
{
    public partial class frmChangeStatus : Form
    {
        private enum StatusEnum { Drafted, Published, Archived }
        BindingSource bindsource = new BindingSource();
        DataTable dtStatus = new();
        int recipeid = 0;

        public frmChangeStatus()
        {
            InitializeComponent();
            btnDraft.Click += BtnDraft_Click;
            btnPublish.Click += BtnPublish_Click;
            btnArchive.Click += BtnArchive_Click;



        }

        public void LoadForm(int recipeidval)
        {
            recipeid = recipeidval;
            this.Tag = recipeid;
            this.Text = "Change Status";
            dtStatus = Recipes.RecipeStatusGet(recipeid);
            bindsource.DataSource = dtStatus;

            WindowsFormsUtility.SetControlBindings(lblRecipeName, bindsource);
            WindowsFormsUtility.SetControlBindings(lblRecipeStatus, bindsource);
            WindowsFormsUtility.SetControlBindings(txtDateDrafted, bindsource);
            WindowsFormsUtility.SetControlBindings(txtDatePublished, bindsource);
            WindowsFormsUtility.SetControlBindings(txtDateArchived, bindsource);
            SetButtonsEnabled();
        }
        private void SetButtonsEnabled()
        {
            string s = SQLUtility.GetValueFromFirstRowAsString(dtStatus, "RecipeStatus");
            foreach (Button btn in tblButtons.Controls)
            {
                btn.Enabled = true;
            }
            if (s == "Drafted")
            {
                btnDraft.Enabled = false;
            }
            else if (s == "Archived")
            {
                btnArchive.Enabled = false;
            }
            else if (s == "Published")
            {
                btnPublish.Enabled = false;
            }
        }
        private void ChangeStatus(string statustype, string changeto)
        {


            var response = MessageBox.Show($"Are you sure you want to change this recipe to {statustype}?", "Recipe", MessageBoxButtons.YesNo);
            if (response == DialogResult.No)
            {
                return;
            }
            Application.UseWaitCursor = true;
            try
            {
                Recipes.ChangeRecipeStatus(recipeid, changeto);

                dtStatus = Recipes.RecipeStatusGet(recipeid);
                bindsource.DataSource = dtStatus;
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
        }

        private void BtnPublish_Click(object? sender, EventArgs e)
        {
            ChangeStatus("Published", "PublishRecipe");
        }

        private void BtnDraft_Click(object? sender, EventArgs e)
        {
            ChangeStatus("Drafted", "DraftRecipe");
        }
        private void BtnArchive_Click(object? sender, EventArgs e)
        {
            ChangeStatus("Archived", "ArchiveRecipe");

        }
       
    }
}
