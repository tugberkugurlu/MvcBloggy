ALTER TABLE [dbo].[DynamicPages]  
	ADD  CONSTRAINT [FK_DynamicPages_Languages] 
	FOREIGN KEY([LanguageID])
	REFERENCES [dbo].[Languages] ([LanguageID])
	ON DELETE CASCADE
GO

ALTER TABLE [dbo].[DynamicPages] CHECK CONSTRAINT [FK_DynamicPages_Languages]
GO