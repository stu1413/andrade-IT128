CREATE PROCEDURE [dbo].[spRoles_Details]
	@id int
AS
begin
	set nocount on;

	SELECT  [Role]
	FROM dbo.Roles
	WHERE Id = @id;

end
