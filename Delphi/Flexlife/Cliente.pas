unit Cliente;

interface

uses
  Windows, Messages, SysUtils, Classes, Graphics, Controls, Forms, Dialogs,
  Db, StdCtrls, Buttons, ExtCtrls, ComCtrls, Grids, DBGrids,
  ADODB, Spin, Mask;

type
  TMainF = class(TForm)
    PgCPageControl: TPageControl;
    TbSListaClientes: TTabSheet;
    TbSCadastroClientes: TTabSheet;
    TbSCadastroContatos: TTabSheet;
    PnlPanel1: TPanel;
    ScBScrollBox1: TScrollBox;
    SpBCodigo: TSpeedButton;
    SpBNome: TSpeedButton;
    LblCodigoNome: TLabel;
    PnlPanel2: TPanel;
    ScBScrollBox2: TScrollBox;
    DBGGradeClientes: TDBGrid;
    PnlPanel4: TPanel;
    ScBScrollBox4: TScrollBox;
    SpECodigoLista: TSpinEdit;
    Connection: TADOConnection;
    EdtNomeLista: TEdit;
    LblCodigoCliente: TLabel;
    SpECodigoCliente: TSpinEdit;
    LblNomeCliente: TLabel;
    EdtNomeCliente: TEdit;
    LblDataCadastroCliente: TLabel;
    MkEDataCadastroCliente: TMaskEdit;
    LblObservacaoCliente: TLabel;
    MmoObservacaoCliente: TMemo;
    TabClientes: TADOTable;
    TabCliContatos: TADOTable;
    DSClientes: TDataSource;
    DSCliContatos: TDataSource;
    PnlPanel3: TPanel;
    ScBScrollBox3: TScrollBox;
    SpBInsertCliente: TSpeedButton;
    SpBUpdateCliente: TSpeedButton;
    SpBDeleteCliente: TSpeedButton;
    ButSaveCliente: TButton;
    PnlPanel6: TPanel;
    ScBScrollBox6: TScrollBox;
    DBGGradeContatos: TDBGrid;
    PnlPanel7: TPanel;
    ScBScrollBox7: TScrollBox;
    LblNomeContato: TLabel;
    EdtNomeContato: TEdit;
    LblCargoContato: TLabel;
    EdtCargoContato: TEdit;
    LblEmailContato: TLabel;
    EdtEmailContato: TEdit;
    TabClientesId_Clientes: TAutoIncField;
    TabClientesCodigo: TIntegerField;
    TabClientesNome: TStringField;
    TabClientesData_Cadastro: TDateTimeField;
    TabClientesObservacao: TMemoField;
    TabCliContatosId_CliContatos: TAutoIncField;
    TabCliContatosId_Clientes: TIntegerField;
    TabCliContatosNome: TStringField;
    TabCliContatosCargo: TStringField;
    TabCliContatosEmail: TStringField;
    PnlPanel5: TPanel;
    ScBScrollBox5: TScrollBox;
    SpBInsertContato: TSpeedButton;
    SpBUpdateContato: TSpeedButton;
    SpBDeleteContato: TSpeedButton;
    ButSaveContato: TButton;
    procedure FormShow(Sender: TObject);
    procedure SpBCodigoClick(Sender: TObject);
    procedure SpBNomeClick(Sender: TObject);
    procedure FormClose(Sender: TObject; var Action: TCloseAction);
    procedure SpECodigoListaChange(Sender: TObject);
    procedure EdtNomeListaChange(Sender: TObject);
    procedure PgCPageControlChange(Sender: TObject);
    procedure SpBInsertClienteClick(Sender: TObject);
    procedure SpBUpdateClienteClick(Sender: TObject);
    procedure SpBDeleteClienteClick(Sender: TObject);
    procedure ButSaveClienteClick(Sender: TObject);
    procedure FormKeyPress(Sender: TObject; var Key: Char);
    procedure DBGGradeContatosCellClick(Column: TColumn);
    procedure ButSaveContatoClick(Sender: TObject);
    procedure SpBDeleteContatoClick(Sender: TObject);
  private
    { Private declarations }
    procedure ReadOnly(OnlyRead: Boolean);
    procedure Data;
    procedure Clear;
    procedure Enable;
    function Save: Boolean;
  public
    { Public declarations }
  end;

var
  MainF: TMainF;

implementation

{$R *.DFM}

procedure TMainF.FormShow(Sender: TObject);
begin
  Connection.Connected := True;
  TabClientes.Active := True;
  TabCliContatos.Active := True;

  SpBCodigoClick(Sender);
  PgCPageControl.ActivePage := TbSListaClientes;
  ReadOnly(True);
end;

