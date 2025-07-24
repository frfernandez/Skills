/*========================================================================*/

Use EmpireXP;

Go

/*========================================================================*/

Create Procedure dbo.LstUnidadesOrder
As
begin
  Execute dbo.FltUnidades 0, '', '', '';
end;

Go

/*========================================================================*/

Create View dbo.VwUnidades
As
  Select Upper(a.LabelDataGridRow) LabelDataGridRow,
         a.Parameter, a.ControlType,
		 a.PrimaryKey, a.Visible,
		 (case
		  when (Select c.Max_Length
                From Sys.Procedures b (NoLock)
                Join Sys.Parameters c (NoLock) On b.Object_Id = c.Object_Id
                Where b.Name = Upper('FltUnidades')
                  And SubString(c.Name, 2, Len(c.Name)) = a.Parameter) > 0 then
            (Select c.Max_Length
             From Sys.Procedures b (NoLock)
             Join Sys.Parameters c (NoLock) On b.Object_Id = c.Object_Id
             Where b.Name = Upper('FltUnidades')
               And SubString(c.Name, 2, Len(c.Name)) = a.Parameter)
          else
            0
          end) SizeParameter,
		 a.CharacterCasing, a.Mask,
		 a.Label1, a.Label2,
         a.Tip1, a.Tip2, a.Tip3,
		 a.SizeWidth1, a.SizeWidth2,
         a.TableName, a.ParameterId, a.ParameterName,
		 a.DataClass, a.SearchFormText,
		 'FltUnidades' ProcedureFilter, 'LstUnidadesOrder' ProcedureList,
		 'FltUnidades' ProcedureIndex,
         a.Minimum, a.Maximum
  From (Select 'Codigo da Unidade' LabelDataGridRow,
               'Codigo' Parameter, 'IdNome' ControlType,
			   'Y' PrimaryKey, 'Y' Visible,
               'Normal' CharacterCasing, '' Mask,
               'Código' Label1, 'Unidade' Label2,
               'Escreva o nome da unidade ' Tip1, 'Lista de todas unidades' Tip2, 'Unidade' Tip3,
		       80 SizeWidth1, 510 SizeWidth2,
			   'Unidades' TableName, 'Codigo' ParameterId, 'Unidade' ParameterName,
			   'Unidades' DataClass, 'Unidades' SearchFormText,
               Null Minimum, Null Maximum
        Union
        Select 'Unidade' LabelDataGridRow,
               'Nome' Parameter, 'Nome' ControlType,
			   'N' PrimaryKey, 'Y' Visible,
               'Upper' CharacterCasing, '' Mask,
               'Unidade' Label1, '' Label2,
               'Escreva parte do nome da unidade' Tip1, '' Tip2, '' Tip3,
		       510 SizeWidth1, 0 SizeWidth2,
			   '' TableName, '' ParameterId, '' ParameterName,
			   '' DataClass, '' SearchFormText,
               Null Minimum, Null Maximum
        Union
        Select 'Ativa' LabelDataGridRow,
               'Ativa' Parameter, 'Check' ControlType,
			   'N' PrimaryKey, 'Y' Visible,
		       'Normal' CharacterCasing, '' Mask,
		       'Ativa' Label1, '' Label2,
               'Marcado para ativo/Desmarcado para inativo' Tip1, 'Remove marcado/desmarcado' Tip2, '' Tip3,
		       80 SizeWidth1, 510 SizeWidth2,
			   '' TableName, '' ParameterId, '' ParameterName,
			   '' DataClass, '' SearchFormText,
               Null Minimum, Null Maximum) a;

Go

/*========================================================================*/

Create Procedure dbo.LstUsuariosOrder
As
begin
  Execute dbo.FltUsuarios 0, '', '', '';
end;

Go

/*========================================================================*/

