create or alter proc dbo.CloneRecipe(
	@RecipeId int= null output,

	@BaseRecipeId int=0,
	@Message varchar(500)='' output
)
as 
begin 
declare @return int=0

;with x as 
(
	select *
	from Recipe r 
	where r.RecipeId= @RecipeId
)
insert Recipe(RecipeName, Calorie, staffId, cuisineid, DateDrafted, DatePublished, DateArchived)
select concat(r.RecipeName, '-clone'), r.Calorie,  r.StaffID, r.CuisineID, GETDATE(), null, null
from x
join recipe r 
on x.RecipeName = r.RecipeName 

select @RecipeId= SCOPE_IDENTITY();


;with x as 
(
	select r.RecipeId, r.RecipeName
	from recipe r 
	where r.RecipeId= @BaseRecipeId
)
insert RecipeIngredient(RecipeId, IngredientID, MeasurementID, RecipeSequence, Amount)
select r.RecipeId, ri.IngredientID, ri.MeasurementID, ri.RecipeSequence, ri.Amount
from  x
join RecipeIngredient ri  
on x.RecipeId= ri.RecipeID
cross join Recipe r 
where r.RecipeName= concat(x.recipeName, '-clone')


;with x as 
(
	select r.RecipeId, r.RecipeName
	from recipe r 
	where r.RecipeId= @BaseRecipeId
)
insert RecipeDirection(RecipeId, Direction, DirectionSequence)
select r.RecipeId, rd.Direction, rd.DirectionSequence
from  x
join RecipeDirection rd  
on x.RecipeId= rd.RecipeID
cross join Recipe r 
where r.RecipeName= concat(x.recipeName, '-clone')


return @return 

end 
go



--select * from recipe

--exec CloneRecipe @RecipeId= 28, @BaseRecipeId=28
--select * from recipe 

