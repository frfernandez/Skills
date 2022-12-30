/*==========================================================================

	System...: Minerva_Foods
	Developer: Fernando Roberto Fernández
	Procedure to show the weight produced by each product in all production order.

==========================================================================*/

Use Minerva_Foods;

Go

/*========================================================================*/

Create Procedure dbo.Prc_Produto_Grupo
As
begin
  Set NoCount On;

  Select a.Num_Ordem_Producao,
         a.Cod_Produto,
		 b.Nome_Produto,
		 a.Peso_Produzido,
		 (case
		  when c.Nome_Grupo Is Null then
		    'SEM GRUPO DEFINIDO'
		  else
		    c.Nome_Grupo
		  end) Nome_Grupo
  From (Select b.Num_Ordem_Producao,
               b.Cod_Produto, Sum(b.Peso) Peso_Produzido
        From dbo.Tab_Ordem_Producao a
        Join dbo.Tab_Pesagem b On a.Num_Ordem_Producao = b.Num_Ordem_Producao
        Group By b.Num_Ordem_Producao, b.Cod_Produto) a
       Join dbo.Tab_Produto       b On a.Cod_Produto = b.Cod_Produto
  Left Join dbo.Tab_Grupo_Produto c On b.Cod_Grupo   = c.Cod_Grupo;
end;

Go

/*========================================================================*/
