USE [HayPhones]
GO

/****** Object:  StoredProcedure [dbo].[sp_eliminarProducto]    Script Date: 4/21/2023 10:11:33 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[sp_eliminarProducto]
    @id int
AS
BEGIN
    DELETE FROM Tbl_Producto WHERE IDProd = @id
END

GO


