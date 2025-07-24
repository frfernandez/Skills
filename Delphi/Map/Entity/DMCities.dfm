object CitiesDM: TCitiesDM
  OldCreateOrder = False
  Left = 234
  Top = 114
  Height = 150
  Width = 275
  object CitiesInsert: TADOStoredProc
    Connection = ConnectionDM.Connection
    ProcedureName = 'InsCities;1'
    Parameters = <
      item
        Name = '@RETURN_VALUE'
        DataType = ftInteger
        Direction = pdReturnValue
        Precision = 10
        Value = Null
      end
      item
        Name = '@City'
        Attributes = [paNullable]
        DataType = ftString
        Size = 50
        Value = Null
      end
      item
        Name = '@IdState'
        Attributes = [paNullable]
        DataType = ftInteger
        Precision = 10
        Value = Null
      end
      item
        Name = '@Long'
        Attributes = [paNullable]
        DataType = ftString
        Size = 5
        Value = Null
      end>
    Left = 40
    Top = 8
  end
  object CitiesUpdate: TADOStoredProc
    Connection = ConnectionDM.Connection
    ProcedureName = 'UpdCities;1'
    Parameters = <
      item
        Name = '@RETURN_VALUE'
        DataType = ftInteger
        Direction = pdReturnValue
        Precision = 10
        Value = Null
      end
      item
        Name = '@Id'
        Attributes = [paNullable]
        DataType = ftInteger
        Precision = 10
        Value = Null
      end
      item
        Name = '@City'
        Attributes = [paNullable]
        DataType = ftString
        Size = 50
        Value = Null
      end
      item
        Name = '@IdState'
        Attributes = [paNullable]
        DataType = ftInteger
        Precision = 10
        Value = Null
      end
      item
        Name = '@Long'
        Attributes = [paNullable]
        DataType = ftString
        Size = 5
        Value = Null
      end>
    Left = 184
    Top = 8
  end
  object CitiesDelete: TADOStoredProc
    Connection = ConnectionDM.Connection
    ProcedureName = 'DelCities;1'
    Parameters = <
      item
        Name = '@RETURN_VALUE'
        DataType = ftInteger
        Direction = pdReturnValue
        Precision = 10
        Value = Null
      end
      item
        Name = '@Id'
        Attributes = [paNullable]
        DataType = ftInteger
        Precision = 10
        Value = Null
      end>
    Left = 40
    Top = 56
  end
  object CitiesFilter: TADOStoredProc
    Connection = ConnectionDM.Connection
    CursorType = ctStatic
    ProcedureName = 'FltCities;1'
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
        Name = '@IdState'
        Attributes = [paNullable]
        DataType = ftInteger
        Precision = 10
      end
      item
        Name = '@IdCountry'
        Attributes = [paNullable]
        DataType = ftInteger
        Precision = 10
      end
      item
        Name = '@IdContinent'
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
