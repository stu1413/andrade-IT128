CREATE PROCEDURE [dbo].[spRegionClients_List]
	@id int
AS
begin
	set nocount on;

	SELECT  [c].[Id], [c].[Name], [c].[Phone], [c].[Email], [r].[Region], [r].[Code]
	FROM dbo.Clients c
	INNER JOIN dbo.Regions r
	ON c.RegionId = r.Id
	WHERE r.Id = @id
	
end