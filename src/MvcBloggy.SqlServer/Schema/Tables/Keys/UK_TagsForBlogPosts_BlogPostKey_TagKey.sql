ALTER TABLE [dbo].[TagsForBlogPosts]
	ADD CONSTRAINT [UK_TagsForBlogPosts_BlogPostKey_TagKey]
	UNIQUE (BlogPostKey, TagKey)
GO
