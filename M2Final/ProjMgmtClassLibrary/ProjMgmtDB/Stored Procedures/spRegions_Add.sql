CREATE PROCEDURE [dbo].[spRegions_Add]
	@region nvarchar (30),
	@code nvarchar (30)
AS
begin
	set nocount on;

	INSERT INTO dbo.Regions
	(Region, Code)
	VALUES (@region, @code)

end
