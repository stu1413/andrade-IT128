CREATE PROCEDURE [dbo].[spDepartments_Edit]
	@id int,
	@department nvarchar(30), 
	@description nvarchar(30)
AS
begin
	set nocount on;

	UPDATE dbo.Departments
	SET Department=IsNull(NullIf(@department, ''), Department), Description=IsNull(NullIf(@description, ''), Description)
	WHERE Id = @id;

end
