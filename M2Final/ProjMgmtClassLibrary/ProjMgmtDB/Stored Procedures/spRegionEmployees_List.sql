CREATE PROCEDURE [dbo].[spRegionEmployees_List]
	@id int
AS
begin
	set nocount on;

	SELECT  [e].[Id], [e].[FirstName], [e].[LastName], [e].[Phone], [e].[Email], [r].[Region], [r].[Code]
	FROM dbo.Employees e
	INNER JOIN dbo.Regions r
	ON e.RegionId = r.Id
	WHERE r.Id = @id
	
end