CREATE TABLE [dbo].[TagsForDynamicPages] (
	[Key] INT IDENTITY NOT NULL,
	[DynamicPageKey] INT NOT NULL,
	[TagKey] INT NOT NULL,
	CONSTRAINT [PK_TagsForDynamicPages] PRIMARY KEY ([Key])
);