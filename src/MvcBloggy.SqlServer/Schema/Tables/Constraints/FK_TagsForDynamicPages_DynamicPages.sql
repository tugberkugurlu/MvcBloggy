ALTER TABLE [dbo].[TagsForDynamicPages]
	ADD CONSTRAINT [FK_TagsForDynamicPages_DynamicPages] 
	FOREIGN KEY([DynamicPageId])
	REFERENCES [dbo].[DynamicPages] ([DynamicPageId])
	ON DELETE CASCADE
GO

ALTER TABLE [dbo].[TagsForDynamicPages] CHECK CONSTRAINT [FK_TagsForDynamicPages_DynamicPages]
GO