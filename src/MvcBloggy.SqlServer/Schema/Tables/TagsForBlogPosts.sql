CREATE TABLE [dbo].[TagsForBlogPosts] (
	[TagsForBlogPostId] INT IDENTITY NOT NULL,
	[BlogPostId] INT NOT NULL,
	[TagId] INT NOT NULL,
	CONSTRAINT [PK_TagsForBlogPosts] PRIMARY KEY ([TagsForBlogPostId])
);