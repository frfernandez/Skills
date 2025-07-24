/*========================================================================*/

Use Rodonaves;

Go

/*========================================================================*/

Create Procedure dbo.InsUnidades
(
@Nome Varchar(50),
@Ativa Char(1)
)
As
begin
  Set NoCount On;

  Insert Into dbo.Unidades
  (Nome, Ativa)
  Values (@Nome, @Ativa);
end;

Go

/*========================================================================*/

Create Procedure dbo.InsUsuarios
(
@Login Varchar(50),
@Senha Varchar(50),
@Status Char(1)
)
As
begin
  Set NoCount On;

  Insert Into dbo.Usuarios
  (Login, Senha, Status)
  Values (@Login, @Senha, @Status);
end;

Go

/*========================================================================*/

Create Procedure dbo.InsColaboradores
(
@Nome Varchar(50),
@CodigoUsuario Integer,
@CodigoUnidade Integer
)
As
begin
  Set NoCount On;

  Insert Into dbo.Colaboradores
  (Nome, CodigoUsuario, CodigoUnidade)
  Values (@Nome, @CodigoUsuario, @CodigoUnidade);
end;

Go

/*========================================================================*/
