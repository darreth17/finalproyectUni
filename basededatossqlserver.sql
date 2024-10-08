USE [master]
GO
/****** Object:  Database [proyectofinal]    Script Date: 5/12/2022 16:18:55 ******/
CREATE DATABASE [proyectofinal]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'proyectofinal', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\proyectofinal.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'proyectofinal_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\proyectofinal_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [proyectofinal] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [proyectofinal].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [proyectofinal] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [proyectofinal] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [proyectofinal] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [proyectofinal] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [proyectofinal] SET ARITHABORT OFF 
GO
ALTER DATABASE [proyectofinal] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [proyectofinal] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [proyectofinal] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [proyectofinal] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [proyectofinal] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [proyectofinal] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [proyectofinal] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [proyectofinal] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [proyectofinal] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [proyectofinal] SET  DISABLE_BROKER 
GO
ALTER DATABASE [proyectofinal] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [proyectofinal] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [proyectofinal] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [proyectofinal] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [proyectofinal] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [proyectofinal] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [proyectofinal] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [proyectofinal] SET RECOVERY FULL 
GO
ALTER DATABASE [proyectofinal] SET  MULTI_USER 
GO
ALTER DATABASE [proyectofinal] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [proyectofinal] SET DB_CHAINING OFF 
GO
ALTER DATABASE [proyectofinal] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [proyectofinal] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [proyectofinal] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [proyectofinal] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'proyectofinal', N'ON'
GO
ALTER DATABASE [proyectofinal] SET QUERY_STORE = OFF
GO
USE [proyectofinal]
GO
/****** Object:  Table [dbo].[cliente]    Script Date: 5/12/2022 16:18:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[cliente](
	[nombre] [nvarchar](50) NOT NULL,
	[apellidos] [nvarchar](50) NOT NULL,
	[identificacion] [nvarchar](50) NOT NULL,
	[correoelectronico] [nvarchar](50) NOT NULL,
	[direccion] [nvarchar](50) NOT NULL,
	[numerodetelefono] [nvarchar](50) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[inventario]    Script Date: 5/12/2022 16:18:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[inventario](
	[codigo] [nvarchar](50) NOT NULL,
	[nombredelarticulo] [nvarchar](50) NOT NULL,
	[existencia] [nvarchar](50) NOT NULL,
	[preciounitario] [nvarchar](50) NOT NULL,
	[descripcion] [nvarchar](50) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[usuario]    Script Date: 5/12/2022 16:18:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[usuario](
	[idusuario] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[email] [varchar](50) NOT NULL,
	[usuario] [varchar](50) NOT NULL,
	[contrasena] [nvarchar](50) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[venta]    Script Date: 5/12/2022 16:18:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[venta](
	[idfactura] [int] IDENTITY(1,1) NOT NULL,
	[indecliente] [nvarchar](50) NOT NULL,
	[nombrecliente] [nvarchar](50) NOT NULL,
	[codigoproducto] [nvarchar](50) NOT NULL,
	[producto] [nvarchar](50) NOT NULL,
	[cantidadavender] [nvarchar](50) NOT NULL,
	[total] [nvarchar](50) NOT NULL
) ON [PRIMARY]
GO
USE [master]
GO
ALTER DATABASE [proyectofinal] SET  READ_WRITE 
GO
