Create Table Public.Unidades
(
Codigo Integer Generated Always As Identity(Increment 1 Start 1) Not Null,
Nome Varchar(50) Not Null,
Ativa Char(1) Default 'N' Not Null,
Constraint PK_Unidades Primary Key (Codigo),
Constraint CK_Unidades_Nome_Upper Check(Nome = Upper(Nome))
);

Create Index Ix_Unidades_Nome On 
Public.Unidades (Nome);

/*========================================================================*/

Create Table Public.Usuarios
(
Codigo Integer Generated Always As Identity(Increment 1 Start 1) Not Null,
Login Varchar(50) Not Null,
Senha Varchar(50) Not Null,
Status Char(1) Default 'N' Not Null,
Constraint PK_Usuarios Primary Key (Codigo),
Constraint CK_Usuarios_Login_Upper Check(Login = Upper(Login)),
Constraint CK_Usuarios_Status_YN Check(Status In ('Y', 'N'))
);

Create Index Ix_Usuarios_Login On 
Public.Usuarios (Login);

/*========================================================================*/

Create Table Public.Colaboradores
(
Codigo Integer Generated Always As Identity(Increment 1 Start 1) Not Null,
Nome Varchar(50) Not Null,
CodigoUsuario Integer Not Null,
CodigoUnidade Integer Not Null,
Constraint PK_Colaboradores Primary Key (Codigo),
Constraint FK_Colaboradores_Usuarios Foreign Key (CodigoUsuario) References Public.Usuarios (Codigo),
Constraint FK_Colaboradores_Unidades Foreign Key (CodigoUnidade) References Public.Unidades (Codigo),
Constraint CK_Colaboradores_Nome_Upper Check(Nome = Upper(Nome))
);

Create Index Ix_Colaboradores_Nome On 
Public.Colaboradores (Nome);

/*========================================================================*/
