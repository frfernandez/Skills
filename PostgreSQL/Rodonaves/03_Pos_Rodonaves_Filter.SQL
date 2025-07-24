Create Function Public.FltUnidades
(
_Codigo Integer,
_Nome Varchar(50),
_Ativa Char(1),
_Search Char(1)
)
Returns Table
(
Codigo Integer,
Nome Varchar(50),
Ativa Char(1)
)
Language PLPGSQL
As $$
begin
  Return Query
  Select a.Codigo, a.Nome, a.Ativa
  From Public.Unidades a
  Where ((_Codigo Is Null) Or
         (a.Codigo = _Codigo))
    And ((_Nome = '') Or
         (a.Nome Like
          (case _Search
           when 'N' then
             a.Nome
           when 'S' then
             _Nome || '%'
           when 'E' then
             '%' || _Nome
           when 'B' then
             '%' || _Nome || '%'
           else
             a.Nome
           end)))
    And ((_Ativa = '') Or
         (a.Ativa = _Ativa))
  Order By a.Nome;
end;$$;

/*========================================================================*/

Create Function Public.FltUsuarios
(
_Codigo Integer,
_Login Varchar(50),
_Status Char(1),
_Search Char(1)
)
Returns Table
(
Codigo Integer,
Login Varchar(50),
Senha Varchar(50),
Status Char(1)
)
Language PLPGSQL
As $$
begin
  Return Query
  Select a.Codigo, a.Login, a.Senha, a.Status
  From Public.Usuarios a (NoLock)
  Where ((_Codigo Is Null) Or
         (a.Codigo = _Codigo))
    And ((_Login = '') Or
         (a.Login Like
          (case _Search
           when 'N' then
             a.Login
           when 'S' then
             _Login || '%'
           when 'E' then
             '%' || _Login
           when 'B' then
             '%' || _Login || '%'
           else
             a.Login
           end)))
    And ((_Status = '') Or
         (a.Status = _Status))
  Order By a.Login;
end;$$;

/*========================================================================*/

Create Function Public.FltColaboradores
(
_Codigo Integer,
_Nome Varchar(50),
_CodigoUsuario Integer,
_CodigoUnidade Integer,
_Search Char(1)
)
Returns Table
(
Codigo Integer,
Nome Varchar(50),
CodigoUsuario Integer,
CodigoUnidade Integer,
Usuario Varchar(50),
Status Char(1),
Unidade Varchar(50),
Ativa Char(1)
)
Language PLPGSQL
As $$
begin
  Return Query
  Select a.Codigo, a.Nome, a.CodigoUsuario, a.CodigoUnidade,
         b.Login Usuario, b.Status,
         c.Nome Unidade, c.Ativa
  From Public.Colaboradores a
  Join Public.Usuarios b On a.CodigoUsuario = b.Codigo
  Join Public.Unidades c On a.CodigoUnidade = c.Codigo
  Where ((_Codigo Is Null) Or
         (a.Codigo = _Codigo))
    And ((_Nome = '') Or
         (a.Nome Like
          (case _Search
           when 'N' then
             a.Nome
           when 'S' then
             _Nome || '%'
           when 'E' then
             '%' || _Nome
           when 'B' then
             '%' || _Nome || '%'
           else
             a.Nome
           end)))
    And ((_CodigoUsuario Is Null) Or
         (a.CodigoUsuario = _CodigoUsuario))
    And ((_CodigoUnidade Is Null) Or
         (a.CodigoUnidade = _CodigoUnidade))
  Order By a.Nome;
end;$$;

/*========================================================================*/
