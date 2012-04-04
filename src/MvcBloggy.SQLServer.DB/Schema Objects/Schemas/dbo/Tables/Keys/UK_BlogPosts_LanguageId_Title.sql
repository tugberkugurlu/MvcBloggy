ALTER TABLE [dbo].[BlogPosts]
	ADD CONSTRAINT [UK_BlogPosts_BlogTitle]
	UNIQUE (LanguageId, Title);

GO