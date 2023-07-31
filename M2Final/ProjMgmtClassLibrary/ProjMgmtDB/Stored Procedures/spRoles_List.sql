CREATE PROCEDURE [dbo].[spRoles_List]
AS
begin
	set nocount on;

	SELECT  [Id], [Role]
	FROM dbo.Roles

end
