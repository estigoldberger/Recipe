using RecipeSystem;

namespace RecipeMAUI;

public partial class RecipeDetail : ContentPage
{
	bizRecipe recipe = new();
	public RecipeDetail( int recipeidval)
	{
		InitializeComponent();
		recipe.Load(recipeidval);
		this.BindingContext = recipe;
		
		
	}
}