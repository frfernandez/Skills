/*========================================================================*/

Use Map;

Go

/*========================================================================*/

Create Trigger IUpdContinent On Continents Instead Of Update
As
Declare @Save Char(1) = 'N',
        @Id Integer,
        @Continent Varchar(50),
        @Message Varchar(255);
begin
  Set NoCount On;

  Select @Id        = Id,
         @Continent = LTrim(Continent)
  From Inserted;

  if (@Continent <> '')
  begin
    if (Exists(Select Top 1 1
               From Continents (NoLock)
               Where Id        <> @Id
                 And Continent  = @Continent))
      Set @Message = 'The continent has been inserted.';
    else
      Set @Save = 'Y';
  end
  else
    Set @Message = 'The continent must be informed.';

  if (@Save = 'Y')
  begin
    Update a
    Set a.Continent = LTrim(b.Continent)
    From Continents a (NoLock)
    Join Inserted b On a.Id = b.Id;
  end
  else
  begin
    RaisError(@Message, 10, 1);
    Return;
  end
end;

Go

/*========================================================================*/

Create Trigger IUpdCountry On Countries Instead Of Update
As
Declare @Save Char(1) = 'N',
        @Id Integer,
        @Country Varchar(50),
        @Initial Varchar(3),
        @IdContinent Integer,
		@International Varchar(5),
        @Message Varchar(255);
begin
  Set NoCount On;

  Select @Id             = Id,
         @Country        = LTrim(Country),
         @Initial        = LTrim(Initial),
         @IdContinent    = IdContinent,
		 @International  = LTrim(International)
  From Inserted;

  if (@Country <> '') And
     (@Initial <> '') And
	 (@IdContinent Is Not Null)
  begin
    if (Exists(Select Top 1 1
               From Countries (NoLock)
               Where Id      <> @Id
			     And Initial  = @Initial
                 And Country  = @Country))
      Set @Message = 'The combination of country, initial, and continent has been inserted.';
    else
      Set @Save = 'Y';
  end
  else
  begin
    if (@International = '')
      Set @Message = 'The internacional distance dialing must be informed.';
	else
      Set @Message = 'The combination of country, initial, and continent must be informed.';
  end

  if (@Save = 'Y')
  begin
    Update a
    Set a.Country        = LTrim(b.Country),
        a.Initial        = LTrim(b.Initial),
        a.IdContinent    = b.IdContinent,
		a.PostalCodeMask = LTrim(b.PostalCodeMask),
		a.International  = b.International
    From Countries a (NoLock)
    Join Inserted b On a.Id = b.Id;
  end
  else
  begin
    RaisError(@Message, 10, 1);
    Return;
  end
end;

Go

/*========================================================================*/

Create Trigger IUpdState On States Instead Of Update
As
Declare @Save Char(1) = 'N',
        @Id Integer,
        @State Varchar(50),
        @Initial Varchar(3),
        @IdCountry Integer,
        @Message Varchar(255);
begin
  Set NoCount On;

  Select @Id        = Id,
         @State     = LTrim(State),
         @Initial   = LTrim(Initial),
         @IdCountry = IdCountry
  From Inserted;

  if (@State <> '') And
     (@Initial <> '') And 
     (@IdCountry Is Not Null)
  begin
    if (Exists(Select Top 1 1
               From States (NoLock)
               Where Id        <> @Id
			     And State      = @State
                 And Initial    = @Initial
                 And IdCountry  = @IdCountry))
      Set @Message = 'The combination of state, initial, and country has been inserted.';
    else
      Set @Save = 'Y';
  end
  else
    Set @Message = 'The combination of state, initial, and country must be informed.';

  if (@Save = 'Y')
  begin
    Update a
    Set a.State     = LTrim(b.State),
        a.Initial   = LTrim(b.Initial),
        a.IdCountry = b.IdCountry
    From States a (NoLock)
    Join Inserted b On a.Id = b.Id;
  end
  else
  begin
    RaisError(@Message, 10, 1);
    Return;
  end
end;

Go

/*========================================================================*/

Create Trigger IUpdCity On Cities Instead Of Update
As
Declare @Save Char(1) = 'N',
        @Id Integer,
        @City Varchar(50),
        @IdState Integer,
		@Long Varchar(5),
        @Message Varchar(255);
begin
  Set NoCount On;

  Select @Id      = Id,
         @City    = LTrim(City),
         @IdState = IdState,
		 @Long    = LTrim(Long)
  From Inserted;

  if ((@City <> '') And (@IdState <> '') And (@Long <> ''))
  begin
    if (Exists(Select Top 1 1
               From Cities (NoLock)
               Where Id      <> @Id
			     And City     = @City
                 And IdState  = @IdState))
      Set @Message = 'The combination of city, and state has been inserted.';
    else
      Set @Save = 'Y';
  end
  else
  begin
    if (@Long = '')
      Set @Message = 'The long distance dialing must be informed.';
	else
      Set @Message = 'The combination of city, and state must be informed.';
  end

  if (@Save = 'Y')
  begin
    Update a
    Set a.City    = LTrim(b.City),
        a.IdState = b.IdState,
		a.Long    = b.Long
    From Cities a (NoLock)
    Join Inserted b On a.Id = b.Id;
  end
  else
  begin
    RaisError(@Message, 10, 1);
    Return;
  end
end;

Go

/*========================================================================*/
