create or alter procedure dbo.CourseGet(
	@CourseId int =0, 
	@CourseType varchar(40)= '', 
	@All bit =0)
as
begin
	select  @CourseType= nullif(@CourseType, '')
	select c.CourseID, c.CourseName, c.CourseSequence
	from Course c 
	where c.CourseID=@CourseId
	or @All=1
	order by c.CourseSequence 

	
end
go 
exec CourseGet @All=1