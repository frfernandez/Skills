/*==========================================================================

	System...: Minerva_Foods
	Developer: Fernando Roberto Fernández
	View to show the products in active groups.

==========================================================================*/

Use Minerva_Foods;

Go

/*========================================================================*/

Create View dbo.Vw_Produto_Grupo_Ativo
As
  Select a.Cod_Produto, a.Nome_Produto,
         b.Nome_Grupo
  From dbo.Tab_Produto a
  Join dbo.Tab_Grupo_Produto b On a.Cod_Grupo = b.Cod_Grupo
  Where b.Ind_Ativo = 1;

Go

/*========================================================================*/
