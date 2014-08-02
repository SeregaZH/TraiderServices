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
BEGIN TRANSACTION;

BEGIN TRY

    INSERT INTO ClaimType (Id, TypeNumber, Name, UpdatedBy, UpdatedDate) 
    VALUES ('286812E9-FE15-4374-84CB-C005834CBFB0', 1, 'Login', SYSTEM_USER, GETDATE())

    INSERT INTO ClaimType (Id, TypeNumber, Name, UpdatedBy, UpdatedDate) 
    VALUES ('7487FDB5-D1E0-4467-A12C-E3E1EE688083', 2, 'Password', SYSTEM_USER, GETDATE())

    INSERT INTO ClaimType (Id, TypeNumber, Name, UpdatedBy, UpdatedDate) 
    VALUES ('D37A68F7-73F9-4D21-A8BC-B3C55DE2C59A', 3, 'Email', SYSTEM_USER, GETDATE())

    INSERT INTO ClaimType (Id, TypeNumber, Name, UpdatedBy, UpdatedDate) 
    VALUES ('AF958598-C43E-410A-AE7B-69D957A32D90', 4, 'FirstName', SYSTEM_USER, GETDATE())

    INSERT INTO ClaimType (Id, TypeNumber, Name, UpdatedBy, UpdatedDate) 
    VALUES ('9C9A570D-61EB-4D1C-8C85-A5FFC5F6E2B5', 5, 'LastName', SYSTEM_USER, GETDATE())

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