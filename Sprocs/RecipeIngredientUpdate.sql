create or alter procedure dbo.RecipeIngredientUpdate(
	@RecipeIngredientId int  output,
	@RecipeId int ,
	@IngredientId int ,
	@MeasurementId int,
	@Amount int=0,
	@Sequence int=0,
	@Message varchar(500) = ''  output
)
as
begin
	declare @return int = 0

	select @RecipeIngredientId = isnull(@RecipeIngredientId,0)

	if @RecipeIngredientId = 0
	begin
		insert RecipeIngredient(RecipeID, IngredientID, MeasurementID, Amount, RecipeSequence)
		values(@RecipeId, @IngredientId, @MeasurementId, @Amount, @Sequence)

		select @RecipeIngredientId= scope_identity()
	end
	else
	begin
		update RecipeIngredient
		set
			RecipeId= @RecipeId,
			IngredientId= @IngredientId,
			MeasurementID= @MeasurementId,
			Amount= @Amount,
			RecipeSequence= @Sequence
		where RecipeIngredientID = @RecipeIngredientId
	end

	return @return
end
go