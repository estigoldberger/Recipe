create or alter proc dbo.RecipeDetailsGet(
	@RecipeId int=0,
	@All bit=0,
	@Message varchar(500) = '' output
)
as 
begin
--LB: It's unnecessary to join all the related tables. Please remove all unnecessary code. (For the dropdowns, it should be enough to return StaffId and CuisineId from the recipe table in order to load up the details page.)
	select r.recipeid, RecipeName=concat(upper(substring(r.RecipeName,1,1)),substring(r.recipeName, 2, len(r.recipeName))), Status=r.RecipeStatus, Username= s.UserName, s.staffId, Calorie= r.Calorie, NumIngredients= count(distinct ri.recipesequence), c.CuisineID, r.DateDrafted, r.DateArchived, r.DatePublished
	from recipe r 
	join staff s
	on s.staffid = r.staffid 
	left join recipeingredient ri 
	on ri.recipeid= r.recipeid
	left join ingredient i 
	on i.ingredientid= ri.ingredientid 
	left join Cuisine c
	on c.CuisineID= r.CuisineID
	where @RecipeId= r.RecipeId
	
	group by r.RecipeName, r.RecipeStatus, s.UserName, r.Calorie, c.CuisineID, s.StaffID, 
	r.DateDrafted, r.DateArchived, r.DatePublished, r.RecipeId
	order by r.RecipeStatus desc
end 
go
-- exec RecipeDetailsGet @All= 1