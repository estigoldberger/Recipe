create or alter proc dbo.CourseDelete(
	@CourseId int,
	@Message varchar(500)= ''
)
as 
begin 
--LB: This should be inside a transaction.

delete rmc
from RecipeMealCourse rmc 
join MealCourse mc 
on mc.MealCourseID= rmc.MealCourseId
--LB: Unnecessary to join to Course table.
join Course c
on c.CourseID= mc.courseID
where c.CourseID= @CourseId

delete mc
from MealCourse mc
--LB: Unnecessary to join to Course table.
join Course c 
on c.CourseID= mc.courseID
where c.CourseID= @CourseId



delete c
from Course c 
where c.CourseID= @CourseId

end
go 