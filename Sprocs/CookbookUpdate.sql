create or alter proc dbo.CookbookUpdate(
@CookbookId int  output,
@StaffID int,
@DateCreated datetime = getdate,
@Price int,
@CookbookName varchar (40),
@CookbookStatus bit=0,
@Message varchar (500)= '' output
)
as
begin 

	select @CookbookId= isnull(@CookbookId, 0)
--LB: User shouldn't be able to set DateCreated value. 
	if @CookbookId =0
	begin
	insert CookBook(StaffId, CookBookName, DateCreated, CookBookStatus, Price)
	values (@StaffID, @CookbookName, @DateCreated, @CookbookStatus, @Price )
	select @CookbookId= SCOPE_IDENTITY()
	end
	else 
	begin 
update CookBook
set 	
	StaffID=@StaffID, 
	CookBookName=@CookbookName, 
	Price= @Price,
	DateCreated=@DateCreated, 
	CookBookStatus=@CookbookStatus
where CookBookId= @CookbookId
	end
end 
go