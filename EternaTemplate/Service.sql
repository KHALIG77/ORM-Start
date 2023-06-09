/*
   Friday, April 21, 20234:03:00 PM
   User: 
   Server: DESKTOP-497OP8B\SQLEXPRESS
   Database: Eterna
   Application: 
*/

/* To prevent any potential data loss issues, you should review this script in detail before running it outside the context of the database designer.*/
BEGIN TRANSACTION
SET QUOTED_IDENTIFIER ON
SET ARITHABORT ON
SET NUMERIC_ROUNDABORT OFF
SET CONCAT_NULL_YIELDS_NULL ON
SET ANSI_NULLS ON
SET ANSI_PADDING ON
SET ANSI_WARNINGS ON
COMMIT
BEGIN TRANSACTION
GO
CREATE TABLE dbo.Service
	(
	Id int NOT NULL IDENTITY (1, 1),
	Title nchar(50) NULL,
	Description nchar(50) NULL,
	Icon nchar(50) NULL
	)  ON [PRIMARY]
GO
ALTER TABLE dbo.Service ADD CONSTRAINT
	PK_Service PRIMARY KEY CLUSTERED 
	(
	Id
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
ALTER TABLE dbo.Service SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
select Has_Perms_By_Name(N'dbo.Service', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.Service', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.Service', 'Object', 'CONTROL') as Contr_Per 