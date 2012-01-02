ALTER TABLE [dbo].[DynamicPages]
	ADD CONSTRAINT [UK_DynamicPages_PageTitle]
	UNIQUE (LanguageId, PageTitle);

GO