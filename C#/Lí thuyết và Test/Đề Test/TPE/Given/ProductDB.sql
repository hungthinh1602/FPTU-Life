USE [master]
GO
/****** Object:  Database [ProductDB]  ******/
CREATE DATABASE ProductDB
GO

USE ProductDB
GO
/****** Object:  Table [dbo].[Readers]  ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Products](
	[ProductId] [varchar](10) NOT NULL,
	[ProductName] [varchar](50) NOT NULL,
	[Category] [varchar](10) NOT NULL,
	[Description] [varchar](200) NOT NULL,
	[Date] [datetime] NOT NULL,
 CONSTRAINT [PK_Products] PRIMARY KEY CLUSTERED 
(
	[ProductId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Products] ([ProductId], [ProductName], [Category], [Description], [Date]) VALUES (N'SP001', N'Leaf', N'Tree', N'Leaf for live', CAST(N'2022-07-07T00:00:00.000' AS DateTime))
INSERT [dbo].[Products] ([ProductId], [ProductName], [Category], [Description], [Date]) VALUES (N'SP002', N'Saw', N'Tool', N'Tool for everyone', CAST(N'2022-07-07T00:00:00.000' AS DateTime))
GO
USE [master]
GO
ALTER DATABASE [ProductDB] SET  READ_WRITE 
GO