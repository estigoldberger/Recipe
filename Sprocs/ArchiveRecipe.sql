create or alter proc dbo.ArchiveRecipe(
	@RecipeId int
)
as
begin 

update Recipe 
set DateArchived=GETDATE()
where RecipeId= @RecipeId
end 
go 