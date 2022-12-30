/*========================================================================*/

Use SampleXP;

Go

/*========================================================================*/

Create Procedure Persons.UpdPersons
(
@Id Integer,
@Text Varchar(50)
)
As
begin
  Set NoCount On;

  Update Persons.Persons
  Set Person = @Text
  Where Id = @Id;
end;

Go

/*========================================================================*/

Create Procedure Persons.UpdPersonsAddresses
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

  Update Persons.PersonsAddresses
  Set PostalArea     = @PostalArea,
      IdNeighborhood = @IdNeighborhood,
	  IdAddress      = @IdAddress,
	  Number         = @Number,
	  IdDistrict     = @IdDistrict,
	  IdCity         = @IdCity,
      Complement     = @Complement
  Where IdPerson = @IdPerson
    And Position = @Position;
end;

Go

/*========================================================================*/