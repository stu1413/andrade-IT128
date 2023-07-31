CREATE PROCEDURE [dbo].[spEmployees_Authenticate]
	@email nvarchar (30),
	@password nvarchar (30)
AS
begin
	set nocount on;

	SELECT [Id], [Email], [FirstName], [LastName], [Password]
	FROM dbo.Employees
	WHERE Email = @email
	AND Password = @password;

end
