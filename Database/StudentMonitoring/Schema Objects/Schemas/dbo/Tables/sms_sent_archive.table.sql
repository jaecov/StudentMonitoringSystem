CREATE TABLE [dbo].[sms_sent_archive] (
    [id]              INT          IDENTITY (1, 1) NOT NULL,
    [archiveddate]    DATETIME     NOT NULL,
    [sent_id]         INT          NOT NULL,
    [number]          VARCHAR (15) NOT NULL,
    [datecreated]     DATETIME     NOT NULL,
    [notification_id] INT          DEFAULT (NULL) NULL,
    PRIMARY KEY CLUSTERED ([id] ASC) WITH (ALLOW_PAGE_LOCKS = ON, ALLOW_ROW_LOCKS = ON, PAD_INDEX = OFF, IGNORE_DUP_KEY = OFF, STATISTICS_NORECOMPUTE = OFF)
);

