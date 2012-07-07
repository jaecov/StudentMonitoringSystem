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
	:r .\00_Parameters.sql
	:r .\01_core.sql
	:r .\02_employee.sql
	:r .\03_enroll.sql
	:r .\04_log.sql
	:r .\05_sms.sql

	/* last to insert test data*/
	:r .\testdata.sql


