CREATE PROCEDURE [dbo].[spAssignments_Delete]
	@id int
AS
begin
	set nocount on;

	DELETE FROM dbo.Assignments
	WHERE Id = @id;

end
