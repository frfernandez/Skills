unit Simple;

interface

uses
  Windows, Messages, SysUtils, Variants, Classes, Graphics, Controls, Forms,
  Dialogs, ExtCtrls, StdCtrls, Buttons, ADODB;

type
  TSimpleF = class(TForm)
    PnlPanel1: TPanel;
    Bevel1: TBevel;
    ScBScrollBox1: TScrollBox;
    BtnIUD: TBitBtn;
    BtnCancel: TBitBtn;
    BtnExit: TBitBtn;
    BtnFilter: TBitBtn;
    PnlPanel2: TPanel;
    ScBScrollBox2: TScrollBox;
    LblDescription: TLabel;
    EdtDescription: TEdit;
    ImgInsert: TImage;
    ImgUpdate: TImage;
    ImgDelete: TImage;
    EdtId: TEdit;
    procedure FormShow(Sender: TObject);
    procedure FormKeyPress(Sender: TObject; var Key: Char);
    procedure BtnIUDClick(Sender: TObject);
    procedure BtnCancelClick(Sender: TObject);
    procedure BtnExitClick(Sender: TObject);
    procedure BtnFilterClick(Sender: TObject);
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
    ColumName: String;
    SPInsert: TADOStoredProc;
    SPUpdate: TADOStoredProc;
    SPDelete: TADOStoredProc;
    SPSelect: TADOStoredProc;
  end;

var
  SimpleF: TSimpleF;

implementation

uses SearchDataList, DB, Components;

{$R *.dfm}

procedure TSimpleF.FormShow(Sender: TObject);
begin
  Config;
end;

procedure TSimpleF.FormKeyPress(Sender: TObject; var Key: Char);
begin
  if (Key = #13) then
    BtnIUDClick(Sender)
  else if (Key = #27) then
    BtnExitClick(Sender);
end;

procedure TSimpleF.BtnIUDClick(Sender: TObject);
begin
  if (CRUDConfig = True) then
    Clear;
end;

procedure TSimpleF.BtnCancelClick(Sender: TObject);
begin
  Clear;
end;

procedure TSimpleF.BtnExitClick(Sender: TObject);
begin
  Close;
end;

procedure TSimpleF.BtnFilterClick(Sender: TObject);
var
  SearchDataListF: TSearchDataListF;
begin
  SearchDataListF := TSearchDataListF.Create(Self);
  try
    SearchDataListF.SPSelect := SPSelect;
    SearchDataListF.Caption := CaptionCopy;
    SearchDataListF.ColumName := ColumName;
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

procedure TSimpleF.Config;
begin
  CaptionCopy := Caption;
  EdtDescription.MaxLength := SPInsert.Parameters.ParamByName('@Text').Size;

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

function TSimpleF.CRUDConfig: Boolean;
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
      StoredProc.Parameters.ParamByName('@Text').Value := Trim(EdtDescription.Text)
    else
      Exit;
  end;

  if (Result = True) then
  begin
    StoredProc.ExecProc;
    StoredProc.Prepared := False;
  end;
end;

procedure TSimpleF.Clear;
var
  I: Integer;
begin
  CRUDRecord := 'I';

  for I := 0 to Screen.ActiveForm.ComponentCount - 1 do
  begin
    if Screen.ActiveForm.FindComponent(Screen.ActiveForm.Components[I].Name) is TEdit then
      TEdit(Screen.ActiveForm.FindComponent(Screen.ActiveForm.Components[I].Name)).Text := '';
  end;
end;

procedure TSimpleF.Data;
begin
  EdtId.Text := SPSelect.Fields[0].AsString;
  EdtDescription.Text := SPSelect.Fields[1].AsString;
end;

end.
