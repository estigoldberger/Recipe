create or alter proc dbo.MeasurementDelete(
	@MeasurementID int,
	@Message varchar(500)=''
)
as
begin

	declare @return int=0
	delete ri
	from RecipeIngredient ri 
	where ri.MeasurementID=@MeasurementID
--LB: No need to join to Measurement table 
	delete m
	from Measurement m
	where m.MeasurementID=@MeasurementID

	return @return
end 
go 