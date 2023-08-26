USE [HayPhones]
GO

/****** Object:  StoredProcedure [dbo].[sp_insertarProducto]    Script Date: 4/21/2023 10:12:10 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO



CREATE PROCEDURE [dbo].[sp_insertarProducto]
    @descripcion varchar(255),
    @precio decimal(18,2),
    @stock int,
	@imei varchar(20)
AS
BEGIN
    INSERT INTO Tbl_Producto (Descripcion, Precio, Stock, IMEI) 
    VALUES (@descripcion, @precio, @stock, @imei)
END

GO


