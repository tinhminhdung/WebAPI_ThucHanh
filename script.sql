USE [WebAPI_ThucHanh]
GO
/****** Object:  Table [dbo].[SinhVien]    Script Date: 12/17/2020 10:41:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SinhVien](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](50) NULL,
	[address] [nvarchar](50) NULL,
 CONSTRAINT [PK_SinhVien] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[SinhVien] ON
INSERT [dbo].[SinhVien] ([id], [name], [address]) VALUES (3, N'Nguyễn Khải An', N'Hà Nội')
INSERT [dbo].[SinhVien] ([id], [name], [address]) VALUES (4, N'Demo 2', N'1')
INSERT [dbo].[SinhVien] ([id], [name], [address]) VALUES (7, N'77', N'7')
SET IDENTITY_INSERT [dbo].[SinhVien] OFF
/****** Object:  Table [dbo].[Lop]    Script Date: 12/17/2020 10:41:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Lop](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](500) NULL,
 CONSTRAINT [PK_Lop] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Lop] ON
INSERT [dbo].[Lop] ([id], [name]) VALUES (1, N'Lop 11')
SET IDENTITY_INSERT [dbo].[Lop] OFF
