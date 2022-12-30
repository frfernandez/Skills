/*==========================================================================

	System...: Coobrastur
	Developer: Fernando Roberto Fernández

==========================================================================*/

Use Coobrastur;

Go

/*========================================================================*/

Execute dbo.IncEmpresa 'EMPRESA 01';
Execute dbo.IncEmpresa 'EMPRESA 02';
Execute dbo.IncEmpresa 'EMPRESA 03';
Execute dbo.IncEmpresa 'EMPRESA 04';
/*
Execute dbo.AltEmpresa 1, 'EMPRESA 001';
Execute dbo.AltEmpresa 2, 'EMPRESA 002';
Execute dbo.AltEmpresa 3, 'EMPRESA 003';
Execute dbo.AltEmpresa 4, 'EMPRESA 004';

Execute dbo.ExcEmpresa 1;
Execute dbo.ExcEmpresa 2;
Execute dbo.ExcEmpresa 3;
Execute dbo.ExcEmpresa 4;
*/

Execute dbo.IncSetor 'SETOR 01';
Execute dbo.IncSetor 'SETOR 02';
Execute dbo.IncSetor 'SETOR 03';
Execute dbo.IncSetor 'SETOR 04';
/*
Execute dbo.AltSetor 1, 'SETOR 001';
Execute dbo.AltSetor 2, 'SETOR 002';
Execute dbo.AltSetor 3, 'SETOR 003';
Execute dbo.AltSetor 4, 'SETOR 004';

Execute dbo.ExcSetor 1;
Execute dbo.ExcSetor 2;
Execute dbo.ExcSetor 3;
Execute dbo.ExcSetor 4;
*/

Execute dbo.IncFuncionario 'FUNCIONARIO 01', '1969-31-07', 1, 1, 1234.56;
Execute dbo.IncFuncionario 'FUNCIONARIO 02', '1976-13-01', 2, 2, 2345.67;
Execute dbo.IncFuncionario 'FUNCIONARIO 03', '1943-23-06', 3, 3, 3456.78;
Execute dbo.IncFuncionario 'FUNCIONARIO 04', '1934-10-06', 4, 4, 9012.34;
/*
Execute dbo.AltFuncionario 1, 'FUNCIONARIO 001', '1969-31-07', 1, 1, 1234.56;
Execute dbo.AltFuncionario 2, 'FUNCIONARIO 002', '1976-13-01', 2, 2, 2345.67;
Execute dbo.AltFuncionario 3, 'FUNCIONARIO 003', '1943-23-06', 3, 3, 3456.78;
Execute dbo.AltFuncionario 4, 'FUNCIONARIO 004', '1934-10-06', 4, 4, 9012.34;

Execute dbo.ExcFuncionario 1;
Execute dbo.ExcFuncionario 2;
Execute dbo.ExcFuncionario 3;
Execute dbo.ExcFuncionario 4;
*/

/*========================================================================*/
