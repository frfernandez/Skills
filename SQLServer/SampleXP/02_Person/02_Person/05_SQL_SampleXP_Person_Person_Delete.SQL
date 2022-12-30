/*========================================================================*/

Use SampleXP;

Go

/*========================================================================*/

Create Procedure Persons.DelPersons
(
@Id Integer
)
As
begin
  Set NoCount On;

  Delete From Persons.Persons
  Where Id = @Id;
end;

Go

/*========================================================================*/

Create Procedure Persons.DelPersonsAddresses
(
@IdPerson Integer,
@Position Integer
)
As
begin
  Set NoCount On;

  Delete From Persons.PersonsAddresses
  Where IdPerson  = @IdPerson
    And Position >= @Position;
end;

Go

/*========================================================================*/