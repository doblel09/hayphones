USE [HayPhones]
GO

/****** Object:  StoredProcedure [dbo].[sp_crearfactura]    Script Date: 4/21/2023 10:10:15 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO



CREATE procedure [dbo].[sp_crearfactura]
	@idFac int,
	@userID int,
	@result int OUTPUT
as
begin
	SET @result = 0
	DECLARE @verificar int = (Select COUNT(*) FROM Tbl_MasterFac WHERE ID_Master = @idFac);
	IF @verificar = 0
	BEGIN
		DECLARE @total int = 0;
		DECLARE @fecha date = CONVERT(date, GETDATE());
		INSERT INTO Tbl_MasterFac (ID_Master, userID, Fecha, Total, Guardar) VALUES (@idFac, @userID, @fecha, @total, 0); -- <-- Agregar 0 a la nueva columna FacturaGuardada
		SET @result = 1;
	END
	ELSE IF @verificar = 1
	BEGIN
		SET @result = 1;
	END
	ELSE
	BEGIN
		SET @result = 0;
	END
	RETURN @result;
END
GO


