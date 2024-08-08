using RecipeSystem;
using System.Data;

namespace RecipeMAUI;

public partial class RecipeList : ContentPage
{
	public RecipeList()
	{
		InitializeComponent();
	}
	private void GetRecipeList()
	{
		DataTable dt = Recipes.GetRecipeList();
		ListView.ItemsSource = dt.Rows;
	}
    private void RecipeListBtn_Clicked(object sender, EventArgs e)
    {
		GetRecipeList();
    }
}