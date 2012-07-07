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
