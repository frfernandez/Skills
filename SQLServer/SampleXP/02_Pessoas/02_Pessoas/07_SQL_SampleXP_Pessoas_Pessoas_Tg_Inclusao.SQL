/*==========================================================================

Sistema......: SampleXP
Desenvolvedor: Fernando Roberto Fern?ndez
Refer?ncia...: Gatilhos de Inclus?o

==========================================================================*/

Use SampleXP;

Go

/*========================================================================*/

Create Trigger Pessoas.AIncPessoa On Pessoas.Pessoas Instead Of Insert
As
Declare @Cadastro Char(1) = 'N';
begin
  Set NoCount On;

  if ((Select LTrim(Pessoa)
       From Inserted) <> '')
  begin
    if (Exists(Select *
               From Pessoas.Pessoas
               Where Pessoa = (Select LTrim(Pessoa)
                               From Inserted)))
      RaisError('A pessoa j? foi cadastrada !', 10, 1);
    else
      Set @Cadastro = 'S';
  end
  else
    RaisError('A pessoa dever? ser informada !', 10, 1);

  if (@Cadastro = 'S')
  begin
    Insert Into Pessoas.Pessoas
    (Pessoa)
    Select LTrim(Pessoa)
    From Inserted;
  end
end;

Go

/*========================================================================*/
