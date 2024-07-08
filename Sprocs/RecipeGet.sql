create or alter proc dbo.RecipeGet(
	@RecipeId int=0,
	@All bit=0,
	@Message varchar(500) = '' output
)
as 
begin
	
	declare @return int=0
	select r.recipeid, RecipeName=concat(upper(substring(r.RecipeName,1,1)),substring(r.recipeName, 2, len(r.recipeName))), Status=r.RecipeStatus, Username= s.UserName,  Calorie= r.Calorie, NumIngredients= count(distinct ri.recipesequence)
	from recipe r
--LB: No need to left join to staff/cuisine since they cannot contain null values.
	left join staff s
	on s.staffid = r.staffid 
	left join cuisine c 
	on c.CuisineID= r.CuisineID
	left join recipeingredient ri 
	on ri.recipeid= r.recipeid
	left join ingredient i 
	on i.ingredientid= ri.ingredientid 
	where @RecipeId= r.RecipeId
	or @All=1
	group by r.RecipeName, r.RecipeStatus, s.UserName, r.Calorie, r.RecipeId
	order by  r.RecipeStatus desc

	return @return 
end 
go
--exec RecipeGet @All=1

