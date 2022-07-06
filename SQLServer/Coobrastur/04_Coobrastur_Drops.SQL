/*==========================================================================

	System...: Coobrastur
	Developer: Fernando Roberto Fernández

==========================================================================*/

Use Coobrastur;

Go

/*========================================================================*/

-- Dropping functions...

Drop Function dbo.Fct_Funcionario_Detalhes;
Drop Function dbo.Fct_Funcionario_Salario_Aumento;
Drop Function dbo.Idade;

/*========================================================================*/

-- Dropping procedures...

Drop Procedure dbo.IncEmpresa;
Drop Procedure dbo.AltEmpresa;
Drop Procedure dbo.ExcEmpresa;

Drop Procedure dbo.IncSetor;
Drop Procedure dbo.AltSetor;
Drop Procedure dbo.ExcSetor;

Drop Procedure dbo.IncFuncionario;
Drop Procedure dbo.AltFuncionario;
Drop Procedure dbo.ExcFuncionario;

/*========================================================================*/

-- Dropping tables...

Drop Table dbo.Funcionario;
Drop Table dbo.Funcionario_Excluidos;
Drop Table dbo.Empresa;
Drop Table dbo.Setor;

/*========================================================================*/
