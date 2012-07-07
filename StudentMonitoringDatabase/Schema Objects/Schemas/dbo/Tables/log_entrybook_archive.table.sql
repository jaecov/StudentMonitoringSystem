CREATE TABLE [dbo].[log_entrybook_archive] (
    [id]           INT            IDENTITY (1, 1) NOT NULL,
    [archiveddate] DATETIME       NULL,
    [entrybook_id] INT            NOT NULL,
    [rfid]         NVARCHAR (100) NOT NULL,
    [timein]       DATETIME       NULL,
    [timeout]      DATETIME       NULL,
    [isoverride]   BIT            DEFAULT ((0)) NOT NULL
);

