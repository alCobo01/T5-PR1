USE [master]
GO
/****** Object:  Database [DbContext]    Script Date: 27/03/2025 23:09:34 ******/
CREATE DATABASE [DbContext]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'DbContext', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\DbContext.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'DbContext_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\DbContext_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [DbContext] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [DbContext].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [DbContext] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [DbContext] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [DbContext] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [DbContext] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [DbContext] SET ARITHABORT OFF 
GO
ALTER DATABASE [DbContext] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [DbContext] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [DbContext] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [DbContext] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [DbContext] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [DbContext] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [DbContext] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [DbContext] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [DbContext] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [DbContext] SET  ENABLE_BROKER 
GO
ALTER DATABASE [DbContext] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [DbContext] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [DbContext] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [DbContext] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [DbContext] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [DbContext] SET READ_COMMITTED_SNAPSHOT ON 
GO
ALTER DATABASE [DbContext] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [DbContext] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [DbContext] SET  MULTI_USER 
GO
ALTER DATABASE [DbContext] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [DbContext] SET DB_CHAINING OFF 
GO
ALTER DATABASE [DbContext] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [DbContext] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [DbContext] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [DbContext] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [DbContext] SET QUERY_STORE = ON
GO
ALTER DATABASE [DbContext] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [DbContext]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 27/03/2025 23:09:35 ******/
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
/****** Object:  Table [dbo].[ConsumsAigua]    Script Date: 27/03/2025 23:09:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ConsumsAigua](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Any] [int] NOT NULL,
	[Comarca] [nvarchar](max) NOT NULL,
	[Poblacio] [nvarchar](max) NOT NULL,
	[ConsumDomesticPerCapita] [float] NOT NULL,
 CONSTRAINT [PK_ConsumsAigua] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[IndicadorsEnergetics]    Script Date: 27/03/2025 23:09:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[IndicadorsEnergetics](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Data] [datetime2](7) NOT NULL,
	[CDEEBC_ProdNeta] [float] NOT NULL,
	[CDEEBC_ProdDisp] [float] NOT NULL,
	[CDEEBC_DemandaElectr] [float] NOT NULL,
	[CCAC_GasolinaAuto] [float] NOT NULL,
 CONSTRAINT [PK_IndicadorsEnergetics] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Simulacions]    Script Date: 27/03/2025 23:09:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Simulacions](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Tipus] [int] NULL,
	[Data] [datetime2](7) NOT NULL,
	[Dada] [float] NOT NULL,
	[Rati] [float] NOT NULL,
	[Cost] [float] NOT NULL,
	[Preu] [float] NOT NULL,
	[EnergiaGenerada] [float] NOT NULL,
	[Benefici] [float] NOT NULL,
 CONSTRAINT [PK_Simulacions] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
USE [master]
GO
ALTER DATABASE [DbContext] SET  READ_WRITE 
GO
