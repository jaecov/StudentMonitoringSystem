﻿-- =============================================
-- Script Template
-- =============================================

CREATE VIEW [dbo].[vstudentinfo]
AS


SELECT     
st.id
, st.number
, st.firstname
, st.middlename
, st.lastname
, st.dateofbirth
, st.picture
, st.gender_id
, st.civilstatus_id
, cs.name as civilstatus_name
, st.citizenship
, st.street
, st.barangay_id
, st.note
, gn.name AS gender_name
, bg.name AS barangay_name
, bg.city_id
, ct.name AS city_name
, ct.province_id
, pr.name AS province_name
, st.fathername
, st.fatheroccupation
, st.fathercontactnumber
, st.fatheraddress
, st.mothername
, st.motheroccupation
, st.mothercontactnumber
, st.motheraddress
, st.current_enrolledyear_id
, st.RFID
, sy.name as schoolyear_name
, c.name as course_name
, c.code as course_code
, l.name as level_name
, sc.name as section_name

FROM dbo.core_student st
INNER JOIN dbo.core_civilstatus cs on st.civilstatus_id = cs.id
INNER JOIN dbo.core_gender gn ON st.gender_id = gn.id 
INNER JOIN dbo.core_barangay bg ON st.barangay_id = bg.id 
INNER JOIN dbo.core_city ct ON bg.city_id = ct.id 
INNER JOIN dbo.core_province pr ON ct.province_id = pr.id
LEFT JOIN  dbo.enroll_enrolledyear ey  on st.current_enrolledyear_id = ey.id
LEFT JOIN dbo.enroll_schoolyear sy ON ey.schoolyear_id = sy.id
LEFT JOIN enroll_course c ON ey.course_id = c.id
LEFT JOIN dbo.enroll_level l ON ey.level_id = l.id
left JOIN dbo.enroll_section sc ON ey.section_id = sc.id
