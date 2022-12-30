/*========================================================================*/

Use SampleXP;

Go

/*========================================================================*/

Create Procedure Persons.FltPersons
(
@Name Varchar(50)
)
As
begin
  Set NoCount On;

  Select a.Id, a.Person
  From Persons.Persons a
  Where a.Person Like '%' + @Name + '%'
  Order By a.Person;
end;

Go

/*========================================================================*/

Create Procedure Persons.PKePersonsAddresses
(
@IdPerson Integer
)
As
begin
  Set NoCount On;

  Select a.IdPerson, a.Position, a.PostalArea,
         a.IdNeighborhood, a.IdAddress, a.Number,
         a.IdDistrict, a.IdCity, a.Complement,
         b.Person,
         c.Neighborhood,
         d.Address,
         e.District,
         f.City, f.IdState,
         g.State, g.Initial StateInitial, g.IdCountry,
         h.Country, h.Initial CountryInitial, h.IdContinent,
         i.Continent
  From Persons.PersonsAddresses a
  Join Persons.Persons   b On a.IdPerson       = b.Id
  Join Map.Neighborhoods c On a.IdNeighborhood = c.Id
  Join Map.Addresses     d On a.IdAddress      = d.Id
  Join Map.Districts     e On a.IdDistrict     = e.Id
  Join Map.Cities        f On a.IdCity         = f.Id
  Join Map.States        g On f.IdState        = g.Id
  Join Map.Countries     h On g.IdCountry      = h.Id
  Join Map.Continents    i On h.IdContinent    = i.Id
  Where a.IdPerson = @IdPerson;
end;

Go

/*========================================================================*/