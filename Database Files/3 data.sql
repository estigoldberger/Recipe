-- SM Excellent! 100%
--use  heartyhearthdb 
go 

delete RecipeIngredient
delete CookBookRecipe 
delete RecipeDirection
delete RecipeMealCourse
delete MealCourse
delete course
delete Meal
delete cookbook 
delete recipe 
delete Ingredient
delete Measurement
delete Cuisine  
delete Staff



insert ingredient (IngredientName)
select 'sugar'
union select 'oil'
union select 'egg'
union select 'eggs'
union select 'flour'
union select 'vanilla sugar'
union select 'baking powder'
union select 'baking soda'
union select 'chocolate chips'
union select 'granny smith apples'
union select 'vanilla yogurt'
union select 'orange juice'
union select 'honey'
union select 'ice cubes'
union select 'bread'
union select 'shredded cheese'
union select 'garlic'
union select 'black pepper'
union select 'salt'
union select 'butter'
union select 'vanilla pudding'
union select 'whipped cream cheese'
union select 'sour cream'
union select 'baking powder'
union select 'Cinnamon'
union select 'chicken cutlets'
union select 'ketchup'
union select 'dark brown sugar'
union select 'water'
union select 'potatoes'
union select 'rice'
union select 'shredded carrots'
union select 'squash'
union select 'black pepper'
union select 'salt'
union select 'sweet carrots'
union select 'sesame seeds'
union select 'garlic powder'
union select 'whole wheat flour'
union select 'mozzarella cheese'
union select 'low fat pizza sauce'
union select 'oregano'
union select 'paprika'
union select 'cocoa'
union select 'yeast'
union select 'flaky dough'


insert measurement (MeasurementType)
select 'tsp'
union select 'tbsp'
union select 'oz.'
union select 'lb.'
union select 'cup'
union select 'cups'
union select 'pinch'
union select 'stick'
union select 'club'
union select 'cloves'
union select 'pkg'
union select 'jars'

insert cuisine (CuisineType)
select 'American'
union select 'English'
union select 'French'
union select 'Chinese'
union select 'Italian'

insert staff (FirstName, LastName, UserName)
select 'Chana', 'Lowenthal', 'Chana L'
union select 'Shira', 'Metzger', 'Shiri'
union select 'Toby', 'Rothschild', 'TR'
union select 'Sara Leah', 'Bergman', 'Best Baker'


; 
with x as (
   select RecipeName = 'chocolate chip cookies', Calorie = 270, LastName = 'rothschild', DateDrafted = '2018-01-08', DatePublished = '2018-07-12', DateArchived = null, CuisineType ='american'
   union select 'apple yogurt smoothie', 90, 'lowenthal', '2018-07-12', '2018-07-29', null, 'french'
   union select 'cheese bread', 124, 'rothschild', '2018-12-24', '2019-03-01', null, 'english'
   union select 'healthy pizza', 110, 'metzger', '2023-01-12', null, null, 'italian'
   union select 'butter muffins', 200, 'bergman', '2022-06-17', '2022-09-15', null, 'american'
   union select 'carrot muffins', 180, 'rothschild', '2020-10-11', '2020-10-12', '2020-11-14', 'american'
   union select 'rice dish', 60, 'lowenthal', '2022-06-15', null, '2022-07-12', 'chinese'
   union select 'sesame chicken', 150, 'metzger', '2019-05-24', '2019-08-01', null, 'chinese'
   union select 'chocolate croissant', 280, 'metzger', '2021-09-19', '2022-01-16', null, 'french'
)
insert Recipe(RecipeName, Calorie, StaffID, DateDrafted, DatePublished, DateArchived, CuisineID)
select x.recipeName, x.calorie, s.staffId, x.datedrafted, x.datePublished, x.dateArchived, c.cuisineID
from x 
join staff s 
on s.lastName = x.lastname
join cuisine c 
on c.cuisinetype = x.cuisineType

