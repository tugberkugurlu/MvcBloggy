CREATE TABLE [dbo].[BlogPostComments] (
	[Key] INT IDENTITY NOT NULL,
	[BlogPostKey] INT NOT NULL,
	[BlogCommentGuid] UNIQUEIDENTIFIER NOT NULL,
	[Name] NVARCHAR(300) NOT NULL,
	[Email] NVARCHAR(300) NOT NULL,
	[WebSite] NVARCHAR(300) NULL,
	[AuthProvider] NVARCHAR(300) NULL,
	[IsAuthor] BIT NOT NULL,
	[Subject] NVARCHAR(300) NULL,
	[Content] NVARCHAR(MAX) NULL,
	[IsApproved] BIT NOT NULL,
	[CreationIp] NVARCHAR(50) NULL,
	[CreatedOn] DATETIMEOFFSET NOT NULL,
	[LastUpdateIp] NVARCHAR(50) NULL,
	[LastUpdatedOn] DATETIMEOFFSET NULL,
	CONSTRAINT [PK_BlogPostComments] PRIMARY KEY ([Key])
);