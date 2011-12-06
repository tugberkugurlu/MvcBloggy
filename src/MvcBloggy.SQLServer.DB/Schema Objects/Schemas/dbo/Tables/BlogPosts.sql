CREATE TABLE [dbo].[BlogPosts](
	[BlogPostID] [int] IDENTITY(1000,1) NOT NULL,
	[LanguageID] [int] NOT NULL,
	[BlogPostGUID] [uniqueidentifier] NOT NULL,
	[SecondaryID] [int] NULL,
	[BlogPostTitle] [nvarchar](300) NULL,
	[BlogPostBriefInfo] [nvarchar](200) NULL,
	[BlogPostContent] [nvarchar](max) NULL,
	[BlogPostTags] [nvarchar](500) NULL,
	[BlogPostImagePath] [nvarchar](300) NULL,
	[CreationIp] [nvarchar](50) NULL,
	[CreatedOn] [datetime] NULL,
	[LastUpdatedOn] [datetime] NULL,
	[IsApproved] [bit] NOT NULL,
	CONSTRAINT [PK_BlogPosts] PRIMARY KEY CLUSTERED (
		[BlogPostID] ASC
	) ON [PRIMARY]

) ON [PRIMARY]

GO