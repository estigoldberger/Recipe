create or alter procedure dbo.CourseGet(
	@CourseId int =0, 
--LB: @CourseType can be removed as it's not being used ion the sproc. 
	@All bit =0)
as
begin
	declare @return int=0
	select c.CourseID, c.CourseName, c.CourseSequence
	from Course c 
	where c.CourseID=@CourseId
	or @All=1
	order by c.CourseSequence 

	return @return
end
go 
--exec CourseGet @All=1