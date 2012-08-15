ALTER TABLE [dbo].[sms_outbox_archive]
	ADD CONSTRAINT [sms_outbox_archive_sms_status] FOREIGN KEY ([status_id]) 
	REFERENCES [dbo].[sms_status] ([id]) ON DELETE NO ACTION ON UPDATE NO ACTION;

