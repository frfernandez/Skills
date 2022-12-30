/*==========================================================================

	System...: Coobrastur
	Developer: Fernando Roberto Fernández

==========================================================================*/

Use Coobrastur;

Go

/*========================================================================*/

Create Table dbo.Empresa
(
Codigo_Empresa Integer Identity(1, 1) Not Null,
Nome_Empresa Varchar(50) Not Null Check(Nome_Empresa = Upper(Nome_Empresa)),
Primary Key (Codigo_Empresa)
);

Go

/*========================================================================*/

Create Table dbo.Setor
(
Codigo_Setor Integer Identity(1, 1) Not Null,
Nome_Setor Varchar(50) Not Null Check(Nome_Setor = Upper(Nome_Setor)),
Primary Key (Codigo_Setor)
);

Go

/*========================================================================*/

Create Table dbo.Funcionario
(
Codigo Integer Identity(1, 1) Not Null,
Nome Varchar(50) Not Null Check(Nome = Upper(Nome)),
Data_Nascimento DateTime Not Null Check(Data_Nascimento < GetDate()),
Codigo_Setor Integer Not Null,
Codigo_Empresa Integer Not Null,
Salario Decimal(18, 2) Not Null Check(Salario > 0),
Detalhes Varchar(255),
Data_Cadastro DateTime Default GetDate() Not Null,
Foreign Key (Codigo_Setor) References dbo.Setor (Codigo_Setor),
Foreign Key (Codigo_Empresa) References dbo.Empresa (Codigo_Empresa),
Primary Key (Codigo)
);

Go

/*========================================================================*/

Create Table dbo.Funcionario_Excluidos
(
Codigo Integer Not Null,
Nome Varchar(50) Not Null Check(Nome = Upper(Nome)),
Data_Nascimento DateTime Not Null Check(Data_Nascimento < GetDate()),
Codigo_Setor Integer Not Null,
Codigo_Empresa Integer Not Null,
Salario Decimal(18, 2) Not Null Check(Salario > 0),
Detalhes Varchar(255),
Data_Cadastro DateTime Default GetDate() Not Null,
Data_Exclusao DateTime Default GetDate() Not Null,
Foreign Key (Codigo_Setor) References dbo.Setor (Codigo_Setor),
Foreign Key (Codigo_Empresa) References dbo.Empresa (Codigo_Empresa),
Primary Key (Codigo)
);

Go

/*========================================================================*/

Create Function dbo.Fct_Funcionario_Detalhes
(
@Codigo_Empresa Varchar(50),
@Codigo_Setor Varchar(50),
@Codigo_Funcionario Integer
)
Returns Varchar(255)
As
begin
  Declare @Nome_Empresa Varchar(50),
          @Nome_Setor Varchar(50);

  Select @Nome_Empresa = Nome_Empresa
  From dbo.Empresa
  Where Codigo_Empresa = @Codigo_Empresa;

  Select @Nome_Setor = a.Nome_Setor
  From dbo.Setor a
  Where a.Codigo_Setor = @Codigo_Setor;

  Return @Nome_Empresa + ' - ' + @Nome_Setor + ' - ' + Cast(@Codigo_Funcionario As Varchar(10));
end;

Go

/*========================================================================*/

Create Trigger dbo.AIncFuncionario On dbo.Funcionario Instead Of Insert
As
Declare @Codigo Integer;
begin
  Set NoCount On;

  Select @Codigo = Max(Codigo) + 1
  From dbo.Funcionario;

  if @Codigo Is Null
    Set @Codigo = 1;

  Insert Into dbo.Funcionario
  (Nome, Data_Nascimento, Codigo_Setor, Codigo_Empresa, Salario,
   Detalhes)
  Select Nome, Data_Nascimento, Codigo_Setor, Codigo_Empresa, Salario,
         (Select dbo.Fct_Funcionario_Detalhes(Codigo_Empresa, Codigo_Setor, @Codigo))
  From Inserted;
end;

Go

/*========================================================================*/

Create Function dbo.Idade
(
@DataInicial Date,
@DataFinal Date
)
Returns Integer
As
begin
  Declare @Anos Integer;
  
  Set @Anos = ((DateDiff(Day, @DataInicial, @DataFinal) - (DateDiff(Day, @DataInicial, @DataFinal) / 365) / 4) / 365);

  Return @Anos;
