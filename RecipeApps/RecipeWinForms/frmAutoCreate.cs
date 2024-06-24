using CPUFramework;
using System.Data.SqlClient;

namespace RecipeWinForms
{
    public partial class frmAuto_Create : Form
    {
        public frmAuto_Create()
        {
            InitializeComponent();
            btnCreate.Click += BtnCreate_Click;
            AutoCreateUserName();

        }
        private void CreateCookbook()
        {
            int staffid = WindowsFormsUtility.GetIdFromComboBox(lstUserName);
            try
            {
                int newid = Cookbooks.AutoCreateCookbook(staffid);  
                if (this.MdiParent != null && this.MdiParent is frmMain)
                {
                    ((frmMain)this.MdiParent).OpenForm(typeof(frmCookbookDetail), newid);

                }
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Recipe");
            }

        }
       
        private void AutoCreateUserName()
        {
            DataTable dtusers = Recipes.UserDetails();
            WindowsFormsUtility.SetListBinding(lstUserName, dtusers, null, "Staff");
            
        }
        private void BtnCreate_Click(object? sender, EventArgs e)
        {
            CreateCookbook();
         



        }
    }
}
