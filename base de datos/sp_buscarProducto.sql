USE [HayPhones]
GO

/****** Object:  StoredProcedure [dbo].[sp_buscarProducto]    Script Date: 4/21/2023 10:09:55 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[sp_buscarProducto]
    @criterio nvarchar(50),
    @campo nvarchar(50)
AS
BEGIN
    IF @criterio = 'Codigo'
    BEGIN
        DECLARE @codigo int
        SET @codigo = CAST(@campo AS int)
        SELECT * FROM Tbl_Producto WHERE IDProd = @codigo
    END
    ELSE IF @criterio = 'Descripcion'
    BEGIN
        SELECT * FROM Tbl_Producto WHERE Descripcion LIKE '%' + @campo + '%'
    END
    ELSE IF @criterio = 'IMEI'
    BEGIN
        SELECT * FROM Tbl_Producto WHERE IMEI LIKE '%' + @campo + '%'
    END
END

GO


