CREATE PROCEDURE [dbo].[spProjectTasks_List]
	@id int
AS
begin
	set nocount on;

	SELECT  [p].[Id], [p].[Title], [p].[StartDate], [p].[EndDate], [t].[Id], [t].[Description], [t].[BeginDate], [t].[DueDate]
	FROM dbo.Tasks t
	INNER JOIN dbo.Projects p
	ON t.ProjectId = p.Id
	WHERE p.Id = @id;
	
end