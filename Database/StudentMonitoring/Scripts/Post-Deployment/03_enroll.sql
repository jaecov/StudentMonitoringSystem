-- =============================================
-- Script Template
-- =============================================

SET IDENTITY_INSERT [dbo].[enroll_schoolyear] ON
INSERT INTO [dbo].[enroll_schoolyear](ID,NAME) VALUES(1,'2011-2012')
INSERT INTO [dbo].[enroll_schoolyear](ID,NAME) VALUES(2,'2012-2013')
SET IDENTITY_INSERT [dbo].[enroll_schoolyear] OFF

SET IDENTITY_INSERT [dbo].[enroll_level] ON
INSERT INTO [dbo].[enroll_level](ID,NAME,[recordorder]) VALUES(1,'1st Year',1)
INSERT INTO [dbo].[enroll_level](ID,NAME,[recordorder]) VALUES(2,'2nd Year',2)
INSERT INTO [dbo].[enroll_level](ID,NAME,[recordorder]) VALUES(3,'3rd Year',3)
INSERT INTO [dbo].[enroll_level](ID,NAME,[recordorder]) VALUES(4,'4th Year',4)
INSERT INTO [dbo].[enroll_level](ID,NAME,[recordorder]) VALUES(5,'5th Year',5)
SET IDENTITY_INSERT [dbo].[enroll_level] OFF

SET IDENTITY_INSERT [dbo].[enroll_semester] ON
INSERT INTO [dbo].[enroll_semester](ID,NAME,[recordorder]) VALUES(1,'1st Semester',1)
INSERT INTO [dbo].[enroll_semester](ID,NAME,[recordorder]) VALUES(2,'2nd Semester',2)
INSERT INTO [dbo].[enroll_semester](ID,NAME,[recordorder]) VALUES(3,'3rd Semester',3)
INSERT INTO [dbo].[enroll_semester](ID,NAME,[recordorder]) VALUES(4,'N/A',4)
SET IDENTITY_INSERT [dbo].[enroll_semester] OFF