USE [master]
GO
/****** Object:  Database [LibraryDB]  ******/
CREATE DATABASE LibraryDB
GO

USE LibraryDB
GO
/****** Object:  Table [dbo].[Readers]  ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Readers](
	[ReaderId] [varchar](10) NOT NULL,
	[ReaderName] [varchar](50) NOT NULL,
	[Category] [varchar](10) NOT NULL,
	[DateOfBirth] [datetime] NOT NULL,
	[Date] [datetime] NOT NULL,
	[Address] [varchar](100) NOT NULL,
 CONSTRAINT [PK_Readers] PRIMARY KEY CLUSTERED 
(
	[ReaderId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Readers] ([ReaderId], [ReaderName], [Category], [DateOfBirth], [Date], [Address]) VALUES (N'R001', N'David', N'Child', CAST(N'2000-01-01T00:00:00.000' AS DateTime), CAST(N'2022-03-07T00:00:00.000' AS DateTime), N'Ho Chi Minh City')
INSERT [dbo].[Readers] ([ReaderId], [ReaderName], [Category], [DateOfBirth], [Date], [Address]) VALUES (N'R002', N'Mark', N'Adult', CAST(N'1980-12-02T00:00:00.000' AS DateTime), CAST(N'2022-02-07T00:00:00.000' AS DateTime), N'Ha Noi')
GO
USE [master]
GO
ALTER DATABASE [LibraryDB] SET  READ_WRITE 
GO
