-- =============================================
-- Script Template
-- =============================================

CREATE VIEW [dbo].[vemployeeinfo]
AS
SELECT     
emp.id
, emp.number
, emp.firstname
, emp.middlename
, emp.lastname
, emp.dateofbirth
, emp.gender_id
, emp.civilstatus_id
, cs.name as civilstatus
, emp.citizenship
, emp.street
, emp.barangay_id
, emp.note
, gn.name AS gender
, bg.name AS barangay
, bg.city_id
, ct.name AS city
, ct.province_id
, pr.name AS province

FROM dbo.emp_employee emp
INNER JOIN dbo.core_civilstatus cs on emp.civilstatus_id = cs.id
INNER JOIN dbo.core_gender gn ON emp.gender_id = gn.id 
INNER JOIN dbo.core_barangay bg ON emp.barangay_id = bg.id 
INNER JOIN dbo.core_city ct ON bg.city_id = ct.id 
INNER JOIN dbo.core_province pr ON ct.province_id = pr.id;


