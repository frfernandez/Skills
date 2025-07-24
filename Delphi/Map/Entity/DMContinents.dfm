object ContinentsDM: TContinentsDM
  OldCreateOrder = False
  Left = 234
  Top = 114
  Height = 150
  Width = 275
  object ContinentsInsert: TADOStoredProc
    Connection = ConnectionDM.Connection
    ProcedureName = 'InsContinents;1'
    Parameters = <
      item
        Name = '@RETURN_VALUE'
        DataType = ftInteger
        Direction = pdOutput
        Precision = 10
        Value = Null
      end
      item
        Name = '@Text'
        Attributes = [paNullable]
        DataType = ftString
        Size = 50
        Value = Null
      end>
    Left = 40
    Top = 8
  end
  object ContinentsUpdate: TADOStoredProc
    Connection = ConnectionDM.Connection
    ProcedureName = 'UpdContinents;1'
    Parameters = <
      item
        Name = '@RETURN_VALUE'
        DataType = ftInteger
        Direction = pdReturnValue
        Precision = 10
        Value = 0
      end
      item
        Name = '@Id'
        Attributes = [paNullable]
        DataType = ftInteger
        Precision = 10
        Value = 0
      end
      item
        Name = '@Text'
        Attributes = [paNullable]
        DataType = ftString
        Size = 50
        Value = ''
      end>
    Left = 184
    Top = 8
  end
  object ContinentsDelete: TADOStoredProc
    Connection = ConnectionDM.Connection
    ProcedureName = 'DelContinents;1'
    Parameters = <
      item
        Name = '@RETURN_VALUE'
        DataType = ftInteger
        Direction = pdReturnValue
        Precision = 10
        Value = 0
      end
      item
        Name = '@Id'
        Attributes = [paNullable]
        DataType = ftInteger
        Precision = 10
        Value = 0
      end>
    Left = 40
    Top = 56
  end
  object ContinentsFilter: TADOStoredProc
    Connection = ConnectionDM.Connection
    CursorType = ctStatic
    ProcedureName = 'FltContinents;1'
    Parameters = <
      item
        Name = '@RETURN_VALUE'
        DataType = ftInteger
        Direction = pdReturnValue
        Precision = 10
        Value = 0
      end
      item
        Name = '@Id'
        Attributes = [paNullable]
        DataType = ftInteger
        Precision = 10
        Value = Null
      end
      item
        Name = '@Name'
        Attributes = [paNullable]
        DataType = ftString
        Size = 50
        Value = ''
      end
      item
        Name = '@Search'
        Attributes = [paNullable]
        DataType = ftString
        Size = 1
        Value = Null
      end>
    Left = 184
    Top = 56
  end
end
