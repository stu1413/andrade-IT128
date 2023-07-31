CREATE PROCEDURE [dbo].[spClientProjects_List]
	@id int
AS
begin
	set nocount on;

	SELECT  [p].[Id], [p].[Title], [p].[Budget], [p].[StartDate], [p].[EndDate], [c].[Name], [c].[Phone], [c].[Email]
	FROM dbo.Projects p
	INNER JOIN dbo.Clients c
	ON p.ClientId = c.Id
	WHERE c.Id = @id
	
end