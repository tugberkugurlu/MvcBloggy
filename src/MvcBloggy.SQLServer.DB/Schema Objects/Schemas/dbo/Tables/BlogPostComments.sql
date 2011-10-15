CREATE TABLE [dbo].[BlogPostComments](
	[BlogCommentID] [int] IDENTITY(3000,1) NOT NULL,
	[BlogPostID] [int] NOT NULL,
	[BlogCommentGUID] [uniqueidentifier] NULL,
	[CommenterName] [nvarchar](300) NULL,
	[CommenterEmail] [nvarchar](300) NULL,
	[CommenterWebSite] [nvarchar](300) NULL,
	[CommenterAuthType] [nvarchar](300) NULL,
	[IsAuthor] [bit] NULL,
	[CommentSubject] [nvarchar](300) NULL,
	[CommentContent] [nvarchar](max) NULL,
	[CreatedOn] [datetime] NULL,
	[CreationIp] [nvarchar](50) NULL,
	[IsApproved] [bit] NULL,
	CONSTRAINT [PK_BlogPostComments] PRIMARY KEY CLUSTERED (
		[BlogCommentID] ASC
	) ON [PRIMARY]

) ON [PRIMARY]

GO