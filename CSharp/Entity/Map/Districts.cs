using Entity.Objects;
using Database;
using Objects;

namespace Entity.Map
{
    public class Districts : IdNameTuple
    {
        public Districts()
        {
        }

        public Districts(Command commandDb)
            : base(commandDb)
        {
            FormText = "Districts";
            ProcedureInsert = "InsDistricts";
            ProcedureUpdate = "UpdDistricts";
            ProcedureDelete = "DelDistricts";
            ProcedureFilter = "FltDistricts";
            ParameterId = "Id";
            ParameterCRUD = "Text";
            ParameterFilter = "Name";
            UpperCase = true;
            DataGridField = "District";
            TableConfigSearch = "Districts";

            Config();
        }
    }
}
