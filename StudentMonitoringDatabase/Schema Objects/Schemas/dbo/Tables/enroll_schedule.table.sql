CREATE TABLE [dbo].[enroll_schedule] (
    [id]          INT      IDENTITY (1, 1) NOT NULL,
    [course_id]   INT      NOT NULL,
    [section_id]  INT      NOT NULL,
    [employee_id] INT      NOT NULL,
    [subject_id]  INT      NOT NULL,
    [room_id]     INT      NOT NULL,
    [datestart]   DATETIME NULL,
    [dateend]     DATETIME NULL
);

