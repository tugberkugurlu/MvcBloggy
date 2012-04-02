ALTER TABLE dbo.[DynamicPages]
	ADD CONSTRAINT [CC_DynamicPages_PageTitle]
	CHECK (dbo.[fn$CheckDynamicPageTitleValidity](PageTitle) = 0);

GO