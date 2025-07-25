object MainF: TMainF
  Left = 220
  Top = 108
  Width = 928
  Height = 480
  BorderIcons = [biSystemMenu]
  Caption = 'Cadastro Clientes/Contatos'
  Color = clBtnFace
  Font.Charset = DEFAULT_CHARSET
  Font.Color = clWindowText
  Font.Height = -11
  Font.Name = 'MS Sans Serif'
  Font.Style = [fsBold]
  KeyPreview = True
  OldCreateOrder = False
  Position = poScreenCenter
  OnClose = FormClose
  OnKeyPress = FormKeyPress
  OnShow = FormShow
  PixelsPerInch = 96
  TextHeight = 13
  object PgCPageControl: TPageControl
    Left = 0
    Top = 0
    Width = 912
    Height = 441
    ActivePage = TbSListaClientes
    Align = alClient
    TabOrder = 0
    TabStop = False
    TabWidth = 300
    OnChange = PgCPageControlChange
    object TbSListaClientes: TTabSheet
      Caption = 'Lista Clientes'
      object PnlPanel1: TPanel
        Left = 0
        Top = 0
        Width = 904
        Height = 62
        Align = alTop
        BevelInner = bvLowered
        BorderWidth = 4
        TabOrder = 0
        object ScBScrollBox1: TScrollBox
          Left = 6
          Top = 6
          Width = 892
          Height = 50
          Align = alClient
          BorderStyle = bsNone
          TabOrder = 0
          object SpBCodigo: TSpeedButton
            Left = 0
            Top = 0
            Width = 80
            Height = 50
            GroupIndex = 1
            Down = True
            Caption = 'C'#243'digo'
            OnClick = SpBCodigoClick
          end
          object SpBNome: TSpeedButton
            Left = 80
            Top = 0
            Width = 80
            Height = 50
            GroupIndex = 1
            Caption = 'Nome'
            OnClick = SpBNomeClick
          end
          object LblCodigoNome: TLabel
            Left = 164
            Top = 4
            Width = 89
            Height = 13
            Caption = 'LblCodigoNome'
          end
          object SpECodigoLista: TSpinEdit
            Left = 164
            Top = 20
            Width = 89
            Height = 22
            MaxValue = 999999999
            MinValue = 1
            TabOrder = 0
            Value = 1
            Visible = False
            OnChange = SpECodigoListaChange
          end
          object EdtNomeLista: TEdit
            Left = 164
            Top = 20
            Width = 725
            Height = 21
            TabOrder = 1
            Visible = False
            OnChange = EdtNomeListaChange
          end
        end
      end
      object PnlPanel2: TPanel
        Left = 0
        Top = 62
        Width = 904
        Height = 351
        Align = alClient
        BevelInner = bvLowered
        BorderWidth = 4
        TabOrder = 1
        object ScBScrollBox2: TScrollBox
          Left = 6
          Top = 6
          Width = 892
          Height = 339
          Align = alClient
          BorderStyle = bsNone
          TabOrder = 0
          object DBGGradeClientes: TDBGrid
            Left = 0
            Top = 0
            Width = 892
            Height = 339
            Align = alClient
            BorderStyle = bsNone
            DataSource = DSClientes
            Options = [dgTitles, dgIndicator, dgColumnResize, dgColLines, dgRowLines, dgTabs, dgRowSelect, dgConfirmDelete, dgCancelOnExit]
            TabOrder = 0
            TitleFont.Charset = DEFAULT_CHARSET
            TitleFont.Color = clWindowText
            TitleFont.Height = -11
            TitleFont.Name = 'MS Sans Serif'
            TitleFont.Style = [fsBold]
          end
        end
      end
    end
    object TbSCadastroClientes: TTabSheet
      Caption = 'Cadastro Clientes'
      ImageIndex = 1
      object PnlPanel3: TPanel
        Left = 0
        Top = 0
        Width = 904
        Height = 62
        Align = alTop
        BevelInner = bvLowered
        BorderWidth = 4
        TabOrder = 1
        object ScBScrollBox3: TScrollBox
          Left = 6
          Top = 6
          Width = 892
          Height = 50
          Align = alClient
          BorderStyle = bsNone
          TabOrder = 0
          object SpBInsertCliente: TSpeedButton
            Left = 0
            Top = 0
            Width = 80
            Height = 50
            AllowAllUp = True
            GroupIndex = 1
            Caption = 'Insert'
            OnClick = SpBInsertClienteClick
          end
          object SpBUpdateCliente: TSpeedButton
            Left = 80
            Top = 0
            Width = 80
            Height = 50
            AllowAllUp = True
            GroupIndex = 1
            Caption = 'Update'
            OnClick = SpBUpdateClienteClick
          end
          object SpBDeleteCliente: TSpeedButton
            Left = 161
            Top = 0
            Width = 80
            Height = 50
            AllowAllUp = True
            GroupIndex = 1
            Caption = 'Delete'
            OnClick = SpBDeleteClienteClick
          end
          object ButSaveCliente: TButton
            Left = 241
            Top = 0
            Width = 80
            Height = 50
            Caption = 'Save'
            Enabled = False
            TabOrder = 0
            TabStop = False
            OnClick = ButSaveClienteClick
          end
        end
      end
      object PnlPanel4: TPanel
        Left = 0
        Top = 62
        Width = 904
        Height = 351
        Align = alClient
        BevelInner = bvLowered
        BorderWidth = 4
        TabOrder = 0
        object ScBScrollBox4: TScrollBox
          Left = 6
          Top = 6
          Width = 892
          Height = 339
          Align = alClient
          BorderStyle = bsNone
          TabOrder = 0
          object LblCodigoCliente: TLabel
            Left = 4
            Top = 4
            Width = 44
            Height = 13
            Caption = 'C'#243'digo:'
          end
          object LblNomeCliente: TLabel
            Left = 4
            Top = 44
            Width = 37
            Height = 13
            Caption = 'Nome:'
          end
          object LblDataCadastroCliente: TLabel
            Left = 4
            Top = 83
            Width = 86
            Height = 13
            Caption = 'Data Cadastro:'
          end
          object LblObservacaoCliente: TLabel
            Left = 4
            Top = 123
            Width = 73
            Height = 13
            Caption = 'Observa'#231#227'o:'
          end
          object SpECodigoCliente: TSpinEdit
            Left = 4
            Top = 20
            Width = 89
            Height = 22
            Hint = 'O c'#243'digo do cliente dever'#225' ser informado.'
            MaxValue = 999999999
            MinValue = 1
            TabOrder = 0
            Value = 1
          end
          object EdtNomeCliente: TEdit
            Left = 4
            Top = 60
            Width = 885
            Height = 21
            Hint = 'O nome do cliente dever'#225' ser informado.'
            MaxLength = 150
            TabOrder = 1
          end
          object MkEDataCadastroCliente: TMaskEdit
            Left = 4
            Top = 99
            Width = 81
            Height = 21
            EditMask = '!99/99/0000;1;_'
            MaxLength = 10
            TabOrder = 2
            Text = '  /  /    '
          end
          object MmoObservacaoCliente: TMemo
            Left = 0
            Top = 140
            Width = 892
            Height = 199
            Align = alBottom
            TabOrder = 3
          end
        end
      end
    end
    object TbSCadastroContatos: TTabSheet
      Caption = 'Cadastro Contatos'
      ImageIndex = 2
      object PnlPanel5: TPanel
        Left = 0
        Top = 0
        Width = 904
        Height = 62
        Align = alTop
        BevelInner = bvLowered
        BorderWidth = 4
        TabOrder = 2
        object ScBScrollBox5: TScrollBox
          Left = 6
          Top = 6
          Width = 892
          Height = 50
          Align = alClient
          BorderStyle = bsNone
          TabOrder = 0
          object SpBInsertContato: TSpeedButton
            Left = 0
            Top = 0
            Width = 80
            Height = 50
            AllowAllUp = True
            GroupIndex = 1
            Caption = 'Insert'
            OnClick = SpBInsertClienteClick
          end
          object SpBUpdateContato: TSpeedButton
            Left = 80
            Top = 0
            Width = 80
            Height = 50
            AllowAllUp = True
            GroupIndex = 1
            Caption = 'Update'
            OnClick = SpBUpdateClienteClick
          end
          object SpBDeleteContato: TSpeedButton
            Left = 161
            Top = 0
            Width = 80
            Height = 50
            AllowAllUp = True
            GroupIndex = 1
            Caption = 'Delete'
            OnClick = SpBDeleteContatoClick
          end
          object ButSaveContato: TButton
            Left = 241
            Top = 0
            Width = 80
            Height = 50
            Caption = 'Save'
            Enabled = False
            TabOrder = 0
            TabStop = False
            OnClick = ButSaveContatoClick
          end
        end
      end
      object PnlPanel6: TPanel
        Left = 0
        Top = 62
        Width = 904
        Height = 215
        Align = alClient
        BevelInner = bvLowered
        BorderWidth = 4
        TabOrder = 0
        object ScBScrollBox6: TScrollBox
          Left = 6
          Top = 6
          Width = 892
          Height = 203
          Align = alClient
          BorderStyle = bsNone
          TabOrder = 0
          object DBGGradeContatos: TDBGrid
            Left = 0
            Top = 0
            Width = 892
            Height = 203
            Align = alClient
            BorderStyle = bsNone
            DataSource = DSCliContatos
            Options = [dgTitles, dgIndicator, dgColumnResize, dgColLines, dgRowLines, dgTabs, dgRowSelect, dgConfirmDelete, dgCancelOnExit]
            TabOrder = 0
            TitleFont.Charset = DEFAULT_CHARSET
            TitleFont.Color = clWindowText
            TitleFont.Height = -11
            TitleFont.Name = 'MS Sans Serif'
            TitleFont.Style = [fsBold]
            OnCellClick = DBGGradeContatosCellClick
          end
        end
      end
      object PnlPanel7: TPanel
        Left = 0
        Top = 277
        Width = 904
        Height = 136
        Align = alBottom
        BevelInner = bvLowered
        BorderWidth = 4
        TabOrder = 1
        object ScBScrollBox7: TScrollBox
          Left = 6
          Top = 6
          Width = 892
          Height = 124
          Align = alClient
          BorderStyle = bsNone
          TabOrder = 0
          object LblNomeContato: TLabel
            Left = 4
            Top = 4
            Width = 37
            Height = 13
            Caption = 'Nome:'
          end
          object LblCargoContato: TLabel
            Left = 4
            Top = 44
            Width = 38
            Height = 13
            Caption = 'Cargo:'
          end
          object LblEmailContato: TLabel
            Left = 4
            Top = 84
            Width = 35
            Height = 13
            Caption = 'Email:'
          end
          object EdtNomeContato: TEdit
            Left = 4
            Top = 20
            Width = 885
            Height = 21
            Hint = 'O nome do contato dever'#225' ser informado.'
            MaxLength = 150
            TabOrder = 0
          end
          object EdtCargoContato: TEdit
            Left = 4
            Top = 60
            Width = 885
            Height = 21
            MaxLength = 150
            TabOrder = 1
          end
          object EdtEmailContato: TEdit
            Left = 4
            Top = 100
            Width = 885
            Height = 21
            MaxLength = 150
            TabOrder = 2
          end
        end
      end
    end
  end
  object Connection: TADOConnection
    ConnectionString = 
      'Provider=SQLOLEDB.1;Password=sa;Persist Security Info=True;User ' +
      'ID=sa;Initial Catalog=FlexLife;Data Source=DELL;Use Procedure fo' +
      'r Prepare=1;Auto Translate=True;Packet Size=4096;Workstation ID=' +
      'DESKTOP1;Use Encryption for Data=False;Tag with column collation' +
      ' when possible=False'
    LoginPrompt = False
    Provider = 'SQLOLEDB.1'
    Left = 418
    Top = 204
  end
  object TabClientes: TADOTable
    Connection = Connection
    CursorType = ctStatic
    TableName = 'TB_Clientes'
    Left = 418
    Top = 232
    object TabClientesId_Clientes: TAutoIncField
      FieldName = 'Id_Clientes'
      ReadOnly = True
      Visible = False
    end
    object TabClientesCodigo: TIntegerField
      FieldName = 'Codigo'
    end
    object TabClientesNome: TStringField
      DisplayWidth = 130
      FieldName = 'Nome'
      Size = 150
    end
    object TabClientesData_Cadastro: TDateTimeField
      FieldName = 'Data_Cadastro'
      Visible = False
    end
    object TabClientesObservacao: TMemoField
      FieldName = 'Observacao'
      Visible = False
      BlobType = ftMemo
    end
  end
  object TabCliContatos: TADOTable
    Connection = Connection
    CursorType = ctStatic
    TableName = 'TB_CliContatos'
    Left = 448
    Top = 232
    object TabCliContatosId_CliContatos: TAutoIncField
      FieldName = 'Id_CliContatos'
      ReadOnly = True
      Visible = False
    end
    object TabCliContatosId_Clientes: TIntegerField
      FieldName = 'Id_Clientes'
      Visible = False
    end
    object TabCliContatosNome: TStringField
      DisplayWidth = 140
      FieldName = 'Nome'
      Size = 150
    end
    object TabCliContatosCargo: TStringField
      FieldName = 'Cargo'
      Visible = False
      Size = 100
    end
    object TabCliContatosEmail: TStringField
      FieldName = 'Email'
      Visible = False
      Size = 150
    end
  end
  object DSClientes: TDataSource
    DataSet = TabClientes
    Left = 418
    Top = 260
  end
  object DSCliContatos: TDataSource
    DataSet = TabCliContatos
    Left = 448
    Top = 260
  end
end
