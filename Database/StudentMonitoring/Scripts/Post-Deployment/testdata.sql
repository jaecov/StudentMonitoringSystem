﻿-- =============================================
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

SET IDENTITY_INSERT [dbo].[core_student] ON
INSERT INTO core_student (id, number, firstname, middlename, lastname, dateofbirth, picture, gender_id, civilstatus_id, citizenship, street, barangay_id, mothername, motheroccupation, mothercontactnumber, motheraddress, fathername, fatheroccupation, fathercontactnumber, fatheraddress, note, current_enrolledyear_id, RFID)
VALUES (1, 2010, 'romeo', 'escoto', 'melo', '07/29/1986', '', 1, 1, 'filipino', '7109 san anselmo st.', '2', 'corazon escoto', 'housekeeper', 'n/a', 'pangasinan', 'rodolfo melo', 'baker', 'n/a', 'pangsinan', 'test 1', 0, 1)
SET IDENTITY_INSERT [dbo].[core_student] OFF	

SET IDENTITY_INSERT [dbo].[enroll_enrolledyear] ON

INSERT INTO dbo.enroll_enrolledyear (id, student_id, level_id, schoolyear_id, semester_id, course_id, section_id, note)
VALUES (1, 1, 1, 1, 1, 1, 1, 'test 1')
INSERT INTO dbo.enroll_enrolledyear (id, student_id, level_id, schoolyear_id, semester_id, course_id, section_id, note)
VALUES (2, 1, 1, 1, 2, 1, 1, 'test 2')

SET IDENTITY_INSERT [dbo].[enroll_enrolledyear] OFF



