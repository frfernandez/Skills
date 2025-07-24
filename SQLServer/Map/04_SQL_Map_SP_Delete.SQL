/*========================================================================*/

Use Map;

Go

/*========================================================================*/

Create Procedure DelContinents
(
@Id Integer
)
As
begin
  Set NoCount On;

  Delete From Continents
  Where Id = @Id;
end;

Go

/*========================================================================*/

Create Procedure DelCountries
(
@Id Integer
)
As
begin
  Set NoCount On;

  Delete From Countries
  Where Id = @Id;
end;

Go

/*========================================================================*/

Create Procedure DelStates
(
@Id Integer
)
As
begin
  Set NoCount On;

  Delete From States
  Where Id = @Id;
end;

Go

/*========================================================================*/

Create Procedure DelCities
(
@Id Integer
)
As
begin
  Set NoCount On;

  Delete From Cities
  Where Id = @Id;
end;

Go

/*========================================================================*/
