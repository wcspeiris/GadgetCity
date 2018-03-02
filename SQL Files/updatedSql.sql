USE [GadgetCity]
GO

/****** Object:  Table [dbo].[brand]    Script Date: 3/2/2018 4:00:39 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[brand](
	[brandId] [int] IDENTITY(1,1) NOT NULL,
	[brandName] [varchar](100) NOT NULL,
	[imgUrl] [varchar](300) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[brandId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO


CREATE TABLE [dbo].[spareParts](
	[sparePartId] [int] IDENTITY(1,1) NOT NULL,
	[sparePartName] [varchar](100) NOT NULL,
	[sparePartBrandId] [int] NOT NULL,
	[sparePartCategory] [varchar](100) NOT NULL,
	[manufactureYear] [varchar](5) NOT NULL,
	[sparePartDescription] [varchar](200) NOT NULL,
	[availableQuantity] [int] NULL,
	[accessedUserId] [varchar](10) NOT NULL,
	[accessedDateTime] [varchar](25) NOT NULL,
	[spartPartImageURl] [varchar](200) NULL,
	[sparePartVehicalBrandID] [int] NULL,
	[sparePartPrice] [int] NULL,
	[sparePartBrand] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[sparePartId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[spareParts]  WITH CHECK ADD  CONSTRAINT [fkSparePartvehicalId] FOREIGN KEY([sparePartBrandId])
REFERENCES [dbo].[vehical_list] ([vehidal_id])
GO

ALTER TABLE [dbo].[spareParts] CHECK CONSTRAINT [fkSparePartvehicalId]
GO

CREATE TABLE [dbo].[vehical_list](
	[vehidal_id] [int] IDENTITY(1,1) NOT NULL,
	[vehical_brand_id] [int] NOT NULL,
	[vehical_name] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[vehidal_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[vehical_list]  WITH CHECK ADD  CONSTRAINT [fkbrandId] FOREIGN KEY([vehical_brand_id])
REFERENCES [dbo].[brand] ([brandId])
GO

ALTER TABLE [dbo].[vehical_list] CHECK CONSTRAINT [fkbrandId]
GO
