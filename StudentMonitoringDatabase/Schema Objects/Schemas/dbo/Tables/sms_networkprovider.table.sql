CREATE TABLE [dbo].[sms_networkprovider] (
    [id]      INT            IDENTITY (1, 1) NOT NULL,
    [code]    NVARCHAR (4)   NOT NULL,
    [network] NVARCHAR (100) NOT NULL
);

