/*========================================================================*/

Use SampleXP;

Go

/*========================================================================*/

Create Procedure Map.InsNeighborhoods
(
@Text Varchar(50)
)
As
begin
  Set NoCount On;

  Insert Into Map.Neighborhoods
  (Neighborhood)
  Values (@Text);
end;

Go

/*========================================================================*/

Create Procedure Map.InsAddresses
(
@Text Varchar(50)
)
As
begin
  Set NoCount On;

  Insert Into Map.Addresses
  (Address)
  Values (@Text);
end;

Go

/*========================================================================*/

Create Procedure Map.InsDistricts
(
@Text Varchar(50)
)
As
begin
  Set NoCount On;

  Insert Into Map.Districts
  (District)
  Values (@Text);
end;

Go

/*========================================================================*/

Create Procedure Map.InsContinents
(
@Text Varchar(50)
)
As
begin
  Set NoCount On;

  Insert Into Map.Continents
  (Continent)
  Values (@Text);
end;

Go

/*========================================================================*/

Create Procedure Map.InsCountries
(
@Country Varchar(50),
@Initial Varchar(5),
@IdContinent Integer
)
As
begin
  Set NoCount On;

  Insert Into Map.Countries
  (Country, Initial, IdContinent)
  Values (@Country, @Initial, @IdContinent);
end;

Go

/*========================================================================*/

Create Procedure Map.InsStates
(
@State Varchar(50),
@Initial Varchar(3),
@IdCountry Integer
)
As
begin
  Set NoCount On;

  Insert Into Map.States
  (State, Initial, IdCountry)
  Values (@State, @Initial, @IdCountry);
end;

Go

/*========================================================================*/

Create Procedure Map.InsCities
(
@City Varchar(50),
@IdState Integer
)
As
begin
  Set NoCount On;

  Insert Into Map.Cities
  (City, IdState)
  Values (@City, @IdState);
end;

Go

/*========================================================================*/