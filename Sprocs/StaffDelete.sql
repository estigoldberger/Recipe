create or alter procedure dbo.StaffDelete(
	@StaffId int = 0,
	@LastName varchar (500)='',
	@Message varchar(500) = ''  output
)
as
begin
	declare @return int=0
	select @StaffID = isnull(@StaffId,0)
	begin try 
		begin tran
--LB: All code should be inside a transaction.
		delete  cr 
		from CookbookRecipe cr 
		join CookBook c 
		on c.CookBookId = cr.CookbookID 
		join staff s 
		on s.StaffID = c.StaffId
		join Recipe r 
		on r.StaffID = s.StaffID
		where s.StaffID=@StaffId


		delete c
		from CookBook c 
		join staff s 
		on s.StaffID = c.StaffId
		where s.StaffID=@StaffId



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
		where s.StaffID=@StaffId

		delete mc 
		from MealCourse mc 
		join meal m 
		on m.MealID = mc.mealID 
		join staff s 
		on s.StaffID = m.StaffID
		where s.StaffID=@StaffId

		delete m 
		from meal m 
		join staff s 
		on s.StaffID = m.StaffID
		where s.StaffID=@StaffId

--LB: No need to join the staff table, the where clause can be based on the staff id in the recipe table. please fix all statement below.
		delete rd
		from RecipeDirection rd 
		join recipe r 
		on r.RecipeId = rd.RecipeID
		where r.StaffID=@StaffId
		
		delete ri
		from RecipeIngredient ri 
		join recipe r 
		on r.RecipeId = ri.RecipeID
		where r.StaffID=@StaffId
		
		delete rmc   
		from recipe r
		join RecipeMealCourse rmc 
		on r.RecipeId = rmc.RecipeID
		where r.StaffID=@StaffId
		
		delete cr  
		from recipe r  
		join CookbookRecipe cr 
		on r.RecipeId = cr.RecipeID
		where r.StaffID=@StaffId
		
		delete r 
		from recipe r 
		where r.StaffID=@StaffId
		
		delete s 
		from staff s 
		where s.StaffID=@StaffId
	commit
	end try 
	begin catch
		rollback;
		throw
    end catch
	return @return
end
go