unit Countries;

interface

uses
  Windows, Messages, SysUtils, Variants, Classes, Graphics, Controls, Forms,
  Dialogs, ExtCtrls, StdCtrls, Buttons, ADODB, Mask;

type
  TCountriesF = class(TForm)
    PnlPanel1: TPanel;
    Bevel1: TBevel;
    ScBScrollBox1: TScrollBox;
    BtnIUD: TBitBtn;
    BtnCancel: TBitBtn;
    BtnExit: TBitBtn;
    BtnFilter: TBitBtn;
    PnlPanel2: TPanel;
    ScBScrollBox2: TScrollBox;
    LblCountry: TLabel;
    EdtCountry: TEdit;
    ImgInsert: TImage;
    ImgUpdate: TImage;
    ImgDelete: TImage;
    EdtId: TEdit;
    LblInitial: TLabel;
    EdtInitial: TEdit;
    LblContinent: TLabel;
    EdtIdContinent: TEdit;
    SpBIdContinent: TSpeedButton;
    EdtContinent: TEdit;
    LblPostalAreaMask: TLabel;
    MkEPostalAreaMask: TMaskEdit;
    LblInternational: TLabel;
    EdtInternational: TEdit;
    SpBCRUDContinent: TSpeedButton;
    procedure FormShow(Sender: TObject);
    procedure FormKeyPress(Sender: TObject; var Key: Char);
    procedure BtnIUDClick(Sender: TObject);
    procedure BtnCancelClick(Sender: TObject);
    procedure BtnExitClick(Sender: TObject);
    procedure BtnFilterClick(Sender: TObject);
    procedure EdtIdContinentExit(Sender: TObject);
    procedure SpBIdContinentClick(Sender: TObject);
    procedure SpBCRUDContinentClick(Sender: TObject);
  private
    { Private declarations }
    CaptionCopy: String;
    procedure Config;
    function CRUDConfig: Boolean;
    procedure Clear;
    procedure Data;
  public
    { Public declarations }
    CRUDRecord: String;
    SPInsert: TADOStoredProc;
    SPUpdate: TADOStoredProc;
    SPDelete: TADOStoredProc;
    SPSelect: TADOStoredProc;
  end;

var
  CountriesF: TCountriesF;

implementation

uses SearchDataList, Simple, DataProcedures, DMContinents, Components;

{$R *.dfm}

procedure TCountriesF.FormShow(Sender: TObject);
begin
  CaptionCopy := Caption;

  Config;
end;

