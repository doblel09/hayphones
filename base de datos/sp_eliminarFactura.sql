USE [HayPhones]
GO

/****** Object:  StoredProcedure [dbo].[sp_eliminarFactura]    Script Date: 4/21/2023 10:11:19 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO





CREATE procedure [dbo].[sp_eliminarFactura]
	@idFac int,
	@result int OUTPUT
as
begin
	-- Copiar los detalles de la factura a una tabla temporal
	SELECT IDProd, Cantidad INTO #TmpDetalle FROM Tbl_Detalle WHERE IDFac = @idFac;

	-- Restaurar stock de los productos asociados a la factura eliminada
	DECLARE @idProd int;
	DECLARE @cantidad int;
	DECLARE @Stock int;
	DECLARE productos_cursor CURSOR FOR
		SELECT IDProd, Cantidad FROM #TmpDetalle;
	OPEN productos_cursor;
	FETCH NEXT FROM productos_cursor INTO @idProd, @cantidad;
	WHILE @@FETCH_STATUS = 0
	BEGIN
		SELECT @Stock = Stock FROM Tbl_Producto WHERE IDProd = @idProd;
		UPDATE Tbl_Producto SET Stock = @Stock + @cantidad WHERE IDProd = @idProd;
		FETCH NEXT FROM productos_cursor INTO @idProd, @cantidad;
	END
	CLOSE productos_cursor;
	DEALLOCATE productos_cursor;

	-- Eliminar la factura y sus detalles
	DELETE FROM Tbl_Detalle WHERE IDFac = @idFac;
	DELETE FROM Tbl_MasterFac WHERE ID_Master = @idFac;

	SET @result = 1;
END
GO


