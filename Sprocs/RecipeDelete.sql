create or alter PROCEDURE dbo.RecipeDelete(
    @RecipeID int,  @message varchar(300)= '' output
)
as 
begin 
     declare @return int=0
--LB: There is a mix of and's and or's. I couldn't delete a archived recipe that was archived for more than 30 days. Please fix the if exists condition.
	 if exists(select * from recipe r  where r.recipeid= @RecipeID and((recipestatus not in ('drafted', 'archived') or(recipestatus= 'archived' and datediff(day, datearchived, getdate())< 30))))
--LB: Formatting tip: Only the code inside the begin end should be indented.
	begin 
        select @return=1, @message= 'Cannot delete recipe unless it is currently drafted or archived for 30 days'
        goto finished
    end
    begin try
		begin tran
--LB: Formatting tip: Code inside the begin/end should be indented. Same for Begin ctach/end catch.
--LB: You must delete all related records before deleting recipe. (ex. CookbookRecipe, RecipeMealCourse)
		delete RecipeMealCourse where RecipeId=@RecipeID
		delete CookbookRecipe where RecipeId= @RecipeID
		delete recipeIngredient where Recipeid= @RecipeId
		delete RecipeDirection where RecipeId= @Recipeid
		delete Recipe where RecipeId= @RecipeID
		commit
	end try
	begin catch
		rollback;
		throw
    end catch

    finished: 
    RETURN @return     
end
go 

            