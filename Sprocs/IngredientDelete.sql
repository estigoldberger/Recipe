create or alter proc dbo.IngredientDelete(
	@IngredientId int,
	@Message varchar(500)=''
)
as
begin
	declare @return int=0
	begin tran 
		begin try
			delete ri
			from RecipeIngredient ri 
--LB: Unnecessary to join to ingredient table.

			delete i 
			from Ingredient i 
			where i.IngredientID= @IngredientId
		commit 
		end try 
		begin catch
			rollback;
			throw
		end catch
	return @return
end 
go 