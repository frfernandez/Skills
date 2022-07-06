/*==========================================================================

Sistema......: SampleXP
Desenvolvedor: Fernando Roberto Fernández
Referência...: Procedimentos Armazenados com Filtros

==========================================================================*/

Use SampleXP;

Go

/*========================================================================*/

Create Procedure Mapeamento.FltTitulosEnderecos
(
@Nome Varchar(50)
)
As
begin
  Set NoCount On;

  Select a.Codigo, a.Titulo
  From Mapeamento.TitulosEnderecos a
  Where a.Titulo Like '%' + @Nome + '%'
  Order By a.Titulo;
end;

Go

/*========================================================================*/

Create Procedure Mapeamento.FltEnderecos
(
@Nome Varchar(50)
)
As
begin
  Set NoCount On;

  Select a.Codigo, a.Endereco
  From Mapeamento.Enderecos a
  Where a.Endereco Like '%' + @Nome + '%'
  Order By a.Endereco;
end;

Go

/*========================================================================*/

Create Procedure Mapeamento.FltBairros
(
@Nome Varchar(50)
)
As
begin
  Set NoCount On;

  Select a.Codigo, a.Bairro
  From Mapeamento.Bairros a
  Where a.Bairro Like '%' + @Nome + '%'
  Order By a.Bairro;
end;

Go

/*========================================================================*/

Create Procedure Mapeamento.FltContinentes
(
@Nome Varchar(50)
)
As
begin
  Set NoCount On;

  Select a.Codigo, a.Continente
  From Mapeamento.Continentes a
  Where a.Continente Like '%' + @Nome + '%'
  Order By a.Continente;
end;

Go

/*========================================================================*/

Create Procedure Mapeamento.FltPaises
(
@Codigo Integer,
@Nome Varchar(50)
)
As
begin
  Set NoCount On;

  Select a.Codigo, a.Pais, a.Sigla,
         a.CodigoContinente,
         b.Continente
  From Mapeamento.Paises a
  Join Mapeamento.Continentes b On a.CodigoContinente = b.Codigo
  Where ((@Codigo Is Null) Or
         ((@Codigo Is Not Null) And
          (a.Codigo = @Codigo))) And
        a.Pais Like '%' + @Nome + '%'
  Order By a.Pais;
end;

Go

/*========================================================================*/

Create Procedure Mapeamento.FltEstados
(
@Codigo Integer,
@Nome Varchar(50),
@CodigoPais Integer
)
As
begin
  Set NoCount On;

  Select a.Codigo, a.Estado, a.Sigla,
         a.CodigoPais,
		 b.Pais
  From Mapeamento.Estados a
  Join Mapeamento.Paises b On a.CodigoPais = b.Codigo
  Where ((@Codigo Is Null) Or
         ((@Codigo Is Not Null) And
          (a.Codigo = @Codigo))) And
        a.Estado Like '%' + @Nome + '%' And
        ((@CodigoPais Is Null) Or
         ((@CodigoPais Is Not Null) And
          (a.CodigoPais = @CodigoPais)))
  Order By a.Estado;
end;

Go

/*========================================================================*/

Create Procedure Mapeamento.FltCidades
(
@Codigo Integer,
@Nome Varchar(50)
)
As
begin
  Set NoCount On;

  Select a.Codigo, a.Cidade, a.CodigoEstado,
         b.Estado, b.Sigla EstadoSigla, b.CodigoPais,
         c.Pais, c.Sigla PaisSigla, c.CodigoContinente,
		 d.Continente
  From Mapeamento.Cidades a
  Join Mapeamento.Estados     b On a.CodigoEstado     = b.Codigo
  Join Mapeamento.Paises      c On b.CodigoPais       = c.Codigo
  Join Mapeamento.Continentes d On c.CodigoContinente = d.Codigo
  Where ((@Codigo Is Null) Or
         ((@Codigo Is Not Null) And
          (a.Codigo = @Codigo))) And
        a.Cidade Like '%' + @Nome + '%'
  Order By a.Cidade;
end;

Go

/*========================================================================*/
