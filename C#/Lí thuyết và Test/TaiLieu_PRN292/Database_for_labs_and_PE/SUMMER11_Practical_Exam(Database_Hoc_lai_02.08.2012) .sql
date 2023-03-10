USE [master]
GO
/****** Object:  Database [SUMMER11_Practical_Exam]    Script Date: 08/01/2011 07:24:20 ******/
IF NOT EXISTS (SELECT name FROM sys.databases WHERE name = N'SUMMER11_Practical_Exam')
BEGIN
CREATE DATABASE [SUMMER11_Practical_Exam] 
END
GO
EXEC dbo.sp_dbcmptlevel @dbname=N'SUMMER11_Practical_Exam', @new_cmptlevel=90
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [SUMMER11_Practical_Exam].[dbo].[sp_fulltext_database] @action = 'disable'
end
GO
ALTER DATABASE [SUMMER11_Practical_Exam] SET ANSI_NULL_DEFAULT OFF
GO
ALTER DATABASE [SUMMER11_Practical_Exam] SET ANSI_NULLS OFF
GO
ALTER DATABASE [SUMMER11_Practical_Exam] SET ANSI_PADDING OFF
GO
ALTER DATABASE [SUMMER11_Practical_Exam] SET ANSI_WARNINGS OFF
GO
ALTER DATABASE [SUMMER11_Practical_Exam] SET ARITHABORT OFF
GO
ALTER DATABASE [SUMMER11_Practical_Exam] SET AUTO_CLOSE OFF
GO
ALTER DATABASE [SUMMER11_Practical_Exam] SET AUTO_CREATE_STATISTICS ON
GO
ALTER DATABASE [SUMMER11_Practical_Exam] SET AUTO_SHRINK OFF
GO
ALTER DATABASE [SUMMER11_Practical_Exam] SET AUTO_UPDATE_STATISTICS ON
GO
ALTER DATABASE [SUMMER11_Practical_Exam] SET CURSOR_CLOSE_ON_COMMIT OFF
GO
ALTER DATABASE [SUMMER11_Practical_Exam] SET CURSOR_DEFAULT  GLOBAL
GO
ALTER DATABASE [SUMMER11_Practical_Exam] SET CONCAT_NULL_YIELDS_NULL OFF
GO
ALTER DATABASE [SUMMER11_Practical_Exam] SET NUMERIC_ROUNDABORT OFF
GO
ALTER DATABASE [SUMMER11_Practical_Exam] SET QUOTED_IDENTIFIER OFF
GO
ALTER DATABASE [SUMMER11_Practical_Exam] SET RECURSIVE_TRIGGERS OFF
GO
ALTER DATABASE [SUMMER11_Practical_Exam] SET  ENABLE_BROKER
GO
ALTER DATABASE [SUMMER11_Practical_Exam] SET AUTO_UPDATE_STATISTICS_ASYNC OFF
GO
ALTER DATABASE [SUMMER11_Practical_Exam] SET DATE_CORRELATION_OPTIMIZATION OFF
GO
ALTER DATABASE [SUMMER11_Practical_Exam] SET TRUSTWORTHY OFF
GO
ALTER DATABASE [SUMMER11_Practical_Exam] SET ALLOW_SNAPSHOT_ISOLATION OFF
GO
ALTER DATABASE [SUMMER11_Practical_Exam] SET PARAMETERIZATION SIMPLE
GO
ALTER DATABASE [SUMMER11_Practical_Exam] SET  READ_WRITE
GO
ALTER DATABASE [SUMMER11_Practical_Exam] SET RECOVERY SIMPLE
GO
ALTER DATABASE [SUMMER11_Practical_Exam] SET  MULTI_USER
GO
ALTER DATABASE [SUMMER11_Practical_Exam] SET PAGE_VERIFY CHECKSUM
GO
ALTER DATABASE [SUMMER11_Practical_Exam] SET DB_CHAINING OFF
GO
USE [SUMMER11_Practical_Exam]
GO
/****** Object:  Table [dbo].[Car]    Script Date: 08/01/2011 07:24:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Car]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Car](
	[CarID] [varchar](50) NOT NULL,
	[CarName] [varchar](50) NULL,
	[Manufacturer] [varchar](50) NULL,
	[Model] [varchar](50) NULL,
	[Price] [float] NULL,
	[ReleasedYear] [varchar](50) NULL,
 CONSTRAINT [PK_Car] PRIMARY KEY CLUSTERED 
(
	[CarID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Bike]    Script Date: 08/01/2011 07:24:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Bike]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Bike](
	[BikeID] [varchar](50) NOT NULL,
	[BikeName] [varchar](50) NULL,
	[Manufacturer] [varchar](50) NULL,
	[Model] [varchar](50) NULL,
	[Price] [float] NULL,
	[ReleasedYear] [varchar](50) NULL,
 CONSTRAINT [PK_Bike] PRIMARY KEY CLUSTERED 
(
	[BikeID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Iphone]    Script Date: 08/01/2011 07:24:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Iphone]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Iphone](
	[IphoneID] [varchar](50) NOT NULL,
	[IphoneName] [varchar](50) NULL,
	[Manufacturer] [varchar](50) NULL,
	[Model] [varchar](50) NULL,
	[Price] [float] NULL,
	[ReleasedYear] [varchar](50) NULL,
 CONSTRAINT [PK_Iphone] PRIMARY KEY CLUSTERED 
(
	[IphoneID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Ipode]    Script Date: 08/01/2011 07:24:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Ipode]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Ipode](
	[IpodeID] [varchar](50) NOT NULL,
	[IpodeName] [varchar](50) NULL,
	[Manufacturer] [varchar](50) NULL,
	[Model] [varchar](50) NULL,
	[Price] [float] NULL,
	[ReleasedYear] [varchar](50) NULL,
 CONSTRAINT [PK_Ipode] PRIMARY KEY CLUSTERED 
(
	[IpodeID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Blackberry]    Script Date: 08/01/2011 07:24:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Blackberry]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Blackberry](
	[BlackberryID] [varchar](50) NOT NULL,
	[BlackberryName] [varchar](50) NULL,
	[Manufacturer] [varchar](50) NULL,
	[Model] [varchar](50) NULL,
	[Price] [float] NULL,
	[ReleasedYear] [varchar](50) NULL,
 CONSTRAINT [PK_Blackberry] PRIMARY KEY CLUSTERED 
(
	[BlackberryID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Nokia]    Script Date: 08/01/2011 07:24:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Nokia]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Nokia](
	[NokiaID] [varchar](50) NOT NULL,
	[NokiaName] [varchar](50) NULL,
	[Manufacturer] [varchar](50) NULL,
	[Model] [varchar](50) NULL,
	[Price] [float] NULL,
	[ReleasedYear] [varchar](50) NULL,
 CONSTRAINT [PK_Nokia] PRIMARY KEY CLUSTERED 
(
	[NokiaID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
