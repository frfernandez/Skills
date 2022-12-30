/*========================================================================*/

Use SampleXP;

Go

/*========================================================================*/

Create Trigger Map.AInsNeighborhood On Map.Neighborhoods Instead Of Insert
As
Declare @Save Char(1) = 'N';
begin
  Set NoCount On;

  if ((Select LTrim(Neighborhood)
       From Inserted) <> '')
  begin
    if (Exists(Select *
               From Map.Neighborhoods
               Where Neighborhood = (Select LTrim(Neighborhood)
                                     From Inserted)))
      RaisError('The neighborhoods has been inserted !', 10, 1);
    else
      Set @Save = 'Y';
  end
  else
    RaisError('The neighborhoods must be informed !', 10, 1);

  if (@Save = 'Y')
  begin
    Insert Into Map.Neighborhoods
    (Neighborhood)
    Select LTrim(Neighborhood)
    From Inserted;
  end
end;

Go

/*========================================================================*/

Create Trigger Map.AInsAddress On Map.Addresses Instead Of Insert
As
Declare @Save Char(1) = 'N';
begin
  Set NoCount On;

  if ((Select LTrim(Address)
       From Inserted) <> '')
  begin
    if (Exists(Select *
               From Map.Addresses
               Where Address = (Select LTrim(Address)
                                From Inserted)))
      RaisError('The address has been inserted !', 10, 1);
    else
      Set @Save = 'Y';
  end
  else
    RaisError('The address must be inserted !', 10, 1);

  if (@Save = 'Y')
  begin
    Insert Into Map.Addresses
    (Address)
    Select LTrim(Address)
    From Inserted;
  end
end;

Go

/*========================================================================*/

Create Trigger Map.AInsDistrict On Map.Districts Instead Of Insert
As
Declare @Save Char(1) = 'N';
begin
  Set NoCount On;

  if ((Select LTrim(District)
       From Inserted) <> '')
  begin
    if (Exists(Select *
               From Map.Districts
               Where District = (Select LTrim(District)
                                 From Inserted)))
      RaisError('The district has been inserted !', 10, 1);
    else
      Set @Save = 'Y';
  end
  else
    RaisError('The district must be inserted !', 10, 1);

  if (@Save = 'Y')
  begin
    Insert Into Map.Districts
    (District)
    Select LTrim(District)
    From Inserted;
  end
end;

Go

/*========================================================================*/

Create Trigger Map.AInsContinent On Map.Continents Instead Of Insert
As
Declare @Save Char(1) = 'N';
begin
  Set NoCount On;

  if ((Select LTrim(Continent)
       From Inserted) <> '')
  begin
    if (Exists(Select *
               From Map.Continents
               Where Continent = (Select LTrim(Continent)
                                  From Inserted)))
      RaisError('The continent has been inserted !', 10, 1);
    else
      Set @Save = 'Y';
  end
  else
    RaisError('The continent must be inserted !', 10, 1);

  if (@Save = 'Y')
  begin
    Insert Into Map.Continents
    (Continent)
    Select LTrim(Continent)
    From Inserted;
  end
end;

Go

/*========================================================================*/

Create Trigger Map.AInsCountry On Map.Countries Instead Of Insert
As
Declare @Save Char(1) = 'N',
        @Country Varchar(50),
        @Initial Varchar(3),
        @IdContinent Integer;
begin
  Set NoCount On;

  Select @Country     = LTrim(Country),
         @Initial     = LTrim(Initial),
         @IdContinent = IdContinent
  From Inserted;

  if (@Country <> '') And
     (@Initial <> '') And
	 (@IdContinent Is Not Null)
  begin
    if (Exists(Select *
               From Map.Countries
               Where Country     = @Country
                 And Initial     = @Initial
                 And IdContinent = @IdContinent))
      RaisError('The combination of country, initial, and continent has been inserted !', 10, 1);
    else
      Set @Save = 'Y';
  end
  else
    RaisError('The combination of country, initial, and continent must be informed !', 10, 1);

  if (@Save = 'Y')
  begin
    Insert Into Map.Countries
    (Country, Initial, IdContinent)
    Select LTrim(Country), LTrim(Initial), IdContinent
    From Inserted;
  end
end;

Go

/*========================================================================*/

Create Trigger Map.AInsState On Map.States Instead Of Insert
As
Declare @Save Char(1) = 'N',
        @State Varchar(50),
        @Initial Varchar(3),
        @IdCountry Integer;
begin
  Set NoCount On;

  Select @State     = LTrim(State),
         @Initial   = LTrim(Initial),
         @IdCountry = IdCountry
  From Inserted;

  if (@State <> '') And
     (@Initial <> '') And
     (@IdCountry Is Not Null)
  begin
    if (Exists(Select *
               From Map.States
               Where State     = @State
                 And Initial   = @Initial
                 And IdCountry = @IdCountry))
      RaisError('The combination of state, initial, and country has been inserted !', 10, 1);
    else
      Set @Save = 'Y';
  end
  else
    RaisError('The combination of state, initial, and country must be informed !', 10, 1);

  if (@Save = 'Y')
  begin
    Insert Into Map.States
    (State, Initial, IdCountry)
    Select LTrim(State), LTrim(Initial), IdCountry
    From Inserted;
  end
end;

Go

/*========================================================================*/

Create Trigger Map.AInsCity On Map.Cities Instead Of Insert
As
Declare @Save Char(1) = 'N',
        @City Varchar(50),
        @IdState Integer;
begin
  Set NoCount On;

  Select @City    = LTrim(City),
         @IdState = IdState
  From Inserted;

  if ((@City <> '') And (@IdState Is Not Null))
  begin
    if (Exists(Select *
               From Map.Cities
               Where City    = @City
                 And IdState = @IdState))
      RaisError('The combination of city, and state has been inserted !', 10, 1);
    else
      Set @Save = 'Y';
  end
  else
    RaisError('The combination of city, and state must be informed !', 10, 1);

  if (@Save = 'Y')
  begin
    Insert Into Map.Cities
    (City, IdState)
    Select LTrim(City), IdState
    From Inserted;
  end
end;

Go

/*========================================================================*/