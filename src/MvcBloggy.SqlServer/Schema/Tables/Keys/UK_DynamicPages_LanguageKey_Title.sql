ALTER TABLE [dbo].[DynamicPages]
	ADD CONSTRAINT [UK_DynamicPages_LanguageKey_Title]
	UNIQUE (LanguageKey, Title);
GO