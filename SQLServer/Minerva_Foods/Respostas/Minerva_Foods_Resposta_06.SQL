/*==========================================================================

	System...: Minerva_Foods
	Developer: Fernando Roberto Fernández
	Creating a trigger in Tab_Movimento_Estoque table.

==========================================================================*/

Use Minerva_Foods;

Go

/*========================================================================*/

Create Trigger dbo.Movimento_Estoque_Ordem_Fechada On dbo.Tab_Movimento_Estoque For Update, Delete
As
Declare @Num_Ordem_Producao Integer,
        @Status Varchar(1);
begin
  Set NoCount On;

  Select @Num_Ordem_Producao = Num_Ordem_Producao
  From Deleted;

  Select @Status = Status
  From dbo.Tab_Ordem_Producao
  Where Num_Ordem_Producao = @Num_Ordem_Producao;

  if (@Status = 'F')
    RaisError('Ordem de produção já fechada !', 10, 1);
end;

Go

/*========================================================================*/
