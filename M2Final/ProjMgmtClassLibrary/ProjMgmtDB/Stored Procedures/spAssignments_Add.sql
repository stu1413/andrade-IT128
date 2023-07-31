CREATE PROCEDURE [dbo].[spAssignments_Add]
	@taskId int, 
	@employeeId int, 
	@startDate date, 
	@endDate date
AS
begin
	set nocount on;

	INSERT INTO dbo.Assignments
	(TaskId, EmployeeId, StartDate, EndDate)
	VALUES (@taskId, @employeeId, @startDate, @endDate)

end
