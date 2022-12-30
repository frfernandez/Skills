/*========================================================================*/

Use SampleXP;

Go

/*========================================================================*/

Create Procedure Persons.InsPersons
(
@Text Varchar(50)
)
As
begin
  Set NoCount On;

  Insert Into Persons.Persons
  (Person)
  Values (@Text);
end;

Go

/*========================================================================*/

Create Procedure Persons.InsPersonsAddresses
(
@IdPerson Integer,
@Position Integer,
@PostalArea Varchar(10),
@IdNeighborhood Integer,
@IdAddress Integer,
@Number Integer,
@IdDistrict Integer,
@IdCity Integer,
@Complement Varchar(50)
)
As
begin
  Set NoCount On;

  Insert Into Persons.PersonsAddresses
  (IdPerson, Position, PostalArea, IdNeighborhood, IdAddress,
   Number, IdDistrict, IdCity, Complement)
  Values (@IdPerson, @Position, @PostalArea, @IdNeighborhood, @IdAddress,
          @Number, @IdDistrict, @IdCity, @Complement);
end;

Go

/*========================================================================*/