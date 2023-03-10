USE [master]
GO
/****** Object:  Database [SUMMER11_Practical_Exam_2]    Script Date: 08/01/2011 07:19:27 ******/
IF NOT EXISTS (SELECT name FROM sys.databases WHERE name = N'SUMMER11_Practical_Exam_2')
BEGIN
CREATE DATABASE [SUMMER11_Practical_Exam_2]
END
GO
EXEC dbo.sp_dbcmptlevel @dbname=N'SUMMER11_Practical_Exam_2', @new_cmptlevel=90
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [SUMMER11_Practical_Exam_2].[dbo].[sp_fulltext_database] @action = 'disable'
end
GO
ALTER DATABASE [SUMMER11_Practical_Exam_2] SET ANSI_NULL_DEFAULT OFF
GO
ALTER DATABASE [SUMMER11_Practical_Exam_2] SET ANSI_NULLS OFF
GO
ALTER DATABASE [SUMMER11_Practical_Exam_2] SET ANSI_PADDING OFF
GO
ALTER DATABASE [SUMMER11_Practical_Exam_2] SET ANSI_WARNINGS OFF
GO
ALTER DATABASE [SUMMER11_Practical_Exam_2] SET ARITHABORT OFF
GO
ALTER DATABASE [SUMMER11_Practical_Exam_2] SET AUTO_CLOSE OFF
GO
ALTER DATABASE [SUMMER11_Practical_Exam_2] SET AUTO_CREATE_STATISTICS ON
GO
ALTER DATABASE [SUMMER11_Practical_Exam_2] SET AUTO_SHRINK OFF
GO
ALTER DATABASE [SUMMER11_Practical_Exam_2] SET AUTO_UPDATE_STATISTICS ON
GO
ALTER DATABASE [SUMMER11_Practical_Exam_2] SET CURSOR_CLOSE_ON_COMMIT OFF
GO
ALTER DATABASE [SUMMER11_Practical_Exam_2] SET CURSOR_DEFAULT  GLOBAL
GO
ALTER DATABASE [SUMMER11_Practical_Exam_2] SET CONCAT_NULL_YIELDS_NULL OFF
GO
ALTER DATABASE [SUMMER11_Practical_Exam_2] SET NUMERIC_ROUNDABORT OFF
GO
ALTER DATABASE [SUMMER11_Practical_Exam_2] SET QUOTED_IDENTIFIER OFF
GO
ALTER DATABASE [SUMMER11_Practical_Exam_2] SET RECURSIVE_TRIGGERS OFF
GO
ALTER DATABASE [SUMMER11_Practical_Exam_2] SET  ENABLE_BROKER
GO
ALTER DATABASE [SUMMER11_Practical_Exam_2] SET AUTO_UPDATE_STATISTICS_ASYNC OFF
GO
ALTER DATABASE [SUMMER11_Practical_Exam_2] SET DATE_CORRELATION_OPTIMIZATION OFF
GO
ALTER DATABASE [SUMMER11_Practical_Exam_2] SET TRUSTWORTHY OFF
GO
ALTER DATABASE [SUMMER11_Practical_Exam_2] SET ALLOW_SNAPSHOT_ISOLATION OFF
GO
ALTER DATABASE [SUMMER11_Practical_Exam_2] SET PARAMETERIZATION SIMPLE
GO
ALTER DATABASE [SUMMER11_Practical_Exam_2] SET  READ_WRITE
GO
ALTER DATABASE [SUMMER11_Practical_Exam_2] SET RECOVERY SIMPLE
GO
ALTER DATABASE [SUMMER11_Practical_Exam_2] SET  MULTI_USER
GO
ALTER DATABASE [SUMMER11_Practical_Exam_2] SET PAGE_VERIFY CHECKSUM
GO
ALTER DATABASE [SUMMER11_Practical_Exam_2] SET DB_CHAINING OFF
GO
USE [SUMMER11_Practical_Exam_2]
GO
/****** Object:  Table [dbo].[Sony]    Script Date: 08/01/2011 07:19:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Sony]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Sony](
	[SonyID] [varchar](50) NOT NULL,
	[SonyName] [varchar](50) NULL,
	[Manufacturer] [varchar](50) NULL,
	[Model] [varchar](50) NULL,
	[Price] [float] NULL,
	[ReleasedYear] [varchar](50) NULL,
 CONSTRAINT [PK_Sony] PRIMARY KEY CLUSTERED 
(
	[SonyID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[LG]    Script Date: 08/01/2011 07:19:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[LG]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[LG](
	[LGID] [varchar](50) NOT NULL,
	[LGName] [varchar](50) NULL,
	[Manufacturer] [varchar](50) NULL,
	[Model] [varchar](50) NULL,
	[Price] [float] NULL,
	[ReleasedYear] [varchar](50) NULL,
 CONSTRAINT [PK_LG] PRIMARY KEY CLUSTERED 
(
	[LGID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Lamb]    Script Date: 08/01/2011 07:19:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Lamb]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Lamb](
	[LambID] [varchar](50) NOT NULL,
	[LambName] [varchar](50) NULL,
	[Manufacturer] [varchar](50) NULL,
	[Model] [varchar](50) NULL,
	[Price] [float] NULL,
	[ReleasedYear] [varchar](50) NULL,
 CONSTRAINT [PK_Lamb] PRIMARY KEY CLUSTERED 
(
	[LambID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Samsung]    Script Date: 08/01/2011 07:19:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Samsung]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Samsung](
	[SamsungID] [varchar](50) NOT NULL,
	[SamsungName] [varchar](50) NULL,
	[Manufacturer] [varchar](50) NULL,
	[Model] [varchar](50) NULL,
	[Price] [float] NULL,
	[ReleasedYear] [varchar](50) NULL,
 CONSTRAINT [PK_Samsung] PRIMARY KEY CLUSTERED 
(
	[SamsungID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ViewSonic]    Script Date: 08/01/2011 07:19:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ViewSonic]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[ViewSonic](
	[ViewSonicID] [varchar](50) NOT NULL,
	[ViewSonicName] [varchar](50) NULL,
	[Manufacturer] [varchar](50) NULL,
	[Model] [varchar](50) NULL,
	[Price] [float] NULL,
	[ReleasedYear] [varchar](50) NULL,
 CONSTRAINT [PK_ViewSonic] PRIMARY KEY CLUSTERED 
(
	[ViewSonicID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Nakatel]    Script Date: 08/01/2011 07:19:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Nakatel]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Nakatel](
	[NakatelID] [varchar](50) NOT NULL,
	[NakatelName] [varchar](50) NULL,
	[Manufacturer] [varchar](50) NULL,
	[Model] [varchar](50) NULL,
	[Price] [float] NULL,
	[ReleasedYear] [varchar](50) NULL,
 CONSTRAINT [PK_Nakatel] PRIMARY KEY CLUSTERED 
(
	[NakatelID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
