ALTER TABLE [dbo].[emp_contact]
    ADD CONSTRAINT [emp_contact_employee] FOREIGN KEY ([employee_id]) REFERENCES [dbo].[emp_employee] ([id]) ON DELETE NO ACTION ON UPDATE NO ACTION;

