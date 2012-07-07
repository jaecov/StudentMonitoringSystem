CREATE TABLE [dbo].[core_student] (
    [id]               INT            IDENTITY (1, 1) NOT NULL,
    [number]           NVARCHAR (50)  NOT NULL,
    [rfid]             NVARCHAR (100) NULL,
    [firstname]        NVARCHAR (50)  NOT NULL,
    [middlename]       NVARCHAR (50)  NOT NULL,
    [lastname]         NVARCHAR (50)  NOT NULL,
    [dateofbirth]      DATE           NULL,
    [picture]          IMAGE          NULL,
    [gender_id]        INT            NOT NULL,
    [civilstatus_id]   INT            NOT NULL,
    [citizenship]      NVARCHAR (50)  NOT NULL,
    [street]           NVARCHAR (100) NULL,
    [barangay_id]      INT            NOT NULL,
    [mothername]       NVARCHAR (100) NULL,
    [motheroccupation] NVARCHAR (100) NULL,
    [fathername]       NVARCHAR (100) NULL,
    [fatheroccupation] NVARCHAR (100) NULL,
    [note]             NVARCHAR (100) NULL
);

