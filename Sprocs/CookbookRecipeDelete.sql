create or alter procedure dbo.CookbookRecipeDelete(
	@CookbookRecipeId int = 0,
	@Message varchar(500) = ''  output
)
as
begin
	declare @return int = 0

	select @CookbookRecipeId = isnull(@CookbookRecipeId,0)
--LB: Please fix column typo. 
	delete CookbookRecipe where CookookRecipeId= @CookbookRecipeId

	return @return
end
go
