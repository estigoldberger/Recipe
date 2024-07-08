create or alter proc dbo.CookbookDetailsGet(
	@CookbookId int=0,
	@Message varchar(500) = '' output
)
as 
begin
	declare @return int=0
	select @CookbookId = isnull(@CookbookId, 0)
	select c.CookBookId,c.CookBookName, c.CookBookStatus, Username= s.UserName, c.DateCreated, s.StaffID, c.Price, Checked=CookBookStatus
	from CookBook c
	join staff s
	on s.staffid = c.staffid 
	where c.CookBookId= @CookbookId
	
	return @return
	
end 
go
-- select * from cookbook

--exec CookbookDetailsGet @CookbookId= 100