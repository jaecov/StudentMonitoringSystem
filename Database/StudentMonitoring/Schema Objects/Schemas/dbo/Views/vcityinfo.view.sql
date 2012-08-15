create view vcityinfo
AS
SELECT 
 c.id
,c.name
,c.province_id
,p.name as province_name
FROM dbo.core_city c
inner join dbo.core_province p on c.province_id = p.id
