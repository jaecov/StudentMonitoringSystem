ALTER TABLE [dbo].[core_student]
    ADD CONSTRAINT [core_gender_core_student] FOREIGN KEY ([gender_id]) REFERENCES [dbo].[core_gender] ([id]) ON DELETE NO ACTION ON UPDATE NO ACTION;

