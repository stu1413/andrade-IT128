CREATE PROCEDURE [dbo].[spProjects_Delete]
	@id int
AS
begin
	set nocount on;

	DELETE FROM dbo.Projects
	WHERE Id = @id;

end
