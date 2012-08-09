/*
Deployment script for StudentMonitoring
*/

GO
SET ANSI_NULLS, ANSI_PADDING, ANSI_WARNINGS, ARITHABORT, CONCAT_NULL_YIELDS_NULL, QUOTED_IDENTIFIER ON;

SET NUMERIC_ROUNDABORT OFF;


GO
:setvar DatabaseName "StudentMonitoring"
:setvar DefaultDataPath "C:\Program Files\Microsoft SQL Server\MSSQL10_50.SQL2K8R2\MSSQL\DATA\"
:setvar DefaultLogPath "C:\Program Files\Microsoft SQL Server\MSSQL10_50.SQL2K8R2\MSSQL\DATA\"

GO
USE [master]

GO
:on error exit
GO
IF (DB_ID(N'$(DatabaseName)') IS NOT NULL
    AND DATABASEPROPERTYEX(N'$(DatabaseName)','Status') <> N'ONLINE')
BEGIN
    RAISERROR(N'The state of the target database, %s, is not set to ONLINE. To deploy to this database, its state must be set to ONLINE.', 16, 127,N'$(DatabaseName)') WITH NOWAIT
    RETURN
END

GO
IF (DB_ID(N'$(DatabaseName)') IS NOT NULL) 
BEGIN
    ALTER DATABASE [$(DatabaseName)]
    SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
    DROP DATABASE [$(DatabaseName)];
END

GO
PRINT N'Creating $(DatabaseName)...'
GO
CREATE DATABASE [$(DatabaseName)]
    ON 
    PRIMARY(NAME = [StudentMonitoringDb], FILENAME = '$(DefaultDataPath)$(DatabaseName).mdf', FILEGROWTH = 1024 KB)
    LOG ON (NAME = [StudentMonitoringDb_log], FILENAME = '$(DefaultLogPath)$(DatabaseName)_log.LDF', MAXSIZE = 2097152 MB, FILEGROWTH = 10 %) COLLATE SQL_Latin1_General_CP1_CI_AS
GO
EXECUTE sp_dbcmptlevel [$(DatabaseName)], 100;


GO
IF EXISTS (SELECT 1
           FROM   [master].[dbo].[sysdatabases]
           WHERE  [name] = N'$(DatabaseName)')
    BEGIN
        ALTER DATABASE [$(DatabaseName)]
            SET ANSI_NULLS ON,
                ANSI_PADDING ON,
                ANSI_WARNINGS ON,
                ARITHABORT ON,
                CONCAT_NULL_YIELDS_NULL ON,
                NUMERIC_ROUNDABORT OFF,
                QUOTED_IDENTIFIER ON,
                ANSI_NULL_DEFAULT ON,
                CURSOR_DEFAULT LOCAL,
                RECOVERY FULL,
                CURSOR_CLOSE_ON_COMMIT OFF,
                AUTO_CREATE_STATISTICS ON,
                AUTO_SHRINK OFF,
                AUTO_UPDATE_STATISTICS ON,
                RECURSIVE_TRIGGERS OFF 
            WITH ROLLBACK IMMEDIATE;
        ALTER DATABASE [$(DatabaseName)]
            SET AUTO_CLOSE OFF 
            WITH ROLLBACK IMMEDIATE;
    END


GO
IF EXISTS (SELECT 1
           FROM   [master].[dbo].[sysdatabases]
           WHERE  [name] = N'$(DatabaseName)')
    BEGIN
        ALTER DATABASE [$(DatabaseName)]
            SET ALLOW_SNAPSHOT_ISOLATION OFF;
    END


GO
IF EXISTS (SELECT 1
           FROM   [master].[dbo].[sysdatabases]
           WHERE  [name] = N'$(DatabaseName)')
    BEGIN
        ALTER DATABASE [$(DatabaseName)]
            SET READ_COMMITTED_SNAPSHOT OFF;
    END


GO
IF EXISTS (SELECT 1
           FROM   [master].[dbo].[sysdatabases]
           WHERE  [name] = N'$(DatabaseName)')
    BEGIN
        ALTER DATABASE [$(DatabaseName)]
            SET AUTO_UPDATE_STATISTICS_ASYNC OFF,
                PAGE_VERIFY NONE,
                DATE_CORRELATION_OPTIMIZATION OFF,
                DISABLE_BROKER,
                PARAMETERIZATION SIMPLE,
                SUPPLEMENTAL_LOGGING OFF 
            WITH ROLLBACK IMMEDIATE;
    END


GO
IF IS_SRVROLEMEMBER(N'sysadmin') = 1
    BEGIN
        IF EXISTS (SELECT 1
                   FROM   [master].[dbo].[sysdatabases]
                   WHERE  [name] = N'$(DatabaseName)')
            BEGIN
                EXECUTE sp_executesql N'ALTER DATABASE [$(DatabaseName)]
    SET TRUSTWORTHY OFF,
        DB_CHAINING OFF 
    WITH ROLLBACK IMMEDIATE';
            END
    END
ELSE
    BEGIN
        PRINT N'The database settings cannot be modified. You must be a SysAdmin to apply these settings.';
    END


GO
IF IS_SRVROLEMEMBER(N'sysadmin') = 1
    BEGIN
        IF EXISTS (SELECT 1
                   FROM   [master].[dbo].[sysdatabases]
                   WHERE  [name] = N'$(DatabaseName)')
            BEGIN
                EXECUTE sp_executesql N'ALTER DATABASE [$(DatabaseName)]
    SET HONOR_BROKER_PRIORITY OFF 
    WITH ROLLBACK IMMEDIATE';
            END
    END
ELSE
    BEGIN
        PRINT N'The database settings cannot be modified. You must be a SysAdmin to apply these settings.';
    END


GO
USE [$(DatabaseName)]

GO
IF fulltextserviceproperty(N'IsFulltextInstalled') = 1
    EXECUTE sp_fulltext_database 'enable';


