CREATE TABLE [dbo].[sms_inbox_archive] (
    [archivedid]   INT            IDENTITY (1, 1) NOT NULL,
    [archiveddate] DATETIME       NOT NULL,
    [id]           INT            NOT NULL,
    [number]       VARCHAR (15)   NOT NULL,
    [message]      VARCHAR (1000) NOT NULL,
    [datecreated]  DATETIME       NOT NULL,
    [status_id]    INT            NOT NULL
);

