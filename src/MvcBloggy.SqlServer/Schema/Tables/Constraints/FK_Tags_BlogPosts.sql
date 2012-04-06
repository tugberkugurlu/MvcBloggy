ALTER TABLE [dbo].[Tags]  
	ADD  CONSTRAINT [FK_Tags_BlogPosts] 
	FOREIGN KEY([BlogPostID])
	REFERENCES [dbo].[BlogPosts] ([BlogPostID])
	ON DELETE CASCADE
GO

ALTER TABLE [dbo].[Tags] CHECK CONSTRAINT [FK_Tags_BlogPosts]
GO