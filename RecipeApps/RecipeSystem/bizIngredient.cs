using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeSystem
{
    public class bizIngredient :bizObject<bizIngredient>
    {
        private int _ingredientId;
        private string _ingredientName="";

        public List<bizIngredient> Search(string ingredientnameval)
        {
            SqlCommand cmd = SQLUtility.GetSqlCommand(this.GetSprocName);
            SQLUtility.SetParameterValue(cmd, "IngredientName", ingredientnameval);
            DataTable dt = SQLUtility.GetDataTable(cmd);
            return this.GetListFromDataTable(dt);
        }
        public int IngredientId
        {
            get { return _ingredientId; }
            set
            {
                if (_ingredientId != value)
                {
                    _ingredientId = value;
                    InvokePropertyChanged();
                }
            }
        }
        public string IngredientName
        {
            get { return _ingredientName; }
            set
            {
                if (_ingredientName != value)
                {
                    _ingredientName = value;
                    InvokePropertyChanged();
                }
            }
        }
    }
}
