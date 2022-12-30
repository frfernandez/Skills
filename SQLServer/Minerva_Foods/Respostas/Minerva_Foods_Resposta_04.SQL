/*==========================================================================

	System...: Minerva_Foods
	Developer: Fernando Roberto Fernández
	Creating the table Tab_Grupo_Produto structure.
	Change the table Tab_Produto structure.
	Making the table Tab_Grupo_Produto a foreign key
	in the table Tab_Produto structure.
	Inserting records in the table Tab_Grupo_Produto.
	Updating a record in the table Tab_Produto.

==========================================================================*/

Use Minerva_Foods;

Go

/*========================================================================*/

Create Table dbo.Tab_Grupo_Produto
(
Cod_Grupo Integer Not Null Check(Cod_Grupo > 0),
Nome_Grupo Varchar(40) Not Null Check(Nome_Grupo = Upper(Nome_Grupo)),
Ind_Ativo Bit Not Null,
Primary Key (Cod_Grupo)
);

Go

/*========================================================================*/

Alter Table dbo.Tab_Produto
Add Cod_Grupo Integer;

Go

/*========================================================================*/

Alter Table dbo.Tab_Produto
Add Foreign Key (Cod_Grupo) References dbo.Tab_Grupo_Produto (Cod_Grupo);

Go

/*========================================================================*/

Insert Into dbo.Tab_Grupo_Produto
(Cod_Grupo, Nome_Grupo, Ind_Ativo)
Values (1, 'CARNE', 1);

Insert Into dbo.Tab_Grupo_Produto
(Cod_Grupo, Nome_Grupo, Ind_Ativo)
Values (2, 'SUBPRODUTO', 1);

Insert Into dbo.Tab_Grupo_Produto
(Cod_Grupo, Nome_Grupo, Ind_Ativo)
Values (3, 'BATATA', 1);

/*========================================================================*/

Update dbo.Tab_Produto
Set Cod_Grupo = 1
Where Cod_Produto = 5;

/*========================================================================*/
