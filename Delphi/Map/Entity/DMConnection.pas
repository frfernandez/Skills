unit DMConnection;

interface

uses
  SysUtils, Classes, DB, ADODB;

type
  TConnectionDM = class(TDataModule)
    Connection: TADOConnection;
    procedure DataModuleCreate(Sender: TObject);
    procedure DataModuleDestroy(Sender: TObject);
  private
    { Private declarations }
  public
    { Public declarations }
  end;

var
  ConnectionDM: TConnectionDM;

implementation

uses SearchDataList;

{$R *.dfm}

procedure TConnectionDM.DataModuleCreate(Sender: TObject);
begin
  Connection.Open;
end;

procedure TConnectionDM.DataModuleDestroy(Sender: TObject);
begin
  Connection.Close;
end;

end.
