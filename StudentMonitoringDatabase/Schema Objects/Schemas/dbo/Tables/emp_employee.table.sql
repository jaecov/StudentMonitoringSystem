CREATE TABLE [dbo].[emp_employee] (
    [id]             INT            IDENTITY (1, 1) NOT NULL,
    [number]         NVARCHAR (50)  NOT NULL,
    [rfid]           NVARCHAR (100) NULL,
    [firstname]      NVARCHAR (50)  NOT NULL,
    [middlename]     NVARCHAR (50)  NOT NULL,
    [lastname]       NVARCHAR (50)  NOT NULL,
    [dateofbirth]    DATETIME       NULL,
    [gender_id]      INT            NOT NULL,
    [civilstatus_id] INT            NOT NULL,
    [citizenship]    NVARCHAR (100) NOT NULL,
    [barangay_id]    INT            NOT NULL
);

