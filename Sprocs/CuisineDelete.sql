create or alter procedure dbo.CuisineDelete(
	@CuisineId int = 0,
	@CuisineType varchar (500)='',
	@Message varchar(500) = ''  output
)
as
begin

	select @CuisineId = isnull(@CuisineId,0)

delete ri 
from RecipeIngredient ri 
join recipe r 
on r.RecipeId= ri.RecipeID
join Cuisine c 
on c.CuisineID = r.CuisineID
where c.cuisineId= @CuisineId

delete rmc
from RecipeMealCourse rmc 
join recipe r 
on r.RecipeId= rmc.RecipeID
join Cuisine c 
on c.CuisineID = r.CuisineID
where c.cuisineId= @CuisineId

delete cr
from CookbookRecipe cr
join recipe r 
on r.RecipeId= cr.RecipeID
join Cuisine c 
on c.CuisineID = r.CuisineID
where c.cuisineId= @CuisineId

delete rd 
from RecipeDirection rd 
join recipe r 
on r.RecipeId= rd.RecipeID
join Cuisine c 
on c.CuisineID = r.CuisineID
where c.cuisineId= @CuisineId



delete r
from Cuisine c 
join recipe r 
on c.CuisineID= r.CuisineID
where c.cuisineId= @CuisineId


delete c
from Cuisine c 
where c.cuisineId= @CuisineId


	
end
go