object ConnectionDM: TConnectionDM
  OldCreateOrder = False
  OnCreate = DataModuleCreate
  OnDestroy = DataModuleDestroy
  Left = 224
  Top = 111
  Height = 129
  Width = 264
  object Connection: TADOConnection
    ConnectionString = 
      'Provider=SQLOLEDB.1;Password=sa;Persist Security Info=True;User ' +
      'ID=sa;Initial Catalog=Map;Data Source=DELL\DELL_KINGSTON'
    LoginPrompt = False
    Provider = 'SQLOLEDB.1'
    Left = 104
    Top = 24
  end
end
