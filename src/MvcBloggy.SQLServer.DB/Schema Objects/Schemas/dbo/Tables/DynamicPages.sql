CREATE TABLE [dbo].[DynamicPages](
	[DynamicPageID] [int] IDENTITY(1000,1) NOT NULL,
	[LanguageID] [int] NOT NULL,
	[DynamicPageGUID] [uniqueidentifier] NOT NULL,
	[PageTitle] [nvarchar](500) NULL,
	[PageBriefInfo] [nvarchar](500) NULL,
	[PageContent] [nvarchar](max) NULL,
	[PageTags] [nvarchar](1000) NULL,
	[PageUrlPortion] [nvarchar](300) NULL,
	[IsApproved] [bit] NULL,
	[CreatedOn] [datetime] NULL,
	[LastUpdatedOn] [datetime] NULL,
	CONSTRAINT [PK_DynamicPages] PRIMARY KEY CLUSTERED (
		[DynamicPageID] ASC
	) ON [PRIMARY]

) ON [PRIMARY]

GO