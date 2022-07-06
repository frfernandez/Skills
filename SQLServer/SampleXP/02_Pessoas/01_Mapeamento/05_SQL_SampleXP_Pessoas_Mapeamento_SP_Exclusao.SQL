/*==========================================================================

Sistema......: SampleXP
Desenvolvedor: Fernando Roberto Fernández
Referência...: Procedimentos Armazenados de Exclusão

==========================================================================*/

Use SampleXP;

Go

/*========================================================================*/

Create Procedure Mapeamento.ExcTitulosEnderecos
(
@Codigo Integer
)
As
begin
  Set NoCount On;

  Delete From Mapeamento.TitulosEnderecos
  Where Codigo = @Codigo;
end;

Go

/*========================================================================*/

Create Procedure Mapeamento.ExcEnderecos
(
@Codigo Integer
)
As
begin
  Set NoCount On;

  Delete From Mapeamento.Enderecos
  Where Codigo = @Codigo;
end;

Go

/*========================================================================*/

Create Procedure Mapeamento.ExcBairros
(
@Codigo Integer
)
As
begin
  Set NoCount On;

  Delete From Mapeamento.Bairros
  Where Codigo = @Codigo;
end;

Go

/*========================================================================*/

Create Procedure Mapeamento.ExcContinentes
(
@Codigo Integer
)
As
begin
  Set NoCount On;

  Delete From Mapeamento.Continentes
  Where Codigo = @Codigo;
end;

Go

/*========================================================================*/

Create Procedure Mapeamento.ExcPaises
(
@Codigo Integer
)
As
begin
  Set NoCount On;

  Delete From Mapeamento.Paises
  Where Codigo = @Codigo;
end;

Go

/*========================================================================*/

Create Procedure Mapeamento.ExcEstados
(
@Codigo Integer
)
As
begin
  Set NoCount On;

  Delete From Mapeamento.Estados
  Where Codigo = @Codigo;
end;

Go

/*========================================================================*/

Create Procedure Mapeamento.ExcCidades
(
@Codigo Integer
)
As
begin
  Set NoCount On;

  Delete From Mapeamento.Cidades
  Where Codigo = @Codigo;
end;

Go

/*========================================================================*/
