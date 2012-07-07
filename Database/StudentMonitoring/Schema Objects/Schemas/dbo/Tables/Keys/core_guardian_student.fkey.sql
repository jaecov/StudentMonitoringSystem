ALTER TABLE [dbo].[core_guardian]
    ADD CONSTRAINT [core_guardian_student] FOREIGN KEY ([student_id]) REFERENCES [dbo].[core_student] ([id]) ON DELETE NO ACTION ON UPDATE NO ACTION;

