CREATE TABLE [dbo].[UserInfo]
(
	[Id] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY, 
    [Status] TINYINT NOT NULL, 
	[UpdatedBy] varchar(200) NOT NULL, 
    [UpdatedDate] DATETIME NOT NULL
)
