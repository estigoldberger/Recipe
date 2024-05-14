create or alter procedure dbo.RecipeGet(
	@Recipeid int =0, 
	@RecipeName varchar(40)= '', 
	@All bit =0
	)
as
begin
	select   @Recipeid= isnull(@RecipeId, 0)
	select r.RecipeId, r.RecipeName, r.Calorie, r.RecipeStatus, r.CuisineId, r.StaffID, r.DateDrafted, r.DatePublished, r.DateArchived, RecipeInfo= dbo.RecipeInfo(r.RecipeId), Sequence=1
	from recipe r
	where r.RecipeId= @Recipeid
	or @All=1
	union select ' ', 'Add Recipe Here',  ' ', ' ', ' ', ' ', ' ', ' ', ' ',' ', 2
	order by r.RecipeName, Sequence

	
end
go 
/*
exec RecipeGet

exec RecipeGet @All=1

exec RecipeGet @RecipeName = 'ri'

declare @id int
select top 1 @id= r.RecipeId from Recipe r
exec RecipeGet @Recipeid= @id */


