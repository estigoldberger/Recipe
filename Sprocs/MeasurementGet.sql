create or alter procedure dbo.MeasurementGet(
	@MeasurementId int =0, 
	 
	@All bit =0)
as
begin
	
	select m.MeasurementID, m.MeasurementType
	from Measurement m 
	where m.MeasurementID= @MeasurementId

	or @All=1
end
go 
exec MeasurementGet @All=1