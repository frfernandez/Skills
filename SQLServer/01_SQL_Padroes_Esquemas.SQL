/*==========================================================================

Padroes.MDF
Padroes.NDF
Padroes.LDF
	Sistema: Padroes
	Desenvolvedor: Fernando Roberto Fernández

==========================================================================*/

USE [master]
GO
DROP LOGIN [Padroes]
GO

/*========================================================================*/

CREATE DATABASE [Padroes] ON  PRIMARY 

( NAME = N'Padroes_01_mdf', FILENAME = N'C:\BancosDados\SQLServer\Padroes\Padroes_Row_01.mdf' , SIZE = 5MB , FILEGROWTH = 5MB )
 LOG ON 
( NAME = N'Padroes_01_log', FILENAME = N'C:\BancosDados\SQLServer\Padroes\Padroes_Log_01.ldf' , SIZE = 5MB , FILEGROWTH = 5MB)
GO
ALTER DATABASE [Padroes] SET COMPATIBILITY_LEVEL = 100
GO
ALTER DATABASE [Padroes] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Padroes] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Padroes] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Padroes] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Padroes] SET ARITHABORT OFF 
GO
ALTER DATABASE [Padroes] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Padroes] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [Padroes] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Padroes] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Padroes] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Padroes] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Padroes] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Padroes] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Padroes] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Padroes] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Padroes] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Padroes] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Padroes] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Padroes] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Padroes] SET  READ_WRITE 
GO
ALTER DATABASE [Padroes] SET RECOVERY FULL 
GO
ALTER DATABASE [Padroes] SET  MULTI_USER 
GO
ALTER DATABASE [Padroes] SET PAGE_VERIFY CHECKSUM  
GO
USE [Padroes]
GO
IF NOT EXISTS (SELECT name FROM sys.filegroups WHERE is_default=1 AND name = N'PRIMARY') ALTER DATABASE [Padroes] MODIFY FILEGROUP [PRIMARY] DEFAULT
GO

/*========================================================================*/

USE [master]
GO
CREATE LOGIN [Padroes] WITH PASSWORD=N'Padroes', DEFAULT_DATABASE=[Padroes], DEFAULT_LANGUAGE=[Português], CHECK_EXPIRATION=OFF, CHECK_POLICY=OFF
GO
EXEC master..sp_addsrvrolemember @loginame = N'Padroes', @rolename = N'bulkadmin'
GO
EXEC master..sp_addsrvrolemember @loginame = N'Padroes', @rolename = N'dbcreator'
GO
EXEC master..sp_addsrvrolemember @loginame = N'Padroes', @rolename = N'diskadmin'
GO
EXEC master..sp_addsrvrolemember @loginame = N'Padroes', @rolename = N'processadmin'
GO
EXEC master..sp_addsrvrolemember @loginame = N'Padroes', @rolename = N'securityadmin'
GO
EXEC master..sp_addsrvrolemember @loginame = N'Padroes', @rolename = N'serveradmin'
GO
EXEC master..sp_addsrvrolemember @loginame = N'Padroes', @rolename = N'setupadmin'
GO
EXEC master..sp_addsrvrolemember @loginame = N'Padroes', @rolename = N'sysadmin'
GO
USE [Padroes]
GO
CREATE USER [Padroes] FOR LOGIN [Padroes]
GO
USE [Padroes]
GO
EXEC sp_addrolemember N'db_accessadmin', N'Padroes'
GO
USE [Padroes]
GO
EXEC sp_addrolemember N'db_backupoperator', N'Padroes'
GO
USE [Padroes]
GO
EXEC sp_addrolemember N'db_datareader', N'Padroes'
GO
USE [Padroes]
GO
EXEC sp_addrolemember N'db_datawriter', N'Padroes'
GO
USE [Padroes]
GO
EXEC sp_addrolemember N'db_ddladmin', N'Padroes'
GO
USE [Padroes]
GO
EXEC sp_addrolemember N'db_owner', N'Padroes'
GO
USE [Padroes]
GO
EXEC sp_addrolemember N'db_securityadmin', N'Padroes'
GO

/*========================================================================*/
