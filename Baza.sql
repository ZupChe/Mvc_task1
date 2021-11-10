USE [master]
GO
/****** Object:  Database [mvc_task1]    Script Date: 10.11.2021 7:36:36 PM ******/
CREATE DATABASE [mvc_task1]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'mvc_task1', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRES\MSSQL\DATA\mvc_task1.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'mvc_task1_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRES\MSSQL\DATA\mvc_task1_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [mvc_task1] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [mvc_task1].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [mvc_task1] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [mvc_task1] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [mvc_task1] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [mvc_task1] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [mvc_task1] SET ARITHABORT OFF 
GO
ALTER DATABASE [mvc_task1] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [mvc_task1] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [mvc_task1] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [mvc_task1] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [mvc_task1] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [mvc_task1] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [mvc_task1] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [mvc_task1] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [mvc_task1] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [mvc_task1] SET  DISABLE_BROKER 
GO
ALTER DATABASE [mvc_task1] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [mvc_task1] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [mvc_task1] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [mvc_task1] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [mvc_task1] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [mvc_task1] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [mvc_task1] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [mvc_task1] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [mvc_task1] SET  MULTI_USER 
GO
ALTER DATABASE [mvc_task1] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [mvc_task1] SET DB_CHAINING OFF 
GO
ALTER DATABASE [mvc_task1] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [mvc_task1] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [mvc_task1] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [mvc_task1] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [mvc_task1] SET QUERY_STORE = OFF
GO
USE [mvc_task1]
GO
/****** Object:  Table [dbo].[Automobil]    Script Date: 10.11.2021 7:36:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Automobil](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[marka] [nvarchar](50) NOT NULL,
	[model] [nvarchar](50) NOT NULL,
	[zapremina_motora] [int] NOT NULL,
	[snaga] [int] NOT NULL,
	[gorivo] [nvarchar](50) NOT NULL,
	[karoserija] [nvarchar](50) NOT NULL,
	[foto] [varchar](max) NULL,
	[opis] [nvarchar](150) NOT NULL,
	[cena] [float] NOT NULL,
	[kontakt] [nvarchar](50) NOT NULL,
	[is_deleted] [int] NULL,
	[godiste] [int] NOT NULL,
 CONSTRAINT [PK__Automobi__3213E83FF5B91C30] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Automobil] ON 

INSERT [dbo].[Automobil] ([id], [marka], [model], [zapremina_motora], [snaga], [gorivo], [karoserija], [foto], [opis], [cena], [kontakt], [is_deleted], [godiste]) VALUES (1, N'BMW', N'X3', 1600, 125, N'benzin', N'SUV', N'~/images/BMWX.jpeg', N'Dodatna Hi Fi oprema', 14500, N'mvccar@car.org', NULL, 2020)
INSERT [dbo].[Automobil] ([id], [marka], [model], [zapremina_motora], [snaga], [gorivo], [karoserija], [foto], [opis], [cena], [kontakt], [is_deleted], [godiste]) VALUES (3, N'Kia', N'Stonic', 1600, 85, N'dizel', N'hatchback', N'~/images/KiaStonic.jpeg', N'Dodatna zimska oprema', 18000, N'kiacar@autoogl.com', NULL, 2019)
INSERT [dbo].[Automobil] ([id], [marka], [model], [zapremina_motora], [snaga], [gorivo], [karoserija], [foto], [opis], [cena], [kontakt], [is_deleted], [godiste]) VALUES (4, N'Kia', N'Sportage', 1600, 125, N'benzin', N'SUV', N'~/images/KiaSportage.jpeg', N'Dodatna zimska oprema', 21250, N'kiacar@autoogl.com', NULL, 2021)
INSERT [dbo].[Automobil] ([id], [marka], [model], [zapremina_motora], [snaga], [gorivo], [karoserija], [foto], [opis], [cena], [kontakt], [is_deleted], [godiste]) VALUES (6, N'Ford', N'Focus', 1500, 150, N'benzin', N'hatchback', N'~/images/FordFocus.jpeg', N'Dodatna zimska oprema', 6000, N'salemax@open.com', NULL, 2011)
INSERT [dbo].[Automobil] ([id], [marka], [model], [zapremina_motora], [snaga], [gorivo], [karoserija], [foto], [opis], [cena], [kontakt], [is_deleted], [godiste]) VALUES (7, N'Golf', N'5', 1400, 85, N'dizel', N'hatchback', NULL, N'U odlicnom stanju.', 9000, N'golf@gollf5.org', NULL, 2011)
INSERT [dbo].[Automobil] ([id], [marka], [model], [zapremina_motora], [snaga], [gorivo], [karoserija], [foto], [opis], [cena], [kontakt], [is_deleted], [godiste]) VALUES (8, N'Volvo', N'XC60', 2000, 180, N'dizel', N'SUV', N'~/images/Volvo.jpeg', N'Dodatna Hi Fi oprema', 9500, N'pelevolvo@volvo.com', NULL, 2011)
INSERT [dbo].[Automobil] ([id], [marka], [model], [zapremina_motora], [snaga], [gorivo], [karoserija], [foto], [opis], [cena], [kontakt], [is_deleted], [godiste]) VALUES (9, N'Toyota', N'Cross Yaris', 2000, 160, N'hybrid', N'SUV', N'~/images/day-exterior-4_040.png', N'Dodatna zimska oprema', 23000, N'cakitoyota@toyota.com', NULL, 2021)
SET IDENTITY_INSERT [dbo].[Automobil] OFF
GO
USE [master]
GO
ALTER DATABASE [mvc_task1] SET  READ_WRITE 
GO
