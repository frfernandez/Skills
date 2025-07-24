object StatesDM: TStatesDM
  OldCreateOrder = False
  Left = 234
  Top = 114
  Height = 150
  Width = 275
  object StatesInsert: TADOStoredProc
    Connection = ConnectionDM.Connection
    ProcedureName = 'InsStates;1'
    Parameters = <
      item
        Name = '@RETURN_VALUE'
        DataType = ftInteger
        Direction = pdReturnValue
        Precision = 10
      end
      item
        Name = '@State'
        Attributes = [paNullable]
        DataType = ftString
        Size = 50
      end
      item
        Name = '@Initial'
        Attributes = [paNullable]
        DataType = ftString
        Size = 3
      end
      item
        Name = '@IdCountry'
        Attributes = [paNullable]
        DataType = ftInteger
        Precision = 10
      end>
    Left = 40
    Top = 8
  end
  object StatesUpdate: TADOStoredProc
    Connection = ConnectionDM.Connection
    ProcedureName = 'UpdStates;1'
    Parameters = <
      item
        Name = '@RETURN_VALUE'
        DataType = ftInteger
        Direction = pdReturnValue
        Precision = 10
      end
      item
        Name = '@Id'
        Attributes = [paNullable]
        DataType = ftInteger
        Precision = 10
      end
      item
        Name = '@State'
        Attributes = [paNullable]
        DataType = ftString
        Size = 50
      end
      item
        Name = '@Initial'
        Attributes = [paNullable]
        DataType = ftString
        Size = 3
      end
      item
        Name = '@IdCountry'
        Attributes = [paNullable]
        DataType = ftInteger
        Precision = 10
      end>
    Left = 184
    Top = 8
  end
  object StatesDelete: TADOStoredProc
    Connection = ConnectionDM.Connection
    ProcedureName = 'DelStates;1'
    Parameters = <
      item
        Name = '@RETURN_VALUE'
        DataType = ftInteger
        Direction = pdReturnValue
        Precision = 10
      end
      item
        Name = '@Id'
        Attributes = [paNullable]
        DataType = ftInteger
        Precision = 10
      end>
    Left = 40
    Top = 56
  end
  object StatesFilter: TADOStoredProc
    Connection = ConnectionDM.Connection
    CursorType = ctStatic
    ProcedureName = 'FltStates;1'
    Parameters = <
      item
        Name = '@RETURN_VALUE'
        DataType = ftInteger
        Direction = pdReturnValue
        Precision = 10
      end
      item
        Name = '@Id'
        Attributes = [paNullable]
        DataType = ftInteger
        Precision = 10
      end
      item
        Name = '@Name'
        Attributes = [paNullable]
        DataType = ftString
        Size = 50
      end
      item
        Name = '@Initial'
        Attributes = [paNullable]
        DataType = ftString
        Size = 3
      end
      item
        Name = '@IdCountry'
        Attributes = [paNullable]
        DataType = ftInteger
        Precision = 10
      end
      item
        Name = '@Search'
        Attributes = [paNullable]
        DataType = ftString
        Size = 1
      end>
    Left = 184
    Top = 56
  end
end
