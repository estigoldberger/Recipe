create or alter procedure dbo.StaffUpdate(
	@StaffId int  output,
	@LastName varchar (100),
	@FirstName varchar(100),
	@UserName varchar(100),
	@Message varchar(500) = ''  output
)
as
begin
	declare @return int = 0

	select @StaffId = isnull(@StaffId,0)
	
	if @StaffId = 0
	begin
		insert Staff(LastName, FirstName, UserName)
		values(@LastName, @FirstName, @UserName)

		select @StaffId= scope_identity()
	end
	else
	begin
		update Staff
		set
			LastName = @LastName,
			FirstName= @FirstName,
			UserName= @UserName
		where StaffId = @StaffId
	end
	
	return @return
end
go