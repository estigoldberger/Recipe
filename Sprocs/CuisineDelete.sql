create or alter procedure dbo.CuisineDelete(
	@CuisineId int = 0,
	@CuisineType varchar (500)='',
	@Message varchar(500) = ''  output
)
as
begin
	declare @return int=0
	select @CuisineId = isnull(@CuisineId,0)
--LB: This should be inside a transaction.
	begin try
		begin tran

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
		where r.cuisineId= @CuisineId

		delete r
--LB: Unnecessary to select from Cuisine, you can base the where clause on the cuisineId in the recipe table. Same for the select above.
		from recipe r
	where r.cuisineId= @CuisineId


		delete c
		from Cuisine c 
		where c.cuisineId= @CuisineId

		commit
	end try 
	begin catch
		rollback;
		throw
	end catch
	return @return
end
go