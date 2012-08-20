ALTER TABLE [dbo].[Languages]
	ADD CONSTRAINT [UK_Languages_Culture]
	UNIQUE (Culture)
GO
