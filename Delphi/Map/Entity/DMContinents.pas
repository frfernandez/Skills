unit DMContinents;

interface

uses
  SysUtils, Classes, DB, ADODB, DMConnection, Variants;

type
  TContinentsDM = class(TDataModule)
    ContinentsInsert: TADOStoredProc;
    ContinentsUpdate: TADOStoredProc;
    ContinentsDelete: TADOStoredProc;
    ContinentsFilter: TADOStoredProc;
  private
    { Private declarations }
  public
    { Public declarations }
  end;

var
  ContinentsDM: TContinentsDM;

implementation

{$R *.dfm}

end.
