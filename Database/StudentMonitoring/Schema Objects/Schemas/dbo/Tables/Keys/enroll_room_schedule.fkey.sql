ALTER TABLE [dbo].[enroll_schedule]
    ADD CONSTRAINT [enroll_room_schedule] FOREIGN KEY ([room_id]) REFERENCES [dbo].[enroll_room] ([id]) ON DELETE NO ACTION ON UPDATE NO ACTION;

