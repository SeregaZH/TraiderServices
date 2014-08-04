﻿CREATE TABLE [dbo].[Users]
(
	[Id] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY, 
    [UpdatedBy] varchar(200) NOT NULL, 
    [UpdatedDate] DATETIME NOT NULL, 
    CONSTRAINT [FK_Users_ToUserInfo] FOREIGN KEY (Id) REFERENCES [UserInfo](Id) ON DELETE CASCADE,     
)
