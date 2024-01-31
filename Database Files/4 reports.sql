-- SM Excellent! See comments, fix and resubmit.

/*
Home Page
    One result set with the number of recipes, meals, and cookbooks. Each row should have a column with the item name (Ex: Recipes) and a column with the count.
*/
use HeartyHearthDB 
go 

select ItemName= 'Recipes', Amount = COUNT(r.recipeId)
from Recipe r 
union select 'Meals', COUNT(m.mealID)
from meal m 
union select 'Cookbooks', count(c.CookBookId)
from CookBook c 
order by Amount desc 


/*
Recipe list page:
    List of all Recipes that are either published or archived, published recipes should appear at the top. 
	Archived recipes should appear gray. Surround the archived recipe with <span style="color:gray">recipe name</span>
    In the resultset show the Recipe with its status, dates it was published and archived in mm/dd/yyyy format (blank if not archived), user, number of calories and number of ingredients.
    Tip: You'll need to use the convert function for the dates
*/
select   RecipeName= (case when r.RecipeStatus = 'archived' then concat('<span style="color:gray">' ,r.RecipeName, '</span>' ) else r.RecipeName end ),
     RecipeStatus, DatePublished= isnull(convert(varchar, r.DatePublished, 101), ''), DateArchived=isnull(convert(varchar,r.DateArchived, 101),''),  s.UserName, r.Calorie,
     NumIngredients = count(distinct ri.RecipeIngredientID)
from staff s  
join recipe r 
on s.StaffID = r.StaffID
join RecipeIngredient ri 
on r.recipeId = ri.RecipeID
where r.RecipeStatus <> 'drafted'
group by r.RecipeName, r.RecipeStatus, s.UserName, r.Calorie, r.DatePublished, r.DateArchived
order by r.RecipeStatus DESC

 


/*Recipe details page:
    Show for a specific recipe (three result sets):
        a) Recipe header: recipe name, number of calories, number of ingredients and number of steps.
        b) List of ingredients: show the measurement quantity, measurement type and ingredient in one column, sorted by sequence. Ex. 1 Teaspoon Salt  
        c) List of prep steps sorted by sequence.
*/

select r.RecipeName, r.Calorie, NumOfIngredients = count(distinct ri.recipesequence), NumOfSteps= count (distinct rd.DirectionSequence), r.pictureCode
from Recipe r 
join RecipeIngredient ri
on r.RecipeId = ri.RecipeID
join RecipeDirection rd 
on r.RecipeId = rd.RecipeID
where r.RecipeName = 'chocolate chip cookies'
group by RecipeName, r.Calorie, r.pictureCode

-- SM join to tables that could use join. Ingredient can be join.
select IngredientList = concat(ri.Amount, ' ', m.MeasurementType, ' ', i.IngredientName) 
from recipe r 
join RecipeIngredient ri 
on r.RecipeId= ri.RecipeID
join Ingredient i 
on i.IngredientID=ri.IngredientID
left join Measurement m 
on m.MeasurementID = ri.MeasurementID
where r.recipeName = 'chocolate chip cookies'
order by ri.RecipeSequence

select rd.Direction
from Recipe r 
join RecipeDirection rd 
on r.RecipeId = rd.RecipeID
where r.recipeName = 'chocolate chip cookies'
order by rd.DirectionSequence


/*
Meal list page:
    For all active meals, show the meal name, user that created the meal, number of calories for the meal, number of courses, and number of recipes per each meal, sorted by name of meal
*/
-- SM This doesn't return anything. Something is wrong with the joins. For count() you need distinct in both.
--eg When I ran it it returned two rows
select distinct m.MealName, s.LastName, s.FirstName,  NumberofCalories=sum(r.calorie), NumberofCourses = count(distinct mc.MealCourseID), NumberofRecipes= count(distinct rm.RecipeID)
from staff s 
join recipe r 
on s.StaffID = r.RecipeId
join meal m 
on m.StaffID = s.StaffID
join MealCourse mc 
on m.MealID = mc.Mealid 
join RecipeMealCourse rm 
on rm.MealCourseId = mc.MealCourseID
where m.IsActive = 1
group by m.MealName, s.LastName, s.FirstName


