ALTER TABLE [dbo].[Languages]
	ADD CONSTRAINT [UK_Languages_CultureOne]
	UNIQUE (CultureOne)
GO
