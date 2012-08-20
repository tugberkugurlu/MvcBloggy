ALTER TABLE [dbo].[TagsForBlogPosts]
	ADD CONSTRAINT [FK_TagsForBlogPosts_BlogPosts] 
	FOREIGN KEY([BlogPostKey])
	REFERENCES [dbo].[BlogPosts] ([Key])
	ON DELETE CASCADE
GO

ALTER TABLE [dbo].[TagsForBlogPosts] CHECK CONSTRAINT [FK_TagsForBlogPosts_BlogPosts]
GO