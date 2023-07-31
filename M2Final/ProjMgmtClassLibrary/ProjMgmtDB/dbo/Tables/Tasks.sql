CREATE TABLE [dbo].[Tasks]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Description] NVARCHAR(30) NOT NULL, 
	[ProjectId] INT NOT NULL,
	[BeginDate] DATETIME2 NOT NULL, 
    [DueDate] DATETIME2 NOT NULL, 
    CONSTRAINT [FK_Tasks_Projects] FOREIGN KEY (ProjectId) REFERENCES Projects(Id)
)
