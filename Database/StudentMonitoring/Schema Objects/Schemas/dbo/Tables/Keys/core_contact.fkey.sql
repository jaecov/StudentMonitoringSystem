ALTER TABLE [dbo].[core_contact]
	ADD CONSTRAINT [core_contact_core_student] FOREIGN KEY ([student_id]) 
	REFERENCES [dbo].[core_student] ([id]) ON DELETE NO ACTION ON UPDATE NO ACTION;

