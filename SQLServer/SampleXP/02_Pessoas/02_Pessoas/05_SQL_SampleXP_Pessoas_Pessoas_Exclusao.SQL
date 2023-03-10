/*==========================================================================

Sistema......: SampleXP
Desenvolvedor: Fernando Roberto Fern?ndez
Refer?ncia...: Procedimentos Armazenados de Exclus?o

==========================================================================*/

Use SampleXP;

Go

/*========================================================================*/

Create Procedure Pessoas.ExcPessoas
(
@Codigo Integer
)
As
begin
  Set NoCount On;

  Delete From Pessoas.Pessoas
  Where Codigo = @Codigo;
end;

Go

/*========================================================================*/

Create Procedure Pessoas.ExcPessoasEnderecos
(
@CodigoPessoa Integer,
@Posicao Integer
)
As
begin
  Set NoCount On;

  Delete From Pessoas.PessoasEnderecos
  Where CodigoPessoa  = @CodigoPessoa
    And Posicao      >= @Posicao;
end;

Go

/*========================================================================*/
