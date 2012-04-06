ALTER TABLE [dbo].[BlogPosts]  
	ADD CONSTRAINT [FK_BlogPosts_Languages] 
	FOREIGN KEY([LanguageID])
	REFERENCES [dbo].[Languages] ([LanguageID])
	ON DELETE CASCADE
GO

ALTER TABLE [dbo].[BlogPosts] CHECK CONSTRAINT [FK_BlogPosts_Languages]
GO