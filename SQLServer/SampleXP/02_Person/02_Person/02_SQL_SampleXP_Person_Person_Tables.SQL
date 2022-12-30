/*========================================================================*/

Use SampleXP;

Go

/*========================================================================*/

Create Table Persons.Persons
(
Id Integer Identity(1, 1) Not Null,
Person Varchar(50) Not Null,
Constraint PK_Persons Primary Key (Id),
Constraint CK_Persons_Person_Upper Check(Person = Upper(Person))
) On SampleXP_FG_Persons;

Go

/*========================================================================*/

Create Table Persons.PersonsAddresses
(
IdPerson Integer Not Null,
Position Integer Not Null,
PostalArea Varchar(10),
IdNeighborhood Integer Not Null,
IdAddress Integer Not Null,
Number Integer,
IdDistrict Integer Not Null,
IdCity Integer Not Null,
Complement Varchar(50) Not Null Check(Complement = Upper(Complement)),
Constraint PK_PersonsDetails Primary Key (IdPerson, Position),
Constraint FK_PersonsDetails_Persons Foreign Key (IdPerson) References Persons.Persons (Id)
On Delete Cascade,
Constraint FK_PersonsAddresses_Neighborhoods Foreign Key (IdNeighborhood) References Map.Neighborhoods (Id),
Constraint FK_PersonsAddresses_Addresses Foreign Key (IdAddress) References Map.Addresses (Id),
Constraint FK_PersonsAddresses_Districts Foreign Key (IdDistrict) References Map.Districts (Id),
Constraint FK_PersonsAddresses_Cities Foreign Key (IdCity) References Map.Cities (Id),
Constraint CK_PersonsAddresses_Position_MoreThanZero Check(Position > 0),
Constraint CK_PersonsAddresses_Complement_Upper Check(Complement = Upper(Complement))
) On SampleXP_FG_Persons;

Go

/*========================================================================*/