create or alter function dbo.RecipeInfo(@RecipeId int)
returns varchar(85)
as 
begin 
	declare @value varchar(85)=''

	select @value=concat(r.RecipeName, ' (', c.CuisineType, ') ', 'has ', count(distinct ri.RecipeSequence), ' ingredients and ', count(distinct rd.DirectionSequence), ' steps') 
    from cuisine c 
    left join recipe r 
    on c.CuisineID= r.CuisineID
    join RecipeIngredient ri
    on r.RecipeId= ri.RecipeID
    join RecipeDirection rd 
    on r.RecipeId= rd.RecipeID
    where r.RecipeId= @RecipeId
    group by r.RecipeName, c.CuisineType
    
    
    return @value
end
go 

/*select dbo.RecipeInfo(r.RecipeId)
from recipe r
*/

