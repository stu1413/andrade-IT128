CREATE PROCEDURE [dbo].[spClients_Edit]
	@id int,
	@phone nvarchar(30), 
	@email nvarchar(30)
AS
begin
	set nocount on;

	UPDATE dbo.Clients
	SET Phone=IsNull(NullIf(@phone, ''), Phone), Email=IsNull(NullIf(@email, ''), Email)
	WHERE Id = @id;

end
