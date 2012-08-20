ALTER TABLE [dbo].[BlogPostUrls]
	ADD CONSTRAINT [UK_BlogPostUrls_UrlPortion]
	UNIQUE (UrlPortion)
GO