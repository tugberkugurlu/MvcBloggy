CREATE TABLE [dbo].[Languages] (
	
	[LanguageID] int IDENTITY(1000,1) NOT NULL,
	[LanguageGUID] uniqueidentifier NOT NULL,
	[DisplayName] nvarchar (50) NULL,
	[LanguageCulture] nvarchar (10) NULL,
	[LanguageCultureOne] nvarchar (10) NULL,
	[LanguageOrder] int NULL,
	[IsApproved] bit NULL,
	[CreatedOn] datetime NULL,
	[LastUpdatedOn] datetime NULL,
	CONSTRAINT [PK_Languages] PRIMARY KEY CLUSTERED( 
		[LanguageID] ASC
	) ON [PRIMARY]

) ON [PRIMARY]

GO