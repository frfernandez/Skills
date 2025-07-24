unit Components;

interface

uses
  SysUtils, Forms, Dialogs, StdCtrls, Mask;

type
  NoForm = class(TForm);
    function Save: Boolean;

implementation

function Save: Boolean;
var
  I: Integer;
  MessageHint: String;
begin
  for I := Screen.ActiveForm.ComponentCount - 1 downto 0 do
  begin
    if Screen.ActiveForm.FindComponent(Screen.ActiveForm.Components[I].Name) is TEdit then
    begin
      if ((Trim(TEdit(Screen.ActiveForm.FindComponent(Screen.ActiveForm.Components[I].Name)).Text) = '') and
          (Trim(TEdit(Screen.ActiveForm.FindComponent(Screen.ActiveForm.Components[I].Name)).Hint) <> '')) then
      begin
        MessageHint := Trim(TEdit(Screen.ActiveForm.FindComponent(Screen.ActiveForm.Components[I].Name)).Hint);

        TEdit(Screen.ActiveForm.FindComponent(Screen.ActiveForm.Components[I].Name)).SetFocus;
      end;
    end
    else if Screen.ActiveForm.FindComponent(Screen.ActiveForm.Components[I].Name) is TMaskEdit then
    begin
      if ((Trim(TMaskEdit(Screen.ActiveForm.FindComponent(Screen.ActiveForm.Components[I].Name)).Text) = '') and
          (Trim(TMaskEdit(Screen.ActiveForm.FindComponent(Screen.ActiveForm.Components[I].Name)).Hint) <> '')) then
      begin
        MessageHint := Trim(TMaskEdit(Screen.ActiveForm.FindComponent(Screen.ActiveForm.Components[I].Name)).Hint);

        TMaskEdit(Screen.ActiveForm.FindComponent(Screen.ActiveForm.Components[I].Name)).SetFocus;
      end;
    end;
  end;

  if (Trim(MessageHint) = '') then
    Result := True
  else
  begin
    MessageDlg(MessageHint, mtError, [mbOk], 0);

    Result := False;
  end;
end;

end.
