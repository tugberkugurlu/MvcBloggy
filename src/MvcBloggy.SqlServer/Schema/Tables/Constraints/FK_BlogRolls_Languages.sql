ALTER TABLE [dbo].[BlogRolls]  
	ADD CONSTRAINT [FK_BlogRolls_Languages] 
	FOREIGN KEY([LanguageKey])
	REFERENCES [dbo].[Languages] ([Key])
	ON DELETE CASCADE
GO

ALTER TABLE [dbo].[BlogRolls] CHECK CONSTRAINT [FK_BlogRolls_Languages]
GO