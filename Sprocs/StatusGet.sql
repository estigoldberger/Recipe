create or alter proc dbo.StatusGet(
	@RecipeId int
	
	
)
as
begin


select r.RecipeId, r.RecipeStatus,RecipeName= concat(upper(substring(r.RecipeName,1,1)),substring(r.recipeName, 2, len(r.recipeName))), r.DateArchived, r.DateDrafted, r.DatePublished
from recipe r 
where r.RecipeId=@RecipeId

end
go 
--exec StatusGet @RecipeId= 10
