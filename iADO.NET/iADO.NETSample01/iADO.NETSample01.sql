USE [master]
GO
/****** Object:  Database [iADO.NETSample01]    Script Date: 4/3/2022 12:35:22 PM ******/
CREATE DATABASE [iADO.NETSample01]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'iADO.NETSample01', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\iADO.NETSample01.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'iADO.NETSample01_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\iADO.NETSample01_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [iADO.NETSample01] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [iADO.NETSample01].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [iADO.NETSample01] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [iADO.NETSample01] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [iADO.NETSample01] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [iADO.NETSample01] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [iADO.NETSample01] SET ARITHABORT OFF 
GO
ALTER DATABASE [iADO.NETSample01] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [iADO.NETSample01] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [iADO.NETSample01] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [iADO.NETSample01] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [iADO.NETSample01] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [iADO.NETSample01] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [iADO.NETSample01] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [iADO.NETSample01] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [iADO.NETSample01] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [iADO.NETSample01] SET  DISABLE_BROKER 
GO
ALTER DATABASE [iADO.NETSample01] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [iADO.NETSample01] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [iADO.NETSample01] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [iADO.NETSample01] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [iADO.NETSample01] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [iADO.NETSample01] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [iADO.NETSample01] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [iADO.NETSample01] SET RECOVERY FULL 
GO
ALTER DATABASE [iADO.NETSample01] SET  MULTI_USER 
GO
ALTER DATABASE [iADO.NETSample01] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [iADO.NETSample01] SET DB_CHAINING OFF 
GO
ALTER DATABASE [iADO.NETSample01] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [iADO.NETSample01] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [iADO.NETSample01] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [iADO.NETSample01] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'iADO.NETSample01', N'ON'
GO
ALTER DATABASE [iADO.NETSample01] SET QUERY_STORE = OFF
GO
USE [iADO.NETSample01]
GO
/****** Object:  Table [dbo].[Categories]    Script Date: 4/3/2022 12:35:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categories](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CategoryName] [nvarchar](50) NULL,
 CONSTRAINT [PK_Categories] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OrderLines]    Script Date: 4/3/2022 12:35:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrderLines](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[OrderId] [int] NULL,
	[ProductId] [int] NULL,
	[Price] [int] NULL,
	[Count] [int] NULL,
 CONSTRAINT [PK_OrderLines] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Orders]    Script Date: 4/3/2022 12:35:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Orders](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CustomerName] [nvarchar](50) NULL,
	[OrdarDate] [datetime] NULL,
 CONSTRAINT [PK_Orders] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Products]    Script Date: 4/3/2022 12:35:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Products](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CategoryId] [int] NULL,
	[ProductName] [nvarchar](50) NULL,
	[Price] [int] NULL,
 CONSTRAINT [PK_Products] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[OrderLines]  WITH CHECK ADD  CONSTRAINT [FK_OrderLines_Orders] FOREIGN KEY([OrderId])
REFERENCES [dbo].[Orders] ([Id])
GO
ALTER TABLE [dbo].[OrderLines] CHECK CONSTRAINT [FK_OrderLines_Orders]
GO
ALTER TABLE [dbo].[OrderLines]  WITH CHECK ADD  CONSTRAINT [FK_OrderLines_Products] FOREIGN KEY([ProductId])
REFERENCES [dbo].[Products] ([Id])
GO
ALTER TABLE [dbo].[OrderLines] CHECK CONSTRAINT [FK_OrderLines_Products]
GO
ALTER TABLE [dbo].[Products]  WITH CHECK ADD  CONSTRAINT [FK_Products_Products] FOREIGN KEY([CategoryId])
REFERENCES [dbo].[Categories] ([Id])
GO
ALTER TABLE [dbo].[Products] CHECK CONSTRAINT [FK_Products_Products]
GO
USE [master]
GO
ALTER DATABASE [iADO.NETSample01] SET  READ_WRITE 
GO
