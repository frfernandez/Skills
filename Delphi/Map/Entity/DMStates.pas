unit DMStates;

interface

uses
  SysUtils, Classes, DB, ADODB, DMConnection, Variants;

type
  TStatesDM = class(TDataModule)
    StatesInsert: TADOStoredProc;
    StatesUpdate: TADOStoredProc;
    StatesDelete: TADOStoredProc;
    StatesFilter: TADOStoredProc;
  private
    { Private declarations }
  public
    { Public declarations }
  end;

var
  StatesDM: TStatesDM;

implementation

{$R *.dfm}

end.
