CREATE TABLE [dbo].[Employees]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Email] NVARCHAR(30) NOT NULL, 
    [Password] NVARCHAR(30) NOT NULL, 
    [FirstName] NVARCHAR(30) NOT NULL, 
    [LastName] NVARCHAR(30) NOT NULL,
    [RoleId] INT NOT NULL, 
    [DepartmentId] INT NOT NULL, 
    [RegionId] INT NOT NULL, 
    [Phone] NVARCHAR(30) NULL,
    [DateHired] DATETIME2 NOT NULL, 
    CONSTRAINT [FK_Employees_Roles] FOREIGN KEY (RoleId) REFERENCES Roles(Id), 
    CONSTRAINT [FK_Employees_Departments] FOREIGN KEY (DepartmentId) REFERENCES Departments(Id), 
    CONSTRAINT [FK_Employees_Regions] FOREIGN KEY (RegionId) REFERENCES Regions(Id)
)
