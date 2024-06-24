create or alter procedure dbo.MealGet(
	@MealId int=0,
	@All bit=0,
	@Message varchar(500) ='' output
)
as 
begin
	declare @return int=0

	select @All = isnull(@All, 0), @MealId= isnull(@MealId, 0)
--LB: Instructions is to sort the meal list by meal name.
	select distinct m.MealID,m.MealName,MealUser= s.username, NumberOfCalories=dbo.MealCalorieCount(m.MealID), NumberofCourses = count(distinct mc.MealCourseID), NumberofRecipes= count(distinct rm.RecipeID)
--LB: Improvement would be to select from meal, and then join to staff. Joining the recipe table shouldn't be needed.
	from meal m 
	left join staff s
	on s.StaffID = m.StaffID
	join MealCourse mc 
	on m.MealID = mc.Mealid 
	join RecipeMealCourse rm 
	on rm.MealCourseId = mc.MealCourseID
	group by m.MealName, s.UserName, m.MealID
	order by m.mealName
	

	return @return
end 
go 

--exec MealGet @All=1
