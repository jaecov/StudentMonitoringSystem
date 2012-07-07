CREATE TABLE [dbo].[audt_log] (
    [id]          INT           IDENTITY (1, 1) NOT NULL,
    [tablename]   NVARCHAR (50) NOT NULL,
    [rowid]       INT           NOT NULL,
    [command]     NVARCHAR (50) NOT NULL,
    [savedby]     NVARCHAR (50) NOT NULL,
    [datecreated] DATETIME      NULL
);

