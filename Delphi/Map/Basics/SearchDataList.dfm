object SearchDataListF: TSearchDataListF
  Left = 236
  Top = 117
  Width = 626
  Height = 378
  ActiveControl = EdtDescription
  BorderIcons = [biSystemMenu]
  Color = clBtnFace
  Font.Charset = DEFAULT_CHARSET
  Font.Color = clWindowText
  Font.Height = -11
  Font.Name = 'MS Sans Serif'
  Font.Style = [fsBold]
  KeyPreview = True
  OldCreateOrder = False
  Position = poDesktopCenter
  OnDestroy = FormDestroy
  OnKeyPress = FormKeyPress
  OnShow = FormShow
  PixelsPerInch = 96
  TextHeight = 13
  object PnlPanel1: TPanel
    Left = 0
    Top = 0
    Width = 610
    Height = 62
    Align = alTop
    BevelInner = bvLowered
    BorderWidth = 4
    TabOrder = 0
    object Bevel1: TBevel
      Left = 6
      Top = 6
      Width = 598
      Height = 50
      Align = alClient
    end
    object ScBScrollBox1: TScrollBox
      Left = 6
      Top = 6
      Width = 598
      Height = 50
      Align = alClient
      BorderStyle = bsNone
      TabOrder = 0
      object BtnExit: TBitBtn
        Left = 80
        Top = 0
        Width = 80
        Height = 50
        Caption = '&Exit'
        TabOrder = 1
        TabStop = False
        OnClick = BtnExitClick
        Glyph.Data = {
          76010000424D7601000000000000760000002800000020000000100000000100
          04000000000000010000120B0000120B00001000000000000000000000000000
          800000800000008080008000000080008000808000007F7F7F00BFBFBF000000
          FF0000FF000000FFFF00FF000000FF00FF00FFFF0000FFFFFF00330000000000
          03333377777777777F333301BBBBBBBB033333773F3333337F3333011BBBBBBB
          0333337F73F333337F33330111BBBBBB0333337F373F33337F333301110BBBBB
          0333337F337F33337F333301110BBBBB0333337F337F33337F333301110BBBBB
          0333337F337F33337F333301110BBBBB0333337F337F33337F333301110BBBBB
          0333337F337F33337F333301110BBBBB0333337F337FF3337F33330111B0BBBB
          0333337F337733337F333301110BBBBB0333337F337F33337F333301110BBBBB
          0333337F3F7F33337F333301E10BBBBB0333337F7F7F33337F333301EE0BBBBB
          0333337F777FFFFF7F3333000000000003333377777777777333}
        Layout = blGlyphTop
        NumGlyphs = 2
      end
      object BtnSelect: TBitBtn
        Left = 0
        Top = 0
        Width = 80
        Height = 50
        Caption = '&Select'
        TabOrder = 0
        TabStop = False
        OnClick = BtnSelectClick
        Glyph.Data = {
          76010000424D7601000000000000760000002800000020000000100000000100
          04000000000000010000120B0000120B00001000000000000000000000000000
          800000800000008080008000000080008000808000007F7F7F00BFBFBF000000
          FF0000FF000000FFFF00FF000000FF00FF00FFFF0000FFFFFF00555555555555
          555555FFFFFFFFFF5F5557777777777505555777777777757F55555555555555
          055555555555FF5575F555555550055030555555555775F7F7F55555550FB000
          005555555575577777F5555550FB0BF0F05555555755755757F555550FBFBF0F
          B05555557F55557557F555550BFBF0FB005555557F55575577F555500FBFBFB0
          305555577F555557F7F5550E0BFBFB003055557575F55577F7F550EEE0BFB0B0
          305557FF575F5757F7F5000EEE0BFBF03055777FF575FFF7F7F50000EEE00000
          30557777FF577777F7F500000E05555BB05577777F75555777F5500000555550
          3055577777555557F7F555000555555999555577755555577755}
        Layout = blGlyphTop
        NumGlyphs = 2
      end
      object RdGRecord: TRadioGroup
        Left = 512
        Top = 0
        Width = 86
        Height = 50
        Align = alRight
        Caption = 'Record'
        ItemIndex = 0
        Items.Strings = (
          '&Update'
          '&Delete')
        TabOrder = 3
      end
      object RdGFilter: TRadioGroup
        Left = 360
        Top = 0
        Width = 152
        Height = 50
        Align = alRight
        Caption = 'Filter'
        Columns = 2
        ItemIndex = 0
        Items.Strings = (
          '&Start'
          'E&nd'
          '&Contain'
          '&All')
        TabOrder = 2
        OnClick = RdGFilterClick
      end
    end
  end
  object PnlPanel2: TPanel
    Left = 0
    Top = 62
    Width = 610
    Height = 58
    Align = alTop
    BevelInner = bvLowered
    BorderWidth = 4
    TabOrder = 1
    object ScBScrollBox2: TScrollBox
      Left = 6
      Top = 6
      Width = 598
      Height = 46
      Align = alClient
      BorderStyle = bsNone
      TabOrder = 0
      object LblDescription: TLabel
        Left = 8
        Top = 4
        Width = 69
        Height = 13
        Caption = 'Description:'
      end
      object LblMinimum: TLabel
        Left = 534
        Top = 4
        Width = 53
        Height = 13
        Caption = 'Minimum:'
      end
      object EdtDescription: TEdit
        Left = 8
        Top = 20
        Width = 520
        Height = 21
        CharCase = ecUpperCase
        TabOrder = 0
        OnChange = EdtDescriptionChange
      end
      object SEdMinimum: TSpinEdit
        Left = 534
        Top = 20
        Width = 60
        Height = 22
        MaxValue = 10
        MinValue = 1
        TabOrder = 1
        Value = 1
      end
    end
  end
  object PnlPanel3: TPanel
    Left = 0
    Top = 120
    Width = 610
    Height = 219
    Align = alClient
    BevelInner = bvLowered
    BorderWidth = 4
    TabOrder = 2
    object ScBScrollBox3: TScrollBox
      Left = 6
      Top = 6
      Width = 598
      Height = 207
      Align = alClient
      BorderStyle = bsNone
      TabOrder = 0
      object DBGDataGrid: TDBGrid
        Left = 0
        Top = 0
        Width = 598
        Height = 207
        Align = alClient
        BorderStyle = bsNone
        Options = [dgTitles, dgIndicator, dgColumnResize, dgColLines, dgRowLines, dgTabs, dgRowSelect, dgConfirmDelete, dgCancelOnExit]
        TabOrder = 0
        TitleFont.Charset = DEFAULT_CHARSET
        TitleFont.Color = clWindowText
        TitleFont.Height = -11
        TitleFont.Name = 'MS Sans Serif'
        TitleFont.Style = [fsBold]
        OnDblClick = DBGDataGridDblClick
      end
    end
  end
end
