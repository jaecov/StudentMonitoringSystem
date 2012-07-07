ALTER TABLE [dbo].[enroll_schedule]
    ADD CONSTRAINT [enroll_course_schedule] FOREIGN KEY ([course_id]) REFERENCES [dbo].[enroll_course] ([id]) ON DELETE NO ACTION ON UPDATE NO ACTION;

