CREATE PROCEDURE [dbo].[spTasks_Edit]
	@id int,
	@description nvarchar(30)
AS
begin
	set nocount on;

	UPDATE dbo.Tasks
	SET Description=IsNull(NullIf(@description, ''), Description)
	WHERE Id = @id;

end
