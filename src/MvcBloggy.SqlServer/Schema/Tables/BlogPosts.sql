CREATE TABLE [dbo].[BlogPosts] (
	[Key] INT IDENTITY NOT NULL,
	[LanguageKey] INT NOT NULL,
	[SecondaryKey] INT NULL,
	[BlogPostGuid] UNIQUEIDENTIFIER NOT NULL,
	[Title] NVARCHAR(300) NOT NULL,
	[BriefInfo] NVARCHAR(200) NULL,
	[Content] NVARCHAR(MAX) NOT NULL,
	[ImagePath] NVARCHAR(300) NULL,
	[IsApproved] BIT NOT NULL,
	[CreationIp] NVARCHAR(50) NULL,
	[CreatedOn] DATETIMEOFFSET NOT NULL,
	[LastUpdateIp] NVARCHAR(50) NULL,
	[LastUpdatedOn] DATETIMEOFFSET NULL,
    CONSTRAINT [PK_BlogPosts] PRIMARY KEY ([Key])
);