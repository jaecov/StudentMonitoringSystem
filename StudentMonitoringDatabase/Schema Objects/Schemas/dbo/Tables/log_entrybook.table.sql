CREATE TABLE [dbo].[log_entrybook] (
    [id]         INT            IDENTITY (1, 1) NOT NULL,
    [rfid]       NVARCHAR (100) NOT NULL,
    [timein]     DATETIME       NULL,
    [timeout]    DATETIME       NULL,
    [isoverride] BIT            DEFAULT ((0)) NOT NULL
);

