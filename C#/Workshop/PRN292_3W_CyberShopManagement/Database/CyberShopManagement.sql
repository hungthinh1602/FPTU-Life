USE [master]
GO
/****** Object:  Database [CyberShopManagement]    Script Date: 3/21/2022 1:30:11 AM ******/
CREATE DATABASE [CyberShopManagement]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'CyberShopManagement', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\CyberShopManagement.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'CyberShopManagement_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\CyberShopManagement_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [CyberShopManagement] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [CyberShopManagement].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [CyberShopManagement] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [CyberShopManagement] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [CyberShopManagement] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [CyberShopManagement] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [CyberShopManagement] SET ARITHABORT OFF 
GO
ALTER DATABASE [CyberShopManagement] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [CyberShopManagement] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [CyberShopManagement] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [CyberShopManagement] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [CyberShopManagement] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [CyberShopManagement] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [CyberShopManagement] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [CyberShopManagement] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [CyberShopManagement] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [CyberShopManagement] SET  DISABLE_BROKER 
GO
ALTER DATABASE [CyberShopManagement] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [CyberShopManagement] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [CyberShopManagement] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [CyberShopManagement] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [CyberShopManagement] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [CyberShopManagement] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [CyberShopManagement] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [CyberShopManagement] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [CyberShopManagement] SET  MULTI_USER 
GO
ALTER DATABASE [CyberShopManagement] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [CyberShopManagement] SET DB_CHAINING OFF 
GO
ALTER DATABASE [CyberShopManagement] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [CyberShopManagement] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [CyberShopManagement] SET DELAYED_DURABILITY = DISABLED 
GO
USE [CyberShopManagement]
GO
/****** Object:  Table [dbo].[Customer]    Script Date: 3/21/2022 1:30:11 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customer](
	[CustomerID] [nvarchar](50) NOT NULL,
	[CustomerName] [nvarchar](50) NOT NULL,
	[PhoneNumber] [nvarchar](50) NOT NULL,
	[Email] [nvarchar](50) NULL,
	[Address] [nvarchar](50) NULL,
 CONSTRAINT [PK_Customer] PRIMARY KEY CLUSTERED 
(
	[CustomerID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[OrderDetail]    Script Date: 3/21/2022 1:30:11 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrderDetail](
	[DetailID] [nvarchar](50) NOT NULL,
	[OrderID] [nvarchar](50) NOT NULL,
	[ProductID] [nvarchar](50) NOT NULL,
	[Price] [float] NOT NULL,
	[Quantity] [int] NOT NULL,
 CONSTRAINT [PK_OrderDetail] PRIMARY KEY CLUSTERED 
(
	[DetailID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Orders]    Script Date: 3/21/2022 1:30:11 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Orders](
	[OrderID] [nvarchar](50) NOT NULL,
	[ProductID] [nvarchar](50) NOT NULL,
	[CustomerID] [nvarchar](50) NOT NULL,
	[OrderQuantity] [int] NOT NULL,
	[Price] [money] NOT NULL,
	[Total] [int] NOT NULL,
 CONSTRAINT [PK_Orders] PRIMARY KEY CLUSTERED 
(
	[OrderID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Product]    Script Date: 3/21/2022 1:30:11 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Product](
	[ProductID] [nvarchar](50) NOT NULL,
	[ProductName] [nvarchar](50) NOT NULL,
	[Brand] [nvarchar](50) NOT NULL,
	[Price] [money] NOT NULL,
	[Producer] [nvarchar](50) NOT NULL,
	[Quantity] [int] NOT NULL,
	[QuantityLeft] [int] NOT NULL,
	[Description] [nvarchar](max) NULL,
 CONSTRAINT [PK_Product] PRIMARY KEY CLUSTERED 
(
	[ProductID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[UserINFO]    Script Date: 3/21/2022 1:30:11 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserINFO](
	[UserID] [nvarchar](50) NOT NULL,
	[Password] [nvarchar](50) NOT NULL
) ON [PRIMARY]

GO
INSERT [dbo].[Customer] ([CustomerID], [CustomerName], [PhoneNumber], [Email], [Address]) VALUES (N'CUS001', N'Hà Đức Trinh', N'090333344', N'email', N'Hà Nội')
INSERT [dbo].[Customer] ([CustomerID], [CustomerName], [PhoneNumber], [Email], [Address]) VALUES (N'CUS002', N'Xuân Trường', N'094445566', N'email', N'Hà Nội')
INSERT [dbo].[Customer] ([CustomerID], [CustomerName], [PhoneNumber], [Email], [Address]) VALUES (N'CUS003', N'Tiến Dũng', N'090555789', N'email', N'Đà Nẵng')
INSERT [dbo].[Customer] ([CustomerID], [CustomerName], [PhoneNumber], [Email], [Address]) VALUES (N'CUS004', N'Quế Ngọc Hải', N'090567893', N'email', N'Hà Nội')
INSERT [dbo].[Customer] ([CustomerID], [CustomerName], [PhoneNumber], [Email], [Address]) VALUES (N'CUS005', N'Nguyễn Công Phượng', N'099988877', N'email', N'Nghệ An')
INSERT [dbo].[Customer] ([CustomerID], [CustomerName], [PhoneNumber], [Email], [Address]) VALUES (N'CUS006', N'Đặng Văn Lâm', N'094111222', N'email', N'Hà Nội')
INSERT [dbo].[Customer] ([CustomerID], [CustomerName], [PhoneNumber], [Email], [Address]) VALUES (N'CUS007', N'Đỗ Duy Mạnh', N'094134567', N'email', N'Hà Nội')
INSERT [dbo].[OrderDetail] ([DetailID], [OrderID], [ProductID], [Price], [Quantity]) VALUES (N'DE001', N'OR001', N'SP001', 250000, 1)
INSERT [dbo].[Orders] ([OrderID], [ProductID], [CustomerID], [OrderQuantity], [Price], [Total]) VALUES (N'OR001', N'SP001', N'CUS001', 1, 25000.0000, 250000)
INSERT [dbo].[Product] ([ProductID], [ProductName], [Brand], [Price], [Producer], [Quantity], [QuantityLeft], [Description]) VALUES (N'SP001', N'Dell G7', N'DELL', 24000000.0000, N'DELL', 10, 2, N'')
INSERT [dbo].[Product] ([ProductID], [ProductName], [Brand], [Price], [Producer], [Quantity], [QuantityLeft], [Description]) VALUES (N'SP002', N'Lenovo ideal pad', N'LENOVO', 12000000.0000, N'LENOVO', 3, 2, N'')
INSERT [dbo].[Product] ([ProductID], [ProductName], [Brand], [Price], [Producer], [Quantity], [QuantityLeft], [Description]) VALUES (N'SP003', N'Lenovo yoga 9 ', N'LENOVO', 46000000.0000, N'LENOVO', 4, 7, N' ')
INSERT [dbo].[Product] ([ProductID], [ProductName], [Brand], [Price], [Producer], [Quantity], [QuantityLeft], [Description]) VALUES (N'SP004', N'Dell inspiron', N'DELL', 19900000.0000, N'DELL', 5, 4, N' ')
INSERT [dbo].[Product] ([ProductID], [ProductName], [Brand], [Price], [Producer], [Quantity], [QuantityLeft], [Description]) VALUES (N'SP005', N'Dell Percision 7510', N'DELL', 18800000.0000, N'DELL', 2, 0, N'Hết hàng trong kho')
INSERT [dbo].[Product] ([ProductID], [ProductName], [Brand], [Price], [Producer], [Quantity], [QuantityLeft], [Description]) VALUES (N'SP006 ', N'Asus Vivobook', N'ASUS', 11900000.0000, N'ASUS', 6, 5, N' ')
INSERT [dbo].[Product] ([ProductID], [ProductName], [Brand], [Price], [Producer], [Quantity], [QuantityLeft], [Description]) VALUES (N'SP007', N'Asus Zenbook', N'ASUS', 29900000.0000, N'ASUS', 7, 4, N' ')
INSERT [dbo].[Product] ([ProductID], [ProductName], [Brand], [Price], [Producer], [Quantity], [QuantityLeft], [Description]) VALUES (N'SP008', N'Macbook Air', N'APPLE', 23800000.0000, N'APPLE', 8, 10, N' ')
INSERT [dbo].[Product] ([ProductID], [ProductName], [Brand], [Price], [Producer], [Quantity], [QuantityLeft], [Description]) VALUES (N'SP009', N'HP Pavilion', N'HP', 17690000.0000, N'HP', 0, 0, N'Hết hàng ')
INSERT [dbo].[Product] ([ProductID], [ProductName], [Brand], [Price], [Producer], [Quantity], [QuantityLeft], [Description]) VALUES (N'SP010', N'HP Evy 2019', N'HP Evy 2019', 18990000.0000, N'HP', 3, 2, N'')
INSERT [dbo].[UserINFO] ([UserID], [Password]) VALUES (N'ad', N'123')
INSERT [dbo].[UserINFO] ([UserID], [Password]) VALUES (N'Thinh', N'thinh123')
INSERT [dbo].[UserINFO] ([UserID], [Password]) VALUES (N'Duy', N'duy123')
ALTER TABLE [dbo].[OrderDetail]  WITH CHECK ADD  CONSTRAINT [FK_OrderDetail_Orders] FOREIGN KEY([OrderID])
REFERENCES [dbo].[Orders] ([OrderID])
GO
ALTER TABLE [dbo].[OrderDetail] CHECK CONSTRAINT [FK_OrderDetail_Orders]
GO
ALTER TABLE [dbo].[OrderDetail]  WITH CHECK ADD  CONSTRAINT [FK_OrderDetail_Product1] FOREIGN KEY([ProductID])
REFERENCES [dbo].[Product] ([ProductID])
GO
ALTER TABLE [dbo].[OrderDetail] CHECK CONSTRAINT [FK_OrderDetail_Product1]
GO
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD  CONSTRAINT [FK_Orders_Customer] FOREIGN KEY([CustomerID])
REFERENCES [dbo].[Customer] ([CustomerID])
GO
ALTER TABLE [dbo].[Orders] CHECK CONSTRAINT [FK_Orders_Customer]
GO
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD  CONSTRAINT [FK_Orders_Product] FOREIGN KEY([ProductID])
REFERENCES [dbo].[Product] ([ProductID])
GO
ALTER TABLE [dbo].[Orders] CHECK CONSTRAINT [FK_Orders_Product]
GO
USE [master]
GO
ALTER DATABASE [CyberShopManagement] SET  READ_WRITE 
GO
