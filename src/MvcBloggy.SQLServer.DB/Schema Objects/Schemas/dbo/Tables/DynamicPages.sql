CREATE TABLE [dbo].[DynamicPages](
	[DynamicPageId] INT IDENTITY(1000,1) NOT NULL,
	[LanguageId] INT NOT NULL,
	[PageTitle] NVARCHAR(500) NOT NULL,
	[PageBriefInfo] NVARCHAR(500) NOT NULL,
	[PageContent] NVARCHAR(max) NULL,
	[IsApproved] BIT NOT NULL,
	[CreatedOn] DATETIMEOFFSET NULL,
	[LastUpdatedOn] DATETIMEOFFSET NULL,
	CONSTRAINT [PK_DynamicPages] PRIMARY KEY CLUSTERED (
		[DynamicPageId] ASC
	) ON [PRIMARY]

) ON [PRIMARY]

GO