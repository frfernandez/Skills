/*==========================================================================

Sistema......: SampleXP
Desenvolvedor: Fernando Roberto Fernández
Referência...: Procedimentos Armazenados com Filtros

==========================================================================*/

Use SampleXP;

Go

/*========================================================================*/

Create Procedure Sistema.FltEsquemaTabela
(
@Objeto Varchar(50)
)
As
begin
  Set NoCount On;

  Set @Objeto = Upper(@Objeto);

  Select b.Name Esquema
  From Sys.Tables a
  Join Sys.Schemas b On a.Schema_Id = b.Schema_Id
  Where a.Name = @Objeto;
end;

Go

/*========================================================================*/

Create Procedure Sistema.FltEsquemaProcedimento
(
@Objeto Varchar(50)
)
As
begin
  Set NoCount On;

  Set @Objeto = Upper(@Objeto);

  Select b.Name Esquema
  From Sys.Procedures a
  Join Sys.Schemas b On a.Schema_Id = b.Schema_Id
  Where a.Name = @Objeto
  Union
  Select b.Name Esquema
  From Sys.Views a
  Join Sys.Schemas b On a.Schema_Id = b.Schema_Id
  Where a.Name = @Objeto;
end;

Go

/*========================================================================*/
