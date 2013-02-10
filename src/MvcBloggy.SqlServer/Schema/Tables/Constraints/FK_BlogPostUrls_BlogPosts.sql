ALTER TABLE [dbo].[BlogPostUrls]
	ADD CONSTRAINT [FK_BlogPostUrls_BlogPosts] 
	FOREIGN KEY([BlogPostId])
	REFERENCES [dbo].[BlogPosts] ([Id])
	ON DELETE CASCADE
GO

ALTER TABLE [dbo].[BlogPostUrls] CHECK CONSTRAINT [FK_BlogPostUrls_BlogPosts]
GO