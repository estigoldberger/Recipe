create or alter PROCEDURE dbo.RecipeDelete(
    @RecipeID int,  @message varchar(300)= ' ' output
)
as 
begin 
     
    
    begin try
	begin tran
	delete recipeIngredient where Recipeid= @RecipeId
    delete RecipeDirection where RecipeId= @Recipeid
	delete Recipe where RecipeId= @RecipeID
	commit
	end try
	begin catch
	rollback;
	throw
    end catch

    
end
go 


