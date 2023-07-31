CREATE PROCEDURE [dbo].[spRegions_Edit]
	@id int,
	@region nvarchar(30),
	@code nvarchar(30)
AS
begin
	set nocount on;

	UPDATE dbo.Regions
	SET Region=IsNull(NullIf(@region, ''), Region), Code=IsNull(NullIf(@code, ''), Code)
	WHERE Id = @id;

end
