unit MapMain;

interface

uses
  Windows, Messages, SysUtils, Variants, Classes, Graphics, Controls, Forms,
  Dialogs, Menus, ADODB;

type
  TMainF = class(TForm)
    MainMenu1: TMainMenu;
    databaseMenu1: TMenuItem;
    databaseCountriesMenu1: TMenuItem;
    databaseStatesMenu1: TMenuItem;
    databaseCitiesMenu1: TMenuItem;
    searchMenu1: TMenuItem;
    searchCountriesMenu1: TMenuItem;
    searchStatesMenu1: TMenuItem;
    searchCitiesMenu1: TMenuItem;
    exitMenu1: TMenuItem;
    procedure FormShow(Sender: TObject);
    procedure FormClose(Sender: TObject; var Action: TCloseAction);
    procedure exitMenu1Click(Sender: TObject);
    procedure FormKeyPress(Sender: TObject; var Key: Char);
    procedure databaseCountriesMenu1Click(Sender: TObject);
    procedure databaseStatesMenu1Click(Sender: TObject);
    procedure databaseCitiesMenu1Click(Sender: TObject);
  private
    { Private declarations }
  public
    { Public declarations }
  end;

var
  MainF: TMainF;

implementation

uses DMConnection, DMContinents, Simple, Countries, DMCountries, States, DMStates,
  DMCities, Cities;

{$R *.dfm}

procedure TMainF.FormShow(Sender: TObject);
begin
  Application.CreateForm(TConnectionDM, ConnectionDM);
end;

procedure TMainF.FormKeyPress(Sender: TObject; var Key: Char);
begin
  if (Key = #27) then
    exitMenu1Click(Sender);
end;

procedure TMainF.exitMenu1Click(Sender: TObject);
begin
  Close;
end;

procedure TMainF.FormClose(Sender: TObject; var Action: TCloseAction);
begin
  ConnectionDM.Free;
  Application.ProcessMessages;
  Action := caFree;
end;

procedure TMainF.databaseCountriesMenu1Click(Sender: TObject);
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

procedure TMainF.databaseStatesMenu1Click(Sender: TObject);
var
  StatesF: TStatesF;
begin
  StatesF := TStatesF.Create(Self);
  try
    Application.CreateForm(TStatesDM, StatesDM);

    StatesF.SPInsert := StatesDM.StatesInsert;
    StatesF.SPUpdate := StatesDM.StatesUpdate;
    StatesF.SPDelete := StatesDM.StatesDelete;
    StatesF.SPSelect := StatesDM.StatesFilter;
    StatesF.CRUDRecord := 'I';
    StatesF.ShowModal;
  finally
    StatesF.Free;
    StatesDM.Free;
  end;
end;

procedure TMainF.databaseCitiesMenu1Click(Sender: TObject);
var
  CitiesF: TCitiesF;
begin
  CitiesF := TCitiesF.Create(Self);
  try
    Application.CreateForm(TCitiesDM, CitiesDM);

    CitiesF.SPInsert := CitiesDM.CitiesInsert;
    CitiesF.SPUpdate := CitiesDM.CitiesUpdate;
    CitiesF.SPDelete := CitiesDM.CitiesDelete;
    CitiesF.SPSelect := CitiesDM.CitiesFilter;
    CitiesF.CRUDRecord := 'I';
    CitiesF.ShowModal;
  finally
    CitiesF.Free;
    CitiesDM.Free;
  end;
end;

end.
