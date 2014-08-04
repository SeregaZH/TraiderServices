/*
Post deployment script
--------------------------------------------------------------------------------------
Author: Siarhei Zhalezka
--------------------------------------------------------------------------------------
*/

DECLARE @su_password VARCHAR(50) = 'SuperUser08081990'
DECLARE @user_id UNIQUEIDENTIFIER = '5FC640B4-45BE-4372-9DD6-66F02E93C231'
DECLARE @status TINYINT = 1 --- active user
DECLARE @login_claim_type_id UNIQUEIDENTIFIER = '286812E9-FE15-4374-84CB-C005834CBFB0'
DECLARE @password_claim_type_id UNIQUEIDENTIFIER = '7487FDB5-D1E0-4467-A12C-E3E1EE688083'
DECLARE @email_claim_type_id UNIQUEIDENTIFIER = 'D37A68F7-73F9-4D21-A8BC-B3C55DE2C59A'
DECLARE @fname_claim_type_id UNIQUEIDENTIFIER = 'AF958598-C43E-410A-AE7B-69D957A32D90'
DECLARE @lname_claim_type_id UNIQUEIDENTIFIER = '9C9A570D-61EB-4D1C-8C85-A5FFC5F6E2B5'
DECLARE @role_claim_type_id UNIQUEIDENTIFIER = '13C58D4F-F6E7-4ED4-8C4F-A054BE0EA471'

BEGIN TRANSACTION;

BEGIN TRY

/*
-------------------------------------------------------------------------------------
Insert default claims types Claims types table
-------------------------------------------------------------------------------------
*/

INSERT INTO ClaimType (Id, TypeNumber, Name, UpdatedBy, UpdatedDate) 
       VALUES (@login_claim_type_id, 1, 'Login', SYSTEM_USER, GETDATE())

INSERT INTO ClaimType (Id, TypeNumber, Name, UpdatedBy, UpdatedDate) 
       VALUES (@password_claim_type_id, 2, 'Password', SYSTEM_USER, GETDATE())

INSERT INTO ClaimType (Id, TypeNumber, Name, UpdatedBy, UpdatedDate) 
       VALUES (@email_claim_type_id, 3, 'Email', SYSTEM_USER, GETDATE())

INSERT INTO ClaimType (Id, TypeNumber, Name, UpdatedBy, UpdatedDate) 
       VALUES (@fname_claim_type_id, 4, 'FirstName', SYSTEM_USER, GETDATE())

INSERT INTO ClaimType (Id, TypeNumber, Name, UpdatedBy, UpdatedDate) 
       VALUES (@lname_claim_type_id, 5, 'LastName', SYSTEM_USER, GETDATE())

INSERT INTO ClaimType (Id, TypeNumber, Name, UpdatedBy, UpdatedDate) 
       VALUES (@role_claim_type_id, 6, 'Role', SYSTEM_USER, GETDATE())

/*
--------------------------------------------------------------------------------------
Insert super user in the database.
For password encription using md5 hash algoritm.
SU password: SuperUser08081990
--------------------------------------------------------------------------------------
*/

DECLARE @su_encripted_password varchar(50) = HashBytes('MD5', @su_password)

INSERT INTO UserInfo (Id, Status, UpdatedBy, UpdatedDate) VALUES (@user_id, @status,SYSTEM_USER, GETDATE())
INSERT INTO Users (Id, UpdatedBy, UpdatedDate) VALUES (@user_id, SYSTEM_USER, GETDATE())

---add claims for superuser
INSERT INTO Claim (Id, Value, [Identity],ClaimTypeId, ClaimTypeNumber, UserId, UpdatedBy, UpdatedDate)
           VALUES ('335CFD40-AF2E-4BEB-8225-6C0F13B74311', 'su', NULL, @login_claim_type_id, 1, @user_id, SYSTEM_USER, GETDATE())

INSERT INTO Claim (Id, Value, [Identity], ClaimTypeId, ClaimTypeNumber, UserId, UpdatedBy, UpdatedDate)
           VALUES ('80560F2F-328D-46D6-A847-09C8CE8C3EDF', @su_encripted_password, NULL,@password_claim_type_id, 2, @user_id, SYSTEM_USER, GETDATE())

INSERT INTO Claim (Id, Value, [Identity], ClaimTypeId, ClaimTypeNumber, UserId, UpdatedBy, UpdatedDate)
           VALUES ('7AA7DAE3-51F2-4F57-912E-B3BF62C69383', 'user', 2,@role_claim_type_id, 6, @user_id, SYSTEM_USER, GETDATE())

INSERT INTO Claim (Id, Value, [Identity], ClaimTypeId, ClaimTypeNumber, UserId, UpdatedBy, UpdatedDate)
           VALUES ('3B327D0A-756B-4C1B-99D9-0F90755D04D1', 'admin', 1,@role_claim_type_id, 6, @user_id, SYSTEM_USER, GETDATE())

END TRY
BEGIN CATCH
     SELECT 
        ERROR_NUMBER() AS ErrorNumber
        ,ERROR_SEVERITY() AS ErrorSeverity
        ,ERROR_STATE() AS ErrorState
        ,ERROR_PROCEDURE() AS ErrorProcedure
        ,ERROR_LINE() AS ErrorLine
        ,ERROR_MESSAGE() AS ErrorMessage;
	 
	 IF @@TRANCOUNT > 0
        ROLLBACK TRANSACTION;
END CATCH;

IF @@TRANCOUNT > 0
    COMMIT TRANSACTION;
GO