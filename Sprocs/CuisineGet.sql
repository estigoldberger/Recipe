create or alter procedure dbo.CuisineGet(
	@Cuisineid int =0, 
	@CuisineType varchar(40)= '', 
	@All bit =0)
as
begin
	select  @CuisineType = nullif(@CuisineType, '')
	select c.CuisineID, c.CuisineType
	from cuisine c
	where c.CuisineID= @Cuisineid
	or c.CuisineType like '%' + @CuisineType + '%'
	or @All=1
end
go 
/*
exec CuisineGet

exec CuisineGet @All=1

exec CuisineGet @CuisineType = 'c'

declare @Cuisineid int
select top 1 @Cuisineid = Cuisineid from Cuisine
exec CuisineGet @Cuisineid= @Cuisineid
*/