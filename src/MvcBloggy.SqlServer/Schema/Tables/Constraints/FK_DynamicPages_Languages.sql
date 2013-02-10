ALTER TABLE [dbo].[DynamicPages]  
	ADD  CONSTRAINT [FK_DynamicPages_Languages] 
	FOREIGN KEY([LanguageId])
	REFERENCES [dbo].[Languages] ([Id])
	ON DELETE CASCADE
GO

ALTER TABLE [dbo].[DynamicPages] CHECK CONSTRAINT [FK_DynamicPages_Languages]
GO