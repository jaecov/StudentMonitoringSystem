ALTER TABLE [dbo].[core_student]
    ADD CONSTRAINT [core_civilstatus_core_student] FOREIGN KEY ([civilstatus_id]) REFERENCES [dbo].[core_civilstatus] ([id]) ON DELETE NO ACTION ON UPDATE NO ACTION;

