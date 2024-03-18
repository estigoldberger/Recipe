create or alter procedure dbo.RecipeGet(
	@Recipeid int =0, 
	@RecipeName varchar(40)= '', 
	@All bit =0
	)
as
begin
	select  @RecipeName = nullif(@recipeName, '')
	select r.RecipeId, r.RecipeName, r.Calorie, r.RecipeStatus, r.CuisineId, r.StaffID, r.DateDrafted, r.DatePublished, r.DateArchived, RecipeInfo= dbo.RecipeInfo(r.RecipeId)
	from recipe r
	where r.RecipeId= @Recipeid
	or r.RecipeName like '%' + @RecipeName + '%'
	or @All=1
	order by r.RecipeName
end
go 
/*
exec RecipeGet

exec RecipeGet @All=1

exec RecipeGet @RecipeName = 'ri'

declare @id int
select top 1 @id= r.RecipeId from Recipe r
exec RecipeGet @Recipeid= @id */


