/*==========================================================================

Sistema......: SampleXP
Desenvolvedor: Fernando Roberto Fernández
Referência...: Banco de Dados

==========================================================================*/

Use SampleXP;

Go

/*========================================================================*/

Alter Database SampleXP
Add FileGroup SampleXP_FG_Pessoas

Go

Alter Database SampleXP
Add File
( NAME = N'SampleXP_FG_Pessoas_01_ndf', FILENAME = N'D:\BancosDados\SQLServer\SampleXP\SampleXP_FG_Pessoas_01.ndf' , SIZE = 3072KB , FILEGROWTH = 102400KB )
To FileGroup SampleXP_FG_Pessoas

Go

/*========================================================================*/

Create Schema Pessoas
Authorization dbo;

Go

Alter Authorization On Schema::[Pessoas] To [SampleXP];

Go

/*========================================================================*/
