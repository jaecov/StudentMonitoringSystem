CREATE TABLE [dbo].[audt_log] (
    [id]          INT          IDENTITY (1, 1) NOT NULL,
    [tablename]   VARCHAR (50) NOT NULL,
    [rowid]       INT          NOT NULL,
    [command]     VARCHAR (50) NOT NULL,
    [savedby]     VARCHAR (50) NOT NULL,
    [datecreated] DATETIME     NOT NULL,
    PRIMARY KEY CLUSTERED ([id] ASC) WITH (ALLOW_PAGE_LOCKS = ON, ALLOW_ROW_LOCKS = ON, PAD_INDEX = OFF, IGNORE_DUP_KEY = OFF, STATISTICS_NORECOMPUTE = OFF)
);

