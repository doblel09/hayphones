USE [HayPhones]
GO

/****** Object:  StoredProcedure [dbo].[sp_actualizarProducto]    Script Date: 4/21/2023 10:09:15 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[sp_actualizarProducto]
    @id int,
    @descripcion varchar(255),
    @precio int,
    @stock int,
    @imei varchar(50)
AS
BEGIN
    UPDATE Tbl_Producto 
    SET Descripcion = @descripcion, Precio = @precio, Stock = @stock, IMEI = @imei
    WHERE IDProd = @id
END
GO