Create View dbo.VwUsuarios
As
  Select Upper(a.LabelDataGridRow) LabelDataGridRow,
         a.Parameter, a.ControlType,
		 a.PrimaryKey, a.Visible,
		 (case
		  when (Select c.Max_Length
                From Sys.Procedures b (NoLock)
                Join Sys.Parameters c (NoLock) On b.Object_Id = c.Object_Id
                Where b.Name = Upper('FltUsuarios')
                  And SubString(c.Name, 2, Len(c.Name)) = a.Parameter) > 0 then
            (Select c.Max_Length
             From Sys.Procedures b (NoLock)
             Join Sys.Parameters c (NoLock) On b.Object_Id = c.Object_Id
             Where b.Name = Upper('FltUsuarios')
               And SubString(c.Name, 2, Len(c.Name)) = a.Parameter)
          else
            0
          end) SizeParameter,
		 a.CharacterCasing, a.Mask,
		 a.Label1, a.Label2,
         a.Tip1, a.Tip2, a.Tip3,
		 a.SizeWidth1, a.SizeWidth2,
         a.TableName, a.ParameterId, a.ParameterName,
		 a.DataClass, a.SearchFormText,
		 'FltUsuarios' ProcedureFilter, 'LstUsuariosOrder' ProcedureList,
		 'FltUsuarios' ProcedureIndex,
         a.Minimum, a.Maximum
  From (Select 'Codigo do Usuário' LabelDataGridRow,
               'Codigo' Parameter, 'IdNome' ControlType,
			   'Y' PrimaryKey, 'Y' Visible,
               'Normal' CharacterCasing, '' Mask,
               'Código' Label1, 'Usuário' Label2,
               'Escreva o nome do usuário ' Tip1, 'Lista de todos usuários' Tip2, 'Usuário' Tip3,
		       80 SizeWidth1, 510 SizeWidth2,
			   'Usuarios' TableName, 'Codigo' ParameterId, 'Usuarios' ParameterName,
			   'Usuarios' DataClass, 'Usuários' SearchFormText,
               Null Minimum, Null Maximum
        Union
        Select 'Usuário' LabelDataGridRow,
               'Nome' Parameter, 'Nome' ControlType,
			   'N' PrimaryKey, 'Y' Visible,
               'Upper' CharacterCasing, '' Mask,
               'Usuário' Label1, '' Label2,
               'Escreva parte do nome do usuário' Tip1, '' Tip2, '' Tip3,
		       510 SizeWidth1, 0 SizeWidth2,
			   '' TableName, '' ParameterId, '' ParameterName,
			   '' DataClass, '' SearchFormText,
               Null Minimum, Null Maximum
        Union
        Select 'Status' LabelDataGridRow,
               'Status' Parameter, 'Check' ControlType,
			   'N' PrimaryKey, 'Y' Visible,
		       'Normal' CharacterCasing, '' Mask,
		       'Status' Label1, '' Label2,
               'Marcado para status ativo/Desmarcado para status inativo' Tip1, 'Remove marcado/desmarcado' Tip2, '' Tip3,
		       80 SizeWidth1, 510 SizeWidth2,
			   '' TableName, '' ParameterId, '' ParameterName,
			   '' DataClass, '' SearchFormText,
               Null Minimum, Null Maximum) a;

Go

/*========================================================================*/

Create Procedure dbo.LstColaboradoresOrder
As
begin
  Execute dbo.FltColaboradores 0, '', Null, Null, '';
end;

Go

/*========================================================================*/

Create View dbo.VwColaboradores
As
  Select Upper(a.LabelDataGridRow) LabelDataGridRow,
         a.Parameter, a.ControlType,
		 a.PrimaryKey, a.Visible,
		 (case
		  when (Select c.Max_Length
                From Sys.Procedures b (NoLock)
                Join Sys.Parameters c (NoLock) On b.Object_Id = c.Object_Id
                Where b.Name = Upper('FltColaboradores')
                  And SubString(c.Name, 2, Len(c.Name)) = a.Parameter) > 0 then
            (Select c.Max_Length
             From Sys.Procedures b (NoLock)
             Join Sys.Parameters c (NoLock) On b.Object_Id = c.Object_Id
             Where b.Name = Upper('FltColaboradores')
               And SubString(c.Name, 2, Len(c.Name)) = a.Parameter)
          else
            0
          end) SizeParameter,
		 a.CharacterCasing, a.Mask,
		 a.Label1, a.Label2,
         a.Tip1, a.Tip2, a.Tip3,
		 a.SizeWidth1, a.SizeWidth2,
         a.TableName, a.ParameterId, a.ParameterName,
		 a.DataClass, a.SearchFormText,
		 'FltColaboradores' ProcedureFilter, 'LstColaboradoresOrder' ProcedureList,
		 'FltColaboradores' ProcedureIndex,
         a.Minimum, a.Maximum
  From (Select 'Codigo do colaborador' LabelDataGridRow,
               'Codigo' Parameter, 'IdNome' ControlType,
			   'Y' PrimaryKey, 'Y' Visible,
               'Normal' CharacterCasing, '' Mask,
               'Código' Label1, 'colaborador' Label2,
               'Escreva o nome do colaborador ' Tip1, 'Lista de todos colaboradores' Tip2, 'Colaborador' Tip3,
		       80 SizeWidth1, 510 SizeWidth2,
			   'Colaboradores' TableName, 'Codigo' ParameterId, 'Colaboradores' ParameterName,
			   'Colaboradores' DataClass, 'Colaboradores' SearchFormText,
               Null Minimum, Null Maximum
        Union
        Select 'Colaborador' LabelDataGridRow,
               'Nome' Parameter, 'Nome' ControlType,
			   'N' PrimaryKey, 'Y' Visible,
               'Upper' CharacterCasing, '' Mask,
               'Colaborador' Label1, '' Label2,
               'Escreva parte do nome do colaborador' Tip1, '' Tip2, '' Tip3,
		       510 SizeWidth1, 0 SizeWidth2,
			   '' TableName, '' ParameterId, '' ParameterName,
			   '' DataClass, '' SearchFormText,
               Null Minimum, Null Maximum) a;

Go

/*========================================================================*/
