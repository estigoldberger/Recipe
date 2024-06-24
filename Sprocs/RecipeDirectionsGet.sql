create or alter procedure dbo.RecipeDirectionsGet(
	@RecipeDirectionId int = 0,
	@RecipeId int=0,
	@All bit = 0,
	@Message varchar(500) = ''  output
)
as
begin
	declare @return int = 0

	select @All = isnull(@All,0), @RecipeDirectionId = isnull(@RecipeDirectionId,0), @RecipeId=isnull(@RecipeId,0)

	select rd.RecipeDirectionID, rd.Direction, Sequence= rd.DirectionSequence, rd.RecipeID
	from RecipeDirection rd 

	where rd.RecipeId= @RecipeId

	order by rd.DirectionSequence 
 

	return @return
end
go