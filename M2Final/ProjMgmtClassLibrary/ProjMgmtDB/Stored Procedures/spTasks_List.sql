CREATE PROCEDURE [dbo].[spTasks_List]
	@id int
AS
begin
	set nocount on;

	SELECT  [t].[Id], [t].[Description], [p].[Title], [t].[BeginDate], [t].[DueDate]
	FROM dbo.Tasks t
	INNER JOIN dbo.Projects p
	ON t.ProjectId = p.Id
	WHERE p.Id = @id
	
end