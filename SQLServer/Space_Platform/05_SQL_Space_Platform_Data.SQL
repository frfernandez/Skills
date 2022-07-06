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

Insert Into Map.Planets
(Planet)
Values ('ANDVARI')

Insert Into Map.Planets
(Planet)
Values ('DEMETER')

Insert Into Map.Planets
(Planet)
Values ('AQUA')

Insert Into Map.Planets
(Planet)
Values ('CALAS')

/*========================================================================*/

Insert Into Map.Travels
(IdPlanetOrigin, IdPlanetDestination, FuelCost)
Values (1, 2, 0)

Insert Into Map.Travels
(IdPlanetOrigin, IdPlanetDestination, FuelCost)
Values (1, 3, 13)

Insert Into Map.Travels
(IdPlanetOrigin, IdPlanetDestination, FuelCost)
Values (1, 4, 23)

Insert Into Map.Travels
(IdPlanetOrigin, IdPlanetDestination, FuelCost)
Values (2, 1, 0)

Insert Into Map.Travels
(IdPlanetOrigin, IdPlanetDestination, FuelCost)
Values (2, 3, 22)

Insert Into Map.Travels
(IdPlanetOrigin, IdPlanetDestination, FuelCost)
Values (2, 4, 25)

Insert Into Map.Travels
(IdPlanetOrigin, IdPlanetDestination, FuelCost)
Values (3, 1, 0)

Insert Into Map.Travels
(IdPlanetOrigin, IdPlanetDestination, FuelCost)
Values (3, 2, 30)

Insert Into Map.Travels
(IdPlanetOrigin, IdPlanetDestination, FuelCost)
Values (3, 4, 12)

Insert Into Map.Travels
(IdPlanetOrigin, IdPlanetDestination, FuelCost)
Values (4, 1, 20)

Insert Into Map.Travels
(IdPlanetOrigin, IdPlanetDestination, FuelCost)
Values (4, 2, 25)

Insert Into Map.Travels
(IdPlanetOrigin, IdPlanetDestination, FuelCost)
Values (4, 3, 15)

/*========================================================================*/
