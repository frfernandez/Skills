/*========================================================================*/

Use Rodonaves;

Go

/*========================================================================*/

Create Trigger dbo.IInsUnidade On dbo.Unidades Instead Of Insert
As
Declare @Save Char(1) = 'N',
        @Message Varchar(255);
begin
  Set NoCount On;

  if ((Select LTrim(Nome)
       From Inserted) <> '')
  begin
    if (Exists(Select Top 1 1
               From dbo.Unidades (NoLock)
               Where Nome = (Select LTrim(Nome)
                             From Inserted)))
      Set @Message = 'O nome da unidade já foi cadastrado.';
    else
      Set @Save = 'Y';
  end
  else
    Set @Message = 'O nome da unidade deverá ser informado.';

  if (@Save = 'Y')
  begin
    Insert Into dbo.Unidades
    (Nome, Ativa)
    Select LTrim(Nome), Ativa
    From Inserted;
  end
  else
  begin
    RaisError(@Message, 10, 1);
    Return;
  end
end;

Go

/*========================================================================*/

Create Trigger dbo.IInsUsuario On dbo.Usuarios Instead Of Insert
As
Declare @Save Char(1) = 'N',
        @Message Varchar(255);
begin
  Set NoCount On;

  if ((Select LTrim(Login)
       From Inserted) <> '')
  begin
    if (Exists(Select Top 1 1
               From dbo.Usuarios (NoLock)
               Where Login = (Select LTrim(Login)
                             From Inserted)))
      Set @Message = 'O login do usuário já foi cadastrado.';
    else
      Set @Save = 'Y';
  end
  else
    Set @Message = 'O login do usuário deverá ser informado.';

  if (@Save = 'Y')
  begin
    Insert Into dbo.Usuarios
    (Login, Senha, Status)
    Select LTrim(Login), Senha, Status
    From Inserted;
  end
  else
  begin
    RaisError(@Message, 10, 1);
    Return;
  end
end;

Go

/*========================================================================*/

Create Trigger dbo.IInsColaborador On dbo.Colaboradores Instead Of Insert
As
Declare @Save Char(1) = 'N',
        @Message Varchar(255);
begin
  Set NoCount On;

  if ((Select LTrim(Nome)
       From Inserted) <> '')
  begin
    if (Exists(Select Top 1 1
               From dbo.Colaboradores (NoLock)
               Where Nome = (Select LTrim(Nome)
                             From Inserted)))
      Set @Message = 'O nome do colaborador já foi cadastrado.';
    else
      Set @Save = 'Y';
  end
  else
    Set @Message = 'O nome do colaborador deverá ser informado.';

  if (@Save = 'Y')
  begin
    Insert Into dbo.Colaboradores
    (Nome, CodigoUsuario, CodigoUnidade)
    Select LTrim(Nome), CodigoUsuario, CodigoUnidade
    From Inserted;
  end
  else
  begin
    RaisError(@Message, 10, 1);
    Return;
  end
end;

Go

/*========================================================================*/
