ALTER TABLE [dbo].[BlogPosts]
	ADD CONSTRAINT [UK_BlogPosts_LanguageKey_Title]
	UNIQUE (LanguageKey, Title);
GO