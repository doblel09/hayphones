USE [HayPhones]
GO

/****** Object:  StoredProcedure [dbo].[sp_login]    Script Date: 4/21/2023 10:12:31 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[sp_login]
    @username varchar(50),
    @pass varchar(50),
    @result int OUTPUT,
	@id int OUTPUT,
	@nombre varchar(20) OUTPUT,
	@acclevel varchar(5) OUTPUT
AS
BEGIN
    SET @result = 0;
    IF EXISTS (SELECT * FROM Tbl_Usuario WHERE userName = @username AND userPass = @pass)
    BEGIN
        SET @result = 1;
		SET @id = (SELECT userID FROM Tbl_Usuario WHERE userName = @username AND userPass = @pass);
		SET @nombre = (SELECT nombre FROM Tbl_Usuario WHERE userName = @username AND userPass = @pass);
		SET @acclevel = (SELECT tipo FROM Tbl_Usuario WHERE userName = @username AND userPass = @pass)
    END
END
GO