/*
Meal details page:
    Show for a specific meal:
        a) Meal header: meal name, user, date created.
        b) List of all recipes: Result set should have one column, including the course type, whether the dish is serverd as main/side (if it's the main course), and recipe name. 
			Format for main course: CourseType: Main/Side dish - Recipe Name. 
            Format for non-main course: CourseType: Recipe Name
            Main dishes of the main course should be bold, using the bold tags as shown below
                ex: 
                    Appetizer: Mixed Greens
                    <b>Main: Main dish - Onion Pastrami Chicken</b>
					Main: Side dish - Roasted cucumbers with mustard
*/
select m.MealName, s.UserName, m.DateCreated
from staff s 
join meal m  
on s.StaffID = m.StaffID
where m.MealName = 'supper sensation'

select SupperSensation=( case 
when c.coursename= 'Main course'and  IsMain = 1 then concat('<b>', c.CourseName, ': ', 'Main Dish - ', r.RecipeName, '</b>') when c.CourseName = 'main course' and IsMain =0 then concat(c.CourseName, ': ', 'Side Dish - ', r.RecipeName) 
when IsMain is null then concat(c.CourseName, ': ', r.RecipeName)
else concat(c.coursename, ': ', r.recipename)
end)
from recipe r 
join RecipeMealCourse rm
on r.RecipeId = rm.RecipeID
join MealCourse mc 
on mc.MealCourseID = rm.MealCourseId 
join Course c 
on c.CourseID = mc.courseID
join meal m 
on m.MealID = mc.Mealid 
where m.MealName = 'supper sensation'
order by c.CourseSequence, IsMain desc 



/*
Cookbook list page:
    Show all active cookbooks with author and number of recipes per book. Sorted by book name.
*/
select c.CookBookName, s.LastName, s.FirstName, NumberOfRecipes=count(cr.CookookRecipeID)
from staff s  
join cookbook c 
on s.StaffID = c.StaffId
join CookbookRecipe cr 
on c.CookBookId = cr.CookbookID
where c.cookbookstatus = 1
group by c.CookBookName, s.LastName, s.FirstName
order by c.CookBookName

/*
Cookbook details page:
    Show for specific cookbook:
    a) Cookbook header: cookbook name, user, date created, price, number of recipes.
    b) List of all recipes in the correct order. Include recipe name, cuisine and number of ingredients and steps.  
        Note: User will click on recipe to see all ingredients and steps.
*/
select c.CookBookName, s.LastName, s.FirstName, c.datecreated, c.Price, NumberofRecipes = count (cr.CookookRecipeID)
from staff s 
join cookbook c 
on c.StaffId = s.StaffID
join CookbookRecipe cr
on c.CookBookId = cr.CookbookID
where c.CookBookName = 'gourmet dishes'
group by c.CookBookName, s.LastName, s.FirstName, c.datecreated, c.Price


select r.RecipeName, u.CuisineType, NumberofIngredients=COUNT(distinct(ri.RecipeIngredientID)), NumberofSteps= (count(distinct rd.DirectionSequence))
from recipe r 
join Cuisine u 
on u.CuisineID = r.CuisineID
join RecipeIngredient ri 
on ri.RecipeID = r.RecipeId 
join RecipeDirection rd 
on rd.RecipeID = r.RecipeID
join CookbookRecipe cr 
on cr.RecipeID = r.RecipeId 
join CookBook c 
on c.CookBookId = cr.CookbookID
where c.CookBookName = 'gourmet dishes'
group by r.RecipeName,  cr.RecipeSequence, u.CuisineType
order by cr.RecipeSequence

