﻿CREATE TABLE [dbo].[log_entrybook] (
    [id]         INT           IDENTITY (1, 1) NOT NULL,
    [rfid]       VARCHAR (100) NOT NULL,
    [timein]     DATETIME      NOT NULL,
    [timeout]    DATETIME      NOT NULL,
    [isoverride] BIT           NOT NULL,
    PRIMARY KEY CLUSTERED ([id] ASC) WITH (ALLOW_PAGE_LOCKS = ON, ALLOW_ROW_LOCKS = ON, PAD_INDEX = OFF, IGNORE_DUP_KEY = OFF, STATISTICS_NORECOMPUTE = OFF)
);

