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

SET IDENTITY_INSERT [dbo].[enroll_course] ON
INSERT INTO [dbo].[enroll_course](id, name, code) VALUES(1,'Bachelor of Science and Technology in Information Technology','BS IT')
INSERT INTO [dbo].[enroll_course](id, name, code) VALUES(2,'Bachelor of Science and Technoloy in Mathematics','BS Math')
SET IDENTITY_INSERT [dbo].[enroll_course] OFF

SET IDENTITY_INSERT [dbo].[enroll_section] ON
INSERT INTO [dbo].enroll_section(id, name, note, course_id, level_id) VALUES(1,'I-A','',1,1)
INSERT INTO [dbo].[enroll_section](id, name, note, course_id, level_id) VALUES(2,'II-A','',1,2)
SET IDENTITY_INSERT [dbo].[enroll_section] OFF

SET IDENTITY_INSERT [dbo].[enroll_room] ON
INSERT INTO [dbo].[enroll_room](id, name, note) VALUES(1,'Room 101','')
INSERT INTO [dbo].[enroll_room](id, name, note) VALUES(2,'Room 102','')
SET IDENTITY_INSERT [dbo].[enroll_room] OFF

SET IDENTITY_INSERT [dbo].[enroll_subject] ON
INSERT INTO [dbo].[enroll_subject](id, code, name, note) VALUES(1,'Eng 101','English 101','')
INSERT INTO [dbo].[enroll_subject](id, code, name, note) VALUES(2,'Math 101','Mathematics 101','')
SET IDENTITY_INSERT [dbo].[enroll_subject] OFF

INSERT INTO [dbo].[core_systemsettings] VALUES('cache','core_barangay,core_city,core_province,core_civilstatus,core_systemsettings,core_gender,sms_status,sms_networkprovidercode,sms_networkprovider')





