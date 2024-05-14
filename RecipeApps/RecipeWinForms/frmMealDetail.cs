namespace RecipeWinForms
{
    public partial class frmMealDetail : Form
    {
        
        int mealid = 0;
        public frmMealDetail()
        {
            InitializeComponent();
        }

       
        public void LoadForm(int mealval)
        {
            mealid = mealval;
            this.Tag = mealid;
            gMeal.DataSource = Meals.GetMealDetails(mealid);
        }

        
    }
}
