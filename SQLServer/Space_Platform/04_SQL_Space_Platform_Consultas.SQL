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

Create View Map.TravelsUnblocked
As
  Select a.Id, a.IdPlanetOrigin, a.IdPlanetDestination, a.FuelCost, a.Blocked,
         b.Planet PlanetOrigin,
	     c.Planet PlanetDestination
  From Map.Travels a
  Join Map.Planets b On a.IdPlanetOrigin      = b.Id
  Join Map.Planets c On a.IdPlanetDestination = c.Id
  Where Blocked = 'N';

Go

/*========================================================================*/
