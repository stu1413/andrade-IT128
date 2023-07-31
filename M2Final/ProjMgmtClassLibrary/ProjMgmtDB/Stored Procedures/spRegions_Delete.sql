CREATE PROCEDURE [dbo].[spRegions_Delete]
	@id int
AS
begin
	set nocount on;

	DELETE FROM dbo.Regions
	WHERE Id = @id;

end
