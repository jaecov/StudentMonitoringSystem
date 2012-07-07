-- =============================================
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
, cs.name as civilstatus
, st.citizenship
, st.street
, st.barangay_id
, st.mothername
, st.motheroccupation
, st.fathername
, st.fatheroccupation
, st.note
, gn.name AS gender
, bg.name AS barangay
, bg.city_id
, ct.name AS city
, ct.province_id
, pr.name AS province

FROM dbo.core_student st
INNER JOIN dbo.core_civilstatus cs on st.civilstatus_id = cs.id
INNER JOIN dbo.core_gender gn ON st.gender_id = gn.id 
INNER JOIN dbo.core_barangay bg ON st.barangay_id = bg.id 
INNER JOIN dbo.core_city ct ON bg.city_id = ct.id 
INNER JOIN dbo.core_province pr ON ct.province_id = pr.id;


