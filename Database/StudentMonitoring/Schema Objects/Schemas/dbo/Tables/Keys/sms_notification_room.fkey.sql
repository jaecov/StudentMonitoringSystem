ALTER TABLE [dbo].[sms_notification]
    ADD CONSTRAINT [sms_notification_room] FOREIGN KEY ([room_id]) REFERENCES [dbo].[enroll_room] ([id]) ON DELETE NO ACTION ON UPDATE NO ACTION;

