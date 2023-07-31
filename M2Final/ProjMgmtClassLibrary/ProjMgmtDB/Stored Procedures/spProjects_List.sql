CREATE PROCEDURE [dbo].[spProjects_List]
AS
begin
	set nocount on;

	SELECT  [p].[Id], [p].[Title], [p].[Description], [c].[Name], [p].[Budget], [e].[Email], [p].[StartDate], [p].[EndDate]
	FROM dbo.Projects p
	INNER JOIN dbo.Clients c
	ON p.ClientId = c.Id
	INNER JOIN dbo.Employees e
	ON p.EmployeeId = e.Id
	
end