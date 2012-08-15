ALTER TABLE [dbo].[core_barangay]
	ADD CONSTRAINT [core_barangay_core_city] FOREIGN KEY ([city_id]) 
	REFERENCES [dbo].[core_city] ([id]) ON DELETE NO ACTION ON UPDATE NO ACTION;

