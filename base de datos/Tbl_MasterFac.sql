USE [HayPhones]
GO

/****** Object:  Table [dbo].[Tbl_MasterFac]    Script Date: 4/21/2023 10:07:32 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Tbl_MasterFac](
	[ID_Master] [int] NOT NULL,
	[userID] [int] NOT NULL,
	[Fecha] [date] NOT NULL,
	[Cliente] [varchar](50) NULL,
	[Comment] [varchar](80) NULL,
	[Total] [int] NOT NULL,
	[Guardar] [int] NOT NULL,
 CONSTRAINT [PK_Tbl_MasterFac] PRIMARY KEY CLUSTERED 
(
	[ID_Master] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Tbl_MasterFac]  WITH CHECK ADD  CONSTRAINT [FK_Tbl_MasterFac_Tbl_Usuario] FOREIGN KEY([userID])
REFERENCES [dbo].[Tbl_Usuario] ([userID])
GO

ALTER TABLE [dbo].[Tbl_MasterFac] CHECK CONSTRAINT [FK_Tbl_MasterFac_Tbl_Usuario]
GO


