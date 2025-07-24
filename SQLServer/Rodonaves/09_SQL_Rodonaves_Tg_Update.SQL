/*========================================================================*/

Use Rodonaves;

Go

/*========================================================================*/

Create Trigger dbo.IUpdUnidade On dbo.Unidades Instead Of Update
As
Declare @Save Char(1) = 'N',
        @Codigo Integer,
        @Nome Varchar(50),
		@Ativa Char(1),
        @Message Varchar(255);
begin
  Set NoCount On;

  Select @Codigo = Codigo,
         @Ativa  = Ativa,
         @Nome   = LTrim(Nome)
  From Inserted;

  if (@Nome <> '')
  begin
    if (Exists(Select Top 1 1
               From dbo.Unidades (NoLock)
               Where Codigo <> @Codigo
                 And Nome    = @Nome))
      Set @Message = 'O nome da unidade já foi cadastrado.';
    else
      Set @Save = 'Y';
  end
  else
    Set @Message = 'O nome da unidade deverá ser informado.';

  if (@Save = 'Y')
  begin
    Update a
    Set a.Nome  = LTrim(b.Nome),
	    a.Ativa = b.Ativa
    From dbo.Unidades a (NoLock)
    Join Inserted b On a.Codigo = b.Codigo;
  end
  else
  begin
    RaisError(@Message, 10, 1);
    Return;
  end
end;

Go

/*========================================================================*/

Create Trigger dbo.IUpdUsuario On dbo.Usuarios Instead Of Update
As
Declare @Save Char(1) = 'N',
        @Codigo Integer,
        @Login Varchar(50),
        @Senha Varchar(50),
		@Status Char(1),
        @Message Varchar(255);
begin
  Set NoCount On;

  Select @Codigo = Codigo,
         @Login  = LTrim(Login),
         @Senha  = Senha,
		 @Status = Status
  From Inserted;

  if (@Login <> '')
  begin
    if (Exists(Select Top 1 1
               From dbo.Usuarios (NoLock)
               Where Codigo <> @Codigo
                 And Login   = @Login))
      Set @Message = 'O login do usuário já foi cadastrado.';
    else
      Set @Save = 'Y';
  end
  else
    Set @Message = 'O login do usuário deverá ser informado.';

  if (@Save = 'Y')
  begin
    Update a
    Set a.Login  = LTrim(b.Login),
	    a.Senha  = b.Senha,
		a.Status = b.Status
    From dbo.Usuarios a (NoLock)
    Join Inserted b On a.Codigo = b.Codigo;
  end
  else
  begin
    RaisError(@Message, 10, 1);
    Return;
  end
end;

Go

/*========================================================================*/

Create Trigger dbo.IUpdColaborador On dbo.Colaboradores Instead Of Update
As
Declare @Save Char(1) = 'N',
        @Codigo Integer,
        @Nome Varchar(50),
		@CodigoUsuario Integer,
		@CodigoUnidade Integer,
        @Message Varchar(255);
begin
  Set NoCount On;

  Select @Codigo        = Codigo,
         @Nome          = LTrim(Nome),
         @CodigoUsuario = CodigoUsuario,
         @CodigoUnidade = CodigoUnidade
  From Inserted;

  if (@Nome <> '')
  begin
    if (Exists(Select Top 1 1
               From dbo.Colaboradores (NoLock)
               Where Codigo <> @Codigo
                 And Nome    = @Nome))
      Set @Message = 'O nome do colaborador já foi cadastrado.';
    else
      Set @Save = 'Y';
  end
  else
    Set @Message = 'O nome do colaborador deverá ser informado.';

  if (@Save = 'Y')
  begin
    Update a
    Set a.Nome          = LTrim(b.Nome),
        a.CodigoUsuario = b.CodigoUsuario,
        a.CodigoUnidade = b.CodigoUnidade
    From dbo.Colaboradores a (NoLock)
    Join Inserted b On a.Codigo = b.Codigo;
  end
  else
  begin
    RaisError(@Message, 10, 1);
    Return;
  end
end;

Go

/*========================================================================*/
