create or alter function dbo.MealCalorieCount(@MealId int)
returns int
as 
begin 
	declare @value int=0
	select @value= SUM(r.Calorie)
    from  MealCourse mc
    join RecipeMealCourse rmc 
    on mc.MealCourseID=rmc.MealCourseId
    join recipe r 
    on r.RecipeId=rmc.RecipeID
    where mc.MealID= @MealId

    return @value
end
go 
/*select dbo.MealCalorieCount(m.mealid)
from meal m 
where m.mealname= 'supper sensation'
*/