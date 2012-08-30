﻿CREATE TABLE [dbo].[core_student] (
    [id] [int] IDENTITY(1,1) NOT NULL,
	[number] [varchar](50) NOT NULL,
	[firstname] [varchar](50) NOT NULL,
	[middlename] [varchar](50) NOT NULL,
	[lastname] [varchar](50) NOT NULL,
	[dateofbirth] [date] NOT NULL,
	[picture] [varchar](1000) NULL,
	[gender_id] [int] NOT NULL,
	[civilstatus_id] [int] NOT NULL,
	[citizenship] [varchar](50) NOT NULL,
	[street] [varchar](100) NULL,
	[barangay_id] [int] NOT NULL,
	[mothername] [varchar](100) NULL,
	[motheroccupation] [varchar](100) NULL,
	[mothercontactnumber] [varchar](11) NULL,
	[motheraddress] [varchar](100) NULL,
	[fathername] [varchar](100) NULL,
	[fatheroccupation] [varchar](100) NULL,
	[fathercontactnumber] [varchar](11) NULL,
	[fatheraddress] [varchar](100) NULL,
	[note] [varchar](100) NULL,
	[current_enrolledyear_id] int NOT NULL DEFAULT(0)
    PRIMARY KEY CLUSTERED ([id] ASC) WITH (ALLOW_PAGE_LOCKS = ON, ALLOW_ROW_LOCKS = ON, PAD_INDEX = OFF, IGNORE_DUP_KEY = OFF, STATISTICS_NORECOMPUTE = OFF)
);

