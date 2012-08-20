CREATE TABLE [dbo].[DynamicPages] (
	[Key] INT IDENTITY NOT NULL,
	[LanguageKey] INT NOT NULL,
	[Title] NVARCHAR(500) NOT NULL,
	[BriefInfo] NVARCHAR(500) NOT NULL,
	[Content] NVARCHAR(max) NULL,
	[IsApproved] BIT NOT NULL,
	[CreationIp] NVARCHAR(50) NULL,
	[CreatedOn] DATETIMEOFFSET NOT NULL,
	[LastUpdateIp] NVARCHAR(50) NULL,
	[LastUpdatedOn] DATETIMEOFFSET NULL,
	CONSTRAINT [PK_DynamicPages] PRIMARY KEY ([Key])
)