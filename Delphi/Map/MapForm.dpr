program MapForm;

uses
  Forms,
  MapMain in 'MapMain.pas' {MainF},
  Simple in 'Basics\Simple.pas' {SimpleF},
  SearchDataList in 'Basics\SearchDataList.pas' {SearchDataListF},
  Countries in 'Form\Countries.pas' {CountriesF},
  DMConnection in 'Entity\DMConnection.pas' {ConnectionDM: TDataModule},
  DMContinents in 'Entity\DMContinents.pas' {ContinentsDM: TDataModule},
  DMCountries in 'Entity\DMCountries.pas' {CountriesDM: TDataModule},
  DataProcedures in 'Entity\DataProcedures.pas',
  States in 'Form\States.pas' {StatesF},
  DMStates in 'Entity\DMStates.pas' {StatesDM: TDataModule},
  DMCities in 'Entity\DMCities.pas' {CitiesDM: TDataModule},
  Cities in 'Form\Cities.pas' {CitiesF},
  Components in 'Basics\Components.pas';

{$R *.res}

begin
  Application.Initialize;
  Application.Title := 'Map';
  Application.CreateForm(TMainF, MainF);
  Application.Run;
end.
