CREATE PROCEDURE [dbo].[spProjects_Edit]
	@id int,
	@title nvarchar(30),
	@description nvarchar(30),
	@budget float
AS
begin
	set nocount on;

	UPDATE dbo.Projects
	SET Title=IsNull(NullIf(@title, ''), Title), Description=IsNull(NullIf(@description, ''), Description), Budget=IsNull(NullIf(@budget, ''), Budget)
	WHERE Id = @id;

end
