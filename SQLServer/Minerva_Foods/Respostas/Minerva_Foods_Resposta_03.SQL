/*==========================================================================

	System...: Minerva_Foods
	Developer: Fernando Roberto Fernández
	Stored procedure that closes the production order.

==========================================================================*/

Use Minerva_Foods;

Go

/*========================================================================*/

Create Procedure dbo.Prc_Ordem_Producao_Fecha
(
@Num_Ordem_Producao Integer
)
As
Declare @Status Varchar(1),
        @Cod_Produto Integer,
		@Peso Decimal(18, 2);
begin
  Set NoCount On;

  Select @Status = Status
  From dbo.Tab_Ordem_Producao
  Where Num_Ordem_Producao = @Num_Ordem_Producao;

  if (@Status <> 'F')
  begin
    Update dbo.Tab_Ordem_Producao
	Set Status = 'F'
    Where Num_Ordem_Producao = @Num_Ordem_Producao;

	Declare CsTab_Ordem_Producao Cursor Fast_Forward Read_Only For
      Select Cod_Produto,
		     Peso
      From dbo.Tab_Pesagem
      Where Num_Ordem_Producao = @Num_Ordem_Producao;

    Open CsTab_Ordem_Producao;
    Fetch Next From CsTab_Ordem_Producao
    Into @Cod_Produto, @Peso;
    While @@Fetch_Status = 0
    begin
	  Insert Into dbo.Tab_Movimento_Estoque
	  (Cod_Produto, Peso_Movimento, Num_Ordem_Producao)
	  Values (@Cod_Produto, @Peso, @Num_Ordem_Producao);

      Fetch Next From CsTab_Ordem_Producao
      Into @Cod_Produto, @Peso;
    end;
    Close CsTab_Ordem_Producao;
    Deallocate CsTab_Ordem_Producao;
  end
end;

Go

/*========================================================================*/

-- Testing Tab_Movimento_Estoque procedure...

Select b.Num_Ordem_Producao, b.Cod_Produto, b.Peso
From dbo.Tab_Ordem_Producao a
Join dbo.Tab_Pesagem b On a.Num_Ordem_Producao = b.Num_Ordem_Producao;

Execute dbo.Prc_Ordem_Producao_Fecha 1;

Select Num_Ordem_Producao, Cod_Produto, Peso_Movimento
From dbo.Tab_Movimento_Estoque;

Select Num_Ordem_Producao, Cod_Produto, Sum(Peso_Movimento) Peso
From dbo.Tab_Movimento_Estoque
Group By Num_Ordem_Producao, Cod_Produto;

/*========================================================================*/
