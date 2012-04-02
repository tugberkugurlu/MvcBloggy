CREATE TABLE [dbo].[Languages] (
	
	[LanguageId] INT IDENTITY(1000,1) NOT NULL,
	[DisplayName] NVARCHAR (50) NULL,
	[LanguageCulture] NVARCHAR (10) NULL,
	[LanguageCultureOne] NVARCHAR (10) NULL,
	[LanguageOrder] INT NULL,
	[IsApproved] BIT NULL,
	[CreatedOn] DATETIMEOFFSET NULL,
	CONSTRAINT [PK_Languages] PRIMARY KEY CLUSTERED( 
		[LanguageId] ASC
	) ON [PRIMARY]

) ON [PRIMARY]

GO