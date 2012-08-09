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





