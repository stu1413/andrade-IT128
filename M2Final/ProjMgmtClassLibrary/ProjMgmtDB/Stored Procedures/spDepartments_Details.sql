CREATE PROCEDURE [dbo].[spDepartments_Details]
	@id int
AS
begin
	set nocount on;

	SELECT  [Id], [Department], [Description]
	FROM dbo.Departments
	WHERE Id = @id;
	
end