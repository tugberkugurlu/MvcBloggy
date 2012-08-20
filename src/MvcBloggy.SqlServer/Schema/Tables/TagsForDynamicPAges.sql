CREATE TABLE [dbo].[TagsForDynamicPages] (
	[TagsForDynamicPageId] INT IDENTITY NOT NULL,
	[DynamicPageId] INT NOT NULL,
	[TagId] INT NOT NULL,
	CONSTRAINT [PK_TagsForDynamicPages] PRIMARY KEY ([TagsForDynamicPageId])
);