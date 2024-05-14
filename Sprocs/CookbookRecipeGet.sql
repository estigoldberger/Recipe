create or alter procedure dbo.CookbookRecipeGet(
	@CookbookRecipeId int=0,
	@CookbookId int=0,
	@All bit=0,
	@Message varchar(500)=''
)
as
begin
	declare @return int=0
	select @All = isnull(@All,0), @CookbookRecipeId = isnull(@CookbookRecipeId,0), @CookbookId=isnull(@CookbookId,0)
	select  cr.CookbookRecipeID, Sequence=  cr.RecipeSequence, cr.RecipeId, cr.CookbookId
from CookbookRecipe cr
where cr.CookBookId= @CookbookId 
or cr.CookbookRecipeID= @CookbookRecipeId

order by cr.RecipeSequence

	return @return

end 
go

-- select * from cookbook
--exec CookbookRecipeGet @CookbookId= 8
