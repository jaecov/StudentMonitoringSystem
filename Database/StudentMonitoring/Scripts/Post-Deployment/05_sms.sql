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
INSERT INTO [dbo].[sms_networkprovidercode](ID,code,networkprovider_id) VALUES(1,'0915',2)
INSERT INTO [dbo].[sms_networkprovidercode](ID,code,networkprovider_id) VALUES(2,'0916',2)
INSERT INTO [dbo].[sms_networkprovidercode](ID,code,networkprovider_id) VALUES(3,'0917',2)
INSERT INTO [dbo].[sms_networkprovidercode](ID,code,networkprovider_id) VALUES(4,'0927',2)
INSERT INTO [dbo].[sms_networkprovidercode](ID,code,networkprovider_id) VALUES(5,'0918',3)
INSERT INTO [dbo].[sms_networkprovidercode](ID,code,networkprovider_id) VALUES(6,'0919',3)
INSERT INTO [dbo].[sms_networkprovidercode](ID,code,networkprovider_id) VALUES(7,'0910',3)
SET IDENTITY_INSERT [dbo].[sms_networkprovidercode] OFF

SET IDENTITY_INSERT [dbo].[sms_status] ON
INSERT INTO [dbo].[sms_status](ID,NAME) VALUES(1,'Unread')
INSERT INTO [dbo].[sms_status](ID,NAME) VALUES(2,'Read')
SET IDENTITY_INSERT [dbo].[sms_status] OFF