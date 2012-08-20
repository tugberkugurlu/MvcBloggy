
CREATE TABLE [dbo].[RestrictedPageNames] (
	[RestrictedPageNameId] INT IDENTITY NOT NULL,
	[LanguageId] INT NOT NULL,
	[Term] NVARCHAR(300) NOT NULL,
	[CreatedOn] DATETIMEOFFSET NULL,
	CONSTRAINT [PK_RestrictedPageNames] PRIMARY KEY ([RestrictedPageNameId])
);