/*========================================================================*/

Use Rodonaves;

Go

/*========================================================================*/

Create Procedure dbo.DelUnidades
(
@Codigo Integer
)
As
begin
  Set NoCount On;

  Delete dbo.Unidades
  Where Codigo = @Codigo;
end;

Go

/*========================================================================*/

Create Procedure dbo.DelUsuarios
(
@Codigo Integer
)
As
begin
  Set NoCount On;

  Delete dbo.Usuarios
  Where Codigo = @Codigo;
end;

Go

/*========================================================================*/

Create Procedure dbo.DelColaboradores
(
@Codigo Integer
)
As
begin
  Set NoCount On;

  Delete dbo.Colaboradores
  Where Codigo = @Codigo;
end;

Go

/*========================================================================*/
