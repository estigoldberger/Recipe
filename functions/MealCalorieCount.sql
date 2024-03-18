create or alter function dbo.MealCalorieCount(@MealId int)
returns int
as 
begin 
	declare @value int=0
	select @value= SUM(r.Calorie)
    from meal m 
    join MealCourse mc
    on m.MealID= mc.mealID
    join RecipeMealCourse rmc 
    on mc.MealCourseID=rmc.MealCourseId
    join recipe r 
    on r.RecipeId=rmc.RecipeID
    where m.MealID= @MealId
    group by m.MealName
    order by m.MealName
    return @value
end
go 
/*select dbo.MealCalorieCount(m.mealid)
from meal m 
where m.mealname= 'breakfast bash'*/