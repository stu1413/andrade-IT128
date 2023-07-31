CREATE PROCEDURE [dbo].[spEmployees_Details]
	@id int
AS
begin
	set nocount on;

	SELECT  [e].[Id], [e].[Email], [e].[FirstName], [e].[LastName], [ro].[Role], [d].[Department], [re].[Code], [e].[Phone], [e].[DateHired]
	FROM dbo.Employees e
	INNER JOIN dbo.Roles ro
	ON e.RoleId = ro.Id
	INNER JOIN dbo.Departments d
	ON e.DepartmentId = d.Id
	INNER JOIN dbo.Regions re
	ON e.RegionId = re.Id
	WHERE e.Id = @id;
	
end