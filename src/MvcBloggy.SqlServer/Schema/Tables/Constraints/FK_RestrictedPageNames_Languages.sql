﻿ALTER TABLE [dbo].[RestrictedPageNames]  
	ADD  CONSTRAINT [FK_RestrictedPageNames_Languages] 
	FOREIGN KEY([LanguageKey])
	REFERENCES [dbo].[Languages] ([Id])
	ON DELETE CASCADE
GO

ALTER TABLE [dbo].[RestrictedPageNames] CHECK CONSTRAINT [FK_RestrictedPageNames_Languages]
GO