GO
/*
 Pre-Deployment Script Template							
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be executed before the build script.	
 Use SQLCMD syntax to include a file in the pre-deployment script.			
 Example:      :r .\myfile.sql								
 Use SQLCMD syntax to reference a variable in the pre-deployment script.		
 Example:      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/

GO
PRINT N'Creating [dbo].[audt_audittrail]...';


GO
CREATE TABLE [dbo].[audt_audittrail] (
    [id]          INT            IDENTITY (1, 1) NOT NULL,
    [message]     VARCHAR (1000) NOT NULL,
    [isexception] BIT            NOT NULL,
    [datecreated] DATETIME       NOT NULL,
    PRIMARY KEY CLUSTERED ([id] ASC) WITH (ALLOW_PAGE_LOCKS = ON, ALLOW_ROW_LOCKS = ON, PAD_INDEX = OFF, IGNORE_DUP_KEY = OFF, STATISTICS_NORECOMPUTE = OFF)
);


GO
PRINT N'Creating [dbo].[audt_log]...';


GO
CREATE TABLE [dbo].[audt_log] (
    [id]          INT          IDENTITY (1, 1) NOT NULL,
    [tablename]   VARCHAR (50) NOT NULL,
    [rowid]       INT          NOT NULL,
    [command]     VARCHAR (50) NOT NULL,
    [savedby]     VARCHAR (50) NOT NULL,
    [datecreated] DATETIME     NOT NULL,
    PRIMARY KEY CLUSTERED ([id] ASC) WITH (ALLOW_PAGE_LOCKS = ON, ALLOW_ROW_LOCKS = ON, PAD_INDEX = OFF, IGNORE_DUP_KEY = OFF, STATISTICS_NORECOMPUTE = OFF)
);


GO
PRINT N'Creating [dbo].[core_barangay]...';


GO
CREATE TABLE [dbo].[core_barangay] (
    [id]      INT           IDENTITY (1, 1) NOT NULL,
    [name]    VARCHAR (100) NOT NULL,
    [city_id] INT           NOT NULL,
    PRIMARY KEY CLUSTERED ([id] ASC) WITH (ALLOW_PAGE_LOCKS = ON, ALLOW_ROW_LOCKS = ON, PAD_INDEX = OFF, IGNORE_DUP_KEY = OFF, STATISTICS_NORECOMPUTE = OFF)
);


GO
PRINT N'Creating [dbo].[core_city]...';


GO
CREATE TABLE [dbo].[core_city] (
    [id]          INT           IDENTITY (1, 1) NOT NULL,
    [name]        VARCHAR (100) NOT NULL,
    [province_id] INT           NOT NULL,
    PRIMARY KEY CLUSTERED ([id] ASC) WITH (ALLOW_PAGE_LOCKS = ON, ALLOW_ROW_LOCKS = ON, PAD_INDEX = OFF, IGNORE_DUP_KEY = OFF, STATISTICS_NORECOMPUTE = OFF)
);


GO
PRINT N'Creating [dbo].[core_civilstatus]...';


GO
CREATE TABLE [dbo].[core_civilstatus] (
    [id]   INT          IDENTITY (1, 1) NOT NULL,
    [name] VARCHAR (20) NOT NULL,
    PRIMARY KEY CLUSTERED ([id] ASC) WITH (ALLOW_PAGE_LOCKS = ON, ALLOW_ROW_LOCKS = ON, PAD_INDEX = OFF, IGNORE_DUP_KEY = OFF, STATISTICS_NORECOMPUTE = OFF)
);


GO
PRINT N'Creating [dbo].[core_contact]...';


GO
CREATE TABLE [dbo].[core_contact] (
    [id]           INT           IDENTITY (1, 1) NOT NULL,
    [number]       VARCHAR (11)  NULL,
    [emailaddress] VARCHAR (100) NULL,
    [note]         VARCHAR (100) NULL,
    [student_id]   INT           NOT NULL,
    PRIMARY KEY CLUSTERED ([id] ASC) WITH (ALLOW_PAGE_LOCKS = ON, ALLOW_ROW_LOCKS = ON, PAD_INDEX = OFF, IGNORE_DUP_KEY = OFF, STATISTICS_NORECOMPUTE = OFF)
);


GO
PRINT N'Creating [dbo].[core_day]...';


GO
CREATE TABLE [dbo].[core_day] (
    [id]   INT          IDENTITY (1, 1) NOT NULL,
    [code] VARCHAR (3)  NOT NULL,
    [name] VARCHAR (10) NOT NULL,
    PRIMARY KEY CLUSTERED ([id] ASC) WITH (ALLOW_PAGE_LOCKS = ON, ALLOW_ROW_LOCKS = ON, PAD_INDEX = OFF, IGNORE_DUP_KEY = OFF, STATISTICS_NORECOMPUTE = OFF)
);


GO
PRINT N'Creating [dbo].[core_gender]...';


GO
CREATE TABLE [dbo].[core_gender] (
    [id]   INT          IDENTITY (1, 1) NOT NULL,
    [name] VARCHAR (10) NOT NULL,
    PRIMARY KEY CLUSTERED ([id] ASC) WITH (ALLOW_PAGE_LOCKS = ON, ALLOW_ROW_LOCKS = ON, PAD_INDEX = OFF, IGNORE_DUP_KEY = OFF, STATISTICS_NORECOMPUTE = OFF)
);


GO
PRINT N'Creating [dbo].[core_guardian]...';


GO
CREATE TABLE [dbo].[core_guardian] (
    [id]           INT           IDENTITY (1, 1) NOT NULL,
    [number]       VARCHAR (11)  NULL,
    [emailaddress] VARCHAR (100) NULL,
    [relationship] VARCHAR (50)  NOT NULL,
    [student_id]   INT           NOT NULL,
    [note]         VARCHAR (100) NULL,
    PRIMARY KEY CLUSTERED ([id] ASC) WITH (ALLOW_PAGE_LOCKS = ON, ALLOW_ROW_LOCKS = ON, PAD_INDEX = OFF, IGNORE_DUP_KEY = OFF, STATISTICS_NORECOMPUTE = OFF)
);


GO
PRINT N'Creating [dbo].[core_province]...';


GO
CREATE TABLE [dbo].[core_province] (
    [id]   INT           IDENTITY (1, 1) NOT NULL,
    [name] VARCHAR (100) NOT NULL,
    PRIMARY KEY CLUSTERED ([id] ASC) WITH (ALLOW_PAGE_LOCKS = ON, ALLOW_ROW_LOCKS = ON, PAD_INDEX = OFF, IGNORE_DUP_KEY = OFF, STATISTICS_NORECOMPUTE = OFF)
);


GO
PRINT N'Creating [dbo].[core_student]...';


GO
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
    [street]           VARCHAR (100)  NULL,
    [barangay_id]      INT            NOT NULL,
    [mothername]       VARCHAR (100)  NULL,
    [motheroccupation] VARCHAR (100)  NULL,
    [fathername]       VARCHAR (100)  NULL,
    [fatheroccupation] VARCHAR (100)  NULL,
    [note]             VARCHAR (100)  NULL,
    PRIMARY KEY CLUSTERED ([id] ASC) WITH (ALLOW_PAGE_LOCKS = ON, ALLOW_ROW_LOCKS = ON, PAD_INDEX = OFF, IGNORE_DUP_KEY = OFF, STATISTICS_NORECOMPUTE = OFF)
);


GO
PRINT N'Creating [dbo].[core_systemsettings]...';


GO
CREATE TABLE [dbo].[core_systemsettings] (
    [key]   VARCHAR (100)  NOT NULL,
    [value] VARCHAR (8000) NOT NULL,
    PRIMARY KEY CLUSTERED ([key] ASC) WITH (ALLOW_PAGE_LOCKS = ON, ALLOW_ROW_LOCKS = ON, PAD_INDEX = OFF, IGNORE_DUP_KEY = OFF, STATISTICS_NORECOMPUTE = OFF)
);


GO
PRINT N'Creating [dbo].[core_user]...';


GO
CREATE TABLE [dbo].[core_user] (
    [id]        INT           IDENTITY (1, 1) NOT NULL,
    [username]  VARCHAR (20)  NOT NULL,
    [password]  VARCHAR (100) NOT NULL,
    [name]      VARCHAR (100) NOT NULL,
    [isdeleted] BIT           NOT NULL,
    PRIMARY KEY CLUSTERED ([id] ASC) WITH (ALLOW_PAGE_LOCKS = ON, ALLOW_ROW_LOCKS = ON, PAD_INDEX = OFF, IGNORE_DUP_KEY = OFF, STATISTICS_NORECOMPUTE = OFF)
);


GO
PRINT N'Creating [dbo].[emp_contact]...';


GO
CREATE TABLE [dbo].[emp_contact] (
    [id]           INT           IDENTITY (1, 1) NOT NULL,
    [number]       VARCHAR (15)  NULL,
    [emailaddress] VARCHAR (100) NULL,
    [note]         VARCHAR (100) NULL,
    [employee_id]  INT           NOT NULL,
    PRIMARY KEY CLUSTERED ([id] ASC) WITH (ALLOW_PAGE_LOCKS = ON, ALLOW_ROW_LOCKS = ON, PAD_INDEX = OFF, IGNORE_DUP_KEY = OFF, STATISTICS_NORECOMPUTE = OFF)
);


GO
PRINT N'Creating [dbo].[emp_employee]...';


GO
CREATE TABLE [dbo].[emp_employee] (
    [id]             INT            IDENTITY (1, 1) NOT NULL,
    [number]         VARCHAR (50)   NOT NULL,
    [firstname]      VARCHAR (50)   NOT NULL,
    [middlename]     VARCHAR (50)   NOT NULL,
    [lastname]       VARCHAR (50)   NOT NULL,
    [dateofbirth]    DATETIME       NOT NULL,
    [gender_id]      INT            NOT NULL,
    [civilstatus_id] INT            NOT NULL,
    [citizenship]    VARCHAR (100)  NOT NULL,
    [street]         VARCHAR (100)  NULL,
    [barangay_id]    INT            NOT NULL,
    [picture]        VARCHAR (1000) NULL,
    [note]           VARCHAR (100)  NULL,
    PRIMARY KEY CLUSTERED ([id] ASC) WITH (ALLOW_PAGE_LOCKS = ON, ALLOW_ROW_LOCKS = ON, PAD_INDEX = OFF, IGNORE_DUP_KEY = OFF, STATISTICS_NORECOMPUTE = OFF)
);


GO
PRINT N'Creating [dbo].[enroll_course]...';


GO
CREATE TABLE [dbo].[enroll_course] (
    [id]   INT           IDENTITY (1, 1) NOT NULL,
    [name] VARCHAR (100) NOT NULL,
    [code] VARCHAR (100) NOT NULL,
    PRIMARY KEY CLUSTERED ([id] ASC) WITH (ALLOW_PAGE_LOCKS = ON, ALLOW_ROW_LOCKS = ON, PAD_INDEX = OFF, IGNORE_DUP_KEY = OFF, STATISTICS_NORECOMPUTE = OFF)
);


GO
PRINT N'Creating [dbo].[enroll_room]...';


GO
CREATE TABLE [dbo].[enroll_room] (
    [id]   INT           IDENTITY (1, 1) NOT NULL,
    [name] VARCHAR (100) NOT NULL,
    [note] VARCHAR (100) NULL,
    PRIMARY KEY CLUSTERED ([id] ASC) WITH (ALLOW_PAGE_LOCKS = ON, ALLOW_ROW_LOCKS = ON, PAD_INDEX = OFF, IGNORE_DUP_KEY = OFF, STATISTICS_NORECOMPUTE = OFF)
);


GO
PRINT N'Creating [dbo].[enroll_schedule]...';


GO
CREATE TABLE [dbo].[enroll_schedule] (
    [id]          INT           IDENTITY (1, 1) NOT NULL,
    [course_id]   INT           NOT NULL,
    [section_id]  INT           NOT NULL,
    [employee_id] INT           NOT NULL,
    [subject_id]  INT           NOT NULL,
    [room_id]     INT           NOT NULL,
    [day_id]      INT           NOT NULL,
    [datestart]   DATETIME      NOT NULL,
    [dateend]     DATETIME      NOT NULL,
    [note]        VARCHAR (100) NULL,
    PRIMARY KEY CLUSTERED ([id] ASC) WITH (ALLOW_PAGE_LOCKS = ON, ALLOW_ROW_LOCKS = ON, PAD_INDEX = OFF, IGNORE_DUP_KEY = OFF, STATISTICS_NORECOMPUTE = OFF)
);


GO
PRINT N'Creating [dbo].[enroll_section]...';


GO
CREATE TABLE [dbo].[enroll_section] (
    [id]   INT           IDENTITY (1, 1) NOT NULL,
    [name] VARCHAR (100) NOT NULL,
    [note] VARCHAR (100) NULL,
    PRIMARY KEY CLUSTERED ([id] ASC) WITH (ALLOW_PAGE_LOCKS = ON, ALLOW_ROW_LOCKS = ON, PAD_INDEX = OFF, IGNORE_DUP_KEY = OFF, STATISTICS_NORECOMPUTE = OFF)
);


GO
PRINT N'Creating [dbo].[enroll_subject]...';


GO
CREATE TABLE [dbo].[enroll_subject] (
    [id]   INT           IDENTITY (1, 1) NOT NULL,
    [name] VARCHAR (100) NOT NULL,
    [note] VARCHAR (100) NULL,
    PRIMARY KEY CLUSTERED ([id] ASC) WITH (ALLOW_PAGE_LOCKS = ON, ALLOW_ROW_LOCKS = ON, PAD_INDEX = OFF, IGNORE_DUP_KEY = OFF, STATISTICS_NORECOMPUTE = OFF)
);


GO
PRINT N'Creating [dbo].[log_entrybook]...';


GO
CREATE TABLE [dbo].[log_entrybook] (
    [id]         INT           IDENTITY (1, 1) NOT NULL,
    [rfid]       VARCHAR (100) NOT NULL,
    [timein]     DATETIME      NOT NULL,
    [timeout]    DATETIME      NOT NULL,
    [isoverride] BIT           NOT NULL,
    PRIMARY KEY CLUSTERED ([id] ASC) WITH (ALLOW_PAGE_LOCKS = ON, ALLOW_ROW_LOCKS = ON, PAD_INDEX = OFF, IGNORE_DUP_KEY = OFF, STATISTICS_NORECOMPUTE = OFF)
);


GO
PRINT N'Creating [dbo].[log_entrybook_archive]...';


GO
CREATE TABLE [dbo].[log_entrybook_archive] (
    [id]           INT           IDENTITY (1, 1) NOT NULL,
    [archiveddate] DATETIME      NOT NULL,
    [entrybook_id] INT           NOT NULL,
    [rfid]         VARCHAR (100) NOT NULL,
    [timein]       DATETIME      NOT NULL,
    [timeout]      DATETIME      NOT NULL,
    [isoverride]   BIT           NOT NULL,
    PRIMARY KEY CLUSTERED ([id] ASC) WITH (ALLOW_PAGE_LOCKS = ON, ALLOW_ROW_LOCKS = ON, PAD_INDEX = OFF, IGNORE_DUP_KEY = OFF, STATISTICS_NORECOMPUTE = OFF)
);


GO
PRINT N'Creating [dbo].[sms_inbox]...';


GO
CREATE TABLE [dbo].[sms_inbox] (
    [id]          INT            NOT NULL,
    [number]      VARCHAR (15)   NOT NULL,
    [message]     VARCHAR (1000) NOT NULL,
    [datecreated] DATETIME       NOT NULL,
    [status_id]   INT            NOT NULL,
    PRIMARY KEY CLUSTERED ([id] ASC) WITH (ALLOW_PAGE_LOCKS = ON, ALLOW_ROW_LOCKS = ON, PAD_INDEX = OFF, IGNORE_DUP_KEY = OFF, STATISTICS_NORECOMPUTE = OFF)
);


GO
PRINT N'Creating [dbo].[sms_inbox_archive]...';


GO
CREATE TABLE [dbo].[sms_inbox_archive] (
    [archivedid]   INT            IDENTITY (1, 1) NOT NULL,
    [archiveddate] DATETIME       NOT NULL,
    [id]           INT            NOT NULL,
    [number]       VARCHAR (15)   NOT NULL,
    [message]      VARCHAR (1000) NOT NULL,
    [datecreated]  DATETIME       NOT NULL,
    [status_id]    INT            NOT NULL
);


GO
PRINT N'Creating [dbo].[sms_networkprovider]...';


GO
CREATE TABLE [dbo].[sms_networkprovider] (
    [id]   INT          IDENTITY (1, 1) NOT NULL,
    [name] VARCHAR (50) NOT NULL,
    PRIMARY KEY CLUSTERED ([id] ASC) WITH (ALLOW_PAGE_LOCKS = ON, ALLOW_ROW_LOCKS = ON, PAD_INDEX = OFF, IGNORE_DUP_KEY = OFF, STATISTICS_NORECOMPUTE = OFF)
);


GO
PRINT N'Creating [dbo].[sms_networkprovidercode]...';


GO
CREATE TABLE [dbo].[sms_networkprovidercode] (
    [id]                 INT         IDENTITY (1, 1) NOT NULL,
    [name]               VARCHAR (4) NOT NULL,
    [networkprovider_id] INT         NOT NULL,
    PRIMARY KEY CLUSTERED ([id] ASC) WITH (ALLOW_PAGE_LOCKS = ON, ALLOW_ROW_LOCKS = ON, PAD_INDEX = OFF, IGNORE_DUP_KEY = OFF, STATISTICS_NORECOMPUTE = OFF)
);


GO
PRINT N'Creating [dbo].[sms_notification]...';


GO
CREATE TABLE [dbo].[sms_notification] (
    [id]          INT            IDENTITY (1, 1) NOT NULL,
    [number]      VARCHAR (15)   NOT NULL,
    [message]     VARCHAR (1000) NOT NULL,
    [remarks]     VARCHAR (100)  NULL,
    [room_id]     INT            NOT NULL,
    [datecreated] DATETIME       NOT NULL,
    PRIMARY KEY CLUSTERED ([id] ASC) WITH (ALLOW_PAGE_LOCKS = ON, ALLOW_ROW_LOCKS = ON, PAD_INDEX = OFF, IGNORE_DUP_KEY = OFF, STATISTICS_NORECOMPUTE = OFF)
);


GO
PRINT N'Creating [dbo].[sms_outbox]...';


GO
CREATE TABLE [dbo].[sms_outbox] (
    [id]              INT            IDENTITY (1, 1) NOT NULL,
    [number]          VARCHAR (15)   NOT NULL,
    [message]         VARCHAR (1000) NOT NULL,
    [status_id]       INT            NOT NULL,
    [notification_id] INT            NULL,
    PRIMARY KEY CLUSTERED ([id] ASC) WITH (ALLOW_PAGE_LOCKS = ON, ALLOW_ROW_LOCKS = ON, PAD_INDEX = OFF, IGNORE_DUP_KEY = OFF, STATISTICS_NORECOMPUTE = OFF)
);


GO
PRINT N'Creating [dbo].[sms_outbox_archive]...';


GO
CREATE TABLE [dbo].[sms_outbox_archive] (
    [id]              INT            NOT NULL,
    [archiveddate]    DATETIME       NOT NULL,
    [outbox_id]       INT            NOT NULL,
    [number]          VARCHAR (15)   NOT NULL,
    [message]         VARCHAR (1000) NOT NULL,
    [status_id]       INT            NOT NULL,
    [notification_id] INT            NULL,
    PRIMARY KEY CLUSTERED ([id] ASC) WITH (ALLOW_PAGE_LOCKS = ON, ALLOW_ROW_LOCKS = ON, PAD_INDEX = OFF, IGNORE_DUP_KEY = OFF, STATISTICS_NORECOMPUTE = OFF)
);


GO
PRINT N'Creating [dbo].[sms_sent]...';


GO
CREATE TABLE [dbo].[sms_sent] (
    [id]              INT           NOT NULL,
    [number]          VARCHAR (15)  NOT NULL,
    [message]         VARCHAR (700) NOT NULL,
    [datecreated]     DATETIME      NOT NULL,
    [notification_id] INT           NULL,
    PRIMARY KEY CLUSTERED ([id] ASC) WITH (ALLOW_PAGE_LOCKS = ON, ALLOW_ROW_LOCKS = ON, PAD_INDEX = OFF, IGNORE_DUP_KEY = OFF, STATISTICS_NORECOMPUTE = OFF)
);


GO
PRINT N'Creating [dbo].[sms_sent_archive]...';


GO
CREATE TABLE [dbo].[sms_sent_archive] (
    [id]              INT          IDENTITY (1, 1) NOT NULL,
    [archiveddate]    DATETIME     NOT NULL,
    [sent_id]         INT          NOT NULL,
    [number]          VARCHAR (15) NOT NULL,
    [datecreated]     DATETIME     NOT NULL,
    [notification_id] INT          NULL,
    PRIMARY KEY CLUSTERED ([id] ASC) WITH (ALLOW_PAGE_LOCKS = ON, ALLOW_ROW_LOCKS = ON, PAD_INDEX = OFF, IGNORE_DUP_KEY = OFF, STATISTICS_NORECOMPUTE = OFF)
);


GO
PRINT N'Creating [dbo].[sms_status]...';


GO
CREATE TABLE [dbo].[sms_status] (
    [id]   INT           IDENTITY (1, 1) NOT NULL,
    [name] VARCHAR (100) NOT NULL,
    PRIMARY KEY CLUSTERED ([id] ASC) WITH (ALLOW_PAGE_LOCKS = ON, ALLOW_ROW_LOCKS = ON, PAD_INDEX = OFF, IGNORE_DUP_KEY = OFF, STATISTICS_NORECOMPUTE = OFF)
);


GO
PRINT N'Creating On column: number...';


GO
ALTER TABLE [dbo].[core_contact]
    ADD DEFAULT (NULL) FOR [number];


GO
PRINT N'Creating On column: emailaddress...';


GO
ALTER TABLE [dbo].[core_contact]
    ADD DEFAULT (NULL) FOR [emailaddress];


GO
PRINT N'Creating On column: note...';


GO
ALTER TABLE [dbo].[core_contact]
    ADD DEFAULT (NULL) FOR [note];


GO
PRINT N'Creating On column: number...';


GO
ALTER TABLE [dbo].[core_guardian]
    ADD DEFAULT (NULL) FOR [number];


GO
PRINT N'Creating On column: emailaddress...';


GO
ALTER TABLE [dbo].[core_guardian]
    ADD DEFAULT (NULL) FOR [emailaddress];


GO
PRINT N'Creating On column: note...';


GO
ALTER TABLE [dbo].[core_guardian]
    ADD DEFAULT (NULL) FOR [note];


GO
PRINT N'Creating On column: street...';


GO
ALTER TABLE [dbo].[core_student]
    ADD DEFAULT (NULL) FOR [street];


GO
PRINT N'Creating On column: mothername...';


GO
ALTER TABLE [dbo].[core_student]
    ADD DEFAULT (NULL) FOR [mothername];


GO
PRINT N'Creating On column: motheroccupation...';


GO
ALTER TABLE [dbo].[core_student]
    ADD DEFAULT (NULL) FOR [motheroccupation];


GO
PRINT N'Creating On column: fathername...';


GO
ALTER TABLE [dbo].[core_student]
    ADD DEFAULT (NULL) FOR [fathername];


GO
PRINT N'Creating On column: fatheroccupation...';


GO
ALTER TABLE [dbo].[core_student]
    ADD DEFAULT (NULL) FOR [fatheroccupation];


GO
PRINT N'Creating On column: note...';


GO
ALTER TABLE [dbo].[core_student]
    ADD DEFAULT (NULL) FOR [note];


GO
PRINT N'Creating On column: number...';


GO
ALTER TABLE [dbo].[emp_contact]
    ADD DEFAULT (NULL) FOR [number];


GO
PRINT N'Creating On column: emailaddress...';


GO
ALTER TABLE [dbo].[emp_contact]
    ADD DEFAULT (NULL) FOR [emailaddress];


GO
PRINT N'Creating On column: note...';


GO
ALTER TABLE [dbo].[emp_contact]
    ADD DEFAULT (NULL) FOR [note];


GO
PRINT N'Creating On column: remarks...';


GO
ALTER TABLE [dbo].[sms_notification]
    ADD DEFAULT (NULL) FOR [remarks];


GO
PRINT N'Creating On column: notification_id...';


GO
ALTER TABLE [dbo].[sms_outbox]
    ADD DEFAULT (NULL) FOR [notification_id];


GO
PRINT N'Creating On column: notification_id...';


GO
ALTER TABLE [dbo].[sms_outbox_archive]
    ADD DEFAULT (NULL) FOR [notification_id];


GO
PRINT N'Creating On column: notification_id...';


GO
ALTER TABLE [dbo].[sms_sent]
    ADD DEFAULT (NULL) FOR [notification_id];


GO
PRINT N'Creating On column: notification_id...';


GO
ALTER TABLE [dbo].[sms_sent_archive]
    ADD DEFAULT (NULL) FOR [notification_id];


GO
PRINT N'Creating core_barangay_city...';


GO
ALTER TABLE [dbo].[core_barangay] WITH NOCHECK
    ADD CONSTRAINT [core_barangay_city] FOREIGN KEY ([city_id]) REFERENCES [dbo].[core_city] ([id]) ON DELETE NO ACTION ON UPDATE NO ACTION;


GO
PRINT N'Creating core_city_province...';


GO
ALTER TABLE [dbo].[core_city] WITH NOCHECK
    ADD CONSTRAINT [core_city_province] FOREIGN KEY ([province_id]) REFERENCES [dbo].[core_province] ([id]) ON DELETE NO ACTION ON UPDATE NO ACTION;


GO
PRINT N'Creating core_contact_student...';


GO
ALTER TABLE [dbo].[core_contact] WITH NOCHECK
    ADD CONSTRAINT [core_contact_student] FOREIGN KEY ([student_id]) REFERENCES [dbo].[core_student] ([id]) ON DELETE NO ACTION ON UPDATE NO ACTION;


GO
PRINT N'Creating core_guardian_student...';


GO
ALTER TABLE [dbo].[core_guardian] WITH NOCHECK
    ADD CONSTRAINT [core_guardian_student] FOREIGN KEY ([student_id]) REFERENCES [dbo].[core_student] ([id]) ON DELETE NO ACTION ON UPDATE NO ACTION;


GO
PRINT N'Creating core_barangay_core_student...';


GO
ALTER TABLE [dbo].[core_student] WITH NOCHECK
    ADD CONSTRAINT [core_barangay_core_student] FOREIGN KEY ([barangay_id]) REFERENCES [dbo].[core_barangay] ([id]) ON DELETE NO ACTION ON UPDATE NO ACTION;


GO
PRINT N'Creating core_civilstatus_core_student...';


GO
ALTER TABLE [dbo].[core_student] WITH NOCHECK
    ADD CONSTRAINT [core_civilstatus_core_student] FOREIGN KEY ([civilstatus_id]) REFERENCES [dbo].[core_civilstatus] ([id]) ON DELETE NO ACTION ON UPDATE NO ACTION;


GO
PRINT N'Creating core_gender_core_student...';


GO
ALTER TABLE [dbo].[core_student] WITH NOCHECK
    ADD CONSTRAINT [core_gender_core_student] FOREIGN KEY ([gender_id]) REFERENCES [dbo].[core_gender] ([id]) ON DELETE NO ACTION ON UPDATE NO ACTION;


GO
PRINT N'Creating emp_contact_employee...';


GO
ALTER TABLE [dbo].[emp_contact] WITH NOCHECK
    ADD CONSTRAINT [emp_contact_employee] FOREIGN KEY ([employee_id]) REFERENCES [dbo].[emp_employee] ([id]) ON DELETE NO ACTION ON UPDATE NO ACTION;


GO
PRINT N'Creating enroll_course_schedule...';


GO
ALTER TABLE [dbo].[enroll_schedule] WITH NOCHECK
    ADD CONSTRAINT [enroll_course_schedule] FOREIGN KEY ([course_id]) REFERENCES [dbo].[enroll_course] ([id]) ON DELETE NO ACTION ON UPDATE NO ACTION;


GO
PRINT N'Creating enroll_day_schedule...';


GO
ALTER TABLE [dbo].[enroll_schedule] WITH NOCHECK
    ADD CONSTRAINT [enroll_day_schedule] FOREIGN KEY ([day_id]) REFERENCES [dbo].[core_day] ([id]) ON DELETE NO ACTION ON UPDATE NO ACTION;


GO
PRINT N'Creating enroll_employee_schedule...';


GO
ALTER TABLE [dbo].[enroll_schedule] WITH NOCHECK
    ADD CONSTRAINT [enroll_employee_schedule] FOREIGN KEY ([employee_id]) REFERENCES [dbo].[emp_employee] ([id]) ON DELETE NO ACTION ON UPDATE NO ACTION;


GO
PRINT N'Creating enroll_room_schedule...';


GO
ALTER TABLE [dbo].[enroll_schedule] WITH NOCHECK
    ADD CONSTRAINT [enroll_room_schedule] FOREIGN KEY ([room_id]) REFERENCES [dbo].[enroll_room] ([id]) ON DELETE NO ACTION ON UPDATE NO ACTION;


GO
PRINT N'Creating enroll_section_schedule...';


GO
ALTER TABLE [dbo].[enroll_schedule] WITH NOCHECK
    ADD CONSTRAINT [enroll_section_schedule] FOREIGN KEY ([section_id]) REFERENCES [dbo].[enroll_section] ([id]) ON DELETE NO ACTION ON UPDATE NO ACTION;


GO
PRINT N'Creating enroll_subject_schedule...';


GO
ALTER TABLE [dbo].[enroll_schedule] WITH NOCHECK
    ADD CONSTRAINT [enroll_subject_schedule] FOREIGN KEY ([subject_id]) REFERENCES [dbo].[enroll_subject] ([id]) ON DELETE NO ACTION ON UPDATE NO ACTION;


GO
PRINT N'Creating sms_inbox_status...';


GO
ALTER TABLE [dbo].[sms_inbox] WITH NOCHECK
    ADD CONSTRAINT [sms_inbox_status] FOREIGN KEY ([status_id]) REFERENCES [dbo].[sms_status] ([id]) ON DELETE NO ACTION ON UPDATE NO ACTION;


GO
PRINT N'Creating sms_inbox_archive_status...';


GO
ALTER TABLE [dbo].[sms_inbox_archive] WITH NOCHECK
    ADD CONSTRAINT [sms_inbox_archive_status] FOREIGN KEY ([status_id]) REFERENCES [dbo].[sms_status] ([id]) ON DELETE NO ACTION ON UPDATE NO ACTION;


GO
PRINT N'Creating sms_networkcode_networkprovider...';


GO
ALTER TABLE [dbo].[sms_networkprovidercode] WITH NOCHECK
    ADD CONSTRAINT [sms_networkcode_networkprovider] FOREIGN KEY ([networkprovider_id]) REFERENCES [dbo].[sms_networkprovider] ([id]) ON DELETE NO ACTION ON UPDATE NO ACTION;


GO
PRINT N'Creating sms_notification_room...';


GO
ALTER TABLE [dbo].[sms_notification] WITH NOCHECK
    ADD CONSTRAINT [sms_notification_room] FOREIGN KEY ([room_id]) REFERENCES [dbo].[enroll_room] ([id]) ON DELETE NO ACTION ON UPDATE NO ACTION;


GO
PRINT N'Creating sms_outbox_status...';


GO
ALTER TABLE [dbo].[sms_outbox] WITH NOCHECK
    ADD CONSTRAINT [sms_outbox_status] FOREIGN KEY ([status_id]) REFERENCES [dbo].[sms_status] ([id]) ON DELETE NO ACTION ON UPDATE NO ACTION;


GO
PRINT N'Creating sms_outbox_archive_status...';


GO
ALTER TABLE [dbo].[sms_outbox_archive] WITH NOCHECK
    ADD CONSTRAINT [sms_outbox_archive_status] FOREIGN KEY ([status_id]) REFERENCES [dbo].[sms_status] ([id]) ON DELETE NO ACTION ON UPDATE NO ACTION;


GO
PRINT N'Creating [dbo].[vbarangayinfo]...';


GO

create view [dbo].[vbarangayinfo]
AS
SELECT 
 b.id
,b.name
,b.city_id
,c.name as city
FROM dbo.core_barangay b
inner join dbo.core_city c on b.city_id = c.id
GO
PRINT N'Creating [dbo].[vcityinfo]...';


GO
create view vcityinfo
AS
SELECT 
 c.id
,c.name
,c.province_id
,p.name as province
FROM dbo.core_city c
inner join dbo.core_province p on c.province_id = p.id
GO
PRINT N'Creating [dbo].[vemployeeinfo]...';


GO


create VIEW [dbo].[vemployeeinfo]
AS
SELECT     
  emp.id
, emp.number
, emp.firstname
, emp.middlename
, emp.lastname
, emp.lastname + ', ' + emp.firstname + ' ' + isnull(emp.middlename,'') as fullname
, emp.dateofbirth
, emp.gender_id
, emp.civilstatus_id
, cs.name as civilstatus
, emp.citizenship
, emp.street
, emp.barangay_id
, emp.picture
, emp.note
, gn.name AS gender
, bg.name AS barangay
, bg.city_id
, ct.name AS city
, ct.province_id
, pr.name AS province
, isnull(emp.street,'') + ' ' + bg.name + ' ' + ct.name + ' ' + pr.name  as [address]

FROM dbo.emp_employee emp
INNER JOIN dbo.core_civilstatus cs on emp.civilstatus_id = cs.id
INNER JOIN dbo.core_gender gn ON emp.gender_id = gn.id 
INNER JOIN dbo.core_barangay bg ON emp.barangay_id = bg.id 
INNER JOIN dbo.core_city ct ON bg.city_id = ct.id 
INNER JOIN dbo.core_province pr ON ct.province_id = pr.id;
GO
PRINT N'Creating [dbo].[vnetworkprovidercodeinfo]...';


GO
create view vnetworkprovidercodeinfo
AS
SELECT 
 c.id
,c.name
,c.networkprovider_id
,p.name as networkprovider
FROM dbo.sms_networkprovidercode c
inner join dbo.sms_networkprovider p on c.networkprovider_id = p.id
GO
PRINT N'Creating [dbo].[vscheduleinfo]...';


GO


CREATE view vscheduleinfo
as

SELECT
SCHED.id,
SCHED.course_id,
SCHED.section_id,
SCHED.employee_id,
SCHED.subject_id,
SCHED.room_id,
SCHED.day_id,
SCHED.datestart,
SCHED.dateend,
SCHED.note,

SC.name AS section,
EMP.number as emp_number,
EMP.firstname as emp_firstname,
EMP.middlename as emp_middlename,
EMP.lastname as emp_lastname,
EMP.picture as emp_picture,
SBJ.name as [subject],
RM.name as room,
DY.code as day_code,
DY.name as [day],
CRS.name as course_name,
CRS.code as course_code

FROM enroll_schedule SCHED 
INNER JOIN enroll_section SC ON SCHED.section_id = SC.id
INNER JOIN emp_employee EMP ON SCHED.employee_id = EMP.id
INNER JOIN enroll_subject SBJ ON SCHED.subject_id = SBJ.id
INNER JOIN enroll_room RM ON SCHED.room_id = RM.id
INNER JOIN core_day DY ON SCHED.day_id = DY.id
INNER JOIN enroll_course CRS ON SCHED.course_id = CRS.id
GO
PRINT N'Creating [dbo].[vstudentinfo]...';


GO
-- =============================================
-- Script Template
-- =============================================

CREATE VIEW [dbo].[vstudentinfo]
AS
SELECT     
st.id
, st.number
, st.firstname
, st.middlename
, st.lastname
, st.dateofbirth
, st.picture
, st.gender_id
, st.civilstatus_id
, cs.name as civilstatus
, st.citizenship
, st.street
, st.barangay_id
, st.mothername
, st.motheroccupation
, st.fathername
, st.fatheroccupation
, st.note
, gn.name AS gender
, bg.name AS barangay
, bg.city_id
, ct.name AS city
, ct.province_id
, pr.name AS province

FROM dbo.core_student st
INNER JOIN dbo.core_civilstatus cs on st.civilstatus_id = cs.id
INNER JOIN dbo.core_gender gn ON st.gender_id = gn.id 
INNER JOIN dbo.core_barangay bg ON st.barangay_id = bg.id 
INNER JOIN dbo.core_city ct ON bg.city_id = ct.id 
INNER JOIN dbo.core_province pr ON ct.province_id = pr.id;
GO
-- Refactoring step to update target server with deployed transaction logs
CREATE TABLE  [dbo].[__RefactorLog] (OperationKey UNIQUEIDENTIFIER NOT NULL PRIMARY KEY)
GO
sp_addextendedproperty N'microsoft_database_tools_support', N'refactoring log', N'schema', N'dbo', N'table', N'__RefactorLog'
GO

GO
/*
Post-Deployment Script Template							
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be appended to the build script.		
 Use SQLCMD syntax to include a file in the post-deployment script.			
 Example:      :r .\myfile.sql								
 Use SQLCMD syntax to reference a variable in the post-deployment script.		
 Example:      :setvar TableName MyTable							
			   SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/
go
-- =============================================
-- Script Template
-- =============================================
-- =============================================
-- Script Template
-- =============================================

SET IDENTITY_INSERT [dbo].[core_gender] ON
INSERT INTO [dbo].[core_gender](ID,NAME) VALUES(1,'Male')
INSERT INTO [dbo].[core_gender](ID,NAME) VALUES(2,'Female')
SET IDENTITY_INSERT [dbo].[core_gender] OFF

SET IDENTITY_INSERT [dbo].[core_civilstatus] ON
INSERT INTO [dbo].[core_civilstatus](ID,NAME) VALUES(1,'Single')
INSERT INTO [dbo].[core_civilstatus](ID,NAME) VALUES(2,'Married')
INSERT INTO [dbo].[core_civilstatus](ID,NAME) VALUES(3,'Widowed')
SET IDENTITY_INSERT [dbo].[core_civilstatus] OFF

SET IDENTITY_INSERT [dbo].[core_day] ON
INSERT INTO [dbo].[core_day](id,code,name) VALUES(1,'MON','Monday')
INSERT INTO [dbo].[core_day](id,code,name) VALUES(2,'TUE','Tuesday')
INSERT INTO [dbo].[core_day](id,code,name) VALUES(3,'WED','Wednesday')
INSERT INTO [dbo].[core_day](id,code,name) VALUES(4,'THU','Thursday')
INSERT INTO [dbo].[core_day](id,code,name) VALUES(5,'FRI','Friday')
INSERT INTO [dbo].[core_day](id,code,name) VALUES(6,'SAT','Saturday')
INSERT INTO [dbo].[core_day](id,code,name) VALUES(7,'SUN','Sunday')
SET IDENTITY_INSERT [dbo].[core_day] OFF
-- =============================================
-- Script Template
-- =============================================
-- =============================================
-- Script Template
-- =============================================
-- =============================================
-- Script Template
-- =============================================

-- =============================================
-- Script Template
-- =============================================

SET IDENTITY_INSERT [dbo].[sms_networkprovider] ON
INSERT INTO [dbo].[sms_networkprovider](ID,NAME) VALUES(1,'Express Telecom')
INSERT INTO [dbo].[sms_networkprovider](ID,NAME) VALUES(2,'Globe / Touch Mobile')
INSERT INTO [dbo].[sms_networkprovider](ID,NAME) VALUES(3,'Smart / Talk N Text')
INSERT INTO [dbo].[sms_networkprovider](ID,NAME) VALUES(4,'Red Mobile')
SET IDENTITY_INSERT [dbo].[sms_networkprovider] OFF

SET IDENTITY_INSERT [dbo].[sms_networkprovidercode] ON
INSERT INTO [dbo].[sms_networkprovidercode](ID,name,networkprovider_id) VALUES(1,'0915',2)
INSERT INTO [dbo].[sms_networkprovidercode](ID,name,networkprovider_id) VALUES(2,'0916',2)
INSERT INTO [dbo].[sms_networkprovidercode](ID,name,networkprovider_id) VALUES(3,'0917',2)
INSERT INTO [dbo].[sms_networkprovidercode](ID,name,networkprovider_id) VALUES(4,'0927',2)
INSERT INTO [dbo].[sms_networkprovidercode](ID,name,networkprovider_id) VALUES(5,'0918',3)
INSERT INTO [dbo].[sms_networkprovidercode](ID,name,networkprovider_id) VALUES(6,'0919',3)
INSERT INTO [dbo].[sms_networkprovidercode](ID,name,networkprovider_id) VALUES(7,'0910',3)
SET IDENTITY_INSERT [dbo].[sms_networkprovidercode] OFF

SET IDENTITY_INSERT [dbo].[sms_status] ON
INSERT INTO [dbo].[sms_status](ID,NAME) VALUES(1,'Unread')
INSERT INTO [dbo].[sms_status](ID,NAME) VALUES(2,'Read')
SET IDENTITY_INSERT [dbo].[sms_status] OFF

	/* last to insert test data*/
