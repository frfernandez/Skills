unit States;

interface

uses
  Windows, Messages, SysUtils, Variants, Classes, Graphics, Controls, Forms,
  Dialogs, ExtCtrls, StdCtrls, Buttons, ADODB, Mask;

type
  TStatesF = class(TForm)
    PnlPanel1: TPanel;
    Bevel1: TBevel;
    ScBScrollBox1: TScrollBox;
    BtnIUD: TBitBtn;
    BtnCancel: TBitBtn;
    BtnExit: TBitBtn;
    BtnFilter: TBitBtn;
    PnlPanel2: TPanel;
    ScBScrollBox2: TScrollBox;
    LblState: TLabel;
    EdtState: TEdit;
    ImgInsert: TImage;
    ImgUpdate: TImage;
    ImgDelete: TImage;
    EdtId: TEdit;
    LblInitial: TLabel;
    EdtInitial: TEdit;
    LblCountry: TLabel;
    EdtIdCountry: TEdit;
    SpBIdCountry: TSpeedButton;
    EdtCountry: TEdit;
    SpBCRUDCountry: TSpeedButton;
    procedure FormShow(Sender: TObject);
    procedure FormKeyPress(Sender: TObject; var Key: Char);
    procedure BtnIUDClick(Sender: TObject);
    procedure BtnCancelClick(Sender: TObject);
    procedure BtnExitClick(Sender: TObject);
    procedure BtnFilterClick(Sender: TObject);
    procedure EdtIdCountryExit(Sender: TObject);
    procedure SpBIdCountryClick(Sender: TObject);
    procedure SpBCRUDCountryClick(Sender: TObject);
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
  StatesF: TStatesF;

implementation

uses SearchDataList, Simple, DataProcedures, Countries, DMCountries, Components;

{$R *.dfm}

procedure TStatesF.FormShow(Sender: TObject);
begin
  CaptionCopy := Caption;

  Config;
end;

procedure TStatesF.FormKeyPress(Sender: TObject; var Key: Char);
begin
  if (Key = #13) then
  begin
    Key := #0;
    Perform(WM_NEXTDLGCTL, 0, 0);
  end
  else if (Key = #27) then
    BtnExitClick(Sender);
end;

procedure TStatesF.BtnIUDClick(Sender: TObject);
begin
  if (CRUDConfig = True) then
    Clear;
end;

procedure TStatesF.BtnCancelClick(Sender: TObject);
begin
  Clear;
  Config;
end;

procedure TStatesF.BtnExitClick(Sender: TObject);
begin
  Close;
end;

procedure TStatesF.BtnFilterClick(Sender: TObject);
var
  SearchDataListF: TSearchDataListF;
begin
  SearchDataListF := TSearchDataListF.Create(Self);
  try
    SearchDataListF.SPSelect := SPSelect;
    SearchDataListF.Caption := CaptionCopy;
    SearchDataListF.ColumName := 'State';
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

procedure TStatesF.EdtIdCountryExit(Sender: TObject);
begin
  if (Trim(EdtIdCountry.Text) = '') then
    EdtCountry.Text := ''
  else
  begin
    try
      Application.CreateForm(TCountriesDM, CountriesDM);

      DataProcedures.Filter(CountriesDM.CountriesFilter, Trim(EdtIdCountry.Text));
      if (CountriesDM.CountriesFilter.EOF) then
      begin
        EdtIdCountry.Text := '';
        EdtCountry.Text := '';
      end
      else
        EdtCountry.Text := CountriesDM.CountriesFilter.FieldByName('Country').AsString;
    finally
      CountriesDM.Free;
    end;

    if (Trim(EdtIdCountry.Text) = '') then
      SpBIdCountryClick(Sender);
  end;
end;

procedure TStatesF.SpBIdCountryClick(Sender: TObject);
var
  SearchDataListF: TSearchDataListF;
begin
  SearchDataListF := TSearchDataListF.Create(Self);
  try
    Application.CreateForm(TCountriesDM, CountriesDM);

    SearchDataListF.SPSelect := CountriesDM.CountriesFilter;
    SearchDataListF.Caption := 'Countries';
    SearchDataListF.ColumName := 'Country';
    SearchDataListF.ShowModal;

    if (SearchDataListF.SPSelect.Active = True) then
    begin
      EdtIdCountry.Text := SearchDataListF.SPSelect.FieldByName('Id').AsString;
      EdtCountry.Text := SearchDataListF.SPSelect.FieldByName('Country').AsString;
    end
    else
    begin
      EdtIdCountry.Text := '';
      EdtCountry.Text := '';
    end;
  finally
    SearchDataListF.Free;
    CountriesDM.Free;
  end;
end;

procedure TStatesF.SpBCRUDCountryClick(Sender: TObject);
var
  CountriesF: TCountriesF;
begin
  CountriesF := TCountriesF.Create(Self);
  try
    Application.CreateForm(TCountriesDM, CountriesDM);

    CountriesF.SPInsert := CountriesDM.CountriesInsert;
    CountriesF.SPUpdate := CountriesDM.CountriesUpdate;
    CountriesF.SPDelete := CountriesDM.CountriesDelete;
    CountriesF.SPSelect := CountriesDM.CountriesFilter;
    CountriesF.CRUDRecord := 'I';
    CountriesF.ShowModal;
  finally
    CountriesF.Free;
    CountriesDM.Free;
  end;
end;

procedure TStatesF.Config;
begin
  EdtState.MaxLength := SPInsert.Parameters.ParamByName('@State').Size;
  EdtInitial.MaxLength := SPInsert.Parameters.ParamByName('@Initial').Size;
  EdtIdCountry.MaxLength := SPInsert.Parameters.ParamByName('@IdCountry').Size;

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

function TStatesF.CRUDConfig: Boolean;
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
      StoredProc.Parameters.ParamByName('@State').Value := Trim(EdtState.Text);
      StoredProc.Parameters.ParamByName('@Initial').Value := Trim(EdtInitial.Text);
      StoredProc.Parameters.ParamByName('@IdCountry').Value := Trim(EdtIdCountry.Text);
    end;
  end;

  if (Result = True) then
  begin
    StoredProc.ExecProc;
    StoredProc.Prepared := False;
  end;
end;

procedure TStatesF.Clear;
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

  EdtState.SetFocus;
end;

procedure TStatesF.Data;
begin
  EdtId.Text := SPSelect.FieldByName('Id').AsString;
  EdtState.Text := SPSelect.FieldByName('State').AsString;
  EdtInitial.Text := SPSelect.FieldByName('Initial').AsString;
  EdtIdCountry.Text := SPSelect.FieldByName('IdCountry').AsString;
  EdtCountry.Text := SPSelect.FieldByName('Country').AsString;
end;

end.