;with x as (
    select RecipeName = 'chocolate Chip cookies', IngredientName= 'sugar', MeasurementType='cups', RecipeSequence= 1, Amount = 1
    union select 'chocolate chip cookies', 'oil', 'cup', 2, .5
    union select 'chocolate chip cookies', 'eggs', '', 3, 3
    union select 'chocolate chip cookies', 'flour', 'cups', 4, 2
    union select 'chocolate chip cookies', 'vanilla sugar', 'tsp', 5, 1
    union select 'chocolate chip cookies', 'baking powder', 'tsp', 6, 2
    union select 'chocolate chip cookies', 'baking soda', 'tsp', 7, .5
    union select 'chocolate chip cookies', 'chocolate chips', 'cups', 8, 1
    union select 'apple yogurt smoothie', 'granny smith apples', '', 1, 3
    union select 'apple yogurt smoothie', 'vanilla yogurt', 'cups', 2, 2
    union select 'apple yogurt smoothie', 'sugar', 'tsp', 3, .5
    union select 'apple yogurt smoothie', 'orange juice', 'cups', 4, .5
    union select 'apple yogurt smoothie', 'honey', 'tbsp', 5, 2
    union select 'apple yogurt smoothie', 'ice cubes', '', 6, 5
    union select 'cheese bread', 'bread', 'club', 1, 1
    union select 'cheese bread', 'butter', 'oz.', 2, 4
    union select 'cheese bread', 'shredded cheese', 'oz.', 3, 8
    union select 'cheese bread', 'garlic', 'cloves', 4, 2
    union select 'cheese bread', 'black pepper', 'tsp', 5, .25
    union select 'cheese bread', 'salt', 'pinch', 6, 1
    union select 'butter muffins', 'butter', 'stick', 1, 1
    union select 'butter muffins', 'sugar', 'cups', 2, 3
    union select 'butter muffins', 'vanilla pudding', 'tbsp', 3, 2
    union select 'butter muffins', 'eggs', '', 4, 4
    union select 'butter muffins', 'whipped cream cheese', 'oz.', 5, 8
    union select 'butter muffins', 'sour cream', 'oz.', 6, 8
    union select 'butter muffins', 'flour', 'cup', 7, 1
    union select 'butter muffins', 'baking powder', 'tsp', 8, 2
    union select 'carrot muffins', 'flour', 'cups', 1, 3
    union select 'carrot muffins', 'sweet carrots', 'jars', 2, 4
    union select 'carrot muffins', 'sugar', 'cups', 3, 1
    union select 'carrot muffins', 'oil', 'cups', 4, .75
    union select 'carrot muffins', 'cinnamon', 'tsp', 5, 2
    union select 'sesame chicken', 'chicken cutlets', 'lb.', 1, 2
    union select 'sesame chicken', 'flour', 'cups', 2, 1
    union select 'sesame chicken', 'paprika', 'tsp', 3, 2
    union select 'sesame chicken', 'ketchup', 'cups', 4, .75
    union select 'sesame chicken', 'dark brown sugar', 'cups', 5, .75
    union select 'sesame chicken', 'water', 'cups', 6, .75
    union select 'sesame chicken', 'sesame seeds', 'cups', 7, .5
    union select 'rice dish', 'rice', 'cups', 1, 4
    union select 'rice dish', 'shredded carrots', '', 2, 2
    union select 'rice dish', 'squash', '', 3, 1
    union select 'chocolate croissant', 'flaky dough', 'pkg', 1, 2
    union select 'chocolate croissant', 'oil', 'cups', 3, .75
    union select 'chocolate croissant', 'cocoa', 'cups', 4, 3
    union select 'chocolate croissant', 'cinnamon', 'tsp', 5, 2
    union select 'chocolate croissant', 'vanilla sugar', 'tsp', 6, 1
    union select 'healthy pizza', 'whole wheat flour', 'cups', 1, 6
    union select 'healthy pizza', 'water', 'cups', 2, 3
    union select 'healthy pizza', 'yeast', 'tbsp', 3, 1
    union select 'healthy pizza', 'salt', 'tsp', 4, 3
    union select 'healthy pizza', 'low fat pizza sauce', 'jars', 5, 1
    union select 'healthy pizza', 'oregano', 'tsp', 6, 1
    union select 'healthy pizza', 'shredded cheese', 'cups', 7, 3
)
insert RecipeIngredient (RecipeID, IngredientID, MeasurementID, RecipeSequence, Amount)
select r.RecipeId, i.IngredientID, m.MeasurementID, x.RecipeSequence, x.Amount
from x 
join recipe r 
on x.RecipeName=r.RecipeName
join Ingredient i 
on x.IngredientName=i.IngredientName
left join Measurement m 
on m.MeasurementType = x.MeasurementType

