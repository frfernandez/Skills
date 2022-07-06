/*==========================================================================

	System...: Minerva_Foods
	Developer: Fernando Roberto Fernández
	Select command to show minimum, maximum and average weight produced by
	each product in the last 30 (thirty) days.

==========================================================================*/

Use Minerva_Foods;

Go

/*========================================================================*/

Select Distinct d.Nome_Produto,
       a.Peso_Minimo_Produzido,
       a.Peso_Maximo_Produzido,
	   a.Media_Produzida
From (Select b.Cod_Produto,
             Min(b.Peso) Peso_Minimo_Produzido,
             Max(b.Peso) Peso_Maximo_Produzido,
			 ((Min(b.Peso) + Max(b.Peso)) / 2) Media_Produzida
      From dbo.Tab_Ordem_Producao a
      Join dbo.Tab_Pesagem b On a.Num_Ordem_Producao = b.Num_Ordem_Producao
      Group By b.Cod_Produto) a
Join dbo.Tab_Pesagem        b On a.Cod_Produto        = b.Cod_Produto
Join dbo.Tab_Ordem_Producao c On b.Num_Ordem_Producao = c.Num_Ordem_Producao
Join dbo.Tab_Produto        d On a.Cod_Produto        = d.Cod_Produto
Where c.Data_Producao >= DateAdd(Day, -30, Cast(GetDate() As Date));

/*========================================================================*/
