create or alter procedure dbo.CookbookRecipeUpdate(
	@CookbookRecipeId int  output,
	@RecipeId int ,
	@CookbookId int =0,
	@Sequence int=0,
	@Message varchar(500) = ''  output
)
as
begin
	declare @return int = 0

	select @CookbookRecipeId = isnull(@CookbookRecipeId,0), @RecipeId= isnull(@RecipeId, 0), @CookbookId= isnull(@CookbookId, 0)

	if @CookbookRecipeId = 0
	begin
		insert CookbookRecipe(RecipeID, CookbookID, RecipeSequence)
		values(@RecipeId, @CookbookId, @Sequence)

		select @CookbookRecipeId= scope_identity()
	end
	else
	begin
		update CookbookRecipe
		set
			RecipeID= @RecipeId, 
			CookbookID= @CookbookId,	
			RecipeSequence= @Sequence
		where CookbookRecipeID= @CookbookRecipeId
	end

	return @return
end
go

