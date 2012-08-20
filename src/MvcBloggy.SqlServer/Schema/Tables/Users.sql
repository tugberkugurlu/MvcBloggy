CREATE TABLE [dbo].[Users] (
    [UserId] INT IDENTITY NOT NULL,
    [Name] NVARCHAR (50) NOT NULL,
    [Email] NVARCHAR (320) NOT NULL,
    [HashedPassword] NVARCHAR (MAX) NOT NULL,
    [Salt] NVARCHAR (MAX) NOT NULL,
    [IsLocked] BIT NOT NULL,
	[CreationIp] NVARCHAR(50) NULL,
	[CreatedOn] DATETIMEOFFSET NOT NULL,
	[LastUpdateIp] NVARCHAR(50) NULL,
	[LastUpdatedOn] DATETIMEOFFSET NULL,
    CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED ([UserId])
);