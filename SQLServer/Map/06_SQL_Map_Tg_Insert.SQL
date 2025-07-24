/*========================================================================*/

Use Map;

Go

/*========================================================================*/

Create Trigger IInsContinent On Continents Instead Of Insert
As
Declare @Save Char(1) = 'N',
        @Message Varchar(255);
begin
  Set NoCount On;

  if ((Select LTrim(Continent)
       From Inserted) <> '')
  begin
    if (Exists(Select Top 1 1
               From Continents (NoLock)
               Where Continent = (Select LTrim(Continent)
                                  From Inserted)))
      Set @Message = 'The continent has been inserted.';
    else
      Set @Save = 'Y';
  end
  else
    Set @Message = 'The continent must be informed.';

  if (@Save = 'Y')
  begin
    Insert Into Continents
    (Continent)
    Select LTrim(Continent)
    From Inserted;
  end
  else
  begin
    RaisError(@Message, 10, 1);
    Return;
  end
end;

Go

/*========================================================================*/

Create Trigger IInsCountry On Countries Instead Of Insert
As
Declare @Save Char(1) = 'N',
        @Country Varchar(50),
        @Initial Varchar(3),
        @IdContinent Integer,
		@International Varchar(5),
        @Message Varchar(255);
begin
  Set NoCount On;

  Select @Country       = LTrim(Country),
         @Initial       = LTrim(Initial),
         @IdContinent   = IdContinent,
		 @International = LTrim(International)
  From Inserted;

  if (@Country <> '') And
     (@Initial <> '') And
	 (@IdContinent Is Not Null) And
     (@International <> '')
  begin
    if (Exists(Select Top 1 1
               From Countries (NoLock)
               Where Country     = @Country
                 And Initial     = @Initial
                 And IdContinent = @IdContinent))
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
    Insert Into Countries
    (Country, Initial, IdContinent, PostalCodeMask, International)
    Select LTrim(Country), LTrim(Initial), IdContinent, PostalCodeMask, International
    From Inserted;
  end
  else
  begin
    RaisError(@Message, 10, 1);
    Return;
  end
end;

Go

/*========================================================================*/

Create Trigger IInsState On States Instead Of Insert
As
Declare @Save Char(1) = 'N',
        @State Varchar(50),
        @Initial Varchar(3),
        @IdCountry Integer,
        @Message Varchar(255);
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
    if (Exists(Select Top 1 1
               From States (NoLock)
               Where State     = @State
                 And Initial   = @Initial
                 And IdCountry = @IdCountry))
      Set @Message = 'The combination of state, initial, and country has been inserted.';
    else
      Set @Save = 'Y';
  end
  else
    Set @Message = 'The combination of state, initial, and country must be informed.';

  if (@Save = 'Y')
  begin
    Insert Into States
    (State, Initial, IdCountry)
    Select LTrim(State), LTrim(Initial), IdCountry
    From Inserted;
  end
  else
  begin
    RaisError(@Message, 10, 1);
    Return;
  end
end;

Go

/*========================================================================*/

Create Trigger IInsCity On Cities Instead Of Insert
As
Declare @Save Char(1) = 'N',
        @City Varchar(50),
        @IdState Integer,
		@Long Varchar(5),
        @Message Varchar(255);
begin
  Set NoCount On;

  Select @City    = LTrim(City),
         @IdState = IdState,
		 @Long    = LTrim(Long)
  From Inserted;

  if ((@City <> '') And (@IdState Is Not Null) And (@Long <> ''))
  begin
    if (Exists(Select Top 1 1
               From Cities (NoLock)
               Where City    = @City
                 And IdState = @IdState))
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
    Insert Into Cities
    (City, IdState, Long)
    Select LTrim(City), IdState, Long
    From Inserted;
  end
  else
  begin
    RaisError(@Message, 10, 1);
    Return;
  end
end;

Go

/*========================================================================*/
