CREATE PROCEDURE [dbo].[spClients_Delete]
	@id int
AS
begin
	set nocount on;

	DELETE FROM dbo.Clients
	WHERE Id = @id;

end
