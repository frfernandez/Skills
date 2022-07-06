/*==========================================================================

	System...: Minerva_Foods
	Developer: Fernando Roberto Fernández
	Inserting data in some tables.

==========================================================================*/

Use Minerva_Foods;

Go

/*========================================================================*/

Insert Into dbo.Tab_Produto
(Cod_Produto, Nome_Produto)
Values (5, 'BANANA');

Insert Into dbo.Tab_Produto
(Cod_Produto, Nome_Produto)
Values (10, 'LARANJA');

Insert Into dbo.Tab_Produto
(Cod_Produto, Nome_Produto)
Values (20, 'AMEJXA');

/*========================================================================*/

Insert Into dbo.Tab_Ordem_Producao
(Observacoes, Status)
Values ('Ordem de produção planejada.', 'P');

Insert Into dbo.Tab_Ordem_Producao
(Observacoes, Status)
Values ('Ordem de produção iniciada.', 'I');

Insert Into dbo.Tab_Ordem_Producao
(Observacoes, Status)
Values ('Ordem de produção fechada.', 'F');

/*========================================================================*/

Insert Into dbo.Tab_Pesagem
(Num_Ordem_Producao, Cod_Produto, Peso)
Values (1, 5, 12);

Insert Into dbo.Tab_Pesagem
(Num_Ordem_Producao, Cod_Produto, Peso)
Values (1, 5, 11);

Insert Into dbo.Tab_Pesagem
(Num_Ordem_Producao, Cod_Produto, Peso)
Values (1, 10, 20);

Insert Into dbo.Tab_Pesagem
(Num_Ordem_Producao, Cod_Produto, Peso)
Values (1, 10, 40);

Insert Into dbo.Tab_Pesagem
(Num_Ordem_Producao, Cod_Produto, Peso)
Values (1, 20, 10);

Insert Into dbo.Tab_Pesagem
(Num_Ordem_Producao, Cod_Produto, Peso)
Values (1, 20, 11);

Insert Into dbo.Tab_Pesagem
(Num_Ordem_Producao, Cod_Produto, Peso)
Values (1, 20, 13);

/*========================================================================*/
