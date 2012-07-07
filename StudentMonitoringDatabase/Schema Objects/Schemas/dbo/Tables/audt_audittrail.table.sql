CREATE TABLE [dbo].[audt_audittrail] (
    [id]          INT      IDENTITY (1, 1) NOT NULL,
    [message]     NTEXT    NOT NULL,
    [isexception] BIT      DEFAULT ((0)) NOT NULL,
    [datecreated] DATETIME NULL
);

