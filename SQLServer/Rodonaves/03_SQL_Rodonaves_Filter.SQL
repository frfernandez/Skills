/*========================================================================*/

Use Rodonaves;

Go

/*========================================================================*/

Create Procedure dbo.FltUnidades
(
@Codigo Integer,
@Nome Varchar(50),
@Ativa Char(1),
@Search Char(1)
)
As
begin
  Set NoCount On;

  Select a.Codigo, a.Nome, a.Ativa
  From dbo.Unidades a (NoLock)
  Where ((@Codigo Is Null) Or
         (a.Codigo = @Codigo))
    And ((@Nome = '') Or
         (a.Nome Like
          (case @Search
           when 'N' then
             a.Nome
           when 'S' then
             @Nome + '%'
           when 'E' then
             '%' + @Nome
           when 'B' then
             '%' + @Nome + '%'
           else
             a.Nome
           end)))
    And ((@Ativa = '') Or
         (a.Ativa = @Ativa))
  Order By a.Nome;
end;

Go

/*========================================================================*/

Create Procedure dbo.FltUsuarios
(
@Codigo Integer,
@Login Varchar(50),
@Status Char(1),
@Search Char(1)
)
As
begin
  Set NoCount On;

  Select a.Codigo, a.Login, a.Senha, a.Status
  From dbo.Usuarios a (NoLock)
  Where ((@Codigo Is Null) Or
         (a.Codigo = @Codigo))
    And ((@Login = '') Or
         (a.Login Like
          (case @Search
           when 'N' then
             a.Login
           when 'S' then
             @Login + '%'
           when 'E' then
             '%' + @Login
           when 'B' then
             '%' + @Login + '%'
           else
             a.Login
           end)))
    And ((@Status = '') Or
         (a.Status = @Status))
  Order By a.Login;
end;

Go

/*========================================================================*/

Create Procedure dbo.FltColaboradores
(
@Codigo Integer,
@Nome Varchar(50),
@CodigoUsuario Integer,
@CodigoUnidade Integer,
@Search Char(1)
)
As
begin
  Set NoCount On;

  Select a.Codigo, a.Nome, a.CodigoUsuario, a.CodigoUnidade,
         b.Login Usuario, b.Status,
         c.Nome Unidade, c.Ativa
  From dbo.Colaboradores a (NoLock)
  Join dbo.Usuarios b (NoLock) On a.CodigoUsuario = b.Codigo
  Join dbo.Unidades c (NoLock) On a.CodigoUnidade = c.Codigo
  Where ((@Codigo Is Null) Or
         (a.Codigo = @Codigo))
    And ((@Nome = '') Or
         (a.Nome Like
          (case @Search
           when 'N' then
             a.Nome
           when 'S' then
             @Nome + '%'
           when 'E' then
             '%' + @Nome
           when 'B' then
             '%' + @Nome + '%'
           else
             a.Nome
           end)))
    And ((@CodigoUsuario Is Null) Or
         (a.CodigoUsuario = @CodigoUsuario))
    And ((@CodigoUnidade Is Null) Or
         (a.CodigoUnidade = @CodigoUnidade))
  Order By a.Nome;
end;

Go

/*========================================================================*/

Select *
From System.Messages
Where IdProject = 1
  And IdIdiom   = 1
  And IdMessage = 41

Select *
From dbo.Unidades

Select *
From dbo.VwUnidades

Select *
From dbo.Usuarios

Select *
From dbo.VwUsuarios

Select *
From dbo.Colaboradores

Select *
From dbo.VwColaboradores

Execute dbo.FltUnidades Null, '', '', 'S';
Execute dbo.FltUsuarios Null, '', '', 'S';
Execute dbo.FltColaboradores Null, '', Null, Null, 'S';
