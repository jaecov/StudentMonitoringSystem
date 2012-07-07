CREATE TABLE [dbo].[sms_outbox] (
    [id]              INT           IDENTITY (1, 1) NOT NULL,
    [number]          NVARCHAR (15) NOT NULL,
    [message]         NTEXT         NOT NULL,
    [status_id]       INT           NOT NULL,
    [notification_id] INT           NULL
);

