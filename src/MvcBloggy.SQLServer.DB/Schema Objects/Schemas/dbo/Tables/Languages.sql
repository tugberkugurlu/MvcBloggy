CREATE TABLE [dbo].[Languages] (
	
	[LanguageId] int IDENTITY(1000,1) NOT NULL,
	[DisplayName] nvarchar (50) NULL,
	[LanguageCulture] nvarchar (10) NULL,
	[LanguageCultureOne] nvarchar (10) NULL,
	[LanguageOrder] int NULL,
	[IsApproved] bit NULL,
	[CreatedOn] datetimeoffset NULL,
	[LastUpdatedOn] datetimeoffset NULL,
	CONSTRAINT [PK_Languages] PRIMARY KEY CLUSTERED( 
		[LanguageId] ASC
	) ON [PRIMARY]

) ON [PRIMARY]

GO