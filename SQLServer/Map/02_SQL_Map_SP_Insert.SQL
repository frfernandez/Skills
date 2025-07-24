/*========================================================================*/

Use Map;

Go

/*========================================================================*/

Create Procedure InsContinents
(
@Text Varchar(50)
)
As
begin
  Set NoCount On;

  Insert Into Continents
  (Continent)
  Values (@Text);
end;

Go

/*========================================================================*/

Create Procedure InsCountries
(
@Country Varchar(50),
@Initial Varchar(5),
@IdContinent Integer,
@PostalCodeMask Varchar(10),
@International Varchar(5)
)
As
begin
  Set NoCount On;

  Insert Into Countries
  (Country, Initial, IdContinent, PostalCodeMask, International)
  Values (@Country, @Initial, @IdContinent, @PostalCodeMask, @International);
end;

Go

/*========================================================================*/

Create Procedure InsStates
(
@State Varchar(50),
@Initial Varchar(3),
@IdCountry Integer
)
As
begin
  Set NoCount On;

  Insert Into States
  (State, Initial, IdCountry)
  Values (@State, @Initial, @IdCountry);
end;

Go

/*========================================================================*/

Create Procedure InsCities
(
@City Varchar(50),
@IdState Integer,
@Long Varchar(5)
)
As
begin
  Set NoCount On;

  Insert Into Cities
  (City, IdState, Long)
  Values (@City, @IdState, @Long);
end;

Go

/*========================================================================*/
