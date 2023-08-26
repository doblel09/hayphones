USE [HayPhones]
GO

/****** Object:  Table [dbo].[Tbl_Detalle]    Script Date: 4/21/2023 10:06:32 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Tbl_Detalle](
	[ID_Detalle] [int] IDENTITY(1,1) NOT NULL,
	[IDFac] [int] NOT NULL,
	[IdProd] [int] NULL,
	[Precio] [int] NOT NULL,
	[Cantidad] [int] NOT NULL,
	[Total] [int] NOT NULL,
 CONSTRAINT [PK_Tbl_Detalle] PRIMARY KEY CLUSTERED 
(
	[ID_Detalle] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Tbl_Detalle]  WITH CHECK ADD  CONSTRAINT [FK_Tbl_Detalle_Tbl_MasterFac] FOREIGN KEY([IDFac])
REFERENCES [dbo].[Tbl_MasterFac] ([ID_Master])
GO

ALTER TABLE [dbo].[Tbl_Detalle] CHECK CONSTRAINT [FK_Tbl_Detalle_Tbl_MasterFac]
GO


