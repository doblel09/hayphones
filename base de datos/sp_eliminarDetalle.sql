USE [HayPhones]
GO

/****** Object:  StoredProcedure [dbo].[sp_eliminarDetalle]    Script Date: 4/21/2023 10:11:03 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO






CREATE procedure [dbo].[sp_eliminarDetalle]
	@idFac int,
	@idProd int,
	@idDetalle int,
	@result int OUTPUT
as
begin	
	DECLARE @Stock int = (SELECT TOP 1 Stock from Tbl_Producto WHERE IDProd = @idProd);
	DECLARE @cantidad int = (SELECT TOP 1 Cantidad FROM Tbl_Detalle WHERE IdProd = @idProd);
	DECLARE @total int = (SELECT Total FROM Tbl_Detalle WHERE ID_Detalle = @idDetalle);
	
	DECLARE @NewStock int = (@Stock + @cantidad);
	UPDATE Tbl_Producto SET Stock = @NewStock WHERE IDProd = @idProd;
	UPDATE Tbl_MasterFac SET Total = (ISNULL(Total, 0) - @total) WHERE ID_Master = @idFac;
	DELETE FROM Tbl_Detalle WHERE ID_Detalle = @idDetalle;

	SET @result = 1;
	RETURN @result;
end
GO


