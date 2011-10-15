ALTER TABLE [dbo].[RestrictedPageNames]  
	ADD  CONSTRAINT [FK_RestrictedPageNames_Languages] 
	FOREIGN KEY([LanguageID])
	REFERENCES [dbo].[Languages] ([LanguageID])
	ON DELETE CASCADE
GO

ALTER TABLE [dbo].[RestrictedPageNames] CHECK CONSTRAINT [FK_RestrictedPageNames_Languages]
GO