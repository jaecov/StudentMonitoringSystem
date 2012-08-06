create view vnetworkprovidercodeinfo
AS
SELECT 
 c.id
,c.name
,c.networkprovider_id
,p.name as networkprovider
FROM dbo.sms_networkprovidercode c
inner join dbo.sms_networkprovider p on c.networkprovider_id = p.id