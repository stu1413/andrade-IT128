CREATE PROCEDURE [dbo].[spAssignments_Edit]
	@id int,
	@employeeId int, 
	@startDate date, 
	@endDate date
AS
begin
	set nocount on;

	UPDATE dbo.Assignments
	SET EmployeeId=IsNull(NullIf(@employeeId, ''), EmployeeId), StartDate=IsNull(NullIf(@startDate, ''), StartDate), EndDate=IsNull(NullIf(@endDate, ''), EndDate)
	WHERE Id = @id;

end
