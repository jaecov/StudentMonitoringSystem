﻿ALTER TABLE [dbo].[sms_inbox]
    ADD CONSTRAINT [sms_inbox_status] FOREIGN KEY ([status_id]) REFERENCES [dbo].[sms_status] ([id]) ON DELETE NO ACTION ON UPDATE NO ACTION;
