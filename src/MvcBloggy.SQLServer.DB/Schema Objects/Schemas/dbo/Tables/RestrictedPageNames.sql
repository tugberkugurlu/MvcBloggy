
CREATE TABLE [dbo].[RestrictedPageNames](
	[RestrictedPageNameId] INT IDENTITY(1000,1) NOT NULL,
	[LanguageId] INT NOT NULL,
	[RestrictedPageTerm] NVARCHAR(300) NULL,
	[CreatedOn] DATETIMEOFFSET NULL,
	CONSTRAINT [PK_RestrictedPageNames] PRIMARY KEY CLUSTERED  (
		[RestrictedPageNameId] ASC
	) ON [PRIMARY]

) ON [PRIMARY]

GO