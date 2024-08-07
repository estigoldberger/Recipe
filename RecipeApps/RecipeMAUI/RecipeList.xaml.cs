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
		bizRecipe recipe = new();
		var lstrecipe = recipe.GetRecipeList();
		ListView.ItemsSource = lstrecipe;
	}
    private void RecipeListBtn_Clicked(object sender, EventArgs e)
    {
		GetRecipeList();
    }
}