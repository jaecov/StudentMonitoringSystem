CREATE TABLE [dbo].[emp_employee] (
    [id]             INT           IDENTITY (1, 1) NOT NULL,
    [number]         VARCHAR (50)  NOT NULL,
    [firstname]      VARCHAR (50)  NOT NULL,
    [middlename]     VARCHAR (50)  NOT NULL,
    [lastname]       VARCHAR (50)  NOT NULL,
    [dateofbirth]    DATETIME      NOT NULL,
    [gender_id]      INT           NOT NULL,
    [civilstatus_id] INT           NOT NULL,
    [citizenship]    VARCHAR (100) NOT NULL,
    [barangay_id]    INT           NOT NULL,
    PRIMARY KEY CLUSTERED ([id] ASC) WITH (ALLOW_PAGE_LOCKS = ON, ALLOW_ROW_LOCKS = ON, PAD_INDEX = OFF, IGNORE_DUP_KEY = OFF, STATISTICS_NORECOMPUTE = OFF)
);

