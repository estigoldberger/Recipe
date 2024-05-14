create or alter proc dbo.CookbookGet(
	@CookbookId int=0,
	@CookbookName varchar(40)= '',
	@All bit =0
)
as 
begin
select @CookbookName = nullif(@CookbookName, '')
	select c.CookBookId, c.CookbookName, Author=s.username, NumberOfRecipes=count(cr.CookbookRecipeID), c.Price
from staff s  
join cookbook c 
on s.StaffID = c.StaffId
left join CookbookRecipe cr 
on c.CookBookId = cr.CookbookID
where c.CookBookId= @CookbookId
or @All=1
group by c.CookBookName, s.UserName, c.Price, c.CookBookId
order by c.CookBookName

end 
go 
