CREATE TABLE [dbo].[BlogPosts] (

	[BlogPostId] INT IDENTITY NOT NULL,
	[LanguageId] INT NOT NULL,
	[SecondaryID] INT NULL,
	[Title] NVARCHAR(300) NOT NULL,
	[BriefInfo] NVARCHAR(200) NULL,
	[Content] NVARCHAR(max) NULL,
	[ImagePath] NVARCHAR(300) NULL,
	[IsApproved] BIT NOT NULL,
	[CreationIp] NVARCHAR(50) NULL,
	[CreatedOn] DATETIMEOFFSET NULL,
	[LastUpdatedOn] DATETIMEOFFSET NULL,
	CONSTRAINT [PK_BlogPosts] PRIMARY KEY ([BlogPostId])

)