-- SM Excellent! See comments, fix and resubmit.
use HeartyHearthDB
go 


drop table if exists RecipeIngredient
drop table if exists CookBookRecipe
drop table if exists RecipeDirection
drop table if exists RecipeMealCourse 
drop table if exists MealCourse
drop table if exists Course 
drop table if exists Meal 
drop table if exists CookBook
drop table if exists Recipe
drop table if exists Ingredient
drop table if exists Measurement
drop table if exists Cuisine
drop table if exists Staff

create table dbo.Ingredient (
IngredientID int not null identity primary key,
IngredientName varchar(20) not null 
    constraint ingredient_name_unique unique
    constraint ck_IngredientName_not_blank check (IngredientName <> ''),
PictureCode as CONCAT('Ingredient_',REPLACE(ingredientname, ' ', '_' ), '.jpg' ) persisted
)

 
create table dbo.Measurement (
MeasurementID int not null identity primary key,
MeasurementType varchar(15) not null 
    constraint ck_measurementtype_cannot_be_blank check (measurementType <> '')
    constraint u_measurementType_must_be_unique unique
)

create table dbo.Cuisine (
CuisineID int not null identity primary key,
CuisineType varchar(20) not null 
    constraint u_cuisineType unique
    constraint c_cuisineType_cannot_be_blank check (CuisineType <> '')
)

create table dbo.Staff (
StaffID int not null identity primary key,
LastName varchar(30) not null constraint ck_last_name_cannot_be_blank check (LastName <> ''),
FirstName varchar(30) not null constraint ck_firstName_cannot_be_blank check (FirstName <> ''),
UserName varchar(20) not null 
    constraint u_userName UNIQUE
    constraint  ck_userName_cannot_be_blank check (UserName <> ''), 
)

create table dbo.Recipe(
RecipeId int not null identity primary key,
-- SM Constraint name should be f_parent_child like f_staff_recipe.
StaffID int not null constraint f_staff_recipe foreign key references Staff (StaffID),
-- SM Constraint name should be f_parent_child
CuisineID int not null constraint f_cuisine_recipe foreign key references Cuisine (cuisineID),
RecipeName varchar(40) not null 
    constraint u_recipeName_must_be_unique unique
    constraint ck_RecipeName_cannot_be_blank check (RecipeName <> ''), 
Calorie int not null constraint ck_calorie_greater_than_0 check (Calorie > 0),
DateDrafted datetime not null default GETDATE() constraint ck_RecipeDateDrafted_cannot_be_futureDate check (DateDrafted <=GETDATE()), 
-- SM DatePublished and DateArchived should "NOT" be defaulted to current date.
DatePublished datetime null  constraint ck_RecipeDatepublished_cannot_be_futureDate check (Datepublished <=GETDATE()),
DateArchived datetime null  constraint ck_recipedatearchived_cannot_be_futureDate check (Datearchived <=GETDATE()),
RecipeStatus  as case when DatePublished is null and DateArchived is null  then 'Drafted'
    when DateArchived is null and DatePublished is not null then 'Published'
    else 'Archived'
    end 
     persisted,
pictureCode as CONCAT('Recipe_',REPLACE(recipename, ' ', '_' ), '.jpg' )persisted,
constraint ck_datePublished_must_be_after_dateDrafted check (DatePublished > DateDrafted ),
-- SM No need to check for null it gets ignored by constraint. Use and for both checks.
--constraint ck_date_archived_is_after_date_drafted_or_published check ( DateArchived > DateDrafted or DateArchived > DatePublished  )
)

create table dbo.RecipeIngredient(
RecipeIngredientID int not null identity primary key,
RecipeID int not null constraint f_Recipe_recipeingredient foreign key references Recipe (RecipeID),
IngredientID int not null constraint f_ingredient_recipeIngredient foreign key references Ingredient (IngredientID),
MeasurementID int  null constraint f_measurement_RecipeIngredient FOREIGN key REFERENCES Measurement (measurementID),
RecipeSequence int not null constraint ck_RIrecipeSequence_greater_than_0 check (RecipeSequence > 0) ,
-- SM Don't allow null.
Amount decimal (4,2) not null constraint ck_Amount_greater_than_0 check (Amount > 0), 
-- SM Use FK in constraint. You're using PK.
constraint u_Recipe_Sequence unique (recipeid, RecipeSequence) 
)

