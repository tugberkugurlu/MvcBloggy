ALTER TABLE [dbo].[BlogPostComments]  
	ADD  CONSTRAINT [FK_BlogPostComments_BlogPosts] 
	FOREIGN KEY([BlogPostKey])
	REFERENCES [dbo].[BlogPosts] ([Key])
	ON DELETE CASCADE
GO

ALTER TABLE [dbo].[BlogPostComments] CHECK CONSTRAINT [FK_BlogPostComments_BlogPosts]
GO