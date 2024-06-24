create or alter procedure dbo.MeasurementGet(
	@MeasurementId int =0,  
	@All bit =0)
as
begin
	declare @return int=0

	select m.MeasurementID, m.MeasurementType
	from Measurement m 
	where m.MeasurementID= @MeasurementId
	or @All=1

	return @return
end
go 
--exec MeasurementGet @All=1