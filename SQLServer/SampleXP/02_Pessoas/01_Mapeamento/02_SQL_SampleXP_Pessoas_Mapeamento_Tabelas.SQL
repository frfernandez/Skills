/*==========================================================================

Sistema......: SampleXP
Desenvolvedor: Fernando Roberto Fernández
Referência...: Mapeamento

==========================================================================*/

Use SampleXP;

Go

/*========================================================================*/

Create Table Mapeamento.TitulosEnderecos
(
Codigo Integer Identity(1, 1) Not Null,
Titulo Varchar(50) Not Null,
Constraint PK_TitulosEnderecos Primary Key (Codigo),
Constraint CK_TitulosEnderecos_Titulo_Maiuscula Check(Titulo = Upper(Titulo))
) On SampleXP_FG_Mapeamento;

Go

/*========================================================================*/

Create Table Mapeamento.Enderecos
(
Codigo Integer Identity(1, 1) Not Null,
Endereco Varchar(50) Not Null,
Constraint PK_Enderecos Primary Key (Codigo),
Constraint CK_Enderecos_Endereco_Maiuscula Check(Endereco = Upper(Endereco))
) On SampleXP_FG_Mapeamento;

Go

/*========================================================================*/

Create Table Mapeamento.Bairros
(
Codigo Integer Identity(1, 1) Not Null,
Bairro Varchar(50) Not Null,
Constraint PK_Bairros Primary Key (Codigo),
Constraint CK_Bairros_Bairro_Maiuscula Check(Bairro = Upper(Bairro))
) On SampleXP_FG_Mapeamento;

Go

/*========================================================================*/

Create Table Mapeamento.Continentes
(
Codigo Integer Identity(1, 1) Not Null,
Continente Varchar(50) Not Null,
Constraint PK_Continentes Primary Key (Codigo),
Constraint CK_Continentes_Continente_Maiuscula Check(Continente = Upper(Continente))
) On SampleXP_FG_Mapeamento;

Go

/*========================================================================*/

Create Table Mapeamento.Paises
(
Codigo Integer Identity(1, 1) Not Null,
Pais Varchar(50) Not Null,
Sigla Varchar(5) Not Null,
CodigoContinente Integer Not Null,
Constraint PK_Paises Primary Key (Codigo),
Constraint FK_Paises_Continentes Foreign Key (CodigoContinente) References Mapeamento.Continentes (Codigo),
Constraint CK_Paises_Pais_Maiuscula Check(Pais = Upper(Pais)),
Constraint CK_Paises_Sigla_Maiuscula Check(Sigla = Upper(Sigla))
) On SampleXP_FG_Mapeamento;

Go

/*========================================================================*/

Create Table Mapeamento.Estados
(
Codigo Integer Identity(1, 1) Not Null,
Estado Varchar(50) Not Null,
Sigla Varchar(3) Not Null,
CodigoPais Integer Not Null,
Constraint PK_Estados Primary Key (Codigo),
Constraint FK_Estados_Paises Foreign Key (CodigoPais) References Mapeamento.Paises (Codigo),
Constraint CK_Estados_Estado_Maiuscula Check(Estado = Upper(Estado)),
Constraint CK_Estados_Sigla_Maiuscula Check(Sigla = Upper(Sigla))
) On SampleXP_FG_Mapeamento;

Go

/*========================================================================*/

Create Table Mapeamento.Cidades
(
Codigo Integer Identity(1, 1) Not Null,
Cidade Varchar(50) Not Null,
CodigoEstado Integer Not Null,
Constraint PK_Cidades Primary Key (Codigo),
Constraint FK_Cidades_Estados Foreign Key (CodigoEstado) References Mapeamento.Estados (Codigo),
Constraint CK_Cidades_Cidade_Maiuscula Check(Cidade = Upper(Cidade))
) On SampleXP_FG_Mapeamento;

Go

/*========================================================================*/
