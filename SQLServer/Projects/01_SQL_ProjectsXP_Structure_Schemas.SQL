/*========================================================================*/

USE [master]
GO
DROP LOGIN [<Project>]
GO

/*========================================================================*/

CREATE DATABASE [<Project>] ON  PRIMARY 

( NAME = N'<Project>_01_mdf', FILENAME = N'D:\Database\SQLServer\<Project>\<Project>_Row_01.mdf' , SIZE = 5MB , FILEGROWTH = 5MB )
ALTER DATABASE [<Project>] SET COMPATIBILITY_LEVEL = 100
GO
ALTER DATABASE [<Project>] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [<Project>] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [<Project>] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [<Project>] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [<Project>] SET ARITHABORT OFF 
GO
ALTER DATABASE [<Project>] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [<Project>] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [<Project>] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [<Project>] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [<Project>] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [<Project>] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [<Project>] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [<Project>] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [<Project>] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [<Project>] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [<Project>] SET DISABLE_BROKER 
GO
ALTER DATABASE [<Project>] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [<Project>] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [<Project>] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [<Project>] SET READ_WRITE 
GO
ALTER DATABASE [<Project>] SET RECOVERY FULL 
GO
ALTER DATABASE [<Project>] SET MULTI_USER 
GO
ALTER DATABASE [<Project>] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE SCOPED CONFIGURATION SET IDENTITY_CACHE = OFF
GO
USE [<Project>]
GO
IF NOT EXISTS (SELECT name
               FROM sys.filegroups
               WHERE is_default=1
                 AND name = N'PRIMARY')
  ALTER DATABASE [<Project>] MODIFY FILEGROUP [PRIMARY] DEFAULT
GO

/*========================================================================*/

USE [master]
GO
CREATE LOGIN [<Project>] WITH PASSWORD=N'<Project>',
DEFAULT_DATABASE=[<Project>],
DEFAULT_LANGUAGE=[Português],
CHECK_EXPIRATION=OFF,
CHECK_POLICY=OFF
GO
EXEC master..sp_addsrvrolemember @loginame = N'<Project>', @rolename = N'bulkadmin'
GO
EXEC master..sp_addsrvrolemember @loginame = N'<Project>', @rolename = N'dbcreator'
GO
EXEC master..sp_addsrvrolemember @loginame = N'<Project>', @rolename = N'diskadmin'
GO
EXEC master..sp_addsrvrolemember @loginame = N'<Project>', @rolename = N'processadmin'
GO
EXEC master..sp_addsrvrolemember @loginame = N'<Project>', @rolename = N'securityadmin'
GO
EXEC master..sp_addsrvrolemember @loginame = N'<Project>', @rolename = N'serveradmin'
GO
EXEC master..sp_addsrvrolemember @loginame = N'<Project>', @rolename = N'setupadmin'
GO
EXEC master..sp_addsrvrolemember @loginame = N'<Project>', @rolename = N'sysadmin'
GO
USE [<Project>]
GO
CREATE USER [<Project>] FOR LOGIN [<Project>]
GO
USE [<Project>]
GO
EXEC sp_addrolemember N'db_accessadmin', N'<Project>'
GO
USE [<Project>]
GO
EXEC sp_addrolemember N'db_backupoperator', N'<Project>'
GO
USE [<Project>]
GO
EXEC sp_addrolemember N'db_datareader', N'<Project>'
GO
USE [<Project>]
GO
EXEC sp_addrolemember N'db_datawriter', N'<Project>'
GO
USE [<Project>]
GO
EXEC sp_addrolemember N'db_ddladmin', N'<Project>'
GO
USE [<Project>]
GO
EXEC sp_addrolemember N'db_owner', N'<Project>'
GO
USE [<Project>]
GO
EXEC sp_addrolemember N'db_securityadmin', N'<Project>'
GO

/*========================================================================*/
