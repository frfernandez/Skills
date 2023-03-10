/*==========================================================================

Sistema......: SampleXP
Desenvolvedor: Fernando Roberto Fern?ndez
Refer?ncia...: Gatilhos de Altera??o

==========================================================================*/

Use SampleXP;

Go

/*========================================================================*/

Create Trigger Mapeamento.AAltTituloEndereco On Mapeamento.TitulosEnderecos Instead Of Update
As
Declare @Cadastro Char(1) = 'N';
begin
  Set NoCount On;

  if ((Select LTrim(Titulo)
       From Inserted) <> '')
  begin
    if Update(Titulo)
    begin
      if (Exists(Select *
                 From Mapeamento.TitulosEnderecos
                 Where Titulo = (Select LTrim(Titulo)
                                 From Inserted)))
        RaisError('O t?tulo do endere?o j? foi cadastrado !', 10, 1);
      else
        Set @Cadastro = 'S';
    end
  end
  else
    RaisError('O t?tulo do endere?o dever? ser informado !', 10, 1);

  if (@Cadastro = 'S')
  begin
    Update a
    Set a.Titulo = LTrim(b.Titulo)
    From Mapeamento.TitulosEnderecos a
    Join Inserted b On a.Codigo = b.Codigo;
  end
end;

Go

/*========================================================================*/

Create Trigger Mapeamento.AAltEndereco On Mapeamento.Enderecos Instead Of Update
As
Declare @Cadastro Char(1) = 'N';
begin
  Set NoCount On;

  if ((Select LTrim(Endereco)
       From Inserted) <> '')
  begin
    if Update(Endereco)
    begin
      if (Exists(Select *
                 From Mapeamento.Enderecos
                 Where Endereco = (Select LTrim(Endereco)
                                   From Inserted)))
        RaisError('O endere?o j? foi cadastrado !', 10, 1);
      else
        Set @Cadastro = 'S';
    end
  end
  else
    RaisError('O endere?o dever? ser informado !', 10, 1);

  if (@Cadastro = 'S')
  begin
    Update a
    Set a.Endereco = LTrim(b.Endereco)
    From Mapeamento.Enderecos a
    Join Inserted b On a.Codigo = b.Codigo;
  end
end;

Go

/*========================================================================*/

Create Trigger Mapeamento.AAltBairro On Mapeamento.Bairros Instead Of Update
As
Declare @Cadastro Char(1) = 'N';
begin
  Set NoCount On;

  if ((Select LTrim(Bairro)
       From Inserted) <> '')
  begin
    if Update(Bairro)
    begin
      if (Exists(Select *
                 From Mapeamento.Bairros
                 Where Bairro = (Select LTrim(Bairro)
                                 From Inserted)))
        RaisError('O bairro j? foi cadastrado !', 10, 1);
      else
        Set @Cadastro = 'S';
    end
  end
  else
    RaisError('O bairro dever? ser informado !', 10, 1);

  if (@Cadastro = 'S')
  begin
    Update a
    Set a.Bairro = LTrim(b.Bairro)
    From Mapeamento.Bairros a
    Join Inserted b On a.Codigo = b.Codigo;
  end
end;

Go

/*========================================================================*/

Create Trigger Mapeamento.AAltContinente On Mapeamento.Continentes Instead Of Update
As
Declare @Cadastro Char(1) = 'N';
begin
  Set NoCount On;

  if ((Select LTrim(Continente)
       From Inserted) <> '')
  begin
    if Update(Continente)
    begin
      if (Exists(Select *
                 From Mapeamento.Continentes
                 Where Continente = (Select LTrim(Continente)
                                     From Inserted)))
        RaisError('O continente j? foi cadastrado !', 10, 1);
      else
        Set @Cadastro = 'S';
    end
  end
  else
    RaisError('O continente dever? ser informado !', 10, 1);

  if (@Cadastro = 'S')
  begin
    Update a
    Set a.Continente = LTrim(b.Continente)
    From Mapeamento.Continentes a
    Join Inserted b On a.Codigo = b.Codigo;
  end
end;

Go

/*========================================================================*/

