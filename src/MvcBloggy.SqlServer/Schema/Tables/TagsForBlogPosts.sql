CREATE TABLE [dbo].[TagsForBlogPosts] (
	[Key] INT IDENTITY NOT NULL,
	[BlogPostKey] INT NOT NULL,
	[TagKey] INT NOT NULL,
	CONSTRAINT [PK_TagsForBlogPosts] PRIMARY KEY ([Key])
);