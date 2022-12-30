/*========================================================================*/

Use SampleXP;

Go

/*========================================================================*/

Create Trigger Persons.AUpdPerson On Persons.Persons Instead Of Update
As
Declare @Save Char(1) = 'N';
begin
  Set NoCount On;

  if ((Select LTrim(Person)
       From Inserted) <> '')
  begin
    if Update(Person)
    begin
      if (Exists(Select *
                 From Persons.Persons
                 Where Person = (Select LTrim(Person)
                                 From Inserted)))
        RaisError('The person has been inserted !', 10, 1);
      else
        Set @Save = 'Y';
    end
  end
  else
    RaisError('The person must be informed !', 10, 1);

  if (@Save = 'Y')
  begin
    Update a
    Set a.Person = LTrim(b.Person)
    From Persons.Persons a
    Join Inserted b On a.Id = b.Id;
  end
end;

Go

/*========================================================================*/