procedure TMainF.FormKeyPress(Sender: TObject; var Key: Char);
begin
  if (Key = #27) then
    Close;
end;

procedure TMainF.SpBCodigoClick(Sender: TObject);
begin
  LblCodigoNome.Caption := SpBCodigo.Caption + ':';
  EdtNomeLista.Visible := False;
  SpECodigoLista.Visible := True;
end;

procedure TMainF.SpBNomeClick(Sender: TObject);
begin
  LblCodigoNome.Caption := SpBNome.Caption + ':';
  SpECodigoLista.Visible := False;
  EdtNomeLista.Visible := True;
end;

procedure TMainF.SpECodigoListaChange(Sender: TObject);
begin
  if (IntToStr(SpECodigoLista.Value) <> '') then
    TabClientes.Locate('Codigo', SpECodigoLista.Value, [loCaseInsensitive, loPartialKey]);
end;

procedure TMainF.EdtNomeListaChange(Sender: TObject);
begin
  TabClientes.Locate('Nome', EdtNomeLista.Text, [loCaseInsensitive, loPartialKey]);
end;

procedure TMainF.PgCPageControlChange(Sender: TObject);
begin
  if (TabClientes.EOF = False) then
  begin
    TabCliContatos.Filtered := False;
    TabCliContatos.Filter := 'Id_Clientes = ' + TabClientes.FieldByName('Id_Clientes').AsString;
    TabCliContatos.Filtered := True;
  end;

  Data;
  ReadOnly(True);
  Enable;
end;

procedure TMainF.DBGGradeContatosCellClick(Column: TColumn);
begin
  Enable;
  Data;
end;

procedure TMainF.SpBInsertClienteClick(Sender: TObject);
begin
  if (TabClientes.RecordCount = 0) then
  begin
    Enable;
    PgCPageControl.ActivePage := TbSCadastroClientes;
    SpBInsertCliente.Down := True;
  end;

  ReadOnly(False);
  Clear;
end;

procedure TMainF.SpBUpdateClienteClick(Sender: TObject);
var
  Count: Integer;
begin
  Count := TabClientes.RecordCount;

  if (PgCPageControl.ActivePage = TbSCadastroContatos) then
  begin
    if (Count = 0) then
      PgCPageControl.ActivePage := TbSCadastroClientes
    else
      Count := TabCliContatos.RecordCount;
  end;

  if (Count = 0) then
  begin
    Enable;
    SpBInsertClienteClick(nil);

    if (PgCPageControl.ActivePage = TbSCadastroClientes) then
      SpBInsertCliente.Down := True
    else if (PgCPageControl.ActivePage = TbSCadastroContatos) then
      SpBInsertContato.Down := True;
  end
  else
    Data;

  ReadOnly(False);
end;

procedure TMainF.SpBDeleteClienteClick(Sender: TObject);
begin
  PgCPageControlChange(Sender);

  if (TabCliContatos.RecordCount = 0) then
  begin
    if (TabClientes.RecordCount > 0) then
      TabClientes.Delete;

    Clear;
    Data;
  end
  else
    MessageDlg('O cliente não pode ser excluído pois há ao menos um contato cadastrado.', mtError, [mbOk], 0);

  Enable;
end;

procedure TMainF.SpBDeleteContatoClick(Sender: TObject);
begin
  if (TabCliContatos.RecordCount > 0) then
    TabCliContatos.Delete;

  Enable;
  Data;
end;

procedure TMainF.ButSaveClienteClick(Sender: TObject);
begin
  if (Save = True) then
  begin
    if (SpBInsertCliente.Down = True) then
      TabClientes.Insert
    else if (SpBUpdateCliente.Down = True) then
      TabClientes.Edit;

    TabClientes.FieldByName('Codigo').AsString := SpECodigoCliente.Text;
    TabClientes.FieldByName('Nome').AsString := EdtNomeCliente.Text;
    TabClientes.FieldByName('Data_Cadastro').AsString := MkEDataCadastroCliente.Text;
    TabClientes.FieldByName('Observacao').AsString := MmoObservacaoCliente.Text;
    TabClientes.Post;

    Enable;
  end;
end;

procedure TMainF.ButSaveContatoClick(Sender: TObject);
begin
  if (Save = True) then
  begin
    if (SpBInsertContato.Down = True) then
      TabCliContatos.Insert
    else if (SpBUpdateContato.Down = True) then
      TabCliContatos.Edit;

    TabCliContatos.FieldByName('Id_Clientes').AsString := TabClientes.FieldByName('Id_Clientes').AsString;
    TabCliContatos.FieldByName('Nome').AsString := EdtNomeContato.Text;
    TabCliContatos.FieldByName('Cargo').AsString := EdtCargoContato.Text;
    TabCliContatos.FieldByName('Email').AsString := EdtEmailContato.Text;
    TabCliContatos.Post;

    Enable;
  end;
end;

procedure TMainF.FormClose(Sender: TObject; var Action: TCloseAction);
begin
  Connection.Connected := False;
  Application.ProcessMessages;
  Action := caFree;
end;

procedure TMainF.ReadOnly(OnlyRead: Boolean);
begin
  if ((PgCPageControl.ActivePage = TbSListaClientes) or
      (PgCPageControl.ActivePage = TbSCadastroClientes)) then
  begin
    ButSaveCliente.Enabled := True;

    if (SpBInsertCliente.Down = True) then
      SpECodigoCliente.ReadOnly := False
    else
      SpECodigoCliente.ReadOnly := True;

    EdtNomeCliente.ReadOnly := OnlyRead;
    MkEDataCadastroCliente.ReadOnly := OnlyRead;
    MmoObservacaoCliente.ReadOnly := OnlyRead;
  end;

  if ((PgCPageControl.ActivePage = TbSListaClientes) or
      (PgCPageControl.ActivePage = TbSCadastroContatos)) then
  begin
    ButSaveContato.Enabled := True;

    EdtNomeContato.ReadOnly := OnlyRead;
    EdtCargoContato.ReadOnly := OnlyRead;
    EdtEmailContato.ReadOnly := OnlyRead;
  end;
end;

procedure TMainF.Data;
begin
  if (PgCPageControl.ActivePage = TbSCadastroClientes) then
  begin
    if (TabClientes.EOF = False) then
    begin
      SpECodigoCliente.Value := TabClientes.FieldByName('Codigo').AsInteger;
      EdtNomeCliente.Text := TabClientes.FieldByName('Nome').AsString;
      MkEDataCadastroCliente.Text := TabClientes.FieldByName('Data_Cadastro').AsString;
      MmoObservacaoCliente.Text := TabClientes.FieldByName('Observacao').AsString;
    end;
  end
  else if (PgCPageControl.ActivePage = TbSCadastroContatos) then
  begin
    if (TabCliContatos.EOF = False) then
    begin
      EdtNomeContato.Text := TabCliContatos.FieldByName('Nome').AsString;
      EdtCargoContato.Text := TabCliContatos.FieldByName('Cargo').AsString;
      EdtEmailContato.Text := TabCliContatos.FieldByName('Email').AsString;
    end;
  end;
end;

procedure TMainF.Clear;
begin
  if (PgCPageControl.ActivePage = TbSCadastroClientes) then
  begin
    SpECodigoCliente.Value := SpECodigoCliente.MinValue;
    EdtNomeCliente.Text := '';
    MkEDataCadastroCliente.Text := '';
    MmoObservacaoCliente.Text := '';
  end
  else if (PgCPageControl.ActivePage = TbSCadastroContatos) then
  begin
    EdtNomeContato.Text := '';
    EdtCargoContato.Text := '';
    EdtEmailContato.Text := '';
  end;
end;

procedure TMainF.Enable;
begin
  if (PgCPageControl.ActivePage = TbSCadastroClientes) then
  begin
    SpBInsertCliente.Down := False;
    SpBUpdateCliente.Down := False;
    SpBDeleteCliente.Down := False;

    ButSaveCliente.Enabled := False;
  end
  else if (PgCPageControl.ActivePage = TbSCadastroContatos) then
  begin
    SpBInsertContato.Down := False;
    SpBUpdateContato.Down := False;
    SpBDeleteContato.Down := False;

    ButSaveContato.Enabled := False;
  end;
end;

function TMainF.Save: Boolean;
var
  MessageHint: String;
begin
  if (PgCPageControl.ActivePage = TbSCadastroClientes) then
  begin
    if (Trim(SpECodigoCliente.Text) = '') then
      MessageHint := SpECodigoCliente.Hint
    else if (Trim(EdtNomeCliente.Text) = '') then
      MessageHint := EdtNomeCliente.Hint;

    if ((SpBInsertCliente.Down = True) and (Trim(MessageHint) = '')) then
    begin
      if (TabClientes.Locate('Codigo', SpECodigoCliente.Value, []) = True) then
        MessageHint := 'Código de cliente já cadastrado.';
    end;
  end
  else if (PgCPageControl.ActivePage = TbSCadastroContatos) then
  begin
    if (Trim(EdtNomeContato.Text) = '') then
      MessageHint := EdtNomeContato.Hint;
  end;

  if (Trim(MessageHint) = '') then
  begin
    ReadOnly(True);

    Result := True;
  end
  else
  begin
    MessageDlg(MessageHint, mtError, [mbOk], 0);

    Result := False;
  end;
end;

end.
