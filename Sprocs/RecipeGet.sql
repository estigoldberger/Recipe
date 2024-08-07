create or alter proc dbo.RecipeGet(
	@RecipeId int=0,
	@RecipeName varchar(200)='',
	@All bit=0,
	@Message varchar(500) = '' output
)
as 
begin
	
	declare @return int=0
	select r.recipeid, RecipeName=concat(upper(substring(r.RecipeName,1,1)),substring(r.recipeName, 2, len(r.recipeName))), Status=r.RecipeStatus, Username= s.UserName,  Calorie= r.Calorie, NumIngredients= count(distinct ri.recipesequence)
--LB: It would make more sense to select from Recipe table and join all necessary tables. Please fix.
	from recipe r
	join staff s
	on s.staffid = r.staffid 
	join cuisine c 
	on c.CuisineID= r.CuisineID
	left join recipeingredient ri 
	on ri.recipeid= r.recipeid
	left join ingredient i 
	on i.ingredientid= ri.ingredientid 
	where @RecipeId= r.RecipeId
	or @All=1
	or r.recipeName like '%' + @RecipeName + '%'
	group by r.RecipeName, r.RecipeStatus, s.UserName, r.Calorie, r.RecipeId
	order by  r.RecipeStatus desc

	return @return 
end 
go
--exec RecipeGet @All=1

