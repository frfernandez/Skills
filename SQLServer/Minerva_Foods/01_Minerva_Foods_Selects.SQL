/*==========================================================================

	System...: Minerva_Foods
	Developer: Fernando Roberto Fernández
	Tests.

==========================================================================*/

Use Minerva_Foods;

Go

/*========================================================================*/

-- Verfying records in tables...

Select *
From dbo.Tab_Grupo_Produto

Select *
From dbo.Tab_Produto;

Select *
From dbo.Tab_Ordem_Producao;

Select *
From dbo.Tab_Pesagem;

Select *
From dbo.Tab_Movimento_Estoque;

/*========================================================================*/

-- Verfying records in view...

Select *
From dbo.Vw_Produto_Grupo_Ativo

Select *
From dbo.Vw_Produto_Sem_Movto_Dias_60

/*========================================================================*/

-- Verfying records in view...

Select dbo.Fct_Media_Ponderada(7, 1, 9, 3) Media_Ponderada

/*========================================================================*/
