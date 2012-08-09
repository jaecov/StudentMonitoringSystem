ALTER TABLE [dbo].[enroll_schedule]
    ADD CONSTRAINT [enroll_day_schedule] FOREIGN KEY ([day_id]) REFERENCES [dbo].[core_day] ([id]) ON DELETE NO ACTION ON UPDATE NO ACTION;

