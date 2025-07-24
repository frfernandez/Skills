/*========================================================================*/

Use Rodonaves;

Go

/*========================================================================*/

Create Table dbo.Unidades
(
Codigo Integer Identity(1, 1) Not Null,
Nome Varchar(50) Not Null,
Ativa Char(1) Default 'N' Not Null,
Constraint PK_Unidades Primary Key (Codigo),
Constraint CK_Unidades_Nome_Upper Check(Nome = Upper(Nome))
);

Go

Create Nonclustered Index Ix_Unidades_Nome On 
dbo.Unidades (Nome);

Go

/*========================================================================*/

Create Table dbo.Usuarios
(
Codigo Integer Identity(1, 1) Not Null,
Login Varchar(50) Not Null,
Senha Varchar(50) Not Null,
Status Char(1) Default 'N' Not Null,
Constraint PK_Usuarios Primary Key (Codigo),
Constraint CK_Usuarios_Login_Upper Check(Login = Upper(Login)),
Constraint CK_Usuarios_Status_YN Check(Status In ('Y', 'N'))
);

Go

Create Nonclustered Index Ix_Usuarios_Login On 
dbo.Usuarios (Login);

Go

/*========================================================================*/

Create Table dbo.Colaboradores
(
Codigo Integer Identity(1, 1) Not Null,
Nome Varchar(50) Not Null,
CodigoUsuario Integer Not Null,
CodigoUnidade Integer Not Null,
Constraint PK_Colaboradores Primary Key (Codigo),
Constraint FK_Colaboradores_Usuarios Foreign Key (CodigoUsuario) References dbo.Usuarios (Codigo),
Constraint FK_Colaboradores_Unidades Foreign Key (CodigoUnidade) References dbo.Unidades (Codigo),
Constraint CK_Colaboradores_Nome_Upper Check(Nome = Upper(Nome))
);

Go

Create Nonclustered Index Ix_Colaboradores_Nome On 
dbo.Colaboradores (Nome);

Go

/*========================================================================*/
