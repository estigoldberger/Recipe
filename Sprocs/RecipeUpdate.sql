create or alter proc dbo.RecipeUpdate(
@RecipeId int  output,
@StaffID int,
@CuisineID int,
@RecipeName varchar (40),
@Calorie int,
@DateDrafted datetime,
@DatePublished datetime,
@DateArchived datetime,
@Message varchar (500)= '' output
)
as
begin 

	select @RecipeId= isnull(@RecipeId, 0)
	
	if @RecipeId =0
	begin
	insert Recipe(StaffID, CuisineID, RecipeName, Calorie, DateDrafted, DatePublished, DateArchived)
	values (@StaffID, @CuisineID, @RecipeName, @Calorie, @DateDrafted, @DatePublished, @DateArchived)
	select @RecipeId= SCOPE_IDENTITY()
	end
	else 
	begin 
update Recipe
set 	
	StaffID=@StaffID, 
	CuisineID=@CuisineID, 
	RecipeName=@RecipeName, 
	Calorie=@Calorie, 
	DateDrafted=@DateDrafted, 
	DatePublished=@DatePublished, 
	DateArchived=@DateArchived
where RecipeId= @Recipeid
	end
end 
go