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