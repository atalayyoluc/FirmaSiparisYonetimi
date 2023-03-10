USE [EnocaChallange]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 15.01.2023 14:29:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Firmalar]    Script Date: 15.01.2023 14:29:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Firmalar](
	[FirmaID] [int] IDENTITY(1,1) NOT NULL,
	[FirmaAdi] [nvarchar](max) NOT NULL,
	[Onay] [bit] NOT NULL,
	[SatısBaslangicSaati] [time](7) NOT NULL,
	[SatısBitisSaati] [time](7) NOT NULL,
 CONSTRAINT [PK_Firmalar] PRIMARY KEY CLUSTERED 
(
	[FirmaID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Siparisler]    Script Date: 15.01.2023 14:29:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Siparisler](
	[SiparisID] [int] IDENTITY(1,1) NOT NULL,
	[FirmaID] [int] NULL,
	[UrunID] [int] NOT NULL,
	[SiparisVeren] [nvarchar](max) NOT NULL,
	[SiparisSaati] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_Siparisler] PRIMARY KEY CLUSTERED 
(
	[SiparisID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Urunler]    Script Date: 15.01.2023 14:29:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Urunler](
	[UrunID] [int] IDENTITY(1,1) NOT NULL,
	[UrunAdi] [nvarchar](max) NOT NULL,
	[Stok] [smallint] NOT NULL,
	[Fiyat] [decimal](18, 2) NOT NULL,
	[FirmaID] [int] NOT NULL,
 CONSTRAINT [PK_Urunler] PRIMARY KEY CLUSTERED 
(
	[UrunID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20230114192208_initial', N'6.0.12')
GO
SET IDENTITY_INSERT [dbo].[Firmalar] ON 

INSERT [dbo].[Firmalar] ([FirmaID], [FirmaAdi], [Onay], [SatısBaslangicSaati], [SatısBitisSaati]) VALUES (1, N'Vestel', 1, CAST(N'10:00:00' AS Time), CAST(N'19:00:00' AS Time))
INSERT [dbo].[Firmalar] ([FirmaID], [FirmaAdi], [Onay], [SatısBaslangicSaati], [SatısBitisSaati]) VALUES (2, N'Apple', 1, CAST(N'10:00:00' AS Time), CAST(N'20:00:00' AS Time))
INSERT [dbo].[Firmalar] ([FirmaID], [FirmaAdi], [Onay], [SatısBaslangicSaati], [SatısBitisSaati]) VALUES (3, N'Samsung', 1, CAST(N'10:00:00' AS Time), CAST(N'22:00:00' AS Time))
INSERT [dbo].[Firmalar] ([FirmaID], [FirmaAdi], [Onay], [SatısBaslangicSaati], [SatısBitisSaati]) VALUES (4, N'Asus', 1, CAST(N'10:20:00' AS Time), CAST(N'20:20:00' AS Time))
INSERT [dbo].[Firmalar] ([FirmaID], [FirmaAdi], [Onay], [SatısBaslangicSaati], [SatısBitisSaati]) VALUES (5, N'Lenovo', 1, CAST(N'09:30:00' AS Time), CAST(N'21:30:00' AS Time))
INSERT [dbo].[Firmalar] ([FirmaID], [FirmaAdi], [Onay], [SatısBaslangicSaati], [SatısBitisSaati]) VALUES (6, N'Dell', 1, CAST(N'15:36:00' AS Time), CAST(N'19:36:00' AS Time))
INSERT [dbo].[Firmalar] ([FirmaID], [FirmaAdi], [Onay], [SatısBaslangicSaati], [SatısBitisSaati]) VALUES (7, N'Xiaomi', 1, CAST(N'10:00:00' AS Time), CAST(N'20:00:00' AS Time))
SET IDENTITY_INSERT [dbo].[Firmalar] OFF
GO
SET IDENTITY_INSERT [dbo].[Siparisler] ON 

INSERT [dbo].[Siparisler] ([SiparisID], [FirmaID], [UrunID], [SiparisVeren], [SiparisSaati]) VALUES (1, 1, 1, N'Ali', CAST(N'2023-01-15T14:30:00.0000000' AS DateTime2))
INSERT [dbo].[Siparisler] ([SiparisID], [FirmaID], [UrunID], [SiparisVeren], [SiparisSaati]) VALUES (2, 1, 1, N'Aysş', CAST(N'2023-01-14T15:06:33.2880000' AS DateTime2))
INSERT [dbo].[Siparisler] ([SiparisID], [FirmaID], [UrunID], [SiparisVeren], [SiparisSaati]) VALUES (3, 2, 1, N'Nilgün', CAST(N'2023-01-14T19:56:47.8040000' AS DateTime2))
INSERT [dbo].[Siparisler] ([SiparisID], [FirmaID], [UrunID], [SiparisVeren], [SiparisSaati]) VALUES (4, 2, 3, N'Ali', CAST(N'2023-01-15T10:47:59.2550000' AS DateTime2))
INSERT [dbo].[Siparisler] ([SiparisID], [FirmaID], [UrunID], [SiparisVeren], [SiparisSaati]) VALUES (5, 3, 4, N'Ahmet', CAST(N'2023-01-15T13:54:17.4484309' AS DateTime2))
INSERT [dbo].[Siparisler] ([SiparisID], [FirmaID], [UrunID], [SiparisVeren], [SiparisSaati]) VALUES (6, 4, 2, N'Ahmet', CAST(N'2023-01-15T13:54:57.9959576' AS DateTime2))
INSERT [dbo].[Siparisler] ([SiparisID], [FirmaID], [UrunID], [SiparisVeren], [SiparisSaati]) VALUES (7, 7, 4, N'Nilgün', CAST(N'2023-01-15T14:05:37.4651779' AS DateTime2))
SET IDENTITY_INSERT [dbo].[Siparisler] OFF
GO
SET IDENTITY_INSERT [dbo].[Urunler] ON 

INSERT [dbo].[Urunler] ([UrunID], [UrunAdi], [Stok], [Fiyat], [FirmaID]) VALUES (1, N'Telefon', 100, CAST(1000.00 AS Decimal(18, 2)), 1)
INSERT [dbo].[Urunler] ([UrunID], [UrunAdi], [Stok], [Fiyat], [FirmaID]) VALUES (2, N'Televizyon', 800, CAST(4000.00 AS Decimal(18, 2)), 3)
INSERT [dbo].[Urunler] ([UrunID], [UrunAdi], [Stok], [Fiyat], [FirmaID]) VALUES (3, N'Bilgisayar', 800, CAST(2000.00 AS Decimal(18, 2)), 2)
INSERT [dbo].[Urunler] ([UrunID], [UrunAdi], [Stok], [Fiyat], [FirmaID]) VALUES (4, N'Telefon', 100, CAST(1000.00 AS Decimal(18, 2)), 1)
INSERT [dbo].[Urunler] ([UrunID], [UrunAdi], [Stok], [Fiyat], [FirmaID]) VALUES (5, N'AkıllıSaat', 100, CAST(1000.00 AS Decimal(18, 2)), 2)
SET IDENTITY_INSERT [dbo].[Urunler] OFF
GO
ALTER TABLE [dbo].[Siparisler]  WITH CHECK ADD  CONSTRAINT [FK_Siparisler_Firmalar_FirmaID] FOREIGN KEY([FirmaID])
REFERENCES [dbo].[Firmalar] ([FirmaID])
GO
ALTER TABLE [dbo].[Siparisler] CHECK CONSTRAINT [FK_Siparisler_Firmalar_FirmaID]
GO
ALTER TABLE [dbo].[Siparisler]  WITH CHECK ADD  CONSTRAINT [FK_Siparisler_Urunler_UrunID] FOREIGN KEY([UrunID])
REFERENCES [dbo].[Urunler] ([UrunID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Siparisler] CHECK CONSTRAINT [FK_Siparisler_Urunler_UrunID]
GO
ALTER TABLE [dbo].[Urunler]  WITH CHECK ADD  CONSTRAINT [FK_Urunler_Firmalar_FirmaID] FOREIGN KEY([FirmaID])
REFERENCES [dbo].[Firmalar] ([FirmaID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Urunler] CHECK CONSTRAINT [FK_Urunler_Firmalar_FirmaID]
GO
