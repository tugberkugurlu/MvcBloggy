ALTER TABLE [dbo].[DynamicPages]  
	ADD  CONSTRAINT [FK_DynamicPages_Languages] 
	FOREIGN KEY([LanguageKey])
	REFERENCES [dbo].[Languages] ([Key])
	ON DELETE CASCADE
GO

ALTER TABLE [dbo].[DynamicPages] CHECK CONSTRAINT [FK_DynamicPages_Languages]
GO