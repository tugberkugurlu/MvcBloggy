CREATE TABLE [dbo].[BlogPostUrls] (
	[Key] INT IDENTITY NOT NULL,
	[BlogPostKey] INT NOT NULL,
	[UrlPortion] NVARCHAR(500) NOT NULL,
	[CreationIp] NVARCHAR(50) NULL,
	[CreatedOn] DATETIMEOFFSET NOT NULL,
	[LastUpdateIp] NVARCHAR(50) NULL,
	[LastUpdatedOn] DATETIMEOFFSET NULL,
    CONSTRAINT [PK_BlogPostUrls] PRIMARY KEY ([Key])
);