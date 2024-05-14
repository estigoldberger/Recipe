create or alter proc dbo.DraftRecipe(
	@RecipeId int
)
as
begin 

update Recipe 
set DatePublished= null  ,
DateDrafted= GETDATE()
 
 
where RecipeId= @RecipeId
end 
go 