/*
April Fools Page:
    On April 1st we have a page with a joke cookbook. For that page provide the following.
    a) A list of all the recipes that are in all cookbooks. The recipe name should be the reverse of the real name with the first letter capitalized and all others lower case.
        There are matching pictures for those names, include the reversed picture names so that we can show the joke pictures.
        Note: ".jpg" file extension must be at the end of the reversed picture name EX: Recipe_Seikooc_pihc_etalocohc.jpg
    b) When the user clicks on any recipe they should see a spoof steps lists showing the step instructions for the LAST step of EACH recipe in the system. No sequence required.
        Hint: Use CTE
*/
select c.cookbookname, RecipeName=concat(upper(substring(REVERSE(r.recipename),1,1)), lower(substring(reverse(r.recipename), 2,len(recipename)))), 
    PictureCode = CONCAT('Recipe_', upper(substring(r.recipename, 1, 1)),substring(REPLACE(reverse(r.recipename), ' ', '_' ), 2, len(recipename)), '.jpg' )
from cookbook c 
join cookbookrecipe  cr 
on c.cookbookid = cr.cookbookid 
join recipe r 
on r.recipeid = cr.recipeid


-- SM -50% You get multiple times same recipe. We only need one recipe with all the last directions. Use CTE to get the last direction of all recipes and then join (somehow) to a specific recipe.
      
;with x as (
    select top(1) RecipeName= r.recipename, rd.direction, rd.DirectionSequence
    from recipe r 
    join recipedirection rd 
    on r.recipeid = rd.recipeid
    where r.RecipeName = 'chocolate chip cookies'
    order by rd.DirectionSequence desc
    union select top(1) RecipeName= r.recipename, rd.direction, rd.DirectionSequence
    from recipe r 
    join recipedirection rd 
    on r.recipeid = rd.recipeid
    where r.RecipeName = 'apple yogurt smoothie'
    order by rd.DirectionSequence desc
    union select top(1) RecipeName= r.recipename, rd.direction, rd.DirectionSequence
    from recipe r 
    join recipedirection rd 
    on r.recipeid = rd.recipeid
    where r.RecipeName = 'cheese bread'
    order by rd.DirectionSequence desc
     union select top(1) RecipeName= r.recipename, rd.direction, rd.DirectionSequence
    from recipe r 
    join recipedirection rd 
    on r.recipeid = rd.recipeid
    where r.RecipeName = 'healthy pizza'
    order by rd.DirectionSequence desc
     union select top(1) RecipeName= r.recipename, rd.direction, rd.DirectionSequence
    from recipe r 
    join recipedirection rd 
    on r.recipeid = rd.recipeid
    where r.RecipeName = 'carrot muffins'
    order by rd.DirectionSequence desc
     union select top(1) RecipeName= r.recipename, rd.direction, rd.DirectionSequence
    from recipe r 
    join recipedirection rd 
    on r.recipeid = rd.recipeid
    where r.RecipeName = 'butter muffins'
    order by rd.DirectionSequence desc
     union select top(1) RecipeName= r.recipename, rd.direction, rd.DirectionSequence
    from recipe r 
    join recipedirection rd 
    on r.recipeid = rd.recipeid
    where r.RecipeName = 'rice dish'
    order by rd.DirectionSequence desc
     union select top(1) RecipeName= r.recipename, rd.direction, rd.DirectionSequence
    from recipe r 
    join recipedirection rd 
    on r.recipeid = rd.recipeid
    where r.RecipeName = 'sesame chicken'
    order by rd.DirectionSequence desc
     union select top(1) RecipeName= r.recipename, rd.direction, rd.DirectionSequence
    from recipe r 
    join recipedirection rd 
    on r.recipeid = rd.recipeid
    where r.RecipeName = 'chocolate croissant'
    order by rd.DirectionSequence desc
)
select x.recipename, x.direction
from x 
order by x.recipename, x.directionsequence desc

/*
For site administration page:
5 seperate reports
    a) List of how many recipes each user created per status. Show 0 if user has no recipes at all.
    b) List of how many recipes each user created and average amount of days that it took for the user's recipes to be published.
    c) For each user, show three columns: Total number of meals, Total Active meals, Total Inactive meals. Show 0 if none
        Hint: For active/inactive columns, use SUM function with CASE to only include in sum if active/inactive 
    d) For each user, show three columns: Total number of cookbooks, Total Active cookbooks, Total Inactive cookbooks. Show 0 if none
        Hint: For active/inactive columns, use SUM function with CASE to only include in sum if active/inactive 
    e) List of archived recipes that were never published, and how long it took for them to be archived.
*/
-- SM count() returns 0 if non were found. But you shouldn't return null for RecipeStatus. Think again what value you want to get all and do from join in that way.
select distinct  s.LastName, r.recipestatus, NumberofRecipes = isnull(COUNT(r.RecipeId),0)
from staff s 
left join Recipe r 
on s.StaffID = r.StaffID 
group by r.RecipeStatus, s.lastname, r.recipestatus
order by  s.lastname, r.RecipeStatus

