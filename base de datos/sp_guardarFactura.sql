USE [HayPhones]
GO

/****** Object:  StoredProcedure [dbo].[sp_guardarFactura]    Script Date: 4/21/2023 10:11:50 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO



CREATE PROCEDURE [dbo].[sp_guardarFactura] 
    @idFac int,
    @Cliente nvarchar(50),
    @Comment nvarchar(80)
AS
BEGIN
    UPDATE Tbl_MasterFac
    SET Cliente = @Cliente,
        Comment = @Comment,
		Guardar = 1
    WHERE ID_Master = @idFac;
END

GO


