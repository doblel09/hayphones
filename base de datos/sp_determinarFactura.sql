USE [HayPhones]
GO

/****** Object:  StoredProcedure [dbo].[sp_determinarfactura]    Script Date: 4/21/2023 10:10:45 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[sp_determinarfactura]
    @factura INT OUTPUT
AS
BEGIN
    SET @factura = (SELECT MAX(ID_Master) FROM Tbl_MasterFac);

    IF @factura IS NULL OR @factura = 0
    BEGIN
        SET @factura = 1;
    END
    ELSE
    BEGIN
        SET @factura = @factura + 1;
    END

    RETURN @factura;
END
GO


