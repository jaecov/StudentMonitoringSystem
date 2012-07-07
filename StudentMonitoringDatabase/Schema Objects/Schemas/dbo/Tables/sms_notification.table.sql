CREATE TABLE [dbo].[sms_notification] (
    [id]          INT            IDENTITY (1, 1) NOT NULL,
    [number]      NVARCHAR (15)  NOT NULL,
    [message]     NTEXT          NOT NULL,
    [remarks]     NVARCHAR (100) NULL,
    [room_id]     INT            NOT NULL,
    [datecreated] DATETIME       NULL
);

