USE [master]
GO
/****** Object:  Database [StoreManager]    Script Date: 12/13/2012 21:48:48 ******/
CREATE DATABASE [StoreManager] ON  PRIMARY 
( NAME = N'StoreManager', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10.SQLEXPRESS\MSSQL\DATA\StoreManager.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'StoreManager_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10.SQLEXPRESS\MSSQL\DATA\StoreManager_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [StoreManager] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [StoreManager].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [StoreManager] SET ANSI_NULL_DEFAULT OFF
GO
ALTER DATABASE [StoreManager] SET ANSI_NULLS OFF
GO
ALTER DATABASE [StoreManager] SET ANSI_PADDING OFF
GO
ALTER DATABASE [StoreManager] SET ANSI_WARNINGS OFF
GO
ALTER DATABASE [StoreManager] SET ARITHABORT OFF
GO
ALTER DATABASE [StoreManager] SET AUTO_CLOSE OFF
GO
ALTER DATABASE [StoreManager] SET AUTO_CREATE_STATISTICS ON
GO
ALTER DATABASE [StoreManager] SET AUTO_SHRINK OFF
GO
ALTER DATABASE [StoreManager] SET AUTO_UPDATE_STATISTICS ON
GO
ALTER DATABASE [StoreManager] SET CURSOR_CLOSE_ON_COMMIT OFF
GO
ALTER DATABASE [StoreManager] SET CURSOR_DEFAULT  GLOBAL
GO
ALTER DATABASE [StoreManager] SET CONCAT_NULL_YIELDS_NULL OFF
GO
ALTER DATABASE [StoreManager] SET NUMERIC_ROUNDABORT OFF
GO
ALTER DATABASE [StoreManager] SET QUOTED_IDENTIFIER OFF
GO
ALTER DATABASE [StoreManager] SET RECURSIVE_TRIGGERS OFF
GO
ALTER DATABASE [StoreManager] SET  DISABLE_BROKER
GO
ALTER DATABASE [StoreManager] SET AUTO_UPDATE_STATISTICS_ASYNC OFF
GO
ALTER DATABASE [StoreManager] SET DATE_CORRELATION_OPTIMIZATION OFF
GO
ALTER DATABASE [StoreManager] SET TRUSTWORTHY OFF
GO
ALTER DATABASE [StoreManager] SET ALLOW_SNAPSHOT_ISOLATION OFF
GO
ALTER DATABASE [StoreManager] SET PARAMETERIZATION SIMPLE
GO
ALTER DATABASE [StoreManager] SET READ_COMMITTED_SNAPSHOT OFF
GO
ALTER DATABASE [StoreManager] SET HONOR_BROKER_PRIORITY OFF
GO
ALTER DATABASE [StoreManager] SET  READ_WRITE
GO
ALTER DATABASE [StoreManager] SET RECOVERY SIMPLE
GO
ALTER DATABASE [StoreManager] SET  MULTI_USER
GO
ALTER DATABASE [StoreManager] SET PAGE_VERIFY CHECKSUM
GO
ALTER DATABASE [StoreManager] SET DB_CHAINING OFF
GO
USE [StoreManager]
GO
/****** Object:  Table [dbo].[Suppliers]    Script Date: 12/13/2012 21:48:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Suppliers](
	[SupplierID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](30) NOT NULL,
	[Address] [nvarchar](100) NOT NULL,
 CONSTRAINT [PK_Suppliers] PRIMARY KEY CLUSTERED 
(
	[SupplierID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Suppliers] ON
INSERT [dbo].[Suppliers] ([SupplierID], [Name], [Address]) VALUES (18, N'Победа АД', N'')
INSERT [dbo].[Suppliers] ([SupplierID], [Name], [Address]) VALUES (19, N'Престиж 96 ООД', N'')
INSERT [dbo].[Suppliers] ([SupplierID], [Name], [Address]) VALUES (20, N'Захарни заводи АД', N'')
INSERT [dbo].[Suppliers] ([SupplierID], [Name], [Address]) VALUES (21, N'Ден и Нощ ООД', N'')
SET IDENTITY_INSERT [dbo].[Suppliers] OFF
/****** Object:  Table [dbo].[Roles]    Script Date: 12/13/2012 21:48:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Roles](
	[RoleID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nchar](20) NOT NULL,
 CONSTRAINT [PK_Roles] PRIMARY KEY CLUSTERED 
(
	[RoleID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Roles] ON
INSERT [dbo].[Roles] ([RoleID], [Name]) VALUES (1, N'Administrator       ')
INSERT [dbo].[Roles] ([RoleID], [Name]) VALUES (2, N'Sales               ')
SET IDENTITY_INSERT [dbo].[Roles] OFF
/****** Object:  Table [dbo].[Users]    Script Date: 12/13/2012 21:48:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[UserID] [int] IDENTITY(1,1) NOT NULL,
	[UserName] [nvarchar](30) NOT NULL,
	[Password] [nvarchar](100) NOT NULL,
	[FirstName] [nvarchar](30) NOT NULL,
	[LastName] [nvarchar](30) NOT NULL,
	[Address] [nvarchar](100) NULL,
	[RoleID] [int] NOT NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[UserID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Users] ON
INSERT [dbo].[Users] ([UserID], [UserName], [Password], [FirstName], [LastName], [Address], [RoleID]) VALUES (2, N'admin', N'admin', N'Administrator', N'Administrator', N'Sofia', 1)
INSERT [dbo].[Users] ([UserID], [UserName], [Password], [FirstName], [LastName], [Address], [RoleID]) VALUES (3, N'sales', N'sales', N'Sales', N'Sales', N'Sales', 2)
SET IDENTITY_INSERT [dbo].[Users] OFF
/****** Object:  Table [dbo].[Products]    Script Date: 12/13/2012 21:48:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Products](
	[ProductID] [int] IDENTITY(1,1) NOT NULL,
	[SupplierID] [int] NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Description] [nvarchar](100) NULL,
	[Stock] [int] NOT NULL,
	[Price] [smallmoney] NOT NULL,
 CONSTRAINT [PK_Products] PRIMARY KEY CLUSTERED 
(
	[ProductID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Products] ON
INSERT [dbo].[Products] ([ProductID], [SupplierID], [Name], [Description], [Stock], [Price]) VALUES (30, 18, N'Вафла "Резово"', N'', 24, 0.5000)
INSERT [dbo].[Products] ([ProductID], [SupplierID], [Name], [Description], [Stock], [Price]) VALUES (31, 18, N'Вафла "Еверест"', N'', 21, 0.4000)
INSERT [dbo].[Products] ([ProductID], [SupplierID], [Name], [Description], [Stock], [Price]) VALUES (32, 18, N'Чаени бисквити', N'', 24, 1.1000)
INSERT [dbo].[Products] ([ProductID], [SupplierID], [Name], [Description], [Stock], [Price]) VALUES (33, 18, N'Бисквити "Изгрев"', N'', 22, 0.7000)
INSERT [dbo].[Products] ([ProductID], [SupplierID], [Name], [Description], [Stock], [Price]) VALUES (34, 19, N'Вафла "Хипер"', N'', 24, 0.6000)
INSERT [dbo].[Products] ([ProductID], [SupplierID], [Name], [Description], [Stock], [Price]) VALUES (35, 19, N'Вафла "Престиж"', N'', 24, 0.4000)
INSERT [dbo].[Products] ([ProductID], [SupplierID], [Name], [Description], [Stock], [Price]) VALUES (36, 19, N'Вафла "Споко"', N'', 23, 0.5000)
INSERT [dbo].[Products] ([ProductID], [SupplierID], [Name], [Description], [Stock], [Price]) VALUES (37, 19, N'Вафла "Гепи"', N'', 22, 0.6000)
INSERT [dbo].[Products] ([ProductID], [SupplierID], [Name], [Description], [Stock], [Price]) VALUES (38, 19, N'Тункави бисквити "Траяна"', N'', 23, 1.6000)
INSERT [dbo].[Products] ([ProductID], [SupplierID], [Name], [Description], [Stock], [Price]) VALUES (39, 19, N'Тункави бисквити "Престиж"', N'', 23, 3.2000)
INSERT [dbo].[Products] ([ProductID], [SupplierID], [Name], [Description], [Stock], [Price]) VALUES (40, 20, N'Вафли "Етър"', N'', 24, 0.4000)
INSERT [dbo].[Products] ([ProductID], [SupplierID], [Name], [Description], [Stock], [Price]) VALUES (41, 20, N'Вафли "Матео"', N'', 24, 0.5000)
INSERT [dbo].[Products] ([ProductID], [SupplierID], [Name], [Description], [Stock], [Price]) VALUES (42, 20, N'Вафли "Чайка"', N'', 23, 2.4000)
INSERT [dbo].[Products] ([ProductID], [SupplierID], [Name], [Description], [Stock], [Price]) VALUES (43, 20, N'Лукум класик', N'', 23, 1.2000)
INSERT [dbo].[Products] ([ProductID], [SupplierID], [Name], [Description], [Stock], [Price]) VALUES (45, 20, N'Локум с орехи и какова глазура', N'', 22, 2.0000)
INSERT [dbo].[Products] ([ProductID], [SupplierID], [Name], [Description], [Stock], [Price]) VALUES (46, 21, N'Вафла "Боровец"', N'', 22, 0.4500)
INSERT [dbo].[Products] ([ProductID], [SupplierID], [Name], [Description], [Stock], [Price]) VALUES (47, 21, N'Вафла "Ден и Нощ"', N'', 24, 0.5000)
INSERT [dbo].[Products] ([ProductID], [SupplierID], [Name], [Description], [Stock], [Price]) VALUES (48, 21, N'Вафла "Milky Wafer"', N'', 22, 0.7000)
INSERT [dbo].[Products] ([ProductID], [SupplierID], [Name], [Description], [Stock], [Price]) VALUES (49, 21, N'Вафла "Choco Wafer"', N'', 24, 0.6000)
INSERT [dbo].[Products] ([ProductID], [SupplierID], [Name], [Description], [Stock], [Price]) VALUES (50, 21, N'Вафла "Yolli"', N'', 22, 0.5500)
SET IDENTITY_INSERT [dbo].[Products] OFF
/****** Object:  Table [dbo].[Sales]    Script Date: 12/13/2012 21:48:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sales](
	[SaleID] [int] IDENTITY(1,1) NOT NULL,
	[UserID] [int] NOT NULL,
	[SaleTimeStamp] [datetime] NOT NULL,
 CONSTRAINT [PK_Sales] PRIMARY KEY CLUSTERED 
(
	[SaleID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Sales] ON
INSERT [dbo].[Sales] ([SaleID], [UserID], [SaleTimeStamp]) VALUES (22, 2, CAST(0x0000A12601642206 AS DateTime))
INSERT [dbo].[Sales] ([SaleID], [UserID], [SaleTimeStamp]) VALUES (23, 2, CAST(0x0000A1260164427E AS DateTime))
INSERT [dbo].[Sales] ([SaleID], [UserID], [SaleTimeStamp]) VALUES (24, 2, CAST(0x0000A126016460B4 AS DateTime))
INSERT [dbo].[Sales] ([SaleID], [UserID], [SaleTimeStamp]) VALUES (25, 2, CAST(0x0000A12601648A5B AS DateTime))
SET IDENTITY_INSERT [dbo].[Sales] OFF
/****** Object:  Table [dbo].[SaleItems]    Script Date: 12/13/2012 21:48:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SaleItems](
	[ItemID] [int] IDENTITY(1,1) NOT NULL,
	[SaleID] [int] NOT NULL,
	[ProductID] [int] NOT NULL,
	[Quantity] [int] NOT NULL,
 CONSTRAINT [PK_SaleItems] PRIMARY KEY CLUSTERED 
(
	[ItemID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[SaleItems] ON
INSERT [dbo].[SaleItems] ([ItemID], [SaleID], [ProductID], [Quantity]) VALUES (21, 22, 31, 2)
INSERT [dbo].[SaleItems] ([ItemID], [SaleID], [ProductID], [Quantity]) VALUES (22, 22, 43, 1)
INSERT [dbo].[SaleItems] ([ItemID], [SaleID], [ProductID], [Quantity]) VALUES (23, 22, 45, 1)
INSERT [dbo].[SaleItems] ([ItemID], [SaleID], [ProductID], [Quantity]) VALUES (24, 23, 46, 2)
INSERT [dbo].[SaleItems] ([ItemID], [SaleID], [ProductID], [Quantity]) VALUES (25, 23, 33, 2)
INSERT [dbo].[SaleItems] ([ItemID], [SaleID], [ProductID], [Quantity]) VALUES (26, 23, 39, 1)
INSERT [dbo].[SaleItems] ([ItemID], [SaleID], [ProductID], [Quantity]) VALUES (27, 24, 31, 1)
INSERT [dbo].[SaleItems] ([ItemID], [SaleID], [ProductID], [Quantity]) VALUES (28, 24, 45, 1)
INSERT [dbo].[SaleItems] ([ItemID], [SaleID], [ProductID], [Quantity]) VALUES (29, 24, 38, 1)
INSERT [dbo].[SaleItems] ([ItemID], [SaleID], [ProductID], [Quantity]) VALUES (30, 24, 36, 1)
INSERT [dbo].[SaleItems] ([ItemID], [SaleID], [ProductID], [Quantity]) VALUES (31, 25, 48, 2)
INSERT [dbo].[SaleItems] ([ItemID], [SaleID], [ProductID], [Quantity]) VALUES (32, 25, 50, 2)
INSERT [dbo].[SaleItems] ([ItemID], [SaleID], [ProductID], [Quantity]) VALUES (33, 25, 37, 2)
INSERT [dbo].[SaleItems] ([ItemID], [SaleID], [ProductID], [Quantity]) VALUES (34, 25, 42, 1)
SET IDENTITY_INSERT [dbo].[SaleItems] OFF
/****** Object:  ForeignKey [FK_Users_Roles]    Script Date: 12/13/2012 21:48:48 ******/
ALTER TABLE [dbo].[Users]  WITH CHECK ADD  CONSTRAINT [FK_Users_Roles] FOREIGN KEY([RoleID])
REFERENCES [dbo].[Roles] ([RoleID])
GO
ALTER TABLE [dbo].[Users] CHECK CONSTRAINT [FK_Users_Roles]
GO
/****** Object:  ForeignKey [FK_Products_Suppliers]    Script Date: 12/13/2012 21:48:48 ******/
ALTER TABLE [dbo].[Products]  WITH CHECK ADD  CONSTRAINT [FK_Products_Suppliers] FOREIGN KEY([SupplierID])
REFERENCES [dbo].[Suppliers] ([SupplierID])
GO
ALTER TABLE [dbo].[Products] CHECK CONSTRAINT [FK_Products_Suppliers]
GO
/****** Object:  ForeignKey [FK_Sales_Users]    Script Date: 12/13/2012 21:48:48 ******/
ALTER TABLE [dbo].[Sales]  WITH CHECK ADD  CONSTRAINT [FK_Sales_Users] FOREIGN KEY([UserID])
REFERENCES [dbo].[Users] ([UserID])
GO
ALTER TABLE [dbo].[Sales] CHECK CONSTRAINT [FK_Sales_Users]
GO
/****** Object:  ForeignKey [FK_SaleItems_Products]    Script Date: 12/13/2012 21:48:48 ******/
ALTER TABLE [dbo].[SaleItems]  WITH CHECK ADD  CONSTRAINT [FK_SaleItems_Products] FOREIGN KEY([ProductID])
REFERENCES [dbo].[Products] ([ProductID])
GO
ALTER TABLE [dbo].[SaleItems] CHECK CONSTRAINT [FK_SaleItems_Products]
GO
/****** Object:  ForeignKey [FK_SaleItems_Sales]    Script Date: 12/13/2012 21:48:48 ******/
ALTER TABLE [dbo].[SaleItems]  WITH CHECK ADD  CONSTRAINT [FK_SaleItems_Sales] FOREIGN KEY([SaleID])
REFERENCES [dbo].[Sales] ([SaleID])
GO
ALTER TABLE [dbo].[SaleItems] CHECK CONSTRAINT [FK_SaleItems_Sales]
GO
