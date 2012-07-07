CREATE TABLE [dbo].[sms_sent_archive] (
    [id]              INT           IDENTITY (1, 1) NOT NULL,
    [archiveddate]    DATETIME      NULL,
    [sent_id]         INT           NOT NULL,
    [number]          NVARCHAR (15) NOT NULL,
    [datecreated]     DATETIME      NULL,
    [notification_id] INT           NULL
);

