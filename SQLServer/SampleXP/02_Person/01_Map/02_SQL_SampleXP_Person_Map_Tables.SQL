/*========================================================================*/

Use SampleXP;

Go

/*========================================================================*/

Create Table Map.Neighborhoods
(
Id Integer Identity(1, 1) Not Null,
Neighborhood Varchar(50) Not Null,
Constraint PK_Neighborhoods Primary Key (Id),
Constraint CK_Neighborhoods_Neighborhood_Upper Check(Neighborhood = Upper(Neighborhood))
) On SampleXP_FG_Map;

Go

/*========================================================================*/

Create Table Map.Addresses
(
Id Integer Identity(1, 1) Not Null,
Address Varchar(50) Not Null,
Constraint PK_Addresses Primary Key (Id),
Constraint CK_Addresses_Address_Upper Check(Address = Upper(Address))
) On SampleXP_FG_Map;

Go

/*========================================================================*/

Create Table Map.Districts
(
Id Integer Identity(1, 1) Not Null,
District Varchar(50) Not Null,
Constraint PK_Districts Primary Key (Id),
Constraint CK_Districts_District_Upper Check(District = Upper(District))
) On SampleXP_FG_Map;

Go

/*========================================================================*/

Create Table Map.Continents
(
Id Integer Identity(1, 1) Not Null,
Continent Varchar(50) Not Null,
Constraint PK_Continents Primary Key (Id),
Constraint CK_Continents_Continent_Upper Check(Continent = Upper(Continent))
) On SampleXP_FG_Map;

Go

/*========================================================================*/

Create Table Map.Countries
(
Id Integer Identity(1, 1) Not Null,
Country Varchar(50) Not Null,
Initial Varchar(5) Not Null,
IdContinent Integer Not Null,
Constraint PK_Countries Primary Key (Id),
Constraint FK_Countries_Continents Foreign Key (IdContinent) References Map.Continents (Id),
Constraint CK_Countries_Country_Upper Check(Country = Upper(Country)),
Constraint CK_Countries_Initial_Upper Check(Initial = Upper(Initial))
) On SampleXP_FG_Map;

Go

/*========================================================================*/

Create Table Map.States
(
Id Integer Identity(1, 1) Not Null,
State Varchar(50) Not Null,
Initial Varchar(3) Not Null,
IdCountry Integer Not Null,
Constraint PK_States Primary Key (Id),
Constraint FK_States_Countries Foreign Key (IdCountry) References Map.Countries (Id),
Constraint CK_States_State_Upper Check(State = Upper(State)),
Constraint CK_States_Initial_Upper Check(Initial = Upper(Initial))
) On SampleXP_FG_Map;

Go

/*========================================================================*/

Create Table Map.Cities
(
Id Integer Identity(1, 1) Not Null,
City Varchar(50) Not Null,
IdState Integer Not Null,
Constraint PK_Cities Primary Key (Id),
Constraint FK_Cities_States Foreign Key (IdState) References Map.States (Id),
Constraint CK_Cities_City_Upper Check(City = Upper(City))
) On SampleXP_FG_Map;

Go

/*========================================================================*/