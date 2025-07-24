unit DMCountries;

interface

uses
  SysUtils, Classes, DB, ADODB, DMConnection, Variants;

type
  TCountriesDM = class(TDataModule)
    CountriesInsert: TADOStoredProc;
    CountriesUpdate: TADOStoredProc;
    CountriesDelete: TADOStoredProc;
    CountriesFilter: TADOStoredProc;
  private
    { Private declarations }
  public
    { Public declarations }
  end;

var
  CountriesDM: TCountriesDM;

implementation

{$R *.dfm}

end.
