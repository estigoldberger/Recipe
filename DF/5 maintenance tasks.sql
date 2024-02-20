-- SM Excellent! See comments, fix and resubmit.
--1) Sometimes when a staff member is fired. We need to eradicate everything from that user in our system. Write the SQL to delete a specific user and all the user's related records.
delete  cr 
from CookbookRecipe cr 
join CookBook c 
on c.CookBookId = cr.CookbookID 
join staff s 
on s.StaffID = c.StaffId
join Recipe r 
on r.StaffID = s.StaffID
where s.LastName = 'metzger'


delete c
from CookBook c 
join staff s 
on s.StaffID = c.StaffId
where s.lastname = 'metzger'



delete rmc
from RecipeMealCourse rmc 
join MealCourse mc 
on mc.MealCourseID = rmc.MealCourseId
join meal m 
on m.MealID=mc.mealID
join staff s 
on s.staffid = m.staffid 
join Recipe r 
on r.RecipeId = rmc.RecipeID
where s.lastname = 'metzger'

delete mc 
from MealCourse mc 
join meal m 
on m.MealID = mc.mealID 
join staff s 
on s.StaffID = m.StaffID
where s.LastName = 'metzger'

delete m 
from meal m 
join staff s 
on s.StaffID = m.StaffID
where s.LastName = 'metzger'

delete rd
from RecipeDirection rd 
join recipe r 
on r.RecipeId = rd.RecipeID
join Staff s 
on s.StaffID = r.StaffID
where s.LastName = 'metzger'

delete ri
from RecipeIngredient ri 
join recipe r 
on r.RecipeId = ri.RecipeID
join Staff s 
on s.StaffID = r.StaffID
where s.LastName = 'metzger'

delete rmc   
from recipe r
join staff s 
on s.StaffID=r.staffId
join RecipeMealCourse rmc 
on r.RecipeId = rmc.RecipeID
where s.LastName = 'metzger'


delete cr  
from staff s 
join recipe r 
on s.StaffID = r.StaffID
join CookbookRecipe cr 
on r.RecipeId = cr.RecipeID
where s.LastName = 'metzger'

delete r 
from recipe r 
join staff s 
on s.StaffID = r.StaffID
where s.LastName = 'metzger'

delete s 
from staff s 
where s.LastName = 'metzger'





--2) Sometimes we want to clone a recipe as a starting point and then edit it. For example we have a complex recipe (steps and ingredients) and want to make a modified version. Write the SQL that clones a specific recipe, add " - clone" to its name.
-- SM Tip: If you're getting all info from recipe table in CTE you can use them for insert and you don't need to join to any table.
-- EG I tried that originally but this was the message I got:
--The column 'StaffID' was specified multiple times for 'x'.
;with x as 
(
	select *
	from Recipe r 
	where r.RecipeName = 'chocolate chip cookies'
)
insert Recipe(RecipeName, Calorie, staffId, cuisineid, DateDrafted, DatePublished, DateArchived)
select concat(r.RecipeName, '-clone'), r.Calorie,  s.StaffID, c.CuisineID, GETDATE(), null, null
from x
join recipe r 
on x.RecipeName = r.RecipeName 
join staff s 
on s.StaffID = r.StaffID 
join Cuisine c 
on c.CuisineID=r.CuisineID


;with x as 
(
	select r.RecipeId, r.RecipeName
	from recipe r 
	where r.RecipeName = 'chocolate chip cookies'
)
insert RecipeIngredient(RecipeId, IngredientID, MeasurementID, RecipeSequence, Amount)
select r.RecipeId, ri.IngredientID, ri.MeasurementID, ri.RecipeSequence, ri.Amount
from  x
join RecipeIngredient ri  
on x.RecipeId= ri.RecipeID
cross join Recipe r 
where r.RecipeName = concat(x.RecipeName, '-clone')

;with x as 
(
	select r.RecipeId, r.RecipeName
	from recipe r 
	where r.RecipeName = 'chocolate chip cookies'
)
insert RecipeDirection(RecipeId, Direction, DirectionSequence)
select r.RecipeId, rd.Direction, rd.DirectionSequence
from  x
join RecipeDirection rd  
on x.RecipeId= rd.RecipeID
cross join Recipe r 
where r.RecipeName = concat(x.RecipeName, '-clone')


/*
3) We offer users an option to auto-create a recipe book containing all of their recipes. 
Write a SQL script that creates the book for a specific user and fills it with their recipes.
The name of the book should be Recipes by Firstname Lastname. 
The price should be the number of recipes multiplied by $1.33
Sequence the book by recipe name.

Tip: To get a unique sequential number for each row in the result set use the ROW_NUMBER() function. See Microsoft Docs.
	 The following can be a column in your select statement: Sequence = ROW_NUMBER() over (order by colum name) , replace column name with the name of the column that the row number should be sorted
*/


; with   x as 
	(
		
		select  
		bookname= concat('Recipes by ', s.FirstName,  ' ', s.LastName),  Price =count(r.recipeid)* 1.33, s.StaffID
		from staff s 
		join recipe r 
		on s.StaffID = r.StaffID
		where s.username = 'chana l'
		group by s.FirstName, s.LastName, s.StaffID
		

		)

insert CookBook (CookBookName, StaffId, CookBookStatus, Price)
select x.bookname, x.staffid, 1, x.Price
from x 



