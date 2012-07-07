CREATE TABLE [dbo].[sms_inbox_archive] (
    [archivedid]   INT           IDENTITY (1, 1) NOT NULL,
    [archiveddate] DATETIME      NULL,
    [id]           INT           NOT NULL,
    [number]       NVARCHAR (15) NOT NULL,
    [message]      NTEXT         NOT NULL,
    [datecreated]  DATETIME      NULL,
    [status_id]    INT           NOT NULL
);