; with x as (
    select RecipeName ='chocolate chip cookies' , Direction ='combine sugar, oil, and eggs in a bowl' , DirectionSequence = 1
    union select 'chocolate chip cookies', 'mix well', 2
    union select 'chocolate chip cookies', 'add flour, vanilla sugar, baking powder, and baking soda', 3
    union select 'chocolate chip cookies', 'beat for five minutes', 4
    union select 'chocolate chip cookies', 'add chocolate chips', 5
    union select 'chocolate chip cookies', 'freeze for 1-2 hours', 6
    union select 'chocolate chip cookies', 'roll into balls and place onto cookie sheet', 7
    union select 'chocolate chip cookies', 'bake on 350 for 10 minutes', 8
    union select 'apple yogurt smoothie', 'peel the apples and dice', 1
    union select 'apple yogurt smoothie', 'combine all ingredients in bowl except apples and ice cubes', 2
    union select 'apple yogurt smoothie',  'mix until smooth', 3
    union select 'apple yogurt smoothie',  'add apples and ice cubes', 4
    union select 'apple yogurt smoothie',  'pour into glasses', 5
    union select 'cheese bread', 'slit bread every 3/4 inch', 1
    union select 'cheese bread', 'combine all ingredients in a bowl', 2
    union select 'cheese bread', 'fill slits with cheese mixture', 3
    union select 'cheese bread', 'wrap bread into foil and bake for 30 minutes', 4
    union select 'butter muffins', 'cream butter with sugars', 1
    union select 'butter muffins', 'add eggs and mix well', 2
    union select 'butter muffins', 'slowly add rest of ingredients', 3
    union select 'butter muffins', 'fill muffin pans 3/4 full and bake for 30 minutes', 4
    union select 'carrot muffins', 'preheat oven to 375', 1
    union select 'carrot muffins', 'pour all ingredients into mixing bowl and mix well', 2
    union select 'carrot muffins', 'pour mixture into muffin pans', 3
    union select 'carrot muffins', 'bake for 18 minutes', 4
    union select 'sesame chicken', 'cut cutlets into smaller pieces', 1
    union select 'sesame chicken', 'coat in flour and paprika', 2
    union select 'sesame chicken', 'fry in oil until golden brown', 3
    union select 'sesame chicken', 'mix ketchup, sugar, and water', 4
    union select 'sesame chicken', 'marinate chicken in the sauce and bake for 15 minutes', 5
    union select 'sesame chicken', 'pour sesame seeds on top of chicken', 6
    union select 'rice dish', 'put carrots in food processor and blend until stringy', 1
    union select 'rice dish', 'cube squash', 2
    union select 'rice dish', 'pour the rice, squash, and carrots into pot and cook for 35 minutes', 3
    union select 'chocolate croissant', 'roll out flaky dough until 3/4 thick', 1
    union select 'chocolate croissant', 'mix cocoa, cinnamon, and vanilla sugar', 2
    union select 'chocolate croissant', 'spread oil over the rolled out dough and put chocolate mixture on top', 3
    union select 'chocolate croissant', 'cut each dough into 4 squares', 4
    union select 'chocolate croissant', 'twist each square into croissant shape and place on cookie sheet', 5
    union select 'chocolate croissant', 'bake on 400 until edges are brown', 6
    union select 'healthy pizza', 'add flour, salt, and  1 cup water', 1
    union select 'healthy pizza', 'mix yeast and 1 cup flour', 2
    union select 'healthy pizza', 'add to flour mixture', 3
    union select 'healthy pizza', 'let rise for 20 minutes', 4
    union select 'healthy pizza', 'divide dough into 5 balls', 5
    union select 'healthy pizza', 'roll each ball into pizza shape', 6
    union select 'healthy pizza', 'mix pizza sauce and oregano and pour over each pizza', 7
    union select 'healthy pizza', 'sprinkle cheese on top', 8
    union select 'healthy pizza', 'bake on 350 for 1/2 hour', 9
)
INSERT RecipeDirection (RecipeID, Direction, DirectionSequence)
select r.RecipeId, x.Direction, x.DirectionSequence
from x
join Recipe r
on x.RecipeName = r.RecipeName


insert course (CourseName, CourseSequence)
select 'Appetizer', 1
union select 'Main Course', 2
union select 'Dessert', 3

insert meal (MealName, DateCreated, IsActive, StaffID)
select 'Breakfast Bash', '2022-10-05 11:03', 1, s.staffId from staff s where s.LastName = 'lowenthal'
union select 'Supper Sensation', '2023-07-09 12:16', 0, s.staffId from staff s where s.LastName = 'metzger'
union select 'Delicious Brunch', '2020-11-03 10:08', 0, s.staffId from staff s where s.LastName = 'lowenthal'
union select 'Pastry Party','2023-06-01 05:11', 1, s.staffId from staff s where s.LastName = 'Rothschild'
union select 'Healthier Meal', GETDATE(),  0, s.staffId from staff s where s.LastName = 'bergman'



