ALTER TABLE [dbo].[sms_inbox_archive]
	ADD CONSTRAINT [sms_inbox_archive_sms_status] FOREIGN KEY ([status_id]) 
	REFERENCES [dbo].[sms_status] ([id]) ON DELETE NO ACTION ON UPDATE NO ACTION;