select  s.username, AmountOfRecipes= count(r.Recipeid), AverageDaysPublished=avg(datediff(day,r.datedrafted , r.datepublished)) 
from recipe r 
join staff s 
on s.staffId = r.StaffID 
group by s.username 


select s.LastName, TotalMeals=ISNULL(count(m.MealID), 0), TotalActiveMeals=isnull(sum(case when m.IsActive =1 then 1 end),0), TotalInactiveMeals=isnull(sum(case when m.IsActive =0 then 1 end),0)
from staff s 
join meal m 
on s.StaffID = m.StaffID
group by s.LastName


select s.LastName, TotalCookbooks=ISNULL(count(c.CookBookId), 0), TotalActiveCookbooks=isnull(sum(case when c.CookBookStatus =1 then 1 end),0), TotalInactiveCookbooks=isnull(sum(case when c.CookBookStatus =0 then 1 end),0)
from staff s 
join CookBook c 
on s.StaffID = c.StaffId
group by s.LastName

-- SM Change column name.
select r.RecipeName, DaysUntilArchived=datediff(day,r.DateDrafted, r.DateArchived) 
from recipe r 
where r.RecipeStatus = 'archived' 
and r.DatePublished is null
group by r.RecipeName, r.DateDrafted, r.DateArchived

/*
For user dashboard page:
    a) For a specific user, show one result set with the number of recipes, meals, and cookbooks. Each row should have a column with the item name (Ex: Recipes) and a column with the count.
        Tip: If you would like, you can use a CTE to get the User Id once instead of in each union select


    b) List of the user's recipes, display the status and the number of hours between the status it's in and the one before that. Omit recipes in drafted status.
    */
select ItemName= 'Recipes', Amount = COUNT(r.recipeId)
from staff s 
join recipe r 
on s.StaffID = r.StaffID
where s.LastName = 'lowenthal'
union select 'Meals', COUNT(m.mealID)
from meal m 
join Staff s 
on s.StaffID = m.staffID
where s.LastName = 'lowenthal'
union select 'Cookbooks', count(c.CookBookId)
from CookBook c 
join staff s 
on s.StaffID = c.StaffId
where s.LastName = 'lowenthal'

select s.LastName, r.RecipeName, r.RecipeStatus, NumHours= DATEDIFF(HOUR,  
case 
    when r.DateArchived is not null and r.DatePublished is null then r.DateDrafted
    when r.DateArchived is not null and r.DatePublished is not null then r.DatePublished
    else r.DateDrafted
end,
case 
    when r.recipestatus = 'published' then r.DatePublished 
    when r.recipestatus = 'archived' then r.datearchived 
end)
from Recipe r 
join Staff s 
on s.StaffID = r.StaffID
where r.RecipeStatus <> 'drafted'
and s.LastName = 'lowenthal'
group by s.LastName, r.RecipeName, r.RecipeStatus, r.DateDrafted, r.DateArchived, r.DatePublished
 



    /*
    OPTIONAL CHALLENGE QUESTION
    c) Show a list of cuisines and the count of recipes the user has per cuisine, 0 if none
        Hint: For the number of recipes, use count of records that have a staffid or CTE.
*/
-- SM This should be "ALL" cuisines with number of recipes a specific user has.
select s.UserName, c.CuisineType, NumberofRecipes= isnull(count(r.StaffID),0)
from Cuisine c 
left join Recipe r  
on c.CuisineID = r.CuisineID
left join staff s  
on s.StaffID = r.StaffID
where s.LastName = 'lowenthal'
group by  c.CuisineType, s.UserName




