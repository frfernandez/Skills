/*==========================================================================

Sistema......: SampleXP
Desenvolvedor: Fernando Roberto Fernández
Referência...: Procedimentos Armazenados com Filtros

==========================================================================*/

Use SampleXP;

Go

/*========================================================================*/

Create Procedure Pessoas.FltPessoas
(
@Nome Varchar(50)
)
As
begin
  Set NoCount On;

  Select a.Codigo, a.Pessoa
  From Pessoas.Pessoas a
  Where a.Pessoa Like '%' + @Nome + '%'
  Order By a.Pessoa;
end;

Go

/*========================================================================*/

Create Procedure Pessoas.PkPessoasEnderecos
(
@CodigoPessoa Integer
)
As
begin
  Set NoCount On;

  Select a.CodigoPessoa, a.Posicao, a.CEP,
         a.CodigoTitulo, a.CodigoEndereco, a.NumeroResidencia,
         a.CodigoBairro, a.CodigoCidade, a.Complemento,
		 b.Pessoa,
		 c.Titulo,
		 d.Endereco,
		 e.Bairro,
		 f.Cidade, f.CodigoEstado,
		 g.Estado, g.Sigla EstadoSigla, g.CodigoPais,
		 h.Pais, h.Sigla PaisSigla, h.CodigoContinente,
		 i.Continente
  From Pessoas.PessoasEnderecos a
  Join Pessoas.Pessoas             b On a.CodigoPessoa     = b.Codigo
  Join Mapeamento.TitulosEnderecos c On a.CodigoTitulo     = c.Codigo
  Join Mapeamento.Enderecos        d On a.CodigoEndereco   = d.Codigo
  Join Mapeamento.Bairros          e On a.CodigoBairro     = e.Codigo
  Join Mapeamento.Cidades          f On a.CodigoCidade     = f.Codigo
  Join Mapeamento.Estados          g On f.CodigoEstado     = g.Codigo
  Join Mapeamento.Paises           h On g.CodigoPais       = h.Codigo
  Join Mapeamento.Continentes      i On h.CodigoContinente = i.Codigo
  Where a.CodigoPessoa = @CodigoPessoa;
end;

Go

/*========================================================================*/
