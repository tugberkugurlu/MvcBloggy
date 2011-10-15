
CREATE TABLE [dbo].[RestrictedPageNames](
	[RestrictedPageNameID] [int] IDENTITY(1000,1) NOT NULL,
	[LanguageID] [int] NOT NULL,
	[RestrictedPageNameGUID] [uniqueidentifier] NOT NULL,
	[RestrictedPageTerm] [nvarchar](300) NULL,
	[CreatedOn] [datetime] NULL,
	CONSTRAINT [PK_RestrictedPageNames] PRIMARY KEY CLUSTERED  (
		[RestrictedPageNameID] ASC
	) ON [PRIMARY]

) ON [PRIMARY]

GO