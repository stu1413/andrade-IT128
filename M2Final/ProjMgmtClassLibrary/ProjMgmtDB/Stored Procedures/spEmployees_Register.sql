CREATE PROCEDURE [dbo].[spEmployees_Register]
	@email nvarchar (30),
	@password nvarchar (30),
	@firstName nvarchar (30),
	@lastName nvarchar (30),
	@roleId int,
	@departmentId int,
	@regionId int,
	@phone nvarchar (30),
	@dateHired datetime2
AS
begin
	set nocount on;

	INSERT INTO dbo.Employees
	(Email, Password, FirstName, LastName, RoleId, DepartmentId, RegionId, Phone, DateHired)
	VALUES (@email, @password, @firstName, @lastName, @roleId, @departmentId, @regionId, @phone, @dateHired)

end
