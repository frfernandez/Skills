unit DataProcedures;

interface

uses
  Forms, ADODB, DB, Variants;

type
  NoForm = class(TForm);
    procedure Filter(SPFilter: TADOStoredProc; Id: String);

implementation

procedure Filter(SPFilter: TADOStoredProc; Id: String);
var
  I: Integer;
begin
  SPFilter.Parameters.Refresh;

  for I := 0 to SPFilter.Parameters.Count - 1 do
  begin
    if (SPFilter.Parameters[I].DataType = ftInteger) then
      SPFilter.Parameters[I].Value := null
    else if (SPFilter.Parameters[I].DataType = ftString) then
      SPFilter.Parameters[I].Value := '';
  end;

  SPFilter.Parameters.ParamByName('@Id').Value := Id;
  SPFilter.Parameters.ParamByName('@Search').Value := 'N';

  SPFilter.ExecProc;
  SPFilter.Open;
  SPFilter.First;
end;

end.
