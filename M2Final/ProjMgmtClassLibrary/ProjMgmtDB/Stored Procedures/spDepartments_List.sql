CREATE PROCEDURE [dbo].[spDepartments_List]
AS
begin
	set nocount on;

	SELECT  [Id], [Department], [Description]
	FROM dbo.Departments
	
end