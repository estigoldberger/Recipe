create or alter proc dbo.DashboardGet(
	@Message varchar(500) = '' output
)
as 
begin
	declare @return int=0

	select Type= 'Recipes', Number=   COUNT(r.recipeId) from Recipe r 
	union select 'Meals', COUNT(m.mealID) from meal m 
	union select 'Cookbooks', count(c.CookBookId) from CookBook c 
	order by Number desc 

	return @return 
end
go 
