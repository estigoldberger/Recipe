create or alter procedure dbo.RecipeDirectionsDelete(
	@RecipeDirectionId varchar(500) = '',
	@Message varchar(500) = ''  output
)
as
begin
	declare @return int = 0

	

	delete RecipeDirection 
	where RecipeDirectionID= @RecipeDirectionId

	return @return
end
go