-- =============================================
-- Script Template
-- =============================================
SET IDENTITY_INSERT [dbo].[core_province] ON
INSERT INTO [dbo].[core_province](id, name) VALUES(1,'Pangasinan')
INSERT INTO [dbo].[core_province](id, name)  VALUES(2,'NCR')
SET IDENTITY_INSERT [dbo].[core_province] OFF

SET IDENTITY_INSERT [dbo].[core_city] ON
INSERT INTO [dbo].[core_city](ID,NAME, province_id) VALUES(1,'Sison',1)
INSERT INTO [dbo].[core_city](ID,NAME, province_id) VALUES(2,'Makati',2)
INSERT INTO [dbo].[core_city](ID,NAME, province_id) VALUES(3,'Manila',2)
INSERT INTO [dbo].[core_city](ID,NAME, province_id) VALUES(4,'Caloocan City',2)
SET IDENTITY_INSERT [dbo].[core_city] OFF

SET IDENTITY_INSERT [dbo].[core_barangay] ON
INSERT INTO [dbo].[core_barangay](ID,NAME, city_id) VALUES(1,'Brgy. Pinmilapil',1)
INSERT INTO [dbo].[core_barangay](ID,NAME, city_id) VALUES(2,'Brgy. Olympia',2)
SET IDENTITY_INSERT [dbo].[core_barangay] OFF

