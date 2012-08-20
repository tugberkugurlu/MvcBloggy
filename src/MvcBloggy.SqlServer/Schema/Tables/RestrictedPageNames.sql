
CREATE TABLE [dbo].[RestrictedPageNames] (
	[Key] INT IDENTITY NOT NULL,
	[LanguageKey] INT NOT NULL,
	[Term] NVARCHAR(300) NOT NULL,
	[CreatedOn] DATETIMEOFFSET NULL,
	CONSTRAINT [PK_RestrictedPageNames] PRIMARY KEY ([Key])
);