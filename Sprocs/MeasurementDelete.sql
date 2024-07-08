create or alter proc dbo.MeasurementDelete(
	@MeasurementID int,
	@Message varchar(500)=''
)
as
begin

	declare @return int=0
	delete ri
	from RecipeIngredient ri 
--LB: It seems like you are missing the where clause for the delete above.

	delete m
	from Measurement m
	where m.MeasurementID=@MeasurementID

	return @return
end 
go 