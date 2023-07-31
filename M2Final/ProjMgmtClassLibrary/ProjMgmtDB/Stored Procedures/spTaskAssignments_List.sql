CREATE PROCEDURE [dbo].[spTaskAssignments_List]
	@id int
AS
begin
	set nocount on;

	SELECT  [p].[Id], [p].[Title], [t].[Id], [t].[Description], [t].[BeginDate], [t].[DueDate], [a].[Id], [a].[StartDate], [a].[EndDate]
	FROM dbo.Assignments a
	INNER JOIN dbo.Tasks t
	ON a.TaskId = t.Id
	INNER JOIN dbo.Projects p
	ON t.ProjectId = p.Id
	WHERE t.Id = @id;
	
end