create or alter procedure dbo.IngredientGet(
	@IngredientId int =0, 
	@IngredientName varchar(200)='',
--LB: Parameter below shuld be removed.
	@All bit =0)
as
begin
	declare @return int=0
	select i.IngredientID, i.IngredientName
	from Ingredient i 
	where i.IngredientID=@IngredientId
	or @All=1
	or i.IngredientName like '%' + @IngredientName + '%'
	return @return
end
go 
--exec IngredientGet @All=1
--exec IngredientGet @IngredientId= 5
