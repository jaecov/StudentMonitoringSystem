CREATE TABLE [dbo].[sms_outbox_archive] (
    [id]              INT           NOT NULL,
    [archiveddate]    DATETIME      NULL,
    [outbox_id]       INT           NOT NULL,
    [number]          NVARCHAR (15) NOT NULL,
    [message]         NTEXT         NOT NULL,
    [status_id]       INT           NOT NULL,
    [notification_id] INT           NULL
);

