ALTER TABLE [dbo].[Tags]  
	ADD CONSTRAINT [FK_Tags_Languages] 
	FOREIGN KEY([LanguageID])
	REFERENCES [dbo].[Languages] ([LanguageID])
	ON DELETE CASCADE
GO

ALTER TABLE [dbo].[Tags] CHECK CONSTRAINT [FK_Tags_Languages]
GO