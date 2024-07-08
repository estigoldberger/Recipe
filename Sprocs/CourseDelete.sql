create or alter proc dbo.CourseDelete(
	@CourseId int,
	@Message varchar(500)= ''
)
as 
begin 
	declare @return int=0
	begin try 
		begin tran
			delete rmc
			from RecipeMealCourse rmc 
			join MealCourse mc 
			on mc.MealCourseID= rmc.MealCourseId
--LB: You are missing the where clause in the delete above.

			delete mc
			from MealCourse mc
--LB: You are missing the where clause in the delete above.

			delete c
			from Course c 
			where c.CourseID= @CourseId
		commit 
	end try
	begin catch
		rollback;
		throw
    end catch
return @return
end
 
go 