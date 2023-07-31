CREATE PROCEDURE [dbo].[spRoleEmployees_List]
	@id int
AS
begin
	set nocount on;

	SELECT  [e].[Id], [e].[FirstName], [e].[LastName], [e].[Phone], [e].[Email], [r].[Role]
	FROM dbo.Employees e
	INNER JOIN dbo.Roles r
	ON e.RoleId = r.Id
	WHERE r.Id = @id

end