end;

Go

/*========================================================================*/

Create Trigger dbo.AAltFuncionario On dbo.Funcionario Instead Of Update
As
Declare @Codigo Integer;
begin
  Set NoCount On;

  Select @Codigo = Codigo
  From Inserted;

  Update a
  Set a.Nome            = b.Nome,
      a.Data_Nascimento = b.Data_Nascimento,
      a.Codigo_Setor    = b.Codigo_Setor,
      a.Codigo_Empresa  = b.Codigo_Empresa,
      a.Salario         = b.Salario,
	  a.Detalhes        = (Select dbo.Fct_Funcionario_Detalhes(a.Codigo_Empresa, a.Codigo_Setor, @Codigo))
  From dbo.Funcionario a
  Join Inserted b On a.Codigo = b.Codigo;
end;

Go

/*========================================================================*/

Create Trigger dbo.AExcFuncionario On dbo.Funcionario For Delete
As
begin
  Set NoCount On;

  Insert Into dbo.Funcionario_Excluidos
  (Codigo, Nome, Data_Nascimento, Codigo_Setor, Codigo_Empresa, Salario,
   Detalhes)
  Select Codigo, Nome, Data_Nascimento, Codigo_Setor, Codigo_Empresa, Salario,
         Detalhes
  From Deleted;
end;

Go

/*========================================================================*/

Create Function dbo.Fct_Funcionario_Salario_Aumento
(
@Codigo_Funcionario Integer,
@Aumento Decimal(6, 4)
)
Returns Decimal(18, 3)
As
begin
  Declare @Perspectiva Decimal(18, 4);

  Select @Perspectiva = Salario + ((Salario * @Aumento) / 100)
  From dbo.Funcionario
  Where Codigo = @Codigo_Funcionario;

  Return @Perspectiva;
end;

Go

/*========================================================================*/

Create Procedure dbo.IncEmpresa
(
@Empresa Varchar(50)
)
As
begin
  Set NoCount On;

  Begin Transaction;

  Insert Into dbo.Empresa
  (Nome_Empresa)
  Values (@Empresa);

  Commit Transaction;
end;

Go

/*========================================================================*/

Create Procedure dbo.AltEmpresa
(
@Codigo Integer,
@Empresa Varchar(50)
)
As
begin
  Set NoCount On;

  Begin Transaction;

  Update dbo.Empresa
  Set Nome_Empresa = @Empresa
  Where Codigo_Empresa = @Codigo;

  Commit Transaction;
end;

Go

/*========================================================================*/

Create Procedure dbo.ExcEmpresa
(
@Codigo Integer
)
As
begin
  Set NoCount On;

  Begin Transaction;

  if (Exists(Select *
             From dbo.Funcionario
			 Where Codigo_Empresa = @Codigo))
  begin
    RaisError('Empresa não pode ser excluída pois possui um funcionário relacionado !', 10, 1);

    Rollback;
  end
  else
  begin
    Delete From dbo.Empresa
    Where Codigo_Empresa = @Codigo;

    Commit Transaction;
  end
end;

Go

/*========================================================================*/

Create Procedure dbo.IncSetor
(
@Setor Varchar(50)
)
As
begin
  Set NoCount On;

  Begin Transaction;

  Insert Into dbo.Setor
  (Nome_Setor)
  Values (@Setor);

  Commit Transaction;
end;

Go

/*========================================================================*/

Create Procedure dbo.AltSetor
(
@Codigo Integer,
@Setor Varchar(50)
)
As
begin
  Set NoCount On;

  Begin Transaction;

  Update dbo.Setor
  Set Nome_Setor = @Setor
  Where Codigo_Setor = @Codigo;

  Commit Transaction;
end;

Go

/*========================================================================*/

Create Procedure dbo.ExcSetor
(
@Codigo Integer
)
As
begin
  Set NoCount On;

  Begin Transaction;

  if (Exists(Select *
             From dbo.Funcionario
			 Where Codigo_Setor = @Codigo))
  begin
    RaisError('Setor não pode ser excluído pois possui um funcionário relacionado !', 10, 1);

    Rollback;
  end
  else
  begin
    Delete From dbo.Setor
    Where Codigo_Setor = @Codigo;

    Commit Transaction;
  end
end;

Go

/*========================================================================*/

