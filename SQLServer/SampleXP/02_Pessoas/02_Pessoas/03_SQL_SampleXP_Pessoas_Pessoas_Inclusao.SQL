/*==========================================================================

Sistema......: SampleXP
Desenvolvedor: Fernando Roberto Fernández
Referência...: Procedimentos Armazenados de Inclusão

==========================================================================*/

Use SampleXP;

Go

/*========================================================================*/

Create Procedure Pessoas.IncPessoas
(
@Descricao Varchar(50)
)
As
begin
  Set NoCount On;

  Insert Into Pessoas.Pessoas
  (Pessoa)
  Values (@Descricao);
end;

Go

/*========================================================================*/

Create Procedure Pessoas.IncPessoasEnderecos
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

  Insert Into Pessoas.PessoasEnderecos
  (CodigoPessoa, Posicao, CEP, CodigoTitulo, CodigoEndereco,
   NumeroResidencia, CodigoBairro, CodigoCidade, Complemento)
  Values (@CodigoPessoa, @Posicao, @CEP, @CodigoTitulo, @CodigoEndereco,
          @NumeroResidencia, @CodigoBairro, @CodigoCidade, @Complemento);
end;

Go

/*========================================================================*/
