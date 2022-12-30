/*========================================================================*/

USE [master]
GO
DROP LOGIN [SampleXP]
GO

/*========================================================================*/

CREATE DATABASE [SampleXP] ON  PRIMARY 

( NAME = N'SampleXP_01_mdf', FILENAME = N'D:\Database\SQLServer\SampleXP\SampleXP_Row_01.mdf' , SIZE = 5MB , FILEGROWTH = 5MB ),
FileGroup SampleXP_FG_System
( NAME = N'SampleXP_FG_System_01_ndf', FILENAME = N'D:\Database\SQLServer\SampleXP\SampleXP_FG_System_01.ndf' , SIZE = 3072KB , FILEGROWTH = 102400KB )
 LOG ON 
( NAME = N'SampleXP_01_log', FILENAME = N'D:\Database\SQLServer\SampleXP\SampleXP_Log_01.ldf' , SIZE = 5MB , FILEGROWTH = 5MB)
GO
ALTER DATABASE [SampleXP] SET COMPATIBILITY_LEVEL = 100
GO
ALTER DATABASE [SampleXP] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [SampleXP] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [SampleXP] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [SampleXP] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [SampleXP] SET ARITHABORT OFF 
GO
ALTER DATABASE [SampleXP] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [SampleXP] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [SampleXP] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [SampleXP] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [SampleXP] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [SampleXP] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [SampleXP] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [SampleXP] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [SampleXP] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [SampleXP] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [SampleXP] SET  DISABLE_BROKER 
GO
ALTER DATABASE [SampleXP] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [SampleXP] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [SampleXP] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [SampleXP] SET  READ_WRITE 
GO
ALTER DATABASE [SampleXP] SET RECOVERY FULL 
GO
ALTER DATABASE [SampleXP] SET  MULTI_USER 
GO
ALTER DATABASE [SampleXP] SET PAGE_VERIFY CHECKSUM  
GO
USE [SampleXP]
GO
IF NOT EXISTS (SELECT name FROM sys.filegroups WHERE is_default=1 AND name = N'PRIMARY') ALTER DATABASE [SampleXP] MODIFY FILEGROUP [PRIMARY] DEFAULT
GO

/*========================================================================*/

USE [master]
GO
CREATE LOGIN [SampleXP] WITH PASSWORD=N'SampleXP', DEFAULT_DATABASE=[SampleXP], DEFAULT_LANGUAGE=[Português], CHECK_EXPIRATION=OFF, CHECK_POLICY=OFF
GO
EXEC master..sp_addsrvrolemember @loginame = N'SampleXP', @rolename = N'bulkadmin'
GO
EXEC master..sp_addsrvrolemember @loginame = N'SampleXP', @rolename = N'dbcreator'
GO
EXEC master..sp_addsrvrolemember @loginame = N'SampleXP', @rolename = N'diskadmin'
GO
EXEC master..sp_addsrvrolemember @loginame = N'SampleXP', @rolename = N'processadmin'
GO
EXEC master..sp_addsrvrolemember @loginame = N'SampleXP', @rolename = N'securityadmin'
GO
EXEC master..sp_addsrvrolemember @loginame = N'SampleXP', @rolename = N'serveradmin'
GO
EXEC master..sp_addsrvrolemember @loginame = N'SampleXP', @rolename = N'setupadmin'
GO
EXEC master..sp_addsrvrolemember @loginame = N'SampleXP', @rolename = N'sysadmin'
GO
USE [SampleXP]
GO
CREATE USER [SampleXP] FOR LOGIN [SampleXP]
GO
USE [SampleXP]
GO
EXEC sp_addrolemember N'db_accessadmin', N'SampleXP'
GO
USE [SampleXP]
GO
EXEC sp_addrolemember N'db_backupoperator', N'SampleXP'
GO
USE [SampleXP]
GO
EXEC sp_addrolemember N'db_datareader', N'SampleXP'
GO
USE [SampleXP]
GO
EXEC sp_addrolemember N'db_datawriter', N'SampleXP'
GO
USE [SampleXP]
GO
EXEC sp_addrolemember N'db_ddladmin', N'SampleXP'
GO
USE [SampleXP]
GO
EXEC sp_addrolemember N'db_owner', N'SampleXP'
GO
USE [SampleXP]
GO
EXEC sp_addrolemember N'db_securityadmin', N'SampleXP'
GO

/*========================================================================*/

Use SampleXP;

Go

/*==========================================================================

File Groups

==========================================================================*/

Alter Database SampleXP
Add FileGroup SampleXP_FG_Index

Go

Alter Database SampleXP
Add File
( NAME = N'SampleXP_FG_Index_01_ndf', FILENAME = N'D:\Database\SQLServer\SampleXP\SampleXP_FG_Index_01.ndf' , SIZE = 3072KB , FILEGROWTH = 102400KB )
To FileGroup SampleXP_FG_Index

Go

Alter Database SampleXP
Add FileGroup SampleXP_FG_Calendar

Go

/*==========================================================================

Schemas

==========================================================================*/

Create Schema System
Authorization dbo;

Go

Alter Authorization On Schema::[System] To [SampleXP];

Go

/*========================================================================*/

Create Schema Calendar
Authorization dbo;

Go

Alter Authorization On Schema::[Calendar] To [SampleXP];

Go

/*========================================================================*/