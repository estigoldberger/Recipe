create or alter proc dbo.IngredientDelete(
	@IngredientId int,
	@Message varchar(500)=''
)
as
begin
delete ri
from RecipeIngredient ri 
join ingredient i 
on i.ingredientid= ri.ingredientid
where i.IngredientID= @IngredientId

delete i 
from Ingredient i 
where i.IngredientID= @IngredientId

end 
go 