/*==========================================================================

	System...: Minerva_Foods
	Developer: Fernando Roberto Fernández
	Creating the database tables.

==========================================================================*/

Use Minerva_Foods;

Go

/*========================================================================*/

Create Table dbo.Tab_Produto
(
Cod_Produto Integer Not Null Check(Cod_Produto > 0),
Nome_Produto Varchar(100) Not Null Check(Nome_Produto = Upper(Nome_Produto)),
Primary Key (Cod_Produto)
);

Go

/*========================================================================*/

Create Table dbo.Tab_Ordem_Producao
(
Num_Ordem_Producao Integer Identity(1, 1) Not Null,
Data_Producao DateTime Default GetDate() Not Null,
Observacoes Varchar(100) Not Null,
Status Varchar(1) Default 'P' Not Null Check(Status In ('P', 'I', 'F')),
Primary Key (Num_Ordem_Producao)
);

Go

/*========================================================================*/

Create Table dbo.Tab_Pesagem
(
Id_Pesagem Integer Identity(1, 1) Not Null,
Num_Ordem_Producao Integer Not Null,
Cod_Produto Integer Not Null,
Peso Decimal(18, 2) Not Null Check(Peso > 0),
Foreign Key (Num_Ordem_Producao) References dbo.Tab_Ordem_Producao (Num_Ordem_Producao),
Foreign Key (Cod_Produto) References dbo.Tab_Produto (Cod_Produto),
Primary Key (Id_Pesagem)
);

Go

/*========================================================================*/

Create Table dbo.Tab_Movimento_Estoque
(
Id_Movimento Integer Identity(1, 1) Not Null,
Dta_Movimento DateTime Default GetDate() Not Null,
Cod_Produto Integer Not Null,
Peso_Movimento Decimal(18, 2) Not Null Check(Peso_Movimento > 0),
Num_Ordem_Producao Integer Not Null,
Foreign Key (Cod_Produto) References dbo.Tab_Produto (Cod_Produto),
Foreign Key (Num_Ordem_Producao) References dbo.Tab_Ordem_Producao (Num_Ordem_Producao),
Primary Key (Id_Movimento)
);

Go

/*========================================================================*/

Create Table dbo.Tab_Estoque
(
Cod_Produto Integer Not Null,
Saldo Decimal(18, 2) Not Null Check(Saldo > 0),
Foreign Key (Cod_Produto) References dbo.Tab_Produto (Cod_Produto),
Primary Key (Cod_Produto)
);

Go

/*========================================================================*/