Create Procedure dbo.IncFuncionario
(
@Nome Varchar(50),
@Data_Nascimento DateTime,
@Codigo_Setor Integer,
@Codigo_Empresa Integer,
@Salario Decimal(18, 2)
)
As
begin
  Set NoCount On;

  Begin Transaction;

  Insert Into dbo.Funcionario
  (Nome, Data_Nascimento, Codigo_Setor, Codigo_Empresa, Salario)
  Values (@Nome, @Data_Nascimento, @Codigo_Setor, @Codigo_Empresa, @Salario);

  Commit Transaction;
end;

Go

/*========================================================================*/

Create Procedure dbo.AltFuncionario
(
@Codigo Integer,
@Nome Varchar(50),
@Data_Nascimento DateTime,
@Codigo_Setor Integer,
@Codigo_Empresa Integer,
@Salario Decimal(18, 2)
)
As
begin
  Set NoCount On;

  Begin Transaction;

  Update dbo.Funcionario
  Set Nome            = @Nome,
      Data_Nascimento = @Data_Nascimento,
      Codigo_Setor    = @Codigo_Setor,
      Codigo_Empresa  = @Codigo_Empresa,
      Salario         = @Salario
  Where Codigo = @Codigo;

  Commit Transaction;
end;

Go

/*========================================================================*/

Create Procedure dbo.ExcFuncionario
(
@Codigo Integer
)
As
begin
  Set NoCount On;

  Begin Transaction;

  Delete From dbo.Funcionario
  Where Codigo = @Codigo;

  Commit Transaction;
end;

Go

/*========================================================================*/

-- Relatorio1
Declare @Salario_Inicial Decimal(18, 2),
        @Salario_Final Decimal(18, 2),
        @Data_Cadastro_Inicial Date,
        @Data_Cadastro_Final Date;

Set @Salario_Inicial = Null;
Set @Salario_Final = Null;
Set @Data_Cadastro_Inicial = Null;
Set @Data_Cadastro_Final = Null;

Select a.Codigo 'Código Funcionário',
       a.Nome 'Nome Funcionário',
       b.Nome_Setor 'Nome Setor',
       c.Nome_Empresa 'Nome Empresa',
       (Select dbo.Idade(a.Data_Nascimento, GetDate())) 'Idade',
       a.Salario 'Salário'
From dbo.Funcionario a
Join dbo.Setor   b On a.Codigo_Setor   = b.Codigo_Setor
Join dbo.Empresa c On a.Codigo_Empresa = c.Codigo_Empresa
Where ((@Salario_Inicial Is Null) Or
       ((@Salario_Inicial Is Not Null) And
        (a.Salario >= @Salario_Inicial))) And
      ((@Salario_Final Is Null) Or
       ((@Salario_Final Is Not Null) And
        (a.Salario <= @Salario_Final))) And
      ((@Data_Cadastro_Inicial Is Null) Or
       ((@Data_Cadastro_Inicial Is Not Null) And
        (a.Data_Cadastro >= Convert(DateTime, Cast(@Data_Cadastro_Inicial As Char(10)) + ' 00:00:00.000', 121)))) And
      ((@Data_Cadastro_Final Is Null) Or
       ((@Data_Cadastro_Final Is Not Null) And
        (a.Data_Cadastro <= Convert(DateTime, Cast(@Data_Cadastro_Final As Char(10)) + ' 23:59:59.999', 121))));

/*========================================================================*/

-- Relatorio2
Declare @Codigo_Funcionario Integer,
        @Aumento Decimal(6, 4);

Set @Codigo_Funcionario = 1;
Set @Aumento = 17.1403;

Select a.Nome 'Nome do Funcionário',
       c.Nome_Empresa 'Nome da Empresa',
       b.Nome_Setor 'Nome do Setor',
       a.Codigo 'Código Funcionário',
       a.Salario 'Salário',
	   dbo.Fct_Funcionario_Salario_Aumento(@Codigo_Funcionario, @Aumento) 'Perspectiva Salarial'
From dbo.Funcionario a
Join dbo.Setor   b On a.Codigo_Setor   = b.Codigo_Setor
Join dbo.Empresa c On a.Codigo_Empresa = c.Codigo_Empresa
Where a.Codigo = @Codigo_Funcionario;

/*========================================================================*/
