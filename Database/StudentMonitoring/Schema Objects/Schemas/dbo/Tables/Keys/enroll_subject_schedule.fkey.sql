ALTER TABLE [dbo].[enroll_schedule]
    ADD CONSTRAINT [enroll_subject_schedule] FOREIGN KEY ([subject_id]) REFERENCES [dbo].[enroll_subject] ([id]) ON DELETE NO ACTION ON UPDATE NO ACTION;

