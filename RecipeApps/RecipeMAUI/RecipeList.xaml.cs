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
        var lst = recipe.GetRecipeList();
        ListView.ItemsSource = lst;
    }
    private void RecipeListBtn_Clicked(object sender, EventArgs e)
    {
        GetRecipeList();
    }

    private async void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
    {
        bizRecipe recipe = (bizRecipe)e.Item;
        await Navigation.PushAsync(new RecipeDetail(recipe.RecipeId));
    }
}