ALTER TABLE [dbo].[core_city]
	ADD CONSTRAINT [core_city_core_province] FOREIGN KEY ([province_id]) 
	REFERENCES [dbo].[core_province] ([id]) ON DELETE NO ACTION ON UPDATE NO ACTION;

