USE [HayPhones]
GO

/****** Object:  StoredProcedure [dbo].[sp_productoinventario]    Script Date: 4/21/2023 10:12:44 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE procedure [dbo].[sp_productoinventario]
as
select IDProd as 'Codigo', Descripcion, Precio as 'Precio Unitario', Stock as 'Stock Disponible', IMEI as 'IMEI/Comentario' from Tbl_Producto
GO


