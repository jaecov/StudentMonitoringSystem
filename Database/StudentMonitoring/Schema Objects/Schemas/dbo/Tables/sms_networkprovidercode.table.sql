CREATE TABLE [dbo].[sms_networkprovidercode] (
    [id]         INT         IDENTITY (1, 1) NOT NULL,
    [name]       VARCHAR (4) NOT NULL,
    [networkprovider_id] INT         NOT NULL,
    PRIMARY KEY CLUSTERED ([id] ASC) WITH (ALLOW_PAGE_LOCKS = ON, ALLOW_ROW_LOCKS = ON, PAD_INDEX = OFF, IGNORE_DUP_KEY = OFF, STATISTICS_NORECOMPUTE = OFF)
);

