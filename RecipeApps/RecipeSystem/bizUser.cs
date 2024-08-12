namespace RecipeSystem
{
    public class bizStaff : bizObject<bizStaff>
    {
        private int _userid;
        private string _userlastname="";
        private string _userfirstname = "";
        private string _username = "";
        private List<bizStaff>? _lststaff;
        public List<bizStaff> Search(string usernameval)
        {
            SqlCommand cmd = SQLUtility.GetSqlCommand(this.GetSprocName);
            SQLUtility.SetParameterValue(cmd, "UserName", usernameval);
            DataTable dt = SQLUtility.GetDataTable(cmd);
            return this.GetListFromDataTable(dt);
        }
        public List<bizStaff>? Staff
        {
            get
            { if(_lststaff == null)
                {
                   _lststaff= new bizStaff().GetList();
                }
                return _lststaff;
                
            }
        }
        public int StaffId
        {
            get { return _userid; }
            set
            {
                if (_userid != value)
                {
                    _userid = value;
                    InvokePropertyChanged();
                }
            }
        }
        public string LastName
        {
            get { return _userlastname; }
            set
            {
                if (_userlastname != value)
                {
                    _userlastname = value;
                    InvokePropertyChanged();
                }
            }
        }
        public string FirstName
        {
            get { return _userfirstname; }
            set
            {
                if (_userfirstname != value)
                {
                    _userfirstname = value;
                    InvokePropertyChanged();
                }
            }
        }
        public string UserName
        {
            get { return _username; }
            set
            {
                if (_username != value)
                {
                    _username = value;
                    InvokePropertyChanged();
                }
            }
        }
    }
}
