CREATE PROCEDURE [dbo].[spTasks_Add]
	@name nvarchar (30),
	@description nvarchar (30), 
	@projectId int, 
	@beginDate date, 
	@dueDate date
AS
begin
	set nocount on;

	INSERT INTO dbo.Tasks
	(Description, ProjectId, BeginDate, DueDate)
	VALUES (@description, @projectId, @beginDate, @dueDate)

end
