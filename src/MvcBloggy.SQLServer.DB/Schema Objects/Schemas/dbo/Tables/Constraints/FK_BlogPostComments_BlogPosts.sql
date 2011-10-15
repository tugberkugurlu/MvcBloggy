ALTER TABLE [dbo].[BlogPostComments]  
	ADD  CONSTRAINT [FK_BlogPostComments_BlogPosts] 
	FOREIGN KEY([BlogPostID])
	REFERENCES [dbo].[BlogPosts] ([BlogPostID])
	ON DELETE CASCADE
GO

ALTER TABLE [dbo].[BlogPostComments] CHECK CONSTRAINT [FK_BlogPostComments_BlogPosts]
GO