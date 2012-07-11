﻿CREATE TABLE [dbo].[core_gender] (
    [id]   INT    identity   NOT NULL,
    [name] VARCHAR (10) NOT NULL,
    PRIMARY KEY CLUSTERED ([id] ASC) WITH (ALLOW_PAGE_LOCKS = ON, ALLOW_ROW_LOCKS = ON, PAD_INDEX = OFF, IGNORE_DUP_KEY = OFF, STATISTICS_NORECOMPUTE = OFF)
);
