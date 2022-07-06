/*==========================================================================

Sistema......: SampleXP
Desenvolvedor: Fernando Roberto Fernández
Referência...: Procedimentos Armazenados de Alteração

==========================================================================*/

Use SampleXP;

Go

/*========================================================================*/

Create Procedure Pessoas.AltPessoas
(
@Codigo Integer,
@Descricao Varchar(50)
)
As
begin
  Set NoCount On;

  Update Pessoas.Pessoas
  Set Pessoa = @Descricao
  Where Codigo = @Codigo;
end;

Go

/*========================================================================*/

Create Procedure Pessoas.AltPessoasEnderecos
(
@CodigoPessoa Integer,
@Posicao Integer,
@CEP Varchar(10),
@CodigoTitulo Integer,
@CodigoEndereco Integer,
@NumeroResidencia Integer,
@CodigoBairro Integer,
@CodigoCidade Integer,
@Complemento Varchar(50)
)
As
begin
  Set NoCount On;

  Update Pessoas.PessoasEnderecos
  Set CEP              = @CEP,
      CodigoTitulo     = @CodigoTitulo,
	  CodigoEndereco   = @CodigoEndereco,
	  NumeroResidencia = @NumeroResidencia,
	  CodigoBairro     = @CodigoBairro,
	  CodigoCidade     = @CodigoCidade,
      Complemento      = @Complemento
  Where CodigoPessoa = @CodigoPessoa
    And Posicao      = @Posicao;
end;

Go

/*========================================================================*/
