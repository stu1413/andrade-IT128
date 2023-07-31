CREATE PROCEDURE [dbo].[spDepartments_Add]
	@department nvarchar (30), 
	@description nvarchar (30)
AS
begin
	set nocount on;

	INSERT INTO dbo.Departments
	(Department, Description)
	VALUES (@department, @description)

end
