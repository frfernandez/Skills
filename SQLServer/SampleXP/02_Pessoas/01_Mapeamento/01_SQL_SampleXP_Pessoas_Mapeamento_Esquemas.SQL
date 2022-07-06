/*==========================================================================

Sistema......: SampleXP
Desenvolvedor: Fernando Roberto Fernández
Referência...: Banco de Dados

==========================================================================*/

Use SampleXP;

Go

/*========================================================================*/

Alter Database SampleXP
Add FileGroup SampleXP_FG_Mapeamento

Go

Alter Database SampleXP
Add File
( NAME = N'SampleXP_FG_Mapeamento_01_ndf', FILENAME = N'D:\BancosDados\SQLServer\SampleXP\SampleXP_FG_Mapeamento_01.ndf' , SIZE = 3072KB , FILEGROWTH = 102400KB )
To FileGroup SampleXP_FG_Mapeamento

Go

/*========================================================================*/

Create Schema Mapeamento
Authorization dbo;

Go

Alter Authorization On Schema::[Mapeamento] To [SampleXP];

Go

/*========================================================================*/
