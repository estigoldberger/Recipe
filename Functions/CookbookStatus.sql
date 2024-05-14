create or alter function dbo.CookbookStatus(@Cookbook int)
returns varchar (8)
as 
begin 
	declare @IsActive varchar (8)=''

	select @IsActive= 
	case 
	
	when c.CookBookStatus= 1 then 'checked'
	else 'else'
	end
    from CookBook c 
    
    
    
    return @IsActive
end
go 