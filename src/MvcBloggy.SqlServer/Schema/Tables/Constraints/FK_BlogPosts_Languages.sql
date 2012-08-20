ALTER TABLE [dbo].[BlogPosts]  
	ADD CONSTRAINT [FK_BlogPosts_Languages] 
	FOREIGN KEY([LanguageKey])
	REFERENCES [dbo].[Languages] ([Key])
	ON DELETE CASCADE
GO

ALTER TABLE [dbo].[BlogPosts] CHECK CONSTRAINT [FK_BlogPosts_Languages]
GO