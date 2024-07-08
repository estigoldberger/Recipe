create or alter proc dbo.RecipeDetailsGet(
	@RecipeId int=0,
	@All bit=0,
	@Message varchar(500) = '' output
)
as 
begin
	declare @return int=0
	
	select r.recipeid, RecipeName=concat(upper(substring(r.RecipeName,1,1)),substring(r.recipeName, 2, len(r.recipeName))), Status=r.RecipeStatus,  r.staffId, Calorie= r.Calorie, NumIngredients= count(distinct ri.recipesequence), r.CuisineID, r.DateDrafted, r.DateArchived, r.DatePublished
	from recipe r 
	left join recipeingredient ri 
	on ri.recipeid= r.recipeid
	left join ingredient i 
	on i.ingredientid= ri.ingredientid 
	where @RecipeId= r.RecipeId
	group by r.RecipeName, r.RecipeStatus,  r.Calorie, r.StaffID, r.CuisineID,
	r.DateDrafted, r.DateArchived, r.DatePublished, r.RecipeId
	order by r.RecipeStatus desc

	return @return
end 
go

--select * from recipe
-- exec RecipeDetailsGet @RecipeId= 1