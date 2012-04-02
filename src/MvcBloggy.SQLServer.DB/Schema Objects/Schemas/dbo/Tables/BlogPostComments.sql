CREATE TABLE [dbo].[BlogPostComments](
	[BlogCommentId] INT IDENTITY(3000,1) NOT NULL,
	[BlogPostId] INT NOT NULL,
	[CommenterName] NVARCHAR(300) NOT NULL,
	[CommenterEmail] NVARCHAR(300) NOT NULL,
	[CommenterWebSite] NVARCHAR(300) NULL,
	[CommenterAuthType] NVARCHAR(300) NULL,
	[IsAuthor] BIT NOT NULL,
	[CommentSubject] NVARCHAR(300) NULL,
	[CommentContent] NVARCHAR(max) NULL,
	[CreatedOn] DATETIMEOFFSET NOT NULL,
	[CreationIp] NVARCHAR(50) NULL,
	[IsApproved] BIT NOT NULL,
	CONSTRAINT [PK_BlogPostComments] PRIMARY KEY CLUSTERED (
		[BlogCommentId] ASC
	) ON [PRIMARY]

) ON [PRIMARY]

GO