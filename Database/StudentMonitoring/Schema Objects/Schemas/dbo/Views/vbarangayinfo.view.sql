
create view [dbo].[vbarangayinfo]
AS
SELECT 
 b.id
,b.name
,b.city_id
,c.name as city
FROM dbo.core_barangay b
inner join dbo.core_city c on b.city_id = c.id
