CREATE TABLE [dbo].[core_guardian] (
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [varchar](100) NOT NULL,
	[address] [varchar](100) NULL,
	[relationship] [varchar](50) NOT NULL,
	[number] [varchar](15) NULL,
	[emailaddress] [varchar](100) NULL,
	[student_id] [int] NOT NULL,
	[note] [varchar](100) NULL,
    PRIMARY KEY CLUSTERED ([id] ASC) WITH (ALLOW_PAGE_LOCKS = ON, ALLOW_ROW_LOCKS = ON, PAD_INDEX = OFF, IGNORE_DUP_KEY = OFF, STATISTICS_NORECOMPUTE = OFF)
);
