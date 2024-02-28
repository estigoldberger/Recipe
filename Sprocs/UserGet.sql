create or alter procedure dbo.UserGet(
	@Userid int =0, 
	@UserName varchar(20)= '', 
	@All bit =0)
as
begin
	select  @UserName = nullif(@UserName, '')
	select s.StaffID, s.LastName, s.FirstName, s.UserName
	from staff s
	where s.StaffID= @Userid
	or s.UserName like '%' + @UserName + '%'
	or @All=1
end
go 
/*
exec UserGet

exec UserGet @All=1

exec UserGet @UserName = ''

exec UserGet @UserName = 'l'

declare @userid int
select top 1 @userid= StaffID from Staff
exec UserGet @Userid= @userid
*/