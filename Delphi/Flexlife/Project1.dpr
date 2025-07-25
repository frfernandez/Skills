program Project1;

uses
  Forms,
  Cliente in 'Cliente.pas' {MainF};

{$R *.RES}

begin
  Application.Initialize;
  Application.CreateForm(TMainF, MainF);
  Application.Run;
end.
