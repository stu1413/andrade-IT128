CREATE TABLE [dbo].[Departments]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Department] NVARCHAR(30) NOT NULL, 
    [Description] NVARCHAR(100) NOT NULL
)
