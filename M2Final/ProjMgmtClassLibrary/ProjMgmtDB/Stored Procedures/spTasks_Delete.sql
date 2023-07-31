CREATE PROCEDURE [dbo].[spTasks_Delete]
	@id int
AS
begin
	set nocount on;

	DELETE FROM dbo.Tasks
	WHERE Id = @id;

end
