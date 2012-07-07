-- =============================================
-- Script Template
-- =============================================

SET IDENTITY_INSERT [dbo].[sms_networkprovider] ON
INSERT INTO [dbo].[sms_networkprovider](ID,NAME) VALUES(1,'Express Telecom')
INSERT INTO [dbo].[sms_networkprovider](ID,NAME) VALUES(2,'Globe / Touch Mobile')
INSERT INTO [dbo].[sms_networkprovider](ID,NAME) VALUES(3,'Smart / Talk N Text')
INSERT INTO [dbo].[sms_networkprovider](ID,NAME) VALUES(4,'Red Mobile')
SET IDENTITY_INSERT [dbo].[sms_networkprovider] OFF

SET IDENTITY_INSERT [dbo].[sms_status] ON
INSERT INTO [dbo].[sms_status](ID,NAME) VALUES(1,'Unread')
INSERT INTO [dbo].[sms_status](ID,NAME) VALUES(2,'Read')
SET IDENTITY_INSERT [dbo].[sms_status] OFF