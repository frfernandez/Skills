/*========================================================================*/

Use SampleXP;

Go

/*========================================================================*/

Create Trigger Persons.AInsPerson On Persons.Persons Instead Of Insert
As
Declare @Save Char(1) = 'N';
begin
  Set NoCount On;

  if ((Select LTrim(Person)
       From Inserted) <> '')
  begin
    if (Exists(Select *
               From Persons.Persons
               Where Person = (Select LTrim(Person)
                               From Inserted)))
      RaisError('The person has been inserted !', 10, 1);
    else
      Set @Save = 'Y';
  end
  else
    RaisError('The person must be informed !', 10, 1);

  if (@Save = 'Y')
  begin
    Insert Into Persons.Persons
    (Person)
    Select LTrim(Person)
    From Inserted;
  end
end;

Go

/*========================================================================*/