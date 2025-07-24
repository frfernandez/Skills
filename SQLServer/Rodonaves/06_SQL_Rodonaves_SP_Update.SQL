/*========================================================================*/

Use Rodonaves;

Go

/*========================================================================*/

Create Procedure dbo.UpdUnidades
(
@Codigo Integer,
@Nome Varchar(50),
@Ativa Char(1)
)
As
begin
  Set NoCount On;

  Update dbo.Unidades
  Set Nome  = @Nome,
      Ativa = @Ativa
  Where Codigo = @Codigo;
end;

Go

/*========================================================================*/

Create Procedure dbo.UpdUsuarios
(
@Codigo Integer,
@Login Varchar(50),
@Senha Varchar(50),
@Status Char(1)
)
As
begin
  Set NoCount On;

  Update dbo.Usuarios
  Set Login  = @Login,
      Senha  = @Senha,
      Status = @Status
  Where Codigo = @Codigo;
end;

Go

/*========================================================================*/

Create Procedure dbo.UpdColaboradores
(
@Codigo Integer,
@Nome Varchar(50),
@CodigoUsuario Integer,
@CodigoUnidade Integer
)
As
begin
  Set NoCount On;

  Update dbo.Colaboradores
  Set Nome          = @Nome,
      CodigoUsuario = @CodigoUsuario,
      CodigoUnidade = @CodigoUnidade
  Where Codigo = @Codigo;
end;

Go

/*========================================================================*/
