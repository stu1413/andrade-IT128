CREATE PROCEDURE [dbo].[spEmployees_Delete]
	@id int
AS
begin
	set nocount on;

	DELETE FROM dbo.Employees
	WHERE Id = @id;

end
