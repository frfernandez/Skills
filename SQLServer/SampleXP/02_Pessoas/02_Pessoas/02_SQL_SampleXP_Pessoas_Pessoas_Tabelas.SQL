/*==========================================================================

Sistema......: SampleXP
Desenvolvedor: Fernando Roberto Fernández
Referência...: Pessoas

==========================================================================*/

Use SampleXP;

Go

/*========================================================================*/

Create Table Pessoas.Pessoas
(
Codigo Integer Identity(1, 1) Not Null,
Pessoa Varchar(50) Not Null,
Constraint PK_Pessoas Primary Key (Codigo),
Constraint CK_Pessoas_Pessoa_Maiuscula Check(Pessoa = Upper(Pessoa))
) On SampleXP_FG_Pessoas;

Go

/*========================================================================*/

Create Table Pessoas.PessoasEnderecos
(
CodigoPessoa Integer Not Null,
Posicao Integer Not Null,
CEP Varchar(10),
CodigoTitulo Integer Not Null,
CodigoEndereco Integer Not Null,
NumeroResidencia Integer,
CodigoBairro Integer Not Null,
CodigoCidade Integer Not Null,
Complemento Varchar(50) Not Null Check(Complemento = Upper(Complemento)),
Constraint PK_PessoasDetalhes Primary Key (CodigoPessoa, Posicao),
Constraint FK_PessoasDetalhes_Pessoas Foreign Key (CodigoPessoa) References Pessoas.Pessoas (Codigo)
On Delete Cascade,
Constraint FK_PessoasEnderecos_TitulosEnderecos Foreign Key (CodigoTitulo) References Mapeamento.TitulosEnderecos (Codigo),
Constraint FK_PessoasEnderecos_Enderecos Foreign Key (CodigoEndereco) References Mapeamento.Enderecos (Codigo),
Constraint FK_PessoasEnderecos_Bairros Foreign Key (CodigoBairro) References Mapeamento.Bairros (Codigo),
Constraint FK_PessoasEnderecos_Cidades Foreign Key (CodigoCidade) References Mapeamento.Cidades (Codigo),
Constraint CK_PessoasEnderecos_Posicao_MaiorZero Check(Posicao > 0),
Constraint CK_PessoasEnderecos_Complemento_Maiuscula Check(Complemento = Upper(Complemento))
) On SampleXP_FG_Pessoas;

Go

/*========================================================================*/
