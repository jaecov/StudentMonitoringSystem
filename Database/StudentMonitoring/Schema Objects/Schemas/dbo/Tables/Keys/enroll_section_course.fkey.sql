ALTER TABLE [dbo].[enroll_section]
    ADD CONSTRAINT [enroll_section_course] FOREIGN KEY ([course_id]) REFERENCES [dbo].[enroll_course] ([id]) ON DELETE NO ACTION ON UPDATE NO ACTION;

