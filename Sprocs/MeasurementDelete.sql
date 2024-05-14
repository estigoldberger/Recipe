create or alter proc dbo.MeasurementDelete(
	@MeasurementID int,
	@Message varchar(500)=''
)
as
begin
delete ri
from RecipeIngredient ri 
join Measurement m 
on m.MeasurementID= ri.MeasurementID
where m.MeasurementID=@MeasurementID


delete m
from Measurement m
where m.MeasurementID=@MeasurementID

end 
go 