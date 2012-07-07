CREATE TABLE [dbo].[core_user] (
    [id]        INT           IDENTITY (1, 1) NOT NULL,
    [username]  VARCHAR (20)  NOT NULL,
    [password]  VARCHAR (100) NOT NULL,
    [name]      VARCHAR (100) NOT NULL,
    [isdeleted] BIT           NOT NULL,
    PRIMARY KEY CLUSTERED ([id] ASC) WITH (ALLOW_PAGE_LOCKS = ON, ALLOW_ROW_LOCKS = ON, PAD_INDEX = OFF, IGNORE_DUP_KEY = OFF, STATISTICS_NORECOMPUTE = OFF)
);

