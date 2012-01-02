CREATE TABLE [dbo].[BlogPosts](
	[BlogPostId] int IDENTITY(1000,1) NOT NULL,
	[LanguageId] int NOT NULL,
	[BlogPostGUID] uniqueidentifier NOT NULL,
	[SecondaryID] int NULL,
	[BlogPostTitle] nvarchar(300) NULL,
	[BlogPostBriefInfo] nvarchar(200) NULL,
	[BlogPostContent] nvarchar(max) NULL,
	[BlogPostTags] nvarchar(500) NULL,
	[BlogPostImagePath] nvarchar(300) NULL,
	[CreationIp] nvarchar(50) NULL,
	[CreatedOn] datetimeoffset NULL,
	[LastUpdatedOn] datetimeoffset NULL,
	[IsApproved] bit NOT NULL,
	CONSTRAINT [PK_BlogPosts] PRIMARY KEY CLUSTERED (
		[BlogPostId] ASC
	) ON [PRIMARY]

) ON [PRIMARY]

GO