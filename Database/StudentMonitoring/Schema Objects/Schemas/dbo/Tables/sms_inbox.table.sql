CREATE TABLE [dbo].[sms_inbox] (
    [id]          INT            NOT NULL,
    [number]      VARCHAR (15)   NOT NULL,
    [message]     VARCHAR (1000) NOT NULL,
    [datecreated] DATETIME       NOT NULL,
    [status_id]   INT            NOT NULL,
    PRIMARY KEY CLUSTERED ([id] ASC) WITH (ALLOW_PAGE_LOCKS = ON, ALLOW_ROW_LOCKS = ON, PAD_INDEX = OFF, IGNORE_DUP_KEY = OFF, STATISTICS_NORECOMPUTE = OFF)
);

