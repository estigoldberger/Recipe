create or alter proc dbo.PublishRecipe(
	@RecipeId int
)
as
begin 

update Recipe 
set DatePublished= GETDATE()
where RecipeId= @RecipeId
end 
go 
