CREATE TABLE [dbo].[enroll_schedule] (
	[id]          INT      IDENTITY (1, 1) NOT NULL,
	[section_id]  INT      NOT NULL,
	[employee_id] INT      NOT NULL,
	[subject_id]  INT      NOT NULL,
	[room_id]     INT      NOT NULL,
	[day_id]      INT      NOT NULL,
	[datestart]   DATETIME NOT NULL,
	[dateend]     DATETIME NOT NULL,
	[note] VARCHAR (100) NULL,
	PRIMARY KEY CLUSTERED ([id] ASC) WITH (ALLOW_PAGE_LOCKS = ON, ALLOW_ROW_LOCKS = ON, PAD_INDEX = OFF, IGNORE_DUP_KEY = OFF, STATISTICS_NORECOMPUTE = OFF)
);

