CREATE TABLE [dbo].[enroll_section] (
    [id]        INT           NOT NULL,
    [name]      VARCHAR (100) NOT NULL,
    [course_id] INT           NOT NULL,
    PRIMARY KEY CLUSTERED ([id] ASC) WITH (ALLOW_PAGE_LOCKS = ON, ALLOW_ROW_LOCKS = ON, PAD_INDEX = OFF, IGNORE_DUP_KEY = OFF, STATISTICS_NORECOMPUTE = OFF)
);

