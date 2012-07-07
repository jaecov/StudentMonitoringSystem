CREATE TABLE [dbo].[sms_inbox] (
    [id]          INT           NOT NULL,
    [number]      NVARCHAR (15) NOT NULL,
    [message]     NTEXT         NOT NULL,
    [datecreated] DATETIME      NULL,
    [status_id]   INT           NOT NULL
);

