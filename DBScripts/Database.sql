USE [master]
GO

/****** Object:  Database [AP16]    Script Date: 19/05/2017 13:17:08 ******/
CREATE DATABASE [AP16]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'AP16', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\AP16.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'AP16_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\AP16_log.ldf' , SIZE = 2048KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO

ALTER DATABASE [AP16] SET COMPATIBILITY_LEVEL = 100
GO

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [AP16].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO

ALTER DATABASE [AP16] SET ANSI_NULL_DEFAULT OFF 
GO

ALTER DATABASE [AP16] SET ANSI_NULLS OFF 
GO

ALTER DATABASE [AP16] SET ANSI_PADDING OFF 
GO

ALTER DATABASE [AP16] SET ANSI_WARNINGS OFF 
GO

ALTER DATABASE [AP16] SET ARITHABORT OFF 
GO

ALTER DATABASE [AP16] SET AUTO_CLOSE OFF 
GO

ALTER DATABASE [AP16] SET AUTO_SHRINK OFF 
GO

ALTER DATABASE [AP16] SET AUTO_UPDATE_STATISTICS ON 
GO

ALTER DATABASE [AP16] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO

ALTER DATABASE [AP16] SET CURSOR_DEFAULT  GLOBAL 
GO

ALTER DATABASE [AP16] SET CONCAT_NULL_YIELDS_NULL OFF 
GO

ALTER DATABASE [AP16] SET NUMERIC_ROUNDABORT OFF 
GO

ALTER DATABASE [AP16] SET QUOTED_IDENTIFIER OFF 
GO

ALTER DATABASE [AP16] SET RECURSIVE_TRIGGERS OFF 
GO

ALTER DATABASE [AP16] SET  DISABLE_BROKER 
GO

ALTER DATABASE [AP16] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO

ALTER DATABASE [AP16] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO

ALTER DATABASE [AP16] SET TRUSTWORTHY OFF 
GO

ALTER DATABASE [AP16] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO

ALTER DATABASE [AP16] SET PARAMETERIZATION SIMPLE 
GO

ALTER DATABASE [AP16] SET READ_COMMITTED_SNAPSHOT OFF 
GO

ALTER DATABASE [AP16] SET HONOR_BROKER_PRIORITY OFF 
GO

ALTER DATABASE [AP16] SET RECOVERY SIMPLE 
GO

ALTER DATABASE [AP16] SET  MULTI_USER 
GO

ALTER DATABASE [AP16] SET PAGE_VERIFY CHECKSUM  
GO

ALTER DATABASE [AP16] SET DB_CHAINING OFF 
GO

ALTER DATABASE [AP16] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO

ALTER DATABASE [AP16] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO

ALTER DATABASE [AP16] SET DELAYED_DURABILITY = DISABLED 
GO

ALTER DATABASE [AP16] SET  READ_WRITE 
GO

