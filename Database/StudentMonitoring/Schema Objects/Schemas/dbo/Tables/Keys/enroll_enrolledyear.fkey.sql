ALTER TABLE [dbo].[enroll_enrolledyear]
	ADD CONSTRAINT [enroll_enrolledyear_enroll_schoolyear] FOREIGN KEY ([schoolyear_id]) 
	REFERENCES [dbo].[enroll_schoolyear] ([id]) ON DELETE NO ACTION ON UPDATE NO ACTION;
go;
ALTER TABLE [dbo].[enroll_enrolledyear]
	ADD CONSTRAINT [enroll_enrolledyear_enroll_semester] FOREIGN KEY ([semester_id]) 
	REFERENCES [dbo].[enroll_semester] ([id]) ON DELETE NO ACTION ON UPDATE NO ACTION;
go;
ALTER TABLE [dbo].[enroll_enrolledyear]
	ADD CONSTRAINT [enroll_enrolledyear_enroll_course] FOREIGN KEY ([course_id]) 
	REFERENCES [dbo].[enroll_course] ([id]) ON DELETE NO ACTION ON UPDATE NO ACTION;
go;
ALTER TABLE [dbo].[enroll_enrolledyear]
	ADD CONSTRAINT [enroll_enrolledyear_enroll_level] FOREIGN KEY ([level_id]) 
	REFERENCES [dbo].[enroll_level] ([id]) ON DELETE NO ACTION ON UPDATE NO ACTION;	

go;
ALTER TABLE [dbo].[enroll_enrolledyear]
	ADD CONSTRAINT [enroll_enrolledyear_enroll_section] FOREIGN KEY ([section_id]) 
	REFERENCES [dbo].[enroll_section] ([id]) ON DELETE NO ACTION ON UPDATE NO ACTION;

