ALTER TABLE [dbo].[BlogPostComments]  
	ADD  CONSTRAINT [FK_BlogPostComments_BlogPosts] 
	FOREIGN KEY([BlogPostId])
	REFERENCES [dbo].[BlogPosts] ([Id])
	ON DELETE CASCADE
GO

ALTER TABLE [dbo].[BlogPostComments] CHECK CONSTRAINT [FK_BlogPostComments_BlogPosts]
GO