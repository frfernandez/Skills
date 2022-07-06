/*==========================================================================

	System...: Minerva_Foods
	Developer: Fernando Roberto Fernández
	View to show the products without store change in the last 60 (sixty) days.

==========================================================================*/

Use Minerva_Foods;

Go

/*========================================================================*/

Create View dbo.Vw_Produto_Sem_Movto_Dias_60
As
  Select a.Cod_Produto, a.Nome_Produto
  From dbo.Tab_Produto a
  Where a.Cod_Produto not In (Select c.Cod_Produto
                              From dbo.Tab_Movimento_Estoque b
                              Join dbo.Tab_Pesagem c On b.Num_Ordem_Producao = c.Num_Ordem_Producao
                              Where b.Dta_Movimento >= DateAdd(Day, -60, Cast(GetDate() As Date)));

Go

/*========================================================================*/
