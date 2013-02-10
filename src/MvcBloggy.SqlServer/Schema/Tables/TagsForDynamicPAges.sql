﻿CREATE TABLE [dbo].[TagsForDynamicPages] (
	[Id] UNIQUEIDENTIFIER NOT NULL DEFAULT NEWSEQUENTIALID(),
	[DynamicPageId] UNIQUEIDENTIFIER NOT NULL,
	[TagId] UNIQUEIDENTIFIER NOT NULL,
	CONSTRAINT [PK_TagsForDynamicPages] PRIMARY KEY ([Id])
);