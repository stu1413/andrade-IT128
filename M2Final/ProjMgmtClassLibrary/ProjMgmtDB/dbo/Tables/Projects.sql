CREATE TABLE [dbo].[Projects]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Title] NVARCHAR(30) NOT NULL, 
    [Description] NVARCHAR(30) NOT NULL, 
    [ClientId] INT NOT NULL,
    [Budget] FLOAT NOT NULL,
    [EmployeeId] INT, 
    [StartDate] DATETIME2 NOT NULL, 
    [EndDate] DATETIME2 NOT NULL, 
    CONSTRAINT [FK_Projects_Employees] FOREIGN KEY (EmployeeId) REFERENCES Employees(Id), 
    CONSTRAINT [FK_Projects_Clients] FOREIGN KEY (ClientId) REFERENCES Clients(Id)
)
