CREATE PROCEDURE [dbo].[spProjects_Add]
	@title nvarchar (30), 
	@description nvarchar (30), 
	@clientId int, 
	@budget float, 
	@employeeId int, 
	@startDate date, 
	@endDate date
AS
begin
	set nocount on;

	INSERT INTO dbo.Projects
	(Title, Description, ClientId, Budget, EmployeeId, StartDate, EndDate)
	VALUES (@title, @description, @clientId, @budget, @employeeId, @startDate, @endDate)

end
