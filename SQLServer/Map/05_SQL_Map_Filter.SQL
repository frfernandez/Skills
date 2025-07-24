/*========================================================================*/

Use Map;

Go

/*========================================================================*/

Create Procedure FltContinents
(
@Id Integer,
@Name Varchar(50),
@Search Char(1)
)
As
begin
  Set NoCount On;

  Select a.Id, a.Continent
  From Continents a (NoLock)
  Where ((@Id Is Null) Or
         (a.Id = @Id))
    And ((@Name = '') Or
         (a.Continent Like
          (case @Search
           when 'N' then
             a.Continent
           when 'S' then
             @Name + '%'
           when 'E' then
             '%' + @Name
           when 'B' then
             '%' + @Name + '%'
           else
             a.Continent
           end)))
  Order By a.Continent;
end;

Go

/*========================================================================*/

Create Procedure FltCountries
(
@Id Integer,
@Name Varchar(50),
@Initial Varchar(5),
@IdContinent Integer,
@International Varchar(5),
@Search Char(1)
)
As
begin
  Set NoCount On;

  Select a.Id, a.Country, a.Initial,
         a.IdContinent, a.PostalCodeMask, a.International,
         b.Continent
  From Countries a (NoLock)
  Join Continents b (NoLock) On a.IdContinent = b.Id
  Where ((@Id Is Null) Or
         (a.Id = @Id))
    And ((@Name = '')  Or
         (a.Country Like
          (case @Search
           when 'N' then
             a.Country
           when 'S' then
             @Name + '%'
           when 'E' then
             '%' + @Name
           when 'B' then
             '%' + @Name + '%'
           else
             a.Country
           end)))
    And ((@Initial = '') Or
         (a.Initial = @Initial))
    And ((@IdContinent Is Null) Or
         (a.IdContinent = @IdContinent))
    And ((@International = '') Or
         (a.International = @International))
  Order By a.Country;
end;

Go

/*========================================================================*/

Create Procedure FltStates
(
@Id Integer,
@Name Varchar(50),
@Initial Varchar(3),
@IdCountry Integer,
@Search Char(1)
)
As
begin
  Set NoCount On;

  Select a.Id, a.State, a.Initial,
         a.IdCountry,
		 b.Country
  From States a (NoLock)
  Join Countries b (NoLock) On a.IdCountry = b.Id
  Where ((@Id Is Null) Or
         (a.Id = @Id))
    And ((@Name = '') Or
         (a.State Like
          (case @Search
           when 'N' then
             a.State
           when 'S' then
             @Name + '%'
           when 'E' then
             '%' + @Name
           when 'B' then
             '%' + @Name + '%'
           else
             a.State
           end)))
    And ((@Initial = '') Or
         (a.Initial = @Initial))
    And ((@IdCountry Is Null) Or
         (a.IdCountry = @IdCountry))
  Order By a.State;
end;

Go

/*========================================================================*/

Create Procedure FltCities
(
@Id Integer,
@Name Varchar(50),
@IdState Integer,
@IdCountry Integer,
@IdContinent Integer,
@Search Char(1)
)
As
begin
  Set NoCount On;

  Select a.Id, a.City, a.IdState, a.Long,
         b.State, b.Initial StateInitial, b.IdCountry,
         c.Country, c.Initial CountryInitial, c.IdContinent,
		 c.PostalCodeMask, c.International,
		 d.Continent
  From Cities a (NoLock)
  Join States     b (NoLock) On a.IdState     = b.Id
  Join Countries  c (NoLock) On b.IdCountry   = c.Id
  Join Continents d (NoLock) On c.IdContinent = d.Id
  Where ((@Id Is Null) Or
         (a.Id = @Id))
    And ((@Name = '') Or
         (a.City Like
          (case @Search
           when 'N' then
             a.City
           when 'S' then
             @Name + '%'
           when 'E' then
             '%' + @Name
           when 'B' then
             '%' + @Name + '%'
           else
             a.City
           end)))
    And ((@IdState Is Null) Or
         (a.IdState = @IdState))
    And ((@IdCountry Is Null) Or
         (b.IdCountry = @IdCountry))
    And ((@IdContinent Is Null) Or
         (c.IdContinent = @IdContinent))
  Order By a.City;
end;

Go

/*========================================================================*/
