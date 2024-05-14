create or alter procedure dbo.RecipeIngredientsDelete(
	@RecipeIngredientId int = 0,
	@Message varchar(500) = ''  output
)
as
begin
	declare @return int = 0

	select @RecipeIngredientId = isnull(@RecipeIngredientId,0)

	delete RecipeIngredient where RecipeIngredientID= @RecipeIngredientId

	return @return
end
go
