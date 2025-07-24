/*========================================================================*/

Use Map;

Go

/*========================================================================*/

Create Procedure UpdContinents
(
@Id Integer,
@Text Varchar(50)
)
As
begin
  Set NoCount On;

  Update Continents
  Set Continent = @Text
  Where Id = @Id;
end;

Go

/*========================================================================*/

Create Procedure UpdCountries
(
@Id Integer,
@Country Varchar(50),
@Initial Varchar(5),
@IdContinent Integer,
@PostalCodeMask Varchar(10),
@International Varchar(5)
)
As
begin
  Set NoCount On;

  Update Countries
  Set Country        = @Country,
      Initial        = @Initial,
      IdContinent    = @IdContinent,
	  PostalCodeMask = @PostalCodeMask,
	  International  = @International
  Where Id = @Id;
end;

Go

/*========================================================================*/

Create Procedure UpdStates
(
@Id Integer,
@State Varchar(50),
@Initial Varchar(3),
@IdCountry Integer
)
As
begin
  Set NoCount On;

  Update States
  Set State     = @State,
      Initial   = @Initial,
      IdCountry = @IdCountry
  Where Id = @Id;
end;

Go

/*========================================================================*/

Create Procedure UpdCities
(
@Id Integer,
@City Varchar(50),
@IdState Integer,
@Long Varchar(5)
)
As
begin
  Set NoCount On;

  Update Cities
  Set City    = @City,
      IdState = @IdState,
	  Long    = @Long
  Where Id = @Id;
end;

Go

/*========================================================================*/
