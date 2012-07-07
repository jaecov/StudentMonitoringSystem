ALTER TABLE [dbo].[core_student]
    ADD CONSTRAINT [core_barangay_core_student] FOREIGN KEY ([barangay_id]) REFERENCES [dbo].[core_barangay] ([id]) ON DELETE NO ACTION ON UPDATE NO ACTION;

