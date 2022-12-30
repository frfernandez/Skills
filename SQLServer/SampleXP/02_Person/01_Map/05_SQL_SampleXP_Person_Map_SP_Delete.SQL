/*========================================================================*/

Use SampleXP;

Go

/*========================================================================*/

Create Procedure Map.DelNeighborhoods
(
@Id Integer
)
As
begin
  Set NoCount On;

  Delete From Map.Neighborhoods
  Where Id = @Id;
end;

Go

/*========================================================================*/

Create Procedure Map.DelAddresses
(
@Id Integer
)
As
begin
  Set NoCount On;

  Delete From Map.Addresses
  Where Id = @Id;
end;

Go

/*========================================================================*/

Create Procedure Map.DelDistricts
(
@Id Integer
)
As
begin
  Set NoCount On;

  Delete From Map.Districts
  Where Id = @Id;
end;

Go

/*========================================================================*/

Create Procedure Map.DelContinents
(
@Id Integer
)
As
begin
  Set NoCount On;

  Delete From Map.Continents
  Where Id = @Id;
end;

Go

/*========================================================================*/

Create Procedure Map.DelCountries
(
@Id Integer
)
As
begin
  Set NoCount On;

  Delete From Map.Countries
  Where Id = @Id;
end;

Go

/*========================================================================*/

Create Procedure Map.DelStates
(
@Id Integer
)
As
begin
  Set NoCount On;

  Delete From Map.States
  Where Id = @Id;
end;

Go

/*========================================================================*/

Create Procedure Map.DelCities
(
@Id Integer
)
As
begin
  Set NoCount On;

  Delete From Map.Cities
  Where Id = @Id;
end;

Go

/*========================================================================*/