insert CookbookRecipe (r.recipeid, c.cookbookid, RecipeSequence)
select r.recipeid ,c.CookBookId, ROW_NUMBER() over (order by r.recipename)
from CookBook c 
join staff s 
on s.StaffID = c.StaffId
join recipe r 
on s.StaffID = r.StaffId
where c.CookBookName like 'Recipes by %'





/*
4) Sometimes the calorie count of of an ingredient changes and we need to change the calorie total for all recipes that use that ingredient.
Our staff nutritionist will specify the amount to change per measurement type, and of course multiply the amount by the quantity of the ingredient.
For example, the calorie count for butter went down by 2 per ounce, and 10 per stick of butter. 
Write an update statement that changes the number of calories of a recipe for a specific ingredient. 
The statement should include at least two measurement types, like the example above. 
*/

/*select r.recipename, r.calorie, 
UpdatedCalorie= 
case 
	when m.MeasurementType = 'oz.' then Calorie -(2*ri.Amount) 
	when m.MeasurementType = 'stick' then  r.Calorie -(10*ri.Amount) 
end */
update r
set r.Calorie= case 
	when m.MeasurementType = 'oz.' then Calorie -(2*ri.Amount) 
	when m.MeasurementType = 'stick' then  r.Calorie -(10*ri.Amount) 
end 
from Ingredient i 
join RecipeIngredient ri 
on i.IngredientID = ri.IngredientID 
join recipe r 
on r.RecipeId = ri.RecipeID 
join Measurement m 
on m.MeasurementID = ri.MeasurementID
where i.IngredientName = 'butter'


/*
5) We need to send out alerts to users that have recipes sitting in draft longer the average amount of time that recipes have taken to be published.
Produce a result set that has 4 columns (Data values in brackets should be replaced with actual data)
	User First Name, 
	User Last Name, 
	email address (first initial + lastname@heartyhearth.com),
	Alert: 
		Your recipe [recipe name] is sitting in draft for [X] hours.
		That is [Z] hours more than the average [Y] hours all other recipes took to be published.
*/
-- SM -50% datediff(DAY, r.DateDrafted, GETDATE()) > avg(datediff(DAY, r.DateDrafted, r.DatePublished)) doesn't make sense.
-- The line is executed on each row.
-- You need a CTE to get the avg of all data and use that to make the calculations.
select distinct  s.LastName, s.FirstName, EmailAddress= concat(substring(s.FirstName, 1,1),s.LastName, '@heartyhearth.com'), 
Alert= 
case 
	when  r.RecipeStatus = 'drafted' 
	and datediff(DAY, r.DateDrafted, GETDATE()) > avg(datediff(DAY, r.DateDrafted, r.DatePublished)) 
	then
	concat(  'your recipe, ', r.RecipeName, ', is sitting in draft for ', datediff(hour, r.DateDrafted, GETDATE()), ' hours. That is ' , datediff(hour, r.DateDrafted, GETDATE())- datediff(hour, r.DateDrafted, r.DatePublished), ' more than the average ', avg(datediff(hour, r.DateDrafted, r.DatePublished)), ' hours that other recipes took to be published.')
	else ''
end
from staff s 
join Recipe r 
on s.StaffID= r.StaffID
group by s.LastName, s.FirstName, r.RecipeName, r.DateDrafted, r.DatePublished, r.RecipeStatus


; with x as 
(select r.recipeid,
averagedaysuntilpublished=	AVG(datediff(day, r.datedrafted, r.datepublished))
	from recipe r 
	group by r.RecipeId
)
select distinct  s.LastName, s.FirstName, EmailAddress= concat(substring(s.FirstName, 1,1),s.LastName, '@heartyhearth.com'), 
Alert= 
case 
	when  r.RecipeStatus = 'drafted' 
	and day(r.DateDrafted) >x.averagedaysuntilpublished 
	then
	concat(  'your recipe, ', r.RecipeName, ', is sitting in draft for ', datediff(hour, r.DateDrafted, GETDATE()), ' hours. That is ' , datediff(hour, r.DateDrafted, GETDATE())- datediff(hour, r.DateDrafted, r.DatePublished), ' more than the average ', avg(datediff(hour, r.DateDrafted, r.DatePublished)), ' hours that other recipes took to be published.')
	else ''
end
from x 
join recipe r 
on r.RecipeId = x.RecipeId
join staff s 
on s.StaffID = r.StaffID
group by s.LastName, s.FirstName


/*
6) We want to send out marketing emails for books. Produce a result set with one row and one column "Email Body" as specified below.
The email should have a unique guid link to follow, which should be shown in the format specified. 

Email Body:
Order cookbooks from HeartyHearth.com! We have [X] books for sale, average price is [Y]. You can order them all and recieve a 25% discount, for a total of [Z].
Click <a href = "www.heartyhearth.com/order/[GUID]">here</a> to order.
*/
-- SM Round up the avg to 2 decimal places.
select EmailBody= concat( 'Order cookbooks from HeartyHearth.com! We have ', count(c.cookbookid), ' ', 'books for sale, average price is ', '$', avg(c.price),'. You can order them all and recieve a 25% discount, for a total of ', '$',sum(c.price)-.25*sum(c.price),'.
Click <a href = "www.heartyhearth.com/order/',newid(),'">here</a> to order.')
from cookbook c

