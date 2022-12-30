/*========================================================================*/

Use SampleXP;

Go

/*========================================================================*/

Create Procedure Map.UpdNeighborhoods
(
@Id Integer,
@Text Varchar(50)
)
As
begin
  Set NoCount On;

  Update Map.Neighborhoods
  Set Neighborhood = @Text
  Where Id = @Id;
end;

Go

/*========================================================================*/

Create Procedure Map.UpdAddresses
(
@Id Integer,
@Text Varchar(50)
)
As
begin
  Set NoCount On;

  Update Map.Addresses
  Set Address = @Text
  Where Id = @Id;
end;

Go

/*========================================================================*/

Create Procedure Map.UpdDistricts
(
@Id Integer,
@Text Varchar(50)
)
As
begin
  Set NoCount On;

  Update Map.Districts
  Set District = @Text
  Where Id = @Id;
end;

Go

/*========================================================================*/

Create Procedure Map.UpdContinents
(
@Id Integer,
@Text Varchar(50)
)
As
begin
  Set NoCount On;

  Update Map.Continents
  Set Continent = @Text
  Where Id = @Id;
end;

Go

/*========================================================================*/

Create Procedure Map.UpdCountries
(
@Id Integer,
@Country Varchar(50),
@Initial Varchar(5),
@IdContinent Integer
)
As
begin
  Set NoCount On;

  Update Map.Countries
  Set Country     = @Country,
      Initial     = @Initial,
      IdContinent = @IdContinent
  Where Id = @Id;
end;

Go

/*========================================================================*/

Create Procedure Map.UpdStates
(
@Id Integer,
@State Varchar(50),
@Initial Varchar(3),
@IdCountry Integer
)
As
begin
  Set NoCount On;

  Update Map.States
  Set State     = @State,
      Initial   = @Initial,
      IdCountry = IdCountry
  Where Id = @Id;
end;

Go

/*========================================================================*/

Create Procedure Map.UpdCities
(
@Id Integer,
@City Varchar(50),
@IdState Integer
)
As
begin
  Set NoCount On;

  Update Map.Cities
  Set City    = @City,
      IdState = @IdState
  Where Id = @Id;
end;

Go

/*========================================================================*/