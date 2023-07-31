CREATE PROCEDURE [dbo].[spEmployees_Edit]
	@id int,
	@password nvarchar(30),
	@phone nvarchar(30)
AS
begin
	set nocount on;

	UPDATE dbo.Employees
	SET Password=IsNull(NullIf(@password, ''), Password), Phone=IsNull(NullIf(@phone, ''), Phone)
	WHERE Id = @id;

end
