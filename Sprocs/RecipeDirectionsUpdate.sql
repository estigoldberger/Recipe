create or alter procedure dbo.RecipeDirectionsUpdate(
	@RecipeDirectionId int  output,
	@RecipeId int ,
	@Direction varchar(500)=' ',
	@Sequence int=0,
	@Message varchar(500) = ''  output
)
as
begin
	declare @return int = 0

	select @RecipeDirectionId = isnull(@RecipeDirectionId,0)

	if @RecipeDirectionId = 0
	begin
--LB: This logic is not being used. The sequence comes in as blank if it's not specified. Also, try being consistent with the sequence logic for directions and steps.
	if @Sequence=0
	begin
		
		select @Sequence= max(rd.DirectionSequence) +1 from RecipeDirection rd
	end
		insert RecipeDirection(RecipeID, Direction,  DirectionSequence)
		values(@RecipeId, @Direction, @Sequence)

		select @RecipeDirectionId= scope_identity()
	end
	else
	begin
		update RecipeDirection
		set
			RecipeID= @RecipeId, 
			Direction= @Direction,
			DirectionSequence= @Sequence
		where RecipeDirectionID = @RecipeDirectionId
	end

	return @return
end
go