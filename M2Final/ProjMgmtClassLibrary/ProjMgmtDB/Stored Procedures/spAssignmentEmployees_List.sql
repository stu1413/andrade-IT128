CREATE PROCEDURE [dbo].[spAssignmentEmployees_List]
	@id int
AS
begin
	set nocount on;

	SELECT  [p].[Id], [p].[Title], [t].[Id], [t].[Description], [a].[Id], [a].[StartDate], [a].[EndDate], [e].[FirstName], [e].[LastName]
	FROM dbo.Assignments a
	INNER JOIN dbo.Employees e
	ON a.EmployeeId = e.Id
	INNER JOIN dbo.Tasks t
	ON a.TaskId = t.Id
	INNER JOIN dbo.Projects p
	ON t.ProjectId = p.Id
	WHERE a.Id = @id;
	
end