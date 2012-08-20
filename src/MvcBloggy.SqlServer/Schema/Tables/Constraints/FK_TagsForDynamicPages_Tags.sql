ALTER TABLE [dbo].[TagsForDynamicPages]
	ADD CONSTRAINT [FK_TagsForDynamicPages_Tags] 
	FOREIGN KEY([TagKey])
	REFERENCES [dbo].[Tags] ([Key])
	--NOTE: Specify ON DELETE NO ACTION 
	--      or ON UPDATE NO ACTION, or modify other FOREIGN KEY constraints.
	--ON DELETE CASCADE
GO

ALTER TABLE [dbo].[TagsForDynamicPages] CHECK CONSTRAINT [FK_TagsForDynamicPages_Tags]
GO