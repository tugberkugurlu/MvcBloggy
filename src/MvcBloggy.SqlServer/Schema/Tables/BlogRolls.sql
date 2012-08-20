CREATE TABLE [dbo].[BlogRolls] (
	[Key] INT IDENTITY NOT NULL,
	[LanguageKey] INT NOT NULL,
	[BlogName] NVARCHAR(300) NOT NULL,
	[BlogAuthor] NVARCHAR(100) NULL,
	[BlogUrl] NVARCHAR(300) NOT NULL,
	[FeedUrl] NVARCHAR(300) NULL,
	[Order] INT NULL,
	[IsApproved] BIT NOT NULL,
	[CreationIp] NVARCHAR(50) NULL,
	[CreatedOn] DATETIMEOFFSET NOT NULL,
	[LastUpdateIp] NVARCHAR(50) NULL,
	[LastUpdatedOn] DATETIMEOFFSET NULL,
	CONSTRAINT [PK_BlogRolls] PRIMARY KEY ([Key])
);