CREATE TABLE [dbo].[ClaimType]
(
	[Id] UNIQUEIDENTIFIER NOT NULL,
    [TypeNumber] INT NOT NULL, 
	[Name] VARCHAR(50) NOT NULL,
	[UpdatedBy] varchar(200) NOT NULL, 
    [UpdatedDate] DATETIME NOT NULL, 
    PRIMARY KEY (Id, [TypeNumber])   
)
