/*========================================================================*/

Use SampleXP;

Go

/*========================================================================*/

Create Procedure Map.FltNeighborhoods
(
@Name Varchar(50)
)
As
begin
  Set NoCount On;

  Select a.Id, a.Neighborhood
  From Map.Neighborhoods a
  Where a.Neighborhood Like '%' + @Name + '%'
  Order By a.Neighborhood;
end;

Go

/*========================================================================*/

Create Procedure Map.FltAddresses
(
@Name Varchar(50)
)
As
begin
  Set NoCount On;

  Select a.Id, a.Address
  From Map.Addresses a
  Where a.Address Like '%' + @Name + '%'
  Order By a.Address;
end;

Go

/*========================================================================*/

Create Procedure Map.FltDistricts
(
@Name Varchar(50)
)
As
begin
  Set NoCount On;

  Select a.Id, a.District
  From Map.Districts a
  Where a.District Like '%' + @Name + '%'
  Order By a.District;
end;

Go

/*========================================================================*/

Create Procedure Map.FltContinents
(
@Name Varchar(50)
)
As
begin
  Set NoCount On;

  Select a.Id, a.Continent
  From Map.Continents a
  Where a.Continent Like '%' + @Name + '%'
  Order By a.Continent;
end;

Go

/*========================================================================*/

Create Procedure Map.FltCountries
(
@Id Integer,
@Name Varchar(50)
)
As
begin
  Set NoCount On;

  Select a.Id, a.Country, a.Initial,
         a.IdContinent,
         b.Continent
  From Map.Countries a
  Join Map.Continents b On a.IdContinent = b.Id
  Where ((@Id Is Null) Or
         ((@Id Is Not Null) And
          (a.Id = @Id))) And
        a.Country Like '%' + @Name + '%'
  Order By a.Country;
end;

Go

/*========================================================================*/

Create Procedure Map.FltStates
(
@Id Integer,
@Name Varchar(50),
@IdCountry Integer
)
As
begin
  Set NoCount On;

  Select a.Id, a.State, a.Initial,
         a.IdCountry,
	 b.Country
  From Map.States a
  Join Map.Countries b On a.IdCountry = b.Id
  Where ((@Id Is Null) Or
         ((@Id Is Not Null) And
          (a.Id = @Id))) And
        a.State Like '%' + @Name + '%' And
        ((@IdCountry Is Null) Or
         ((@IdCountry Is Not Null) And
          (a.IdCountry = @IdCountry)))
  Order By a.State;
end;

Go

/*========================================================================*/

Create Procedure Map.FltCities
(
@Id Integer,
@Name Varchar(50)
)
As
begin
  Set NoCount On;

  Select a.Id, a.City, a.IdState,
         b.State, b.Initial StateInitial, b.IdCountry,
         c.Country, c.Initial CountryInitial, c.IdContinent,
	 d.Continent
  From Map.Cities a
  Join Map.States     b On a.IdState     = b.Id
  Join Map.Countries  c On b.IdCountry   = c.Id
  Join Map.Continents d On c.IdContinent = d.Id
  Where ((@Id Is Null) Or
         ((@Id Is Not Null) And
          (a.Id = @Id))) And
        a.City Like '%' + @Name + '%'
  Order By a.City;
end;

Go

/*========================================================================*/