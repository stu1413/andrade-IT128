CREATE PROCEDURE [dbo].[spDepartments_Delete]
	@id int
AS
begin
	set nocount on;

	DELETE FROM dbo.Departments
	WHERE Id = @id;

end
