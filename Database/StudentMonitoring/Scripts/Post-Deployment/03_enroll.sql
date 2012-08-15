-- =============================================
-- Script Template
-- =============================================

SET IDENTITY_INSERT [dbo].[enroll_schoolyear] ON
INSERT INTO [dbo].[enroll_schoolyear](ID,NAME) VALUES(1,'2011-2012')
INSERT INTO [dbo].[enroll_schoolyear](ID,NAME) VALUES(2,'2012-2013')
SET IDENTITY_INSERT [dbo].[enroll_schoolyear] OFF

SET IDENTITY_INSERT [dbo].[enroll_level] ON
INSERT INTO [dbo].[enroll_level](ID,NAME) VALUES(1,'1st Year')
INSERT INTO [dbo].[enroll_level](ID,NAME) VALUES(2,'2nd Year')
INSERT INTO [dbo].[enroll_level](ID,NAME) VALUES(3,'3rd Year')
INSERT INTO [dbo].[enroll_level](ID,NAME) VALUES(4,'4th Year')
INSERT INTO [dbo].[enroll_level](ID,NAME) VALUES(5,'5th Year')
SET IDENTITY_INSERT [dbo].[enroll_level] OFF