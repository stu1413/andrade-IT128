CREATE PROCEDURE [dbo].[spRegions_Details]
	@id int
AS
begin
	set nocount on;

	SELECT  [Id], [Region], [Code]
	FROM dbo.Regions
	WHERE Id = @id;
	
end