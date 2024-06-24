--LB: Best would be to include table name in the sproc name so you know what it refers to.
create or alter proc dbo.AutoCreateCookbook(
	@CookbookId int =null output,
	@Message varchar (500)='',
	@StaffId int


)
as 
begin
	declare @return int=0
	; with   x as 
	(
		
			select  
			bookname= concat('Recipes by ', s.FirstName,  ' ', s.LastName),  Price =count(r.recipeid)* 1.33, s.StaffID
			from staff s 
			join recipe r 
			on s.StaffID = r.StaffID
			where s.StaffID= @StaffId
			group by s.FirstName, s.LastName, s.StaffID
		

		)

	insert CookBook (CookBookName, StaffId, CookBookStatus, Price)
	select x.bookname, x.staffid, 1, x.Price
	from x 

	select @CookbookId= SCOPE_IDENTITY()

	insert CookbookRecipe (r.recipeid, c.cookbookid, RecipeSequence)
	select r.recipeid ,c.CookBookId, ROW_NUMBER() over (order by r.recipename)
	from CookBook c 
	join staff s 
	on s.StaffID = c.StaffId
	join recipe r 
	on s.StaffID = r.StaffId
	where c.CookBookName like 'recipes by %' 
	and s.StaffID= @StaffId

	return @return

end 
go 

--exec AutoCreate @StaffId= 64