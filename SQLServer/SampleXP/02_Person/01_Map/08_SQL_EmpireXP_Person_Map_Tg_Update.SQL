/*========================================================================*/

Use SampleXP;

Go

/*========================================================================*/

Create Trigger Map.AUpdNeighborhoodAddress On Map.Neighborhoods Instead Of Update
As
Declare @Save Char(1) = 'N';
begin
  Set NoCount On;

  if ((Select LTrim(Neighborhood)
       From Inserted) <> '')
  begin
    if Update(Neighborhood)
    begin
      if (Exists(Select *
                 From Map.Neighborhoods
                 Where Neighborhood = (Select LTrim(Neighborhood)
                                       From Inserted)))
        RaisError('The neighborhoods has been inserted !', 10, 1);
      else
        Set @Save = 'Y';
    end
  end
  else
    RaisError('The neighborhoods must be informed !', 10, 1);

  if (@Save = 'Y')
  begin
    Update a
    Set a.Neighborhood = LTrim(b.Neighborhood)
    From Map.Neighborhoods a
    Join Inserted b On a.Id = b.Id;
  end
end;

Go

/*========================================================================*/

Create Trigger Map.AUpdAddress On Map.Addresses Instead Of Update
As
Declare @Save Char(1) = 'N';
begin
  Set NoCount On;

  if ((Select LTrim(Address)
       From Inserted) <> '')
  begin
    if Update(Address)
    begin
      if (Exists(Select *
                 From Map.Addresses
                 Where Address = (Select LTrim(Address)
                                  From Inserted)))
        RaisError('The address has been inserted !', 10, 1);
      else
        Set @Save = 'Y';
    end
  end
  else
    RaisError('The address must be inserted !', 10, 1);

  if (@Save = 'Y')
  begin
    Update a
    Set a.Address = LTrim(b.Address)
    From Map.Addresses a
    Join Inserted b On a.Id = b.Id;
  end
end;

Go

/*========================================================================*/

Create Trigger Map.AUpdDistrict On Map.Districts Instead Of Update
As
Declare @Save Char(1) = 'N';
begin
  Set NoCount On;

  if ((Select LTrim(District)
       From Inserted) <> '')
  begin
    if Update(District)
    begin
      if (Exists(Select *
                 From Map.Districts
                 Where District = (Select LTrim(District)
                                   From Inserted)))
        RaisError('The district has been inserted !', 10, 1);
      else
        Set @Save = 'Y';
    end
  end
  else
    RaisError('The district must be inserted !', 10, 1);

  if (@Save = 'Y')
  begin
    Update a
    Set a.District = LTrim(b.District)
    From Map.Districts a
    Join Inserted b On a.Id = b.Id;
  end
end;

Go

/*========================================================================*/

Create Trigger Map.AUpdContinent On Map.Continents Instead Of Update
As
Declare @Save Char(1) = 'N';
begin
  Set NoCount On;

  if ((Select LTrim(Continent)
       From Inserted) <> '')
  begin
    if Update(Continent)
    begin
      if (Exists(Select *
                 From Map.Continents
                 Where Continent = (Select LTrim(Continent)
                                    From Inserted)))
        RaisError('The continent has been inserted !', 10, 1);
      else
        Set @Save = 'Y';
    end
  end
  else
    RaisError('The continent must be inserted !', 10, 1);

  if (@Save = 'Y')
  begin
    Update a
    Set a.Continent = LTrim(b.Continent)
    From Map.Continents a
    Join Inserted b On a.Id = b.Id;
  end
end;

Go

/*========================================================================*/

Create Trigger Map.AUpdCountry On Map.Countries Instead Of Update
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
    if Update(Country) or Update(Initial) or
       Update(IdContinent)
    begin
      if (Exists(Select *
                 From Map.Countries
                 Where Country        = @Country
                   And Initial        = @Initial
                   And IdContinent    = @IdContinent))
        RaisError('The combination of country, initial, and continent has been inserted !', 10, 1);
      else
        Set @Save = 'Y';
    end
  end
  else
    RaisError('The combination of country, initial, and continent must be informed !', 10, 1);

  if (@Save = 'Y')
  begin
    Update a
    Set a.Country     = LTrim(b.Country),
        a.Initial     = LTrim(b.Initial),
        a.IdContinent = b.IdContinent
    From Map.Countries a
    Join Inserted b On a.Id = b.Id;
  end
end;

Go

/*========================================================================*/

Create Trigger Map.AUpdState On Map.States Instead Of Update
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
    if Update(State)
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
  end
  else
    RaisError('The combination of state, initial, and country must be informed !', 10, 1);

  if (@Save = 'Y')
  begin
    Update a
    Set a.State     = LTrim(b.State),
        a.Initial   = LTrim(b.Initial),
        a.IdCountry = b.IdCountry
    From Map.States a
    Join Inserted b On a.Id = b.Id;
  end
end;

Go

/*========================================================================*/

Create Trigger Map.AUpdCity On Map.Cities Instead Of Update
As
Declare @Save Char(1) = 'N',
        @City Varchar(50),
        @IdState Integer;
begin
  Set NoCount On;

  Select @City    = LTrim(City),
         @IdState = LTrim(IdState)
  From Inserted;

  if ((@City <> '') And (@IdState <> ''))
  begin
    if Update(City)
    begin
      if (Exists(Select *
                 From Map.Cities
                 Where City    = @City
                   And IdState = @IdState))
        RaisError('The combination of city, and state has been inserted !', 10, 1);
      else
        Set @Save = 'Y';
    end
  end
  else
    RaisError('The combination of city, and state must be informed !', 10, 1);

  if (@Save = 'Y')
  begin
    Update a
    Set a.City    = b.City,
        a.IdState = b.IdState
    From Map.Cities a
    Join Inserted b On a.Id = b.Id;
  end
end;

Go

/*========================================================================*/