ALTER TABLE [dbo].[BlogPosts]
	ADD CONSTRAINT [UK_BlogPosts_LanguageKey_Title]
	UNIQUE ([LanguageId], Title);
GO