/*==========================================================================

	System...: Minerva_Foods
	Developer: Fernando Roberto Fernández
	Tests.

==========================================================================*/

Use Minerva_Foods;

Go

/*========================================================================*/

-- Dropping views...

Drop View dbo.Vw_Produto_Grupo_Ativo;
Drop View dbo.Vw_Produto_Sem_Movto_Dias_60;

/*========================================================================*/

-- Dropping functions...

Drop Function dbo.Fct_Media_Ponderada

/*========================================================================*/

-- Dropping procedures...

Drop Procedure dbo.Prc_Ordem_Producao_Fecha;
Drop Procedure dbo.Prc_Produto_Grupo;

/*========================================================================*/

-- Dropping tables...

Drop Table dbo.Tab_Estoque;
Drop Table dbo.Tab_Movimento_Estoque;
Drop Table dbo.Tab_Pesagem;
Drop Table dbo.Tab_Ordem_Producao;
Drop Table dbo.Tab_Produto;
Drop Table dbo.Tab_Grupo_Produto;

/*========================================================================*/
