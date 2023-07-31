CREATE PROCEDURE [dbo].[spDepartmentEmployees_List]
	@id int
AS
begin
	set nocount on;

	SELECT  [e].[Id], [e].[FirstName], [e].[LastName], [e].[Phone], [e].[Email], [d].[Department]
	FROM dbo.Employees e
	INNER JOIN dbo.Departments d
	ON e.DepartmentId = d.Id
	WHERE d.Id = @id;
	
end