ALTER TABLE [dbo].[enroll_schedule]
	ADD CONSTRAINT [enroll_schedule_enroll_section] FOREIGN KEY ([section_id]) 
	REFERENCES [dbo].[enroll_section] ([id]) ON DELETE NO ACTION ON UPDATE NO ACTION;
go;
ALTER TABLE [dbo].[enroll_schedule]
	ADD CONSTRAINT [enroll_schedule_enroll_day] FOREIGN KEY ([day_id]) 
	REFERENCES [dbo].[core_day] ([id]) ON DELETE NO ACTION ON UPDATE NO ACTION;
go;
ALTER TABLE [dbo].[enroll_schedule]
	ADD CONSTRAINT [enroll_schedule_enroll_employee] FOREIGN KEY ([employee_id]) 
	REFERENCES [dbo].[emp_employee] ([id]) ON DELETE NO ACTION ON UPDATE NO ACTION;
go;
ALTER TABLE [dbo].[enroll_schedule]
	ADD CONSTRAINT [enroll_schedule_enroll_room] FOREIGN KEY ([room_id]) 
	REFERENCES [dbo].[enroll_room] ([id]) ON DELETE NO ACTION ON UPDATE NO ACTION;

go;
ALTER TABLE [dbo].[enroll_schedule]
	ADD CONSTRAINT [enroll_schedule_enroll_subject] FOREIGN KEY ([subject_id]) 
	REFERENCES [dbo].[enroll_subject] ([id]) ON DELETE NO ACTION ON UPDATE NO ACTION;


