CREATE TABLE [dbo].[Claim]
(
	[Id] UNIQUEIDENTIFIER NOT NULL , 
    [Value] VARCHAR(MAX) NOT NULL,
	[Identity] INT NULL, 
    [ClaimTypeId] UNIQUEIDENTIFIER NOT NULL, 
	[ClaimTypeNumber] INT NOT NULL, 
    [UserId] UNIQUEIDENTIFIER NOT NULL,
    [UpdatedBy] varchar(200) NOT NULL, 
    [UpdatedDate] DATETIME NOT NULL, 
    PRIMARY KEY ([Id]), 
    CONSTRAINT [FK_Claim_ToClaimType] FOREIGN KEY (ClaimTypeId, ClaimTypeNumber) REFERENCES ClaimType(Id, [TypeNumber]) ON DELETE CASCADE,
	CONSTRAINT [FK_Claim_ToUserInfo] FOREIGN KEY (UserId) REFERENCES UserInfo(Id) ON DELETE CASCADE
)
