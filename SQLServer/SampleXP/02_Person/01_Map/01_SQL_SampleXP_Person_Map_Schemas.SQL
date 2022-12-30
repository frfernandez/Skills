/*========================================================================*/

Use SampleXP;

Go

/*========================================================================*/

Alter Database SampleXP
Add FileGroup SampleXP_FG_Map

Go

Alter Database SampleXP
Add File
( NAME = N'SampleXP_FG_Map_01_ndf', FILENAME = N'D:\Database\SQLServer\SampleXP\SampleXP_FG_Map_01.ndf' , SIZE = 3072KB , FILEGROWTH = 102400KB )
To FileGroup SampleXP_FG_Map

Go

/*========================================================================*/

Create Schema Map
Authorization dbo;

Go

Alter Authorization On Schema::[Map] To [SampleXP];

Go

/*========================================================================*/