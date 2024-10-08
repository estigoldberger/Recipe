﻿namespace RecipeSystem
{
    public class bizRecipe : bizObject<bizRecipe>
    {

        public bizRecipe()
        {

        }

        private int _recipeId;
        private int _staffId;
        private int _cuisineId;
        private string _recipename = "";
        private int _calorie;
        private DateTime _datedrafted;
        private DateTime? _datepublished;
        private DateTime? _datearchived;
        private string _recipestatus = "";
        private List<bizStaff> lstStaff;



        public List<bizRecipe> GetRecipeList()
        {

            SqlCommand cmd = SQLUtility.GetSqlCommand("RecipeGet");
            SQLUtility.SetParameterValue(cmd, "@All", 1);
            DataTable dt = SQLUtility.GetDataTable(cmd);
            return this.GetListFromDataTable(dt);
        }
        public List<bizRecipe> Search(string recipenameval)
        {
            SqlCommand cmd = SQLUtility.GetSqlCommand(this.GetSprocName);
            SQLUtility.SetParameterValue(cmd, "RecipeName", recipenameval);
            DataTable dt = SQLUtility.GetDataTable(cmd);
            return this.GetListFromDataTable(dt);
        }
        public List<bizStaff> StaffList
        {
            get
            {
                if (lstStaff == null)
                {
                    lstStaff = new bizStaff().GetList();
                }
                return lstStaff;

            }
        }

        public int RecipeId
        {
            get { return _recipeId; }
            set
            {
                if (_recipeId != value)
                {
                    _recipeId = value;
                    InvokePropertyChanged();
                }
            }
        }

        public int StaffId
        {
            get { return _staffId; }
            set
            {
                if (_staffId != value)
                {
                    _staffId = value;
                    InvokePropertyChanged();
                }
            }
        }

        public int CuisineId
        {
            get { return _cuisineId; }
            set
            {
                if (_cuisineId != value)
                {
                    _cuisineId = value;
                    InvokePropertyChanged();
                }
            }
        }

        public string RecipeName
        {
            get { return _recipename; }
            set
            {
                if (_recipename != value)
                {
                    _recipename = value;
                    InvokePropertyChanged();
                }
            }
        }

        public int Calorie
        {
            get { return _calorie; }
            set
            {
                if (_calorie != value)
                {
                    _calorie = value;
                    InvokePropertyChanged();
                }
            }
        }

        public DateTime DateDrafted
        {
            get { return _datedrafted; }
            set
            {
                if (_datedrafted != value)
                {
                    _datedrafted = value;
                    InvokePropertyChanged();
                }
            }
        }

        public DateTime? DatePublished
        {
            get { return _datepublished; }
            set
            {
                if (_datepublished != value)
                {
                    _datepublished = value;
                    InvokePropertyChanged();
                }
            }
        }

        public DateTime? DateArchived
        {
            get { return _datearchived; }
            set
            {
                if (_datearchived != value)
                {
                    _datearchived = value;
                    InvokePropertyChanged();
                }
            }
        }

        public string Status
        {
            get { return _recipestatus; }
            set
            {
                if (_recipestatus != value)
                {
                    _recipestatus = value;
                    InvokePropertyChanged();
                }
            }

        }
    }

}

