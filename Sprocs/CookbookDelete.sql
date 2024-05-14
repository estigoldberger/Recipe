create or alter proc dbo.CookbookDelete(
	@CookbookId int = 0,
	@Message varchar(500) = ''  output
)
as
begin
	declare @return int = 0

    begin try
	begin tran
	delete CookbookRecipe where CookbookID= @CookbookId
    delete CookBook where CookBookId= @CookbookId
	
	commit
	end try
	begin catch
	rollback;
	throw
    end catch

     
    RETURN @return  
end
go
