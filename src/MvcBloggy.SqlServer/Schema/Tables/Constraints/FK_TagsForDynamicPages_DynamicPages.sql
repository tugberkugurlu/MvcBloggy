ALTER TABLE [dbo].[TagsForDynamicPages]
	ADD CONSTRAINT [FK_TagsForDynamicPages_DynamicPages] 
	FOREIGN KEY([DynamicPageKey])
	REFERENCES [dbo].[DynamicPages] ([Key])
	ON DELETE CASCADE
GO

ALTER TABLE [dbo].[TagsForDynamicPages] CHECK CONSTRAINT [FK_TagsForDynamicPages_DynamicPages]
GO