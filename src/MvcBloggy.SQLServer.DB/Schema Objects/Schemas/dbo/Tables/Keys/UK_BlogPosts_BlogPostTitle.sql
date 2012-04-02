ALTER TABLE [dbo].[BlogPosts]
	ADD CONSTRAINT [UK_BlogPosts_BlogTitle]
	UNIQUE (BlogPostTitle);

GO