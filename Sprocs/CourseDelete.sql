create or alter proc dbo.CourseDelete(
	@CourseId int,
	@Message varchar(500)= ''
)
as 
begin 

delete rmc
from RecipeMealCourse rmc 
join MealCourse mc 
on mc.MealCourseID= rmc.MealCourseId
join Course c
on c.CourseID= mc.courseID
where c.CourseID= @CourseId

delete mc
from MealCourse mc
join Course c 
on c.CourseID= mc.courseID
where c.CourseID= @CourseId



delete c
from Course c 
where c.CourseID= @CourseId

end
go 