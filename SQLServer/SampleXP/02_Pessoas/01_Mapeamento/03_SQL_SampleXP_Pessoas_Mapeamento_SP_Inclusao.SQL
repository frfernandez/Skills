/*==========================================================================

Sistema......: SampleXP
Desenvolvedor: Fernando Roberto Fernández
Referência...: Procedimentos Armazenados de Inclusão

==========================================================================*/

Use SampleXP;

Go

/*========================================================================*/

Create Procedure Mapeamento.IncTitulosEnderecos
(
@Descricao Varchar(50)
)
As
begin
  Set NoCount On;

  Insert Into Mapeamento.TitulosEnderecos
  (Titulo)
  Values (@Descricao);
end;

Go

/*========================================================================*/

Create Procedure Mapeamento.IncEnderecos
(
@Descricao Varchar(50)
)
As
begin
  Set NoCount On;

  Insert Into Mapeamento.Enderecos
  (Endereco)
  Values (@Descricao);
end;

Go

/*========================================================================*/

Create Procedure Mapeamento.IncBairros
(
@Descricao Varchar(50)
)
As
begin
  Set NoCount On;

  Insert Into Mapeamento.Bairros
  (Bairro)
  Values (@Descricao);
end;

Go

/*========================================================================*/

Create Procedure Mapeamento.IncContinentes
(
@Descricao Varchar(50)
)
As
begin
  Set NoCount On;

  Insert Into Mapeamento.Continentes
  (Continente)
  Values (@Descricao);
end;

Go

/*========================================================================*/

Create Procedure Mapeamento.IncPaises
(
@Pais Varchar(50),
@Sigla Varchar(5),
@CodigoContinente Integer
)
As
begin
  Set NoCount On;

  Insert Into Mapeamento.Paises
  (Pais, Sigla, CodigoContinente)
  Values (@Pais, @Sigla, @CodigoContinente);
end;

Go

/*========================================================================*/

Create Procedure Mapeamento.IncEstados
(
@Estado Varchar(50),
@Sigla Varchar(3),
@CodigoPais Integer
)
As
begin
  Set NoCount On;

  Insert Into Mapeamento.Estados
  (Estado, Sigla, CodigoPais)
  Values (@Estado, @Sigla, @CodigoPais);
end;

Go

/*========================================================================*/

Create Procedure Mapeamento.IncCidades
(
@Cidade Varchar(50),
@CodigoEstado Integer
)
As
begin
  Set NoCount On;

  Insert Into Mapeamento.Cidades
  (Cidade, CodigoEstado)
  Values (@Cidade, @CodigoEstado);
end;

Go

/*========================================================================*/
