
CREATE TABLE [dbo].[RestrictedPageNames](
	[RestrictedPageNameId] int IDENTITY(1000,1) NOT NULL,
	[LanguageId] int NOT NULL,
	[RestrictedPageTerm] nvarchar(300) NULL,
	[CreatedOn] datetimeoffset NULL,
	CONSTRAINT [PK_RestrictedPageNames] PRIMARY KEY CLUSTERED  (
		[RestrictedPageNameId] ASC
	) ON [PRIMARY]

) ON [PRIMARY]

GO