USE [HayPhones]
GO

/****** Object:  StoredProcedure [dbo].[sp_agregarProducto]    Script Date: 4/21/2023 10:09:38 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO



CREATE procedure [dbo].[sp_agregarProducto]
	@idFac int,
	@idProd int,
	@cantidad int,
	@result int OUTPUT
as
begin
		
		DECLARE @Stock int = (SELECT Stock FROM Tbl_Producto WHERE IDProd = @idProd);
		IF @Stock < @cantidad
		BEGIN
			SET @result = 0;
		END
		ELSE
		BEGIN
			DECLARE @TipoVenta varchar(10) = 'Producto';
			DECLARE @Precio int = (SELECT Precio FROM Tbl_Producto WHERE IDProd = @idProd);
			DECLARE @Total int = @Precio * @cantidad;
			DECLARE @TotalDetalle int = (SELECT Total FROM Tbl_MasterFac WHERE ID_Master = @idFac);
			UPDATE Tbl_MasterFac SET Total = (@TotalDetalle + @Total) WHERE ID_Master = @idFac;
			DECLARE @RemoveStock int = @Stock - @cantidad;
			UPDATE Tbl_Producto SET Stock = @RemoveStock WHERE IDProd = @idProd;
			INSERT INTO Tbl_Detalle (IDFac, IDProd, Precio, Cantidad, Total) VALUES (@idFac, @idProd, @Precio, @cantidad, @Total);
			SET @result = 1;
		END
	
END
GO


