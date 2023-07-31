CREATE PROCEDURE [dbo].[spRoles_Edit]
	@id int,
	@role nvarchar(30)
AS
begin
	set nocount on;

	UPDATE dbo.Roles
	SET Role=IsNull(NullIf(@role, ''), Role)
	WHERE Id = @id;

end
