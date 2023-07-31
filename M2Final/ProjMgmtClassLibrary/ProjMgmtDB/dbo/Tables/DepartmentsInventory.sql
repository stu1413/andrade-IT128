CREATE TABLE [dbo].[DepartmentsInventory]
(
	[DepartmentId] INT NOT NULL,
	[EmployeeId] INT NOT NULL, 
	[AssignmentId] INT NOT NULL,
	CONSTRAINT [CK_DepartmentsInventory] PRIMARY KEY (DepartmentId, EmployeeId),
    CONSTRAINT [FK_DepartmentInventory_Employees] FOREIGN KEY (EmployeeId) REFERENCES Employees(Id),
    CONSTRAINT [FK_DepartmentInventory_Departments] FOREIGN KEY (DepartmentId) REFERENCES Departments(Id),
    CONSTRAINT [FK_DepartmentInventory_Assignments] FOREIGN KEY (AssignmentId) REFERENCES Assignments(Id)
)
