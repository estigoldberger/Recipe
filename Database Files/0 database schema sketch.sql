-- SM Excellent sketch! See comments. I think it's ok to start creating DB. Good luck!!! If you need clarification on comments, please ask me on slack.
/*
Hearty Hearth Recipe Database


Ingredient
IngredientID pk
IngredientName varchar(20) unique check (IngredientName <> '')
pictureCode as ('Ingredient-Ingredientname.jpg') persisted
 

Measurement 
MeasurementID pk
MeasurementType varchar(15), not blank, unique

Cuisine
CuisineID pk
CuisineType varchar(20) unique, not blank

User
UserID
LastName varchar(30) constraint check (LastName <> '')
FirstName varchar(30) constraint check (FirstName <> '')
-- SM Remove this unique constraint
unique (firstname, lastname)
UserName varchar(20) constraint check (UserName <> '') unique 

Recipe
RecipeId pk
RecipeName varchar(20) constraint check (RecipeName <> '') unique
UserID fk
Calories int not null
-- SM All date columns should be datetime.
DateDrafted date not null 
DatePublished date null
DateArchived date null
DatePublished must be after DateDrafted
-- SM Why do you need this constraint?
constraint check ( DatePublished is null and DateArchived is null )
-- SM Not always when published is null it will be drafted. It can also be archived.
Status  as case when DatePublished is null and then 'Draft'
    when DateArchived is null then 'Published'
    else 'Archived'
     persisted 
CuisineID fk 
pictureCode as ('Recipe-RecipeName.jpg') persisted

RecipeIngredient
RecipeIngredientID pk
RecipeID fk
IngredientID fk 
MeasurementID fk 
Sequence int not null constraint unique (recipeid, sequence)
Amount int not null 
-- SM No need for this column. We have the calories on full recipe.
Calories int not null


RecipeDirection
RDid pk
-- SM You need the recipe table not the recipeingredient.
RecipeID fk
Direction varchar (50) constraint check (Direction <> '')
Sequence constraint unique (recipeingredientid, sequence)

Course
CourseID pk 
CourseName varchar(20) unique check (CourseName <> '')
-- SM Can be a normal single column unique constraint.
sequence int  not null unique (CourseId, sequence)

Meal
MealID pk 
MealName varchar (30) not blank, unique
MealStatus bit 
DateCreated date not null
UserID fk 
pictureCode  as ('Meal-Mealname.jpg') persisted

MealCourse
MealCourseID
mealID fk
courseID fk


RecipeMealCourse
RecipeMealCourseId pk
RecipeID fk
MealCourseId fk
IsMain bit 

CookBook
CookBookId pk
CookBookName varchar(40)
Price decimal (4,3)
DateCreated date not null
pictureCode concat('cookbook-cookbookname.jpg')
Active bit

CookbookRecipe
CookookRecipeID pk
RecipeID fk unique (cookbookRecipeID, RecipeID)
-- SM No need for this column.

CookbookID fk
-- SM Should be unique to cookbook
sequence int not null unique (cookbookrecipeId, sequence)

*/