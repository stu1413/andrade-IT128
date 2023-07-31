CREATE PROCEDURE [dbo].[spClients_List]
AS
begin
	set nocount on;

	SELECT  [c].[Id], [c].[Name], [c].[Phone], [c].[Email], [r].[Code]
	FROM dbo.Clients c
	INNER JOIN dbo.Regions r
	ON c.RegionId = r.Id
	
end