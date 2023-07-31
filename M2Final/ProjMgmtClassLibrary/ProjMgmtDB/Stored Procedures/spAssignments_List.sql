CREATE PROCEDURE [dbo].[spAssignments_List]
	@id int
AS
begin
	set nocount on;

	SELECT  [a].[Id], [t].[Description], [e].[Email], [a].[StartDate], [a].[EndDate]
	FROM dbo.Assignments a
	INNER JOIN dbo.Tasks t
	ON a.TaskId = t.Id
	INNER JOIN dbo.Employees e
	ON a.EmployeeId = e.Id
	WHERE a.Id = @id
	
end