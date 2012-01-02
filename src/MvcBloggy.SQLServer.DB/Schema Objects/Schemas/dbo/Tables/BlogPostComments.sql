CREATE TABLE [dbo].[BlogPostComments](
	[BlogCommentId] int IDENTITY(3000,1) NOT NULL,
	[BlogPostId] int NOT NULL,
	[CommenterName] nvarchar(300) NOT NULL,
	[CommenterEmail] nvarchar(300) NOT NULL,
	[CommenterWebSite] nvarchar(300) NULL,
	[CommenterAuthType] nvarchar(300) NULL,
	[IsAuthor] [bit] NOT NULL,
	[CommentSubject] nvarchar(300) NULL,
	[CommentContent] nvarchar(max) NULL,
	[CreatedOn] datetimeoffset NOT NULL,
	[CreationIp] nvarchar(50) NULL,
	[IsApproved] bit NOT NULL,
	CONSTRAINT [PK_BlogPostComments] PRIMARY KEY CLUSTERED (
		[BlogCommentId] ASC
	) ON [PRIMARY]

) ON [PRIMARY]

GO