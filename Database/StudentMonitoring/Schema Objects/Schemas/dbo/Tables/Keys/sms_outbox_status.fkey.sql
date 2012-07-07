ALTER TABLE [dbo].[sms_outbox]
    ADD CONSTRAINT [sms_outbox_status] FOREIGN KEY ([status_id]) REFERENCES [dbo].[sms_status] ([id]) ON DELETE NO ACTION ON UPDATE NO ACTION;