INSERT INTO [dbo].[core_systemsettings] VALUES('cache','core_barangay,core_city,core_province,core_civilstatus,core_systemsettings,core_gender,sms_status,sms_networkprovidercode,sms_networkprovider')






GO
PRINT N'Checking existing data against newly created constraints';


GO
USE [$(DatabaseName)];


GO
ALTER TABLE [dbo].[core_barangay] WITH CHECK CHECK CONSTRAINT [core_barangay_city];

ALTER TABLE [dbo].[core_city] WITH CHECK CHECK CONSTRAINT [core_city_province];

ALTER TABLE [dbo].[core_contact] WITH CHECK CHECK CONSTRAINT [core_contact_student];

ALTER TABLE [dbo].[core_guardian] WITH CHECK CHECK CONSTRAINT [core_guardian_student];

ALTER TABLE [dbo].[core_student] WITH CHECK CHECK CONSTRAINT [core_barangay_core_student];

ALTER TABLE [dbo].[core_student] WITH CHECK CHECK CONSTRAINT [core_civilstatus_core_student];

ALTER TABLE [dbo].[core_student] WITH CHECK CHECK CONSTRAINT [core_gender_core_student];

ALTER TABLE [dbo].[emp_contact] WITH CHECK CHECK CONSTRAINT [emp_contact_employee];

