/*==========================================================================

Space_Platform.MDF
Space_Platform.NDF
Space_Platform.LDF
	System: Space_Platform
	Developer: Fernando Roberto Fernández

==========================================================================*/

USE [master]
GO
DROP LOGIN [Space_Platform]
GO

/*========================================================================*/

CREATE DATABASE [Space_Platform] ON  PRIMARY 

( NAME = N'Space_Platform_01_mdf', FILENAME = N'C:\BancosDados\SQLServer\Space_Platform\Space_Platform_Row_01.mdf' , SIZE = 5MB , FILEGROWTH = 5MB ),
FileGroup Space_Platform_FG_Documents
( NAME = N'Space_Platform_FG_Documents_01_ndf', FILENAME = N'C:\BancosDados\SQLServer\Space_Platform\Space_Platform_FG_Documents_01.ndf' , SIZE = 3072KB , FILEGROWTH = 102400KB )

 LOG ON 
( NAME = N'Space_Platform_01_log', FILENAME = N'C:\BancosDados\SQLServer\Space_Platform\Space_Platform_Log_01.ldf' , SIZE = 5MB , FILEGROWTH = 5MB)
GO
ALTER DATABASE [Space_Platform] SET COMPATIBILITY_LEVEL = 100
GO
ALTER DATABASE [Space_Platform] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Space_Platform] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Space_Platform] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Space_Platform] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Space_Platform] SET ARITHABORT OFF 
GO
ALTER DATABASE [Space_Platform] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Space_Platform] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [Space_Platform] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Space_Platform] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Space_Platform] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Space_Platform] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Space_Platform] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Space_Platform] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Space_Platform] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Space_Platform] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Space_Platform] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Space_Platform] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Space_Platform] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Space_Platform] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Space_Platform] SET  READ_WRITE 
GO
ALTER DATABASE [Space_Platform] SET RECOVERY FULL 
GO
ALTER DATABASE [Space_Platform] SET  MULTI_USER 
GO
ALTER DATABASE [Space_Platform] SET PAGE_VERIFY CHECKSUM  
GO
USE [Space_Platform]
GO
IF NOT EXISTS (SELECT name FROM sys.filegroups WHERE is_default=1 AND name = N'PRIMARY') ALTER DATABASE [Space_Platform] MODIFY FILEGROUP [PRIMARY] DEFAULT
GO

/*========================================================================*/

USE [master]
GO
CREATE LOGIN [Space_Platform] WITH PASSWORD=N'Space_Platform', DEFAULT_DATABASE=[Space_Platform], DEFAULT_LANGUAGE=[Português], CHECK_EXPIRATION=OFF, CHECK_POLICY=OFF
GO
EXEC master..sp_addsrvrolemember @loginame = N'Space_Platform', @rolename = N'bulkadmin'
GO
EXEC master..sp_addsrvrolemember @loginame = N'Space_Platform', @rolename = N'dbcreator'
GO
EXEC master..sp_addsrvrolemember @loginame = N'Space_Platform', @rolename = N'diskadmin'
GO
EXEC master..sp_addsrvrolemember @loginame = N'Space_Platform', @rolename = N'processadmin'
GO
EXEC master..sp_addsrvrolemember @loginame = N'Space_Platform', @rolename = N'securityadmin'
GO
EXEC master..sp_addsrvrolemember @loginame = N'Space_Platform', @rolename = N'serveradmin'
GO
EXEC master..sp_addsrvrolemember @loginame = N'Space_Platform', @rolename = N'setupadmin'
GO
EXEC master..sp_addsrvrolemember @loginame = N'Space_Platform', @rolename = N'sysadmin'
GO
USE [Space_Platform]
GO
CREATE USER [Space_Platform] FOR LOGIN [Space_Platform]
GO
USE [Space_Platform]
GO
EXEC sp_addrolemember N'db_accessadmin', N'Space_Platform'
GO
USE [Space_Platform]
GO
EXEC sp_addrolemember N'db_backupoperator', N'Space_Platform'
GO
USE [Space_Platform]
GO
EXEC sp_addrolemember N'db_datareader', N'Space_Platform'
GO
USE [Space_Platform]
GO
EXEC sp_addrolemember N'db_datawriter', N'Space_Platform'
GO
USE [Space_Platform]
GO
EXEC sp_addrolemember N'db_ddladmin', N'Space_Platform'
GO
USE [Space_Platform]
GO
EXEC sp_addrolemember N'db_owner', N'Space_Platform'
GO
USE [Space_Platform]
GO
EXEC sp_addrolemember N'db_securityadmin', N'Space_Platform'
GO

/*========================================================================*/

Use Space_Platform;

Go

/*==========================================================================

File Groups

==========================================================================*/

Alter Database Space_Platform
Add FileGroup Space_Platform_FG_Indexes

Go

Alter Database Space_Platform
Add File
( NAME = N'Space_Platform_FG_Indexes_01_ndf', FILENAME = N'C:\BancosDados\SQLServer\Space_Platform\Space_Platform_FG_Indexes_01.ndf' , SIZE = 3072KB , FILEGROWTH = 102400KB )
To FileGroup Space_Platform_FG_Indexes

Go

Alter Database Space_Platform
Add FileGroup Space_Platform_FG_Map

Go

Alter Database Space_Platform
Add File
( NAME = N'Space_Platform_FG_Map_01_ndf', FILENAME = N'C:\BancosDados\SQLServer\Space_Platform\Space_Platform_FG_Map_01.ndf' , SIZE = 3072KB , FILEGROWTH = 102400KB )
To FileGroup Space_Platform_FG_Map

Go

Alter Database Space_Platform
Add FileGroup Space_Platform_FG_Contracts

Go

Alter Database Space_Platform
Add File
( NAME = N'Space_Platform_FG_Contracts_01_ndf', FILENAME = N'C:\BancosDados\SQLServer\Space_Platform\Space_Platform_FG_Contracts_01.ndf' , SIZE = 3072KB , FILEGROWTH = 102400KB )
To FileGroup Space_Platform_FG_Contracts

Go

/*==========================================================================

Schemas

==========================================================================*/

Create Schema Map
Authorization dbo;

Go

Alter Authorization On Schema::[Map] To [Space_Platform];

Go

/*========================================================================*/

Create Schema Documents
Authorization dbo;

Go

Alter Authorization On Schema::[Documents] To [Space_Platform];

Go

/*========================================================================*/

Create Schema Contracts
Authorization dbo;

Go

Alter Authorization On Schema::[Contracts] To [Space_Platform];

Go

/*========================================================================*/