procedure TCountriesF.FormKeyPress(Sender: TObject; var Key: Char);
begin
  if (Key = #13) then
  begin
    Key := #0;
    Perform(WM_NEXTDLGCTL, 0, 0);
  end
  else if (Key = #27) then
    BtnExitClick(Sender);
end;

procedure TCountriesF.BtnIUDClick(Sender: TObject);
begin
  if (CRUDConfig = True) then
    Clear;
end;

procedure TCountriesF.BtnCancelClick(Sender: TObject);
begin
  Clear;
  Config;
end;

procedure TCountriesF.BtnExitClick(Sender: TObject);
begin
  Close;
end;

procedure TCountriesF.BtnFilterClick(Sender: TObject);
var
  SearchDataListF: TSearchDataListF;
begin
  SearchDataListF := TSearchDataListF.Create(Self);
  try
    SearchDataListF.SPSelect := SPSelect;
    SearchDataListF.Caption := CaptionCopy;
    SearchDataListF.ColumName := 'Country';
    SearchDataListF.ShowModal;

    if (SPSelect.Active = True) then
    begin
      if (SearchDataListF.RdGRecord.ItemIndex = 0) then
        CRUDRecord := 'U'
      else if (SearchDataListF.RdGRecord.ItemIndex = 1) then
        CRUDRecord := 'D';

      Data;
    end
    else
    begin
      CRUDRecord := 'I';
      Clear;
    end;

    Config;
  finally
    SearchDataListF.Free;
  end;
end;

procedure TCountriesF.EdtIdContinentExit(Sender: TObject);
begin
  if (Trim(EdtIdContinent.Text) = '') then
    EdtContinent.Text := ''
  else
  begin
    try
      Application.CreateForm(TContinentsDM, ContinentsDM);

      DataProcedures.Filter(ContinentsDM.ContinentsFilter, Trim(EdtIdContinent.Text));
      if (ContinentsDM.ContinentsFilter.EOF) then
      begin
        EdtIdContinent.Text := '';
        EdtContinent.Text := '';
      end
      else
        EdtContinent.Text := ContinentsDM.ContinentsFilter.FieldByName('Continent').AsString;
    finally
      ContinentsDM.Free;
    end;

    if (Trim(EdtIdContinent.Text) = '') then
      SpBIdContinentClick(Sender);
  end;
end;

procedure TCountriesF.SpBIdContinentClick(Sender: TObject);
var
  SearchDataListF: TSearchDataListF;
begin
  SearchDataListF := TSearchDataListF.Create(Self);
  try
    Application.CreateForm(TContinentsDM, ContinentsDM);

    SearchDataListF.SPSelect := ContinentsDM.ContinentsFilter;
    SearchDataListF.Caption := 'Continents';
    SearchDataListF.ColumName := 'Continent';
    SearchDataListF.ShowModal;

    if (SearchDataListF.SPSelect.Active = True) then
    begin
      EdtIdContinent.Text := SearchDataListF.SPSelect.FieldByName('Id').AsString;
      EdtContinent.Text := SearchDataListF.SPSelect.FieldByName('Continent').AsString;
    end
    else
    begin
      EdtIdContinent.Text := '';
      EdtContinent.Text := '';
    end;
  finally
    SearchDataListF.Free;
    ContinentsDM.Free;
  end;
end;

procedure TCountriesF.SpBCRUDContinentClick(Sender: TObject);
var
  SimpleF: TSimpleF;
begin
  SimpleF := TSimpleF.Create(Self);
  try
    Application.CreateForm(TContinentsDM, ContinentsDM);

    SimpleF.SPInsert := ContinentsDM.ContinentsInsert;
    SimpleF.SPUpdate := ContinentsDM.ContinentsUpdate;
    SimpleF.SPDelete := ContinentsDM.ContinentsDelete;
    SimpleF.SPSelect := ContinentsDM.ContinentsFilter;
    SimpleF.CRUDRecord := 'I';
    SimpleF.ColumName := 'Continent';
    SimpleF.Caption := 'Continents';
    SimpleF.ShowModal;
  finally
    SimpleF.Free;
    ContinentsDM.Free;
  end;
end;

procedure TCountriesF.Config;
begin
  EdtCountry.MaxLength := SPInsert.Parameters.ParamByName('@Country').Size;
  EdtInitial.MaxLength := SPInsert.Parameters.ParamByName('@Initial').Size;
  EdtIdContinent.MaxLength := SPInsert.Parameters.ParamByName('@IdContinent').Size;
  MkEPostalAreaMask.MaxLength := SPInsert.Parameters.ParamByName('@PostalCodeMask').Size;
  EdtInternational.MaxLength := SPInsert.Parameters.ParamByName('@International').Size;

  if (CRUDRecord = 'I') then
  begin
    Caption := CaptionCopy + ' - Insert';

    BtnIUD.Caption := '&Insert';
    BtnIUD.Glyph := ImgInsert.Picture.Bitmap;
  end
  else if (CRUDRecord = 'U') then
  begin
    Caption := CaptionCopy + ' - Update';

    BtnIUD.Caption := '&Update';
    BtnIUD.Glyph := ImgUpdate.Picture.Bitmap;
  end
  else if (CRUDRecord = 'D') then
  begin
    Caption := CaptionCopy + ' - Delete';

    BtnIUD.Caption := '&Delete';
    BtnIUD.Glyph := ImgDelete.Picture.Bitmap;
  end;
end;

function TCountriesF.CRUDConfig: Boolean;
var
  StoredProc: TADOStoredProc;
begin
  Result := True;
  StoredProc := nil;

  if (CRUDRecord = 'I') then
    StoredProc := SPInsert
  else if (CRUDRecord = 'U') then
    StoredProc := SPUpdate
  else if (CRUDRecord = 'D') then
    StoredProc := SPDelete;

  StoredProc.Prepared := True;
  StoredProc.Parameters.Refresh;

  if (CRUDRecord <> 'I') then
    StoredProc.Parameters.ParamByName('@Id').Value := Trim(EdtId.Text);

  if (CRUDRecord <> 'D') then
  begin
    Result := Save;

    if (Result = True) then
    begin
      StoredProc.Parameters.ParamByName('@Country').Value := Trim(EdtCountry.Text);
      StoredProc.Parameters.ParamByName('@Initial').Value := Trim(EdtInitial.Text);
      StoredProc.Parameters.ParamByName('@IdContinent').Value := Trim(EdtIdContinent.Text);
      StoredProc.Parameters.ParamByName('@PostalCodeMask').Value := Trim(MkEPostalAreaMask.Text);
      StoredProc.Parameters.ParamByName('@International').Value := Trim(EdtInternational.Text);
    end;
  end;

  if (Result = True) then
  begin
    StoredProc.ExecProc;
    StoredProc.Prepared := False;
  end;
end;

procedure TCountriesF.Clear;
var
  I: Integer;
begin
  CRUDRecord := 'I';

  for I := 0 to Screen.ActiveForm.ComponentCount - 1 do
  begin
    if Screen.ActiveForm.FindComponent(Screen.ActiveForm.Components[I].Name) is TEdit then
      TEdit(Screen.ActiveForm.FindComponent(Screen.ActiveForm.Components[I].Name)).Text := ''
    else if Screen.ActiveForm.FindComponent(Screen.ActiveForm.Components[I].Name) is TMaskEdit then
      TMaskEdit(Screen.ActiveForm.FindComponent(Screen.ActiveForm.Components[I].Name)).Text := '';
  end;

  EdtCountry.SetFocus;
end;

procedure TCountriesF.Data;
begin
  EdtId.Text := SPSelect.FieldByName('Id').AsString;
  EdtCountry.Text := SPSelect.FieldByName('Country').AsString;
  EdtInitial.Text := SPSelect.FieldByName('Initial').AsString;
  EdtIdContinent.Text := SPSelect.FieldByName('IdContinent').AsString;
  EdtContinent.Text := SPSelect.FieldByName('Continent').AsString;
  MkEPostalAreaMask.Text := SPSelect.FieldByName('PostalCodeMask').AsString;
  EdtInternational.Text := SPSelect.FieldByName('International').AsString;
end;

end.
