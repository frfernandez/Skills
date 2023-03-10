/*==========================================================================

Sistema......: SampleXP
Desenvolvedor: Fernando Roberto Fern?ndez
Refer?ncia...: Gatilhos de Altera??o

==========================================================================*/

Use SampleXP;

Go

/*========================================================================*/

Create Trigger Pessoas.AAltPessoa On Pessoas.Pessoas Instead Of Update
As
Declare @Cadastro Char(1) = 'N';
begin
  Set NoCount On;

  if ((Select LTrim(Pessoa)
       From Inserted) <> '')
  begin
    if Update(Pessoa)
    begin
      if (Exists(Select *
                 From Pessoas.Pessoas
                 Where Pessoa = (Select LTrim(Pessoa)
                                 From Inserted)))
        RaisError('A pessoa j? foi cadastrada !', 10, 1);
      else
        Set @Cadastro = 'S';
    end
  end
  else
    RaisError('A pessoa dever? ser informada !', 10, 1);

  if (@Cadastro = 'S')
  begin
    Update a
    Set a.Pessoa = LTrim(b.Pessoa)
    From Pessoas.Pessoas a
    Join Inserted b On a.Codigo = b.Codigo;
  end
end;

Go

/*========================================================================*/
