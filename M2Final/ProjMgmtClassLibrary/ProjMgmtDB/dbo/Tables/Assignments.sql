CREATE TABLE [dbo].[Assignments]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY,
	[TaskId] INT NOT NULL,
	[DepartmentId] INT NOT NULL,
	[EmployeeId] INT NULL,
	[StartDate] DATETIME2 NULL, 
    [EndDate] DATETIME2 NULL,
    CONSTRAINT [FK_Assignments_Tasks] FOREIGN KEY (TaskId) REFERENCES Tasks(Id),
    CONSTRAINT [FK_Assignments_Departments] FOREIGN KEY (DepartmentId) REFERENCES Departments(Id),
    CONSTRAINT [FK_Assignments_Employees] FOREIGN KEY (EmployeeId) REFERENCES Departments(Id)
)