Create Trigger Mapeamento.AAltPais On Mapeamento.Paises Instead Of Update
As
Declare @Cadastro Char(1) = 'N',
        @Pais Varchar(50),
        @Sigla Varchar(3),
        @CodigoContinente Integer;
begin
  Set NoCount On;

  Select @Pais             = LTrim(Pais),
         @Sigla            = LTrim(Sigla),
         @CodigoContinente = CodigoContinente
  From Inserted;

  if (@Pais <> '') And
     (@Sigla <> '') And
	 (@CodigoContinente Is Not Null)
  begin
    if Update(Pais)
    begin
      if (Exists(Select *
                 From Mapeamento.Paises
                 Where Pais             = @Pais
                   And Sigla            = @Sigla
                   And CodigoContinente = @CodigoContinente))
        RaisError('A combina??o de pais, sigla e continente j? foram cadastradas !', 10, 1);
      else
        Set @Cadastro = 'S';
    end
  end
  else
    RaisError('A combina??o de pais, sigla e continente dever?o ser informadas !', 10, 1);

  if (@Cadastro = 'S')
  begin
    Update a
    Set a.Pais             = LTrim(b.Pais),
        a.Sigla            = LTrim(b.Sigla),
        a.CodigoContinente = b.CodigoContinente
    From Mapeamento.Paises a
    Join Inserted b On a.Codigo = b.Codigo;
  end
end;

Go

/*========================================================================*/

Create Trigger Mapeamento.AAltEstado On Mapeamento.Estados Instead Of Update
As
Declare @Cadastro Char(1) = 'N',
        @Estado Varchar(50),
        @Sigla Varchar(3),
        @CodigoPais Integer;
begin
  Set NoCount On;

  Select @Estado     = LTrim(Estado),
         @Sigla      = LTrim(Sigla),
         @CodigoPais = CodigoPais
       From Inserted;

  if (@Estado <> '') And
     (@Sigla <> '') And 
     (@CodigoPais Is Not Null)
  begin
    if Update(Estado)
    begin
      if (Exists(Select *
                 From Mapeamento.Estados
                 Where Estado     = @Estado
                   And Sigla      = @Sigla
                   And CodigoPais = @CodigoPais))
        RaisError('A combina??o de estado, sigla e pa?s j? foram cadastradas !', 10, 1);
      else
        Set @Cadastro = 'S';
    end
  end
  else
    RaisError('A combina??o de estado, sigla e pa?s dever?o ser informadas !', 10, 1);

  if (@Cadastro = 'S')
  begin
    Update a
    Set a.Estado     = LTrim(b.Estado),
        a.Sigla      = LTrim(b.Sigla),
        a.CodigoPais = b.CodigoPais
    From Mapeamento.Estados a
    Join Inserted b On a.Codigo = b.Codigo;
  end
end;

Go

/*========================================================================*/

Create Trigger Mapeamento.AAltCidade On Mapeamento.Cidades Instead Of Update
As
Declare @Cadastro Char(1) = 'N',
        @Cidade Varchar(50),
        @CodigoEstado Integer;
begin
  Set NoCount On;

  Select @Cidade       = LTrim(Cidade),
         @CodigoEstado = LTrim(CodigoEstado)
  From Inserted;

  if ((@Cidade <> '') And (@CodigoEstado <> ''))
  begin
    if Update(Cidade)
    begin
      if (Exists(Select *
                 From Mapeamento.Cidades
                 Where Cidade       = @Cidade
                   And CodigoEstado = @CodigoEstado))
        RaisError('A combina??o de cidade e estado j? foram cadastradas !', 10, 1);
      else
        Set @Cadastro = 'S';
    end
  end
  else
    RaisError('A combina??o de cidade e estado dever?o ser informadas !', 10, 1);

  if (@Cadastro = 'S')
  begin
    Update a
    Set a.Cidade       = b.Cidade,
        a.CodigoEstado = b.CodigoEstado
    From Mapeamento.Cidades a
    Join Inserted b On a.Codigo = b.Codigo;
  end
end;

Go

/*========================================================================*/
