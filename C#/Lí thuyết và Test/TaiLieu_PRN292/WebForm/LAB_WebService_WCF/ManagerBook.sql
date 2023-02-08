USE [Manager]
GO
/****** Object:  Table [dbo].[Books]    Script Date: 08/22/2012 21:35:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Books](
	[BookID] [int] NOT NULL,
	[BookTitle] [varchar](50) NOT NULL,
	[BookPrice] [float] NOT NULL,
 CONSTRAINT [PK_Books] PRIMARY KEY CLUSTERED 
(
	[BookID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[Books] ([BookID], [BookTitle], [BookPrice]) VALUES (1, N'lap trinh IOS 5', 465)
