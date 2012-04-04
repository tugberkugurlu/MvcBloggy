CREATE TABLE [dbo].[BlogPostComments] (

	[BlogCommentId] INT IDENTITY NOT NULL,
	[BlogPostId] INT NOT NULL,
	[CommenterName] NVARCHAR(300) NOT NULL,
	[CommenterEmail] NVARCHAR(300) NOT NULL,
	[CommenterWebSite] NVARCHAR(300) NULL,
	[CommenterAuthType] NVARCHAR(300) NULL,
	[IsAuthor] BIT NOT NULL,
	[Subject] NVARCHAR(300) NULL,
	[Content] NVARCHAR(MAX) NULL,
	[IsApproved] BIT NOT NULL,
	[CreatedOn] DATETIMEOFFSET NOT NULL,
	[CreationIp] NVARCHAR(50) NULL,
	CONSTRAINT [PK_BlogPostComments] PRIMARY KEY ([BlogCommentId])

)