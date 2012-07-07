CREATE TABLE [dbo].[core_guardian] (
    [id]           INT           IDENTITY (1, 1) NOT NULL,
    [number]       VARCHAR (11)  DEFAULT (NULL) NULL,
    [emailaddress] VARCHAR (100) DEFAULT (NULL) NULL,
	[relationship] VARCHAR (50) NOT NULL,
    [student_id]   INT           NOT NULL,
	[note]         VARCHAR (100) DEFAULT (NULL) NULL,
    PRIMARY KEY CLUSTERED ([id] ASC) WITH (ALLOW_PAGE_LOCKS = ON, ALLOW_ROW_LOCKS = ON, PAD_INDEX = OFF, IGNORE_DUP_KEY = OFF, STATISTICS_NORECOMPUTE = OFF)
);
