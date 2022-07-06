/*==========================================================================

Sistema......: SampleXP
Desenvolvedor: Fernando Roberto Fernández
Referência...: Procedimentos Armazenados de Alteração

==========================================================================*/

Use SampleXP;

Go

/*========================================================================*/

Create Procedure Mapeamento.AltTitulosEnderecos
(
@Codigo Integer,
@Descricao Varchar(50)
)
As
begin
  Set NoCount On;

  Update Mapeamento.TitulosEnderecos
  Set Titulo = @Descricao
  Where Codigo = @Codigo;
end;

Go

/*========================================================================*/

Create Procedure Mapeamento.AltEnderecos
(
@Codigo Integer,
@Descricao Varchar(50)
)
As
begin
  Set NoCount On;

  Update Mapeamento.Enderecos
  Set Endereco = @Descricao
  Where Codigo = @Codigo;
end;

Go

/*========================================================================*/

Create Procedure Mapeamento.AltBairros
(
@Codigo Integer,
@Descricao Varchar(50)
)
As
begin
  Set NoCount On;

  Update Mapeamento.Bairros
  Set Bairro = @Descricao
  Where Codigo = @Codigo;
end;

Go

/*========================================================================*/

Create Procedure Mapeamento.AltContinentes
(
@Codigo Integer,
@Descricao Varchar(50)
)
As
begin
  Set NoCount On;

  Update Mapeamento.Continentes
  Set Continente = @Descricao
  Where Codigo = @Codigo;
end;

Go

/*========================================================================*/

Create Procedure Mapeamento.AltPaises
(
@Codigo Integer,
@Pais Varchar(50),
@Sigla Varchar(5),
@CodigoContinente Integer
)
As
begin
  Set NoCount On;

  Update Mapeamento.Paises
  Set Pais             = @Pais,
      Sigla            = @Sigla,
      CodigoContinente = @CodigoContinente
  Where Codigo = @Codigo;
end;

Go

/*========================================================================*/

Create Procedure Mapeamento.AltEstados
(
@Codigo Integer,
@Estado Varchar(50),
@Sigla Varchar(3),
@CodigoPais Integer
)
As
begin
  Set NoCount On;

  Update Mapeamento.Estados
  Set Estado     = @Estado,
      Sigla      = @Sigla,
      CodigoPais = CodigoPais
  Where Codigo = @Codigo;
end;

Go

/*========================================================================*/

Create Procedure Mapeamento.AltCidades
(
@Codigo Integer,
@Cidade Varchar(50),
@CodigoEstado Integer
)
As
begin
  Set NoCount On;

  Update Mapeamento.Cidades
  Set Cidade       = @Cidade,
      CodigoEstado = @CodigoEstado
  Where Codigo = @Codigo;
end;

Go

/*========================================================================*/
