CREATE TABLE [dbo].[core_contact] (
    [id]           INT           IDENTITY (1, 1) NOT NULL,
    [number]       VARCHAR (15)  DEFAULT (NULL) NULL,
    [emailaddress] VARCHAR (100) DEFAULT (NULL) NULL,
    [note]         VARCHAR (100) DEFAULT (NULL) NULL,
    [student_id]   INT           NOT NULL,
    PRIMARY KEY CLUSTERED ([id] ASC) WITH (ALLOW_PAGE_LOCKS = ON, ALLOW_ROW_LOCKS = ON, PAD_INDEX = OFF, IGNORE_DUP_KEY = OFF, STATISTICS_NORECOMPUTE = OFF)
);

