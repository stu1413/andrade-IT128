CREATE PROCEDURE [dbo].[spRegions_List]
AS
begin
	set nocount on;

	SELECT  [Id], [Region], [Code]
	FROM dbo.Regions
	
end