CREATE TABLE [dbo].[core_user] (
    [id]        INT            IDENTITY (1, 1) NOT NULL,
    [username]  NVARCHAR (20)  NOT NULL,
    [password]  NVARCHAR (100) NOT NULL,
    [name]      NVARCHAR (100) NOT NULL,
    [isdeleted] BIT            DEFAULT ((0)) NOT NULL
);

