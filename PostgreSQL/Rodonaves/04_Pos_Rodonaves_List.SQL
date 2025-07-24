Create Function Public.LstUnidadesOrder()
Returns Table
(
CodigoLst Integer,
NomeLst Varchar(50),
AtivaLst Char(1)
)
Language PLPGSQL
As $$
begin
  Return Query
  Select Codigo, Nome, Ativa
  From Public.FltUnidades(0, '', '', '');
end;$$;

/*========================================================================*/

Select *
From Information_Schema.Parameters
Where Specific_Name Like Lower('FltUnidade%')
  And Parameter_Mode  = 'IN'
Order By Ordinal_Position;

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

/*========================================================================*/
