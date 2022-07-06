/*==========================================================================

	System...: Coobrastur
	Developer: Fernando Roberto Fernández

==========================================================================*/

Use Coobrastur;

Go

/*========================================================================*/

Select *
From dbo.Empresa;

Select *
From dbo.Setor;

Select *
From dbo.Funcionario;

Select *
From dbo.Funcionario_Excluidos;

Select dbo.Fct_Funcionario_Salario_Aumento(1, 17.1403) Perspectiva;

Select dbo.Idade(Cast('31/07/1969' As Date), Cast('10/06/1976' As Date)) Idade;

/*========================================================================*/
