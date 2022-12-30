/*========================================================================*/

Use SampleXP;

Go

/*========================================================================*/

Alter Database SampleXP
Add FileGroup SampleXP_FG_Persons

Go

Alter Database SampleXP
Add File
( NAME = N'SampleXP_FG_Persons_01_ndf', FILENAME = N'D:\Database\SQLServer\SampleXP\SampleXP_FG_Persons_01.ndf' , SIZE = 3072KB , FILEGROWTH = 102400KB )
To FileGroup SampleXP_FG_Persons

Go

/*========================================================================*/

Create Schema Persons
Authorization dbo;

Go

Alter Authorization On Schema::[Persons] To [SampleXP];

Go

/*========================================================================*/