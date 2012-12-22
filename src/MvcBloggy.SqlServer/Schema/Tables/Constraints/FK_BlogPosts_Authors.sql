ALTER TABLE [dbo].[BlogPosts]  
	ADD CONSTRAINT [FK_BlogPosts_Authors]
	FOREIGN KEY([AuthorKey])
	REFERENCES [dbo].[Authors] ([Key])
	ON DELETE CASCADE
GO

ALTER TABLE [dbo].[BlogPosts] CHECK CONSTRAINT [FK_BlogPosts_Authors]
GO