; with x as (
    select MealName = 'breakfast bash', CourseName = 'appetizer'
    union select 'breakfast bash', 'main course'
    union select 'supper sensation', 'appetizer'
    union select 'supper sensation', 'main course'
    union select 'supper sensation', 'dessert'
    union select 'delicious brunch', 'appetizer'
    union select 'delicious brunch', 'main course'
    union select 'delicious brunch', 'dessert'
    union select 'pastry party', 'appetizer'
    union select 'pastry party', 'main course'
)
insert MealCourse (MealId, courseID)
select m.MealID, c.CourseID
from x 
join meal m 
on m.MealName = x.MealName
join Course c 
on c.CourseName = x.CourseName



; with x as (
    select RecipeName = 'chocolate chip cookies', MealName = 'supper sensation', CourseName = 'dessert', IsMain = 1
    union select 'chocolate chip cookies', 'pastry party', 'appetizer', 0
    union select 'apple yogurt smoothie', 'breakfast bash', 'appetizer',  0
    union select 'apple yogurt smoothie', 'delicious brunch', 'appetizer', 0
    union select 'cheese bread', 'breakfast bash', 'main course', 1
    union select 'cheese bread', 'delicious brunch', 'main course', 1
    union select 'butter muffins', 'breakfast bash', 'main course', 0
    union select 'butter muffins', 'pastry party', 'main course', 0
    union select 'chocolate croissant', 'pastry party', 'main course', 1
    union select 'sesame chicken', 'supper sensation', 'main course', 1
    union select 'rice dish', 'supper sensation', 'main course', 0
    union select 'carrot muffins', 'supper sensation', 'appetizer', 0
    union select 'carrot muffins', 'delicious brunch', 'main course', 0
    union select 'chocolate croissant', 'delicious brunch', 'dessert', 0
    

)
insert RecipeMealCourse (RecipeID, MealCourseId, IsMain)
select r.RecipeId, mc.MealCourseID, x.IsMain
from x 
join Recipe r 
on r.RecipeName = x.RecipeName 
join Meal m  
on m.MealName = x.MealName
join Course c 
on c.CourseName = x.CourseName
join MealCourse mc 
on m.MealID = mc.mealID and c.CourseID = mc.courseID

; with x as (
select  CookBookName = 'Treats for Two', Price = 30.00, DateCreated = '08/16/2021', LastName = 'bergman', CookBookStatus = 1
union select 'Pastry Palate', 38.00, '03/12/2021', 'lowenthal', 0
union select 'Gourmet Dishes', 15.00, '11/21/2022', 'metzger', 0
union select 'Meal Maven', 42.00, '01/07/2023', 'rothschild', 1
)
insert CookBook(CookBookName, staffId, Price, DateCreated, CookBookStatus)
select x.CookBookName, s.StaffID, x.Price, x.DateCreated, x.CookBookStatus
from x 
join staff s 
on s.LastName = x.LastName


; with x as (
    select CookBookName = 'Treats for Two' , RecipeName = 'chocolate chip cookies',  RecipeSequence = 1
    union select 'treats for two', 'apple yogurt smoothie',  2
    union select 'treats for two', 'cheese bread', 3
    union select 'treats for two', 'butter muffins', 4
    union select 'pastry palate', 'chocolate chip cookies', 1
    union select 'pastry palate', 'butter muffins', 2
    union select 'pastry palate', 'carrot muffins', 3
    union select 'pastry palate', 'chocolate croissant', 4
    union select 'gourmet dishes', 'sesame chicken', 1
    union select 'gourmet dishes', 'cheese bread', 2
    union select 'gourmet dishes', 'rice dish', 3
    union select 'meal maven', 'apple yogurt smoothie', 1
    union select 'meal maven', 'butter muffins', 2
    union select 'meal maven', 'sesame chicken', 3
    union select 'meal maven', 'chocolate chip cookies', 4

)
insert CookbookRecipe (RecipeID, CookbookID, RecipeSequence)
select r.RecipeId, c.cookBookID, x.RecipeSequence
from x 
join Recipe r
on x.RecipeName = r.recipeName
join cookBook c 
on x.CookBookName = c.cookbookname