ALTER TABLE [dbo].[enroll_schedule] WITH CHECK CHECK CONSTRAINT [enroll_course_schedule];

ALTER TABLE [dbo].[enroll_schedule] WITH CHECK CHECK CONSTRAINT [enroll_day_schedule];

ALTER TABLE [dbo].[enroll_schedule] WITH CHECK CHECK CONSTRAINT [enroll_employee_schedule];

ALTER TABLE [dbo].[enroll_schedule] WITH CHECK CHECK CONSTRAINT [enroll_room_schedule];

ALTER TABLE [dbo].[enroll_schedule] WITH CHECK CHECK CONSTRAINT [enroll_section_schedule];

ALTER TABLE [dbo].[enroll_schedule] WITH CHECK CHECK CONSTRAINT [enroll_subject_schedule];

ALTER TABLE [dbo].[sms_inbox] WITH CHECK CHECK CONSTRAINT [sms_inbox_status];

ALTER TABLE [dbo].[sms_inbox_archive] WITH CHECK CHECK CONSTRAINT [sms_inbox_archive_status];

ALTER TABLE [dbo].[sms_networkprovidercode] WITH CHECK CHECK CONSTRAINT [sms_networkcode_networkprovider];

ALTER TABLE [dbo].[sms_notification] WITH CHECK CHECK CONSTRAINT [sms_notification_room];

ALTER TABLE [dbo].[sms_outbox] WITH CHECK CHECK CONSTRAINT [sms_outbox_status];

ALTER TABLE [dbo].[sms_outbox_archive] WITH CHECK CHECK CONSTRAINT [sms_outbox_archive_status];


GO
IF EXISTS (SELECT 1
           FROM   [master].[dbo].[sysdatabases]
           WHERE  [name] = N'$(DatabaseName)')
    BEGIN
        DECLARE @VarDecimalSupported AS BIT;
        SELECT @VarDecimalSupported = 0;
        IF ((ServerProperty(N'EngineEdition') = 3)
            AND (((@@microsoftversion / power(2, 24) = 9)
                  AND (@@microsoftversion & 0xffff >= 3024))
                 OR ((@@microsoftversion / power(2, 24) = 10)
                     AND (@@microsoftversion & 0xffff >= 1600))))
            SELECT @VarDecimalSupported = 1;
        IF (@VarDecimalSupported > 0)
            BEGIN
                EXECUTE sp_db_vardecimal_storage_format N'$(DatabaseName)', 'ON';
            END
    END


GO
