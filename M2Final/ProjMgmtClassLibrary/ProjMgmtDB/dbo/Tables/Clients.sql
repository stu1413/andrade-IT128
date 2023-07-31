﻿CREATE TABLE [dbo].[Clients]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Name] NVARCHAR(30) NOT NULL, 
    [Phone] NVARCHAR(30) NOT NULL, 
    [Email] NVARCHAR(30) NOT NULL,
	[RegionId] INT NOT NULL,
    CONSTRAINT [FK_Clients_Regions] FOREIGN KEY (RegionId) REFERENCES Regions(Id)
)
