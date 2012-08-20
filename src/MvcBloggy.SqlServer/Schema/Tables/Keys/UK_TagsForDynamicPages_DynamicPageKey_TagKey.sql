ALTER TABLE [dbo].[TagsForDynamicPages]
	ADD CONSTRAINT [UK_TagsForDynamicPages_DynamicPageKey_TagKey]
	UNIQUE (DynamicPageKey, TagKey)
GO