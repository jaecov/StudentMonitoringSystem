ALTER TABLE [dbo].[enroll_section]
	ADD CONSTRAINT [enroll_section_enroll_level] FOREIGN KEY ([level_id]) 
	REFERENCES [dbo].[enroll_level] ([id]) ON DELETE NO ACTION ON UPDATE NO ACTION;
go;
ALTER TABLE [dbo].[enroll_section]
	ADD CONSTRAINT [enroll_section_enroll_course] FOREIGN KEY ([course_id]) 
	REFERENCES [dbo].[enroll_course] ([id]) ON DELETE NO ACTION ON UPDATE NO ACTION;
go;


