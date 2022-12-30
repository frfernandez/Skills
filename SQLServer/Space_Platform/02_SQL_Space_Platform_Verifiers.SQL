/*=======================================================================

Space_Platform.MDF
Space_Platform.NDF
Space_Platform.LDF
	System: Space_Platform
	Developer: Fernando Roberto Fernández

=======================================================================*/

Create Procedure Documents.Luhn
(
@DocCode Varchar(50),
@Correct Char(1) Output,
@Message Varchar(255) Output
)
As
Declare
  @Count Integer,
  @DocCodeExtract Varchar(50),
  @Sum Decimal(12, 2),
  @Division Decimal(12, 2),
  @Remainder Char(1);
begin
  Set @DocCodeExtract = '';
  Set @Count = 1;

  While (@Count <= Len(LTrim(RTrim(@DocCode))))
  begin
    if (SubString(LTrim(RTrim(@DocCode)), @Count, 1) In ('0', '1', '2', '3', '4', '5', '6', '7', '8', '9'))
      Set @DocCodeExtract = @DocCodeExtract + SubString(LTrim(RTrim(@DocCode)), @Count, 1);

    Set @Count = @Count + 1;
  end

  Set @DocCode = @DocCodeExtract;

  if (Len(LTrim(RTrim(@DocCode))) = 7)
  begin
    Set @Sum = 0;
    Set @Count = 6;

    While (@Count >= 1)
    begin
      Set @Sum = @Sum + (Cast(SubString(LTrim(RTrim(@DocCode)), @Count, 1) As Integer) * (7 - @Count));
      Set @Count = @Count - 1;
    end

    if (7 - (@Sum % 7) < 6)
      Set @Remainder = Cast(LTrim(RTrim(Cast(Cast(7 - (@Sum % 7) As Integer) As Varchar(6)))) As Char(1));
    else if (7 - (@Sum % 7) >= 6)
      Set @Remainder = '0';

    if (@Remainder = SubString(LTrim(RTrim(@DocCode)), 6, 1))
    begin
      Set @Sum = 0;
      Set @Count = 6;

      While (@Count >= 1)
      begin
        Set @Sum = @Sum + (Cast(SubString(LTrim(RTrim(@DocCode)), @Count, 1) As Integer) * (12 - @Count));
        Set @Count = @Count - 1;
      end

      if (7 - (@Sum % 7) < 6)
        Set @Remainder = Cast(LTrim(RTrim(Cast(Cast(7 - (@Sum % 7) As Integer) As Varchar(6)))) As Char(1));
      else if (7 - (@Sum % 7) >= 6)
        Set @Remainder = '0';

      if (@Remainder = SubString(LTrim(RTrim(@DocCode)), 7, 1))
      begin
        Set @Message = 'Correct luhn !';
        Set @Correct = 'y';
      end
      else if (@Remainder <> SubString(LTrim(RTrim(@DocCode)), 7, 1))
      begin
        Set @Message = 'Incorrect luhn !';
        Set @Correct = 'n';
      end
    end
    else if (@Remainder <> SubString(LTrim(RTrim(@DocCode)), 6, 1))
    begin
      Set @Message = 'Incorrect luhn !';
      Set @Correct = 'n';
    end
  end
  else if (Len(LTrim(RTrim(@DocCode))) <> 7)
  begin
    Set @Message = 'Luhn needs 7 (seven) digits !';
    Set @Correct = 'n';
  end
end;

Go

/*=====================================================================*/
