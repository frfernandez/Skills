unit DMCities;

interface

uses
  SysUtils, Classes, DB, ADODB, DMConnection, Variants;

type
  TCitiesDM = class(TDataModule)
    CitiesInsert: TADOStoredProc;
    CitiesUpdate: TADOStoredProc;
    CitiesDelete: TADOStoredProc;
    CitiesFilter: TADOStoredProc;
  private
    { Private declarations }
  public
    { Public declarations }
  end;

var
  CitiesDM: TCitiesDM;

implementation

{$R *.dfm}

end.
