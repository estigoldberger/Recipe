create or alter proc dbo.MealDetailsGet(
	@MealId int=0,
	@All bit=0,
	@Message varchar(500) = '' output
)
as 
begin
	declare @return int=0
	select m.MealName, s.UserName, m.DateCreated, Recipes=( case 
when c.coursename= 'Main course'and  IsMain = 1 then concat('<b>', c.CourseName, ': ', 'Main Dish - ', r.RecipeName, '</b>') when c.CourseName = 'main course' and IsMain =0 then concat(c.CourseName, ': ', 'Side Dish - ', r.RecipeName) 
when IsMain is null then concat(c.CourseName, ': ', r.RecipeName)
else concat(c.coursename, ': ', r.recipename)
end)
	from staff s 
	join meal m  
	on s.StaffID = m.StaffID
	join MealCourse mc 
	on m.MealID= mc.mealID
	join RecipeMealCourse rmc 
	on mc.MealCourseID= rmc.MealCourseId
	join recipe r 
	on r.RecipeId= rmc.RecipeID
	join course c 
	on c.CourseID= mc.courseID
	where m.MealID = @MealId
	return @return
end 
go


	

-- select * from Meal

--exec MealDetailsGet @MealId= 55