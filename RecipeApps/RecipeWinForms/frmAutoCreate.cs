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
            SqlCommand cmd = SQLUtility.GetSqlCommand("AutoCreate");
            SQLUtility.SetParameterValue(cmd, "@StaffId", staffid);
            SQLUtility.ExecuteSQL(cmd);
        }
       
        private void AutoCreateUserName()
        {
            DataTable dtusers = Recipes.UserDetails();
            WindowsFormsUtility.SetListBinding(lstUserName, dtusers, null, "Staff");
            
        }
        private void BtnCreate_Click(object? sender, EventArgs e)
        {
            CreateCookbook();
            if (this.MdiParent != null && this.MdiParent is frmMain)
            {
                ((frmMain)this.MdiParent).OpenForm(typeof(frmCookbookList));
                this.Close();
            }



        }
    }
}
