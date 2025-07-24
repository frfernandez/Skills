/*========================================================================*/

Use Map;

Go

/*========================================================================*/

Create Table Continents
(
Id Integer Identity(1, 1) Not Null,
Continent Varchar(50) Not Null,
Constraint PK_Continents Primary Key (Id),
Constraint CK_Continents_Continent_Upper Check(Continent = Upper(Continent))
);

Go

Create Nonclustered Index Ix_Continents_Continent On 
Continents (Continent);

Go

/*========================================================================*/

Create Table Countries
(
Id Integer Identity(1, 1) Not Null,
Country Varchar(50) Not Null,
Initial Varchar(5) Not Null,
IdContinent Integer Not Null,
PostalCodeMask Varchar(10),
International Varchar(5) Not Null,
Constraint PK_Countries Primary Key (Id),
Constraint FK_Countries_Continents Foreign Key (IdContinent) References Continents (Id),
Constraint CK_Countries_Country_Upper Check(Country = Upper(Country)),
Constraint CK_Countries_Initial_Upper Check(Initial = Upper(Initial)),
Constraint CK_Countries_International_Upper Check(International = Upper(International))
);

Go

Create Nonclustered Index Ix_Countries_Country On 
Countries (Country);

Go

/*========================================================================*/

Create Table States
(
Id Integer Identity(1, 1) Not Null,
State Varchar(50) Not Null,
Initial Varchar(3) Not Null,
IdCountry Integer Not Null,
Constraint PK_States Primary Key (Id),
Constraint FK_States_Countries Foreign Key (IdCountry) References Countries (Id),
Constraint CK_States_State_Upper Check(State = Upper(State)),
Constraint CK_States_Initial_Upper Check(Initial = Upper(Initial))
);

Go

Create Nonclustered Index Ix_States_State On 
States (State);

Go

/*========================================================================*/

Create Table Cities
(
Id Integer Identity(1, 1) Not Null,
City Varchar(50) Not Null,
IdState Integer Not Null,
Long Varchar(5),
Constraint PK_Cities Primary Key (Id),
Constraint FK_Cities_States Foreign Key (IdState) References States (Id),
Constraint CK_Cities_City_Upper Check(City = Upper(City)),
Constraint CK_Cities_Long_Upper Check(Long = Upper(Long))
);

Go

Create Nonclustered Index Ix_Cities_City On 
Cities (City);

Go

/*========================================================================*/
