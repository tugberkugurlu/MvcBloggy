﻿
CREATE TABLE [dbo].[RestrictedPageNames] (
	[Id] UNIQUEIDENTIFIER NOT NULL DEFAULT NEWSEQUENTIALID(),
	[LanguageKey] UNIQUEIDENTIFIER NOT NULL,
	[Term] NVARCHAR(300) NOT NULL,
	[CreatedOn] DATETIMEOFFSET NULL,
	CONSTRAINT [PK_RestrictedPageNames] PRIMARY KEY ([Id])
);