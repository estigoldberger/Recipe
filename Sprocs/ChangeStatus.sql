create or alter proc dbo.ChangeStatus(
	@RecipeId int,
	@ChangeTo varchar(20)
)
as
begin 

	declare @return int=0
	if @ChangeTo= 'Publish'
	update Recipe 
	set
	DatePublished=convert(varchar, GETDATE(),1)
	where RecipeId= @RecipeId

	if @ChangeTo= 'Archive'
	update Recipe 
	set
	DateArchived=convert(varchar, GETDATE(),1)
	where RecipeId= @RecipeId

	if @ChangeTo= 'Draft'
	update Recipe 
	set
	DatePublished=null,
	DateDrafted=convert(varchar, GETDATE(),1)
	where RecipeId= @RecipeId

	return @return 
end 
go 
