CREATE PROCEDURE [dbo].[spClients_Add]
	@name nvarchar (30),
	@phone nvarchar (30),
	@email nvarchar (30),
	@regionId int
AS
begin
	set nocount on;

	INSERT INTO dbo.Clients
	(Name, Phone, Email, RegionId)
	VALUES (@name, @phone, @email, @regionId)

end