create table dbo.RecipeDirection (
RecipeDirectionID int not null identity primary key,
RecipeID int not null constraint f_recipe_recipeDirection foreign key references Recipe(RecipeID),
Direction varchar (150) not null constraint ck_direction_cannot_be_blank check (Direction <> ''),
DirectionSequence int not null constraint ck_directionSequence_greater_than_0 check (DirectionSequence > 0)
constraint u_RecipeID_DirectionSequence unique (recipeid, DirectionSequence)
)

create table dbo.Course (
CourseID int not null identity primary key,
CourseName varchar(20) not null 
    constraint u_coursename_must_be_unique unique
    constraint ck_courseName_is_not_blank check (CourseName <> ''),
CourseSequence int  not null constraint ck_courseSequence_greater_than_0 check (coursesequence > 0)
constraint u_coursesequence_must_be_unique unique 
)

create table dbo.Meal (
MealID int not null identity primary key,
-- SM Constraint name should be f_parent_child #.
StaffID int not null constraint f_staff_meal_ foreign key references Staff (StaffID),
MealName varchar (40) not null 
    constraint ck_mealName_cannot_be_blank check (mealname <> '')
    constraint u_mealName_must_be_unique unique,
IsActive bit not null default 1 ,
DateCreated datetime not null  default getdate () constraint ck_dateCreated_cannot_be_FutureDate check (DateCreated <= getdate()) ,
pictureCode as CONCAT('Meal_',REPLACE(Mealname, ' ', '_' ), '.jpg' ) persisted
)

create table dbo.MealCourse (
MealCourseID int not null identity primary key,
mealID int not null constraint f_meal_MealCourse foreign key references Meal (MealID),
courseID int not null constraint f_course_meal_course foreign key references Course (courseID),
constraint u_Mealid_courseID_must_be_unique unique (MealId, CourseId)
)

create table dbo.RecipeMealCourse (
RecipeMealCourseId int not null identity primary key,
RecipeID int not null constraint f_Recipe_RecipeMealCourse foreign key references Recipe (RecipeID),
MealCourseId int not null constraint f_MealCourse_RecipeMealCourse foreign key references MealCourse (MealCourseID),
IsMain bit not null ,
constraint u_RecipeId_MealCourseID_must_be_unique unique (RecipeId, MealCourseID)
)


create table dbo.CookBook(
CookBookId int not null identity primary key,
-- SM Constraint name should be f_parent_child.
StaffId int not null constraint f_staff_cookbook foreign key references Staff (StaffID),
CookBookName varchar(40) not null 
    constraint ck_cookbookName_not_blank check (CookbookName <> '') 
    constraint u_cookbookName_must_be_unique unique,
Price decimal (4, 2) not null constraint ck_price_greater_than_0 check (Price > 0),
-- SM Don't allow future dates.
DateCreated datetime not null default GETDATE () constraint ck_Cookbook_dateCreated_cannot_be_futureDate check (Datecreated <=GETDATE()),
CookBookStatus bit not null default 1, 
PictureCode as CONCAT('Cookbook_',REPLACE(Cookbookname, ' ', '_' ), '.jpg' )PERSISTED,
)

create table dbo.CookbookRecipe(
CookookRecipeID int not null identity primary key,
RecipeID int not null constraint f_Recipe_CookbookRecipe foreign key references Recipe (RecipeID),
CookbookID int not null constraint f_CookBook_CookbookRecipe foreign key references CookBook (CookBookID),
-- SM Ad constraint that it must be > 0.
RecipeSequence int not null constraint ck_CookbookRecipeSequence_greater_than_0 check (RecipeSequence > 0), 
constraint u_recipesequence_must_be_unique unique (cookbookID, recipeSequence),
constraint u_recipeID_CookbookID_must_be_unique unique (recipeId, cookbookid)
)