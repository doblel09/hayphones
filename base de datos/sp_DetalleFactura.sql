USE [HayPhones]
GO

/****** Object:  StoredProcedure [dbo].[sp_DetalleFactura]    Script Date: 4/21/2023 10:10:29 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[sp_DetalleFactura]
    @idFac INT
AS
BEGIN
    SELECT Tbl_Detalle.ID_Detalle, Tbl_Detalle.IdProd, Tbl_Detalle.Cantidad, Tbl_Producto.Descripcion, Tbl_Detalle.Precio, Tbl_Detalle.Total 
    FROM Tbl_Detalle
    INNER JOIN Tbl_Producto ON Tbl_Producto.IDProd = Tbl_Detalle.IdProd
    WHERE IDFAC = @idFac
END
GO


