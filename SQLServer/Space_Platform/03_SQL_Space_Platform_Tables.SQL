/*==========================================================================

Space_Platform.MDF
Space_Platform.NDF
Space_Platform.LDF
	System: Space_Platform
	Developer: Fernando Roberto Fernández

==========================================================================*/

Use Space_Platform;

Go

/*========================================================================*/

Create Table Map.Planets
(
Id Integer Identity(1, 1) Not Null Check(Id > 0),
Planet Varchar(50) Not Null Check(Planet = Upper(Planet)),
Primary Key (Id)
) On Space_Platform_FG_Map;

Go

/*========================================================================*/

Create Table Map.Travels
(
Id Integer Identity(1, 1) Not Null Check(Id > 0),
IdPlanetOrigin Integer Not Null Check(IdPlanetOrigin > 0),
IdPlanetDestination Integer Not Null Check(IdPlanetDestination > 0),
FuelCost Decimal(12, 2) Default 0 Not Null Check(FuelCost >= 0),
Blocked As (case
            when FuelCost = 0 then
			  'Y'
			else
			  'N'
			end),
Primary Key (Id),
Foreign Key (IdPlanetOrigin) References Map.Planets (Id),
Foreign Key (IdPlanetDestination) References Map.Planets (Id)
) On Space_Platform_FG_Map;

Go

/*========================================================================*/

Create Table Contracts.Pilots
(
Id Integer Identity(1, 1) Not Null Check(Id > 0),
Name Varchar(50) Not Null Check(Name = Upper(Name)),
Age Integer Not Null Check(Age > 18),
Credits Decimal(12, 2) Default 0 Not Null Check(Credits >= 0),
Primary Key (Id)
) On Space_Platform_FG_Contracts;

Go

/*========================================================================*/

Create Table Contracts.Ships
(
Id Integer Identity(1, 1) Not Null Check(Id > 0),
Name Varchar(50) Not Null Check(Name = Upper(Name)),
FuelCapacity Decimal(12, 3) Default 0 Not Null Check(FuelCapacity >= 0),
FuelLevel Decimal(12, 3) Default 0 Not Null Check(FuelLevel >= 0),
WeightCapacity Decimal(12, 3) Default 0 Not Null Check(WeightCapacity >= 0),
Primary Key (Id)
) On Space_Platform_FG_Contracts;

Go

/*========================================================================*/

Create Table Contracts.Contracts
(
Id Integer Identity(1, 1) Not Null Check(Id > 0),
Description Varchar(50) Not Null Check(Description = Upper(Description)),
IdTravels Integer Not Null Check(IdTravels > 0),
Value Decimal(12, 2) Default 0 Not Null Check(value >= 0),
Primary Key (Id),
Foreign Key (IdTravels) References Map.Travels (Id),
) On Space_Platform_FG_Contracts;

Go

/*========================================================================*/

Create Table Contracts.Resources
(
IdContract Integer Not Null Check(IdContract > 0),
Name Varchar(50) Not Null Check(Name = Upper(Name)),
Weight Decimal(12, 3) Default 0 Not Null Check(Weight >= 0),
Primary Key (IdContract),
Foreign Key (IdContract) References Contracts.Contracts (Id)
) On Space_Platform_FG_Contracts;

Go

/*========================================================================*/

Create Table Contracts.ContractsShips
(
IdContract Integer Not Null Check(IdContract > 0),
IdPilot Integer Not Null Check(IdPilot > 0),
IdShip Integer Not Null Check(IdShip > 0),
Primary Key (IdContract),
Foreign Key (IdContract) References Contracts.Contracts (Id),
Foreign Key (IdPilot) References Contracts.Pilots (Id),
Foreign Key (IdShip) References Contracts.Ships (Id)
) On Space_Platform_FG_Contracts;

Go

/*========================================================================*/
