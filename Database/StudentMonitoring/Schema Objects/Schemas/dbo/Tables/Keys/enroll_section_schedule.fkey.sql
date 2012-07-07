ALTER TABLE [dbo].[enroll_schedule]
    ADD CONSTRAINT [enroll_section_schedule] FOREIGN KEY ([section_id]) REFERENCES [dbo].[enroll_section] ([id]) ON DELETE NO ACTION ON UPDATE NO ACTION;

