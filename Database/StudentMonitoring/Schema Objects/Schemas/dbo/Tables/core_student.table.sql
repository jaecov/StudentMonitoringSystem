CREATE TABLE [dbo].[core_student] (
    [id]               INT            IDENTITY (1, 1) NOT NULL,
    [number]           VARCHAR (50)   NOT NULL,
    [firstname]        VARCHAR (50)   NOT NULL,
    [middlename]       VARCHAR (50)   NOT NULL,
    [lastname]         VARCHAR (50)   NOT NULL,
    [dateofbirth]      DATE           NOT NULL,
    [picture]          VARCHAR (1000) NULL,
    [gender_id]        INT            NOT NULL,
    [civilstatus_id]   INT            NOT NULL,
    [citizenship]      VARCHAR (50)   NOT NULL,
    [street]           VARCHAR (100)  DEFAULT (NULL) NULL,
    [barangay_id]      INT            NOT NULL,
    [mothername]       VARCHAR (100)  DEFAULT (NULL) NULL,
    [motheroccupation] VARCHAR (100)  DEFAULT (NULL) NULL,
    [fathername]       VARCHAR (100)  DEFAULT (NULL) NULL,
    [fatheroccupation] VARCHAR (100)  DEFAULT (NULL) NULL,
    [note]             VARCHAR (100)  DEFAULT (NULL) NULL,
    PRIMARY KEY CLUSTERED ([id] ASC) WITH (ALLOW_PAGE_LOCKS = ON, ALLOW_ROW_LOCKS = ON, PAD_INDEX = OFF, IGNORE_DUP_KEY = OFF, STATISTICS_NORECOMPUTE = OFF)
);

