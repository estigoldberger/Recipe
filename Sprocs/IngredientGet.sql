create or alter procedure dbo.IngredientGet(
	@IngredientId int =0, 
--LB: Parameter below shuld be removed.
	@IngredientName varchar(40)= '', 
	@All bit =0)
as
begin
	select  @IngredientName= nullif(@IngredientName, '')
	select i.IngredientID, i.IngredientName
	from Ingredient i 
	where i.IngredientID=@IngredientId
	or @All=1
	
end
go 
exec IngredientGet @All=1
exec IngredientGet @IngredientId= 5
