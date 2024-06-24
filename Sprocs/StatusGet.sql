create or alter proc dbo.StatusGet(
	@RecipeId int
)
as
begin

	declare @return int=0
	select r.RecipeId, r.RecipeStatus,RecipeName= concat(upper(substring(r.RecipeName,1,1)),substring(r.recipeName, 2, len(r.recipeName))), r.DateArchived, r.DateDrafted, r.DatePublished
	from recipe r 
	where r.RecipeId=@RecipeId

	return @return 
end
go 
--exec StatusGet @RecipeId= 85
