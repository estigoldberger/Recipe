create or alter PROCEDURE dbo.RecipeDelete(
    @RecipeID int,  @message varchar(300)= '' output
)
as 
begin 
     declare @return int=0
     if exists(select * from recipe r where r.RecipeId= @RecipeID and  recipestatus not in ('drafted', 'archived') or(recipestatus= 'archived' and datediff(day, datearchived, getdate())< 30))
        begin 
        select @return=1, @message= 'Cannot delete recipe unless it is currently drafted or archived for 30 days'
        goto finished
        END
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

    finished: 
    RETURN @return     
end
go 

            