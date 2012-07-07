ALTER TABLE [dbo].[enroll_schedule]
    ADD CONSTRAINT [enroll_employee_schedule] FOREIGN KEY ([employee_id]) REFERENCES [dbo].[emp_employee] ([id]) ON DELETE NO ACTION ON UPDATE NO ACTION;

