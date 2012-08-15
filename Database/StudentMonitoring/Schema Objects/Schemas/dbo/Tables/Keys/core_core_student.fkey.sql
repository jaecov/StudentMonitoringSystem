ALTER TABLE [dbo].[core_student]
    ADD CONSTRAINT [core_student_core_barangay] FOREIGN KEY ([barangay_id]) 
	REFERENCES [dbo].[core_barangay] ([id]) ON DELETE NO ACTION ON UPDATE NO ACTION;

go;
ALTER TABLE [dbo].[core_student]
    ADD CONSTRAINT [core_student_core_gender] FOREIGN KEY ([gender_id]) 
	REFERENCES [dbo].[core_gender] ([id]) ON DELETE NO ACTION ON UPDATE NO ACTION;

go;
ALTER TABLE [dbo].[core_student]
	ADD CONSTRAINT [core_student_core_civilstatus] FOREIGN KEY ([civilstatus_id]) 
	REFERENCES [dbo].[core_civilstatus] ([id]) ON DELETE NO ACTION ON UPDATE NO ACTION;
go;



