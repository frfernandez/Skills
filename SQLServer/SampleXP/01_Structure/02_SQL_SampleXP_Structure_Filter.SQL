/*========================================================================*/

Use SampleXP;

Go

/*========================================================================*/

Create Procedure System.FltSchemaTable
(
@Object Varchar(50)
)
As
begin
  Set NoCount On;

  Set @Object = Upper(@Object);

  Select b.Name SchemaName
  From Sys.Tables a
  Join Sys.Schemas b On a.Schema_Id = b.Schema_Id
  Where a.Name = @Object;
end;

Go

/*========================================================================*/

Create Procedure System.FltSchemaProcedure
(
@Object Varchar(50)
)
As
begin
  Set NoCount On;

  Set @Object = Upper(@Object);

  Select b.Name SchemaName
  From Sys.Procedures a
  Join Sys.Schemas b On a.Schema_Id = b.Schema_Id
  Where a.Name = @Object
  Union
  Select b.Name SchemaName
  From Sys.Views a
  Join Sys.Schemas b On a.Schema_Id = b.Schema_Id
  Where a.Name = @Object;
end;

Go

/*========================================================================*/
