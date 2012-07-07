CREATE TABLE [dbo].[core_contact] (
    [id]           INT            IDENTITY (1, 1) NOT NULL,
    [number]       NVARCHAR (15)  NULL,
    [emailaddress] NVARCHAR (100) NULL,
    [note]         NVARCHAR (100) NULL,
    [student_id]   INT            NOT NULL
);

