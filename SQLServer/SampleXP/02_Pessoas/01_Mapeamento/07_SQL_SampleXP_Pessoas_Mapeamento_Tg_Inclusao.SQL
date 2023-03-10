/*==========================================================================

Sistema......: SampleXP
Desenvolvedor: Fernando Roberto Fern?ndez
Refer?ncia...: Gatilhos de Inclus?o

==========================================================================*/

Use SampleXP;

Go

/*========================================================================*/

Create Trigger Mapeamento.AIncTituloEndereco On Mapeamento.TitulosEnderecos Instead Of Insert
As
Declare @Cadastro Char(1) = 'N';
begin
  Set NoCount On;

  if ((Select LTrim(Titulo)
       From Inserted) <> '')
  begin
    if (Exists(Select *
               From Mapeamento.TitulosEnderecos
               Where Titulo = (Select LTrim(Titulo)
                               From Inserted)))
      RaisError('O t?tulo do endere?o j? foi cadastrado !', 10, 1);
    else
      Set @Cadastro = 'S';
  end
  else
    RaisError('O t?tulo do endere?o dever? ser informado !', 10, 1);

  if (@Cadastro = 'S')
  begin
    Insert Into Mapeamento.TitulosEnderecos
    (Titulo)
    Select LTrim(Titulo)
    From Inserted;
  end
end;

Go

/*========================================================================*/

Create Trigger Mapeamento.AIncEndereco On Mapeamento.Enderecos Instead Of Insert
As
Declare @Cadastro Char(1) = 'N';
begin
  Set NoCount On;

  if ((Select LTrim(Endereco)
       From Inserted) <> '')
  begin
    if (Exists(Select *
               From Mapeamento.Enderecos
               Where Endereco = (Select LTrim(Endereco)
                                 From Inserted)))
      RaisError('O endere?o j? foi cadastrado !', 10, 1);
    else
      Set @Cadastro = 'S';
  end
  else
    RaisError('O endere?o dever? ser informado !', 10, 1);

  if (@Cadastro = 'S')
  begin
    Insert Into Mapeamento.Enderecos
    (Endereco)
    Select LTrim(Endereco)
    From Inserted;
  end
end;

Go

/*========================================================================*/

Create Trigger Mapeamento.AIncBairro On Mapeamento.Bairros Instead Of Insert
As
Declare @Cadastro Char(1) = 'N';
begin
  Set NoCount On;

  if ((Select LTrim(Bairro)
       From Inserted) <> '')
  begin
    if (Exists(Select *
               From Mapeamento.Bairros
               Where Bairro = (Select LTrim(Bairro)
                               From Inserted)))
      RaisError('O bairro j? foi cadastrado !', 10, 1);
    else
      Set @Cadastro = 'S';
  end
  else
    RaisError('O bairro dever? ser informado !', 10, 1);

  if (@Cadastro = 'S')
  begin
    Insert Into Mapeamento.Bairros
    (Bairro)
    Select LTrim(Bairro)
    From Inserted;
  end
end;

Go

/*========================================================================*/

Create Trigger Mapeamento.AIncContinente On Mapeamento.Continentes Instead Of Insert
As
Declare @Cadastro Char(1) = 'N';
begin
  Set NoCount On;

  if ((Select LTrim(Continente)
       From Inserted) <> '')
  begin
    if (Exists(Select *
               From Mapeamento.Continentes
               Where Continente = (Select LTrim(Continente)
                                   From Inserted)))
      RaisError('O continente j? foi cadastrado !', 10, 1);
    else
      Set @Cadastro = 'S';
  end
  else
    RaisError('O continente dever? ser informado !', 10, 1);

  if (@Cadastro = 'S')
  begin
    Insert Into Mapeamento.Continentes
    (Continente)
    Select LTrim(Continente)
    From Inserted;
  end
end;

Go

/*========================================================================*/

Create Trigger Mapeamento.AIncPais On Mapeamento.Paises Instead Of Insert
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
    if (Exists(Select *
               From Mapeamento.Paises
               Where Pais             = @Pais
                 And Sigla            = @Sigla
                 And CodigoContinente = @CodigoContinente))
      RaisError('A combina??o de pais, sigla e continente j? foram cadastradas !', 10, 1);
    else
      Set @Cadastro = 'S';
  end
  else
    RaisError('A combina??o de pais, sigla e continente dever?o ser informadas !', 10, 1);

  if (@Cadastro = 'S')
  begin
    Insert Into Mapeamento.Paises
    (Pais, Sigla, CodigoContinente)
    Select LTrim(Pais), LTrim(Sigla), CodigoContinente
    From Inserted;
  end
end;

Go

/*========================================================================*/

Create Trigger Mapeamento.AIncEstado On Mapeamento.Estados Instead Of Insert
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
    if (Exists(Select *
               From Mapeamento.Estados
               Where Estado     = @Estado
                 And Sigla      = @Sigla
                 And CodigoPais = @CodigoPais))
      RaisError('A combina??o de estado, sigla e pa?s j? foram cadastradas !', 10, 1);
    else
      Set @Cadastro = 'S';
  end
  else
    RaisError('A combina??o de estado, sigla e pa?s dever?o ser informadas !', 10, 1);

  if (@Cadastro = 'S')
  begin
    Insert Into Mapeamento.Estados
    (Estado, Sigla, CodigoPais)
    Select LTrim(Estado), LTrim(Sigla), CodigoPais
    From Inserted;
  end
end;

Go

/*========================================================================*/

Create Trigger Mapeamento.AIncCidade On Mapeamento.Cidades Instead Of Insert
As
Declare @Cadastro Char(1) = 'N',
        @Cidade Varchar(50),
        @CodigoEstado Integer;
begin
  Set NoCount On;

  Select @Cidade       = LTrim(Cidade),
         @CodigoEstado = CodigoEstado
  From Inserted;

  if ((@Cidade <> '') And (@CodigoEstado Is Not Null))
  begin
    if (Exists(Select *
               From Mapeamento.Cidades
               Where Cidade       = @Cidade
                 And CodigoEstado = @CodigoEstado))
      RaisError('A combina??o de cidade e estado j? foram cadastradas !', 10, 1);
    else
      Set @Cadastro = 'S';
  end
  else
    RaisError('A combina??o de cidade e estado dever?o ser informadas !', 10, 1);

  if (@Cadastro = 'S')
  begin
    Insert Into Mapeamento.Cidades
    (Cidade, CodigoEstado)
    Select LTrim(Cidade), CodigoEstado
    From Inserted;
  end
end;

Go

/*========================================================================*/
