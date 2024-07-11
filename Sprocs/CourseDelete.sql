create or alter proc dbo.CourseDelete(
	@CourseId int,
	@Message varchar(500)= ''
)
as 
begin 
	declare @return int=0
--LB: This should be inside a transaction.
	begin try 
		begin tran
			delete rmc
			from RecipeMealCourse rmc 
			join MealCourse mc 
			on mc.MealCourseID= rmc.MealCourseId
			where mc.courseID=@CourseId
--LB: Unnecessary to join to Course table.
			delete mc
			from MealCourse mc
			where mc.courseID=@CourseId
			
--LB: Unnecessary to join to Course table.
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