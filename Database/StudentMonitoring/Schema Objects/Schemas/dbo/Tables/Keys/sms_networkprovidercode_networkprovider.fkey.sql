ALTER TABLE [dbo].[sms_networkprovidercode]
    ADD CONSTRAINT [sms_networkcode_networkprovider] FOREIGN KEY ([networkprovider_id]) REFERENCES [dbo].[sms_networkprovider] ([id]) ON DELETE NO ACTION ON UPDATE NO ACTION;

