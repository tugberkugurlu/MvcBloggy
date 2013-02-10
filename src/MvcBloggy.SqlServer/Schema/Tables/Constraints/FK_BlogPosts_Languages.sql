ALTER TABLE [dbo].[BlogPosts]  
	ADD CONSTRAINT [FK_BlogPosts_Languages] 
	FOREIGN KEY([LanguageId])
	REFERENCES [dbo].[Languages] ([Id])
	ON DELETE CASCADE
GO

ALTER TABLE [dbo].[BlogPosts] CHECK CONSTRAINT [FK_BlogPosts_Languages]
GO