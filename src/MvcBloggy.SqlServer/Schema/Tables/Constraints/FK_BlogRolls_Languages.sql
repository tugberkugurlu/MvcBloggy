ALTER TABLE [dbo].[BlogRolls]  
	ADD CONSTRAINT [FK_BlogRolls_Languages] 
	FOREIGN KEY([LanguageID])
	REFERENCES [dbo].[Languages] ([LanguageID])
	ON DELETE CASCADE
GO

ALTER TABLE [dbo].[BlogRolls] CHECK CONSTRAINT [FK_BlogRolls_Languages]
GO