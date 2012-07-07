﻿CREATE TABLE [dbo].[sms_notification] (
    [id]          INT            IDENTITY (1, 1) NOT NULL,
    [number]      VARCHAR (15)   NOT NULL,
    [message]     VARCHAR (1000) NOT NULL,
    [remarks]     VARCHAR (100)  DEFAULT (NULL) NULL,
    [room_id]     INT            NOT NULL,
    [datecreated] DATETIME       NOT NULL,
    PRIMARY KEY CLUSTERED ([id] ASC) WITH (ALLOW_PAGE_LOCKS = ON, ALLOW_ROW_LOCKS = ON, PAD_INDEX = OFF, IGNORE_DUP_KEY = OFF, STATISTICS_NORECOMPUTE = OFF)
);

