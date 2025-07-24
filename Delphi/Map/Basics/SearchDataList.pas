unit SearchDataList;

interface

uses
  Windows, Messages, SysUtils, Variants, Classes, Graphics, Controls, Forms,
  Dialogs, Grids, DBGrids, StdCtrls, Buttons, ExtCtrls, ADODB, DB, Spin;

type
  TSearchDataListF = class(TForm)
    PnlPanel1: TPanel;
    Bevel1: TBevel;
    ScBScrollBox1: TScrollBox;
    BtnExit: TBitBtn;
    BtnSelect: TBitBtn;
    PnlPanel2: TPanel;
    ScBScrollBox2: TScrollBox;
    LblDescription: TLabel;
    EdtDescription: TEdit;
    LblMinimum: TLabel;
    SEdMinimum: TSpinEdit;
    PnlPanel3: TPanel;
    ScBScrollBox3: TScrollBox;
    DBGDataGrid: TDBGrid;
    RdGRecord: TRadioGroup;
    RdGFilter: TRadioGroup;
    procedure FormShow(Sender: TObject);
    procedure FormKeyPress(Sender: TObject; var Key: Char);
    procedure BtnExitClick(Sender: TObject);
    procedure FormDestroy(Sender: TObject);
    procedure EdtDescriptionChange(Sender: TObject);
    procedure BtnSelectClick(Sender: TObject);
    procedure RdGFilterClick(Sender: TObject);
    procedure DBGDataGridDblClick(Sender: TObject);
  private
    { Private declarations }
    procedure Config;
    procedure DataGridConfig;
    procedure Filter;
  public
    { Public declarations }
    SPSelect: TADOStoredProc;
    DSDataSource: TDataSource;
    ColumName: String;
  end;

var
  SearchDataListF: TSearchDataListF;

implementation

{$R *.dfm}

procedure TSearchDataListF.FormShow(Sender: TObject);
begin
  Config;
  Filter;
end;

procedure TSearchDataListF.FormKeyPress(Sender: TObject; var Key: Char);
begin
  if (Key = #13) then
    BtnSelectClick(Sender)
  else if (Key = #27) then
    BtnExitClick(Sender);
end;

procedure TSearchDataListF.BtnSelectClick(Sender: TObject);
begin
  if (SPSelect.EOF) then
    SPSelect.Close;

  Close;
end;

procedure TSearchDataListF.BtnExitClick(Sender: TObject);
begin
  SPSelect.Close;

  Close;
end;

procedure TSearchDataListF.RdGFilterClick(Sender: TObject);
begin
  Filter;
end;

procedure TSearchDataListF.EdtDescriptionChange(Sender: TObject);
begin
  if ((RdGFilter.ItemIndex = 3) and (SPSelect.Active = True)) then
    SPSelect.Locate(ColumName, EdtDescription.Text, [loCaseInsensitive, loPartialKey])
  else
    Filter;
end;

procedure TSearchDataListF.DBGDataGridDblClick(Sender: TObject);
begin
  BtnSelectClick(Sender);
end;

procedure TSearchDataListF.Config;
begin
  DSDataSource := TDataSource.Create(Self);
  DSDataSource.DataSet := SPSelect;
  DBGDataGrid.DataSource := DSDataSource;
end;

procedure TSearchDataListF.DataGridConfig;
var
  I: Integer;
begin
  for I := 0 to DBGDataGrid.Columns.Count - 1 do
  begin
    if (I <> 1) then
      DBGDataGrid.Columns[I].Visible := False;
  end;
end;

procedure TSearchDataListF.Filter;
var
  I: Integer;
begin
  SPSelect.Close;

  if (Length(EdtDescription.Text) >= SEdMinimum.Value) then
  begin
    SPSelect.Parameters.Refresh;

    for I := 0 to SPSelect.Parameters.Count - 1 do
    begin
      if (SPSelect.Parameters[I].DataType = ftInteger) then
        SPSelect.Parameters[I].Value := null
      else if (SPSelect.Parameters[I].DataType = ftString) then
        SPSelect.Parameters[I].Value := '';
    end;

    SPSelect.Parameters.ParamByName('@Name').Value := EdtDescription.Text;
      
    if (RdGFilter.ItemIndex = 0) then
      SPSelect.Parameters.ParamByName('@Search').Value := 'S'
    else if (RdGFilter.ItemIndex = 1) then
      SPSelect.Parameters.ParamByName('@Search').Value := 'E'
    else if (RdGFilter.ItemIndex = 2) then
      SPSelect.Parameters.ParamByName('@Search').Value := 'B'
    else if (RdGFilter.ItemIndex = 3) then
      SPSelect.Parameters.ParamByName('@Search').Value := 'N';

    SPSelect.Open;

    DataGridConfig;
  end;
end;

procedure TSearchDataListF.FormDestroy(Sender: TObject);
begin
  DSDataSource.Free;
end;

end.
