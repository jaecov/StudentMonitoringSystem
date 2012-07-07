CREATE TABLE [dbo].[core_city] (
    [id]          INT            IDENTITY (1, 1) NOT NULL,
    [name]        NVARCHAR (100) NOT NULL,
    [province_id] INT            NOT NULL
);

