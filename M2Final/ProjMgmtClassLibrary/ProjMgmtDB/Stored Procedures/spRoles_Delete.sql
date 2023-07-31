CREATE PROCEDURE [dbo].[spRoles_Delete]
	@id int
AS
begin
	set nocount on;

	DELETE FROM dbo.Roles
	WHERE Id = @id;

end
