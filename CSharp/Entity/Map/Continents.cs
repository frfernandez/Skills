using Entity.Objects;
using Database;
using Objects;

namespace Entity.Map
{
    public class Continents : IdNameTuple
    {
        public Continents()
        {
        }

        public Continents(Command commandDb)
            : base(commandDb)
        {
            FormText = "Continents";
            ProcedureInsert = "InsContinents";
            ProcedureUpdate = "UpdContinents";
            ProcedureDelete = "DelContinents";
            ProcedureFilter = "FltContinents";
            ParameterId = "Id";
            ParameterCRUD = "Text";
            ParameterFilter = "Name";
            UpperCase = true;
            DataGridField = "Continent";
            TableConfigSearch = "Continents";

            Config();
        }
    }
}
