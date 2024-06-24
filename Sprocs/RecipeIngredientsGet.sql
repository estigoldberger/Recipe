create or alter procedure dbo.RecipeIngredientsGet(
	@RecipeIngredientId int = 0,
	@IngredientId int=0,
	@MeasurementId int=0,
	@RecipeId int=0,
	@All bit = 0,
	@Message varchar(500) = ''  output
)
as
begin
	declare @return int = 0

	select @All = isnull(@All,0), @RecipeIngredientId = isnull(@RecipeIngredientId,0), @RecipeId=isnull(@RecipeId,0)

	select   ri.RecipeIngredientID,  ri.recipeId, ri.IngredientId, ri.measurementId, ri.Amount, Sequence= ri.RecipeSequence
	from  RecipeIngredient ri 
	where ri.RecipeIngredientID= @RecipeIngredientId
	or ri.RecipeId= @RecipeId
	or @All=1
	order by ri.RecipeSequence, ri.Amount


	return @return
end
go


--exec RecipeIngredientsGet @RecipeId= 10
