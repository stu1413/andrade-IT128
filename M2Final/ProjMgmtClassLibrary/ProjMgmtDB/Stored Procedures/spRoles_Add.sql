CREATE PROCEDURE [dbo].[spRoles_Add]
	@role nvarchar (30)
AS
begin
	set nocount on;

	INSERT INTO dbo.Roles
	(Role)
	VALUES (@role)

end
