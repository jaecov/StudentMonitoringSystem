CREATE TABLE [dbo].[sms_sent] (
    [id]              INT            NOT NULL,
    [number]          NVARCHAR (15)  NOT NULL,
    [message]         NVARCHAR (700) NOT NULL,
    [datecreated]     DATETIME       NULL,
    [notification_id] INT            NULL
);

