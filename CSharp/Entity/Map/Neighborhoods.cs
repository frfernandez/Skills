using Entity.Objects;
using Database;
using Objects;

namespace Entity.Map
{
    public class Neighborhoods : IdNameTuple
    {
        public Neighborhoods()
        {
        }

        public Neighborhoods(Command commandDb)
            : base(commandDb)
        {
            FormText = "Neighborhoods";
            ProcedureInsert = "InsNeighborhoods";
            ProcedureUpdate = "UpdNeighborhoods";
            ProcedureDelete = "DelNeighborhoods";
            ProcedureFilter = "FltNeighborhoods";
            ParameterId = "Id";
            ParameterCRUD = "Text";
            ParameterFilter = "Name";
            UpperCase = true;
            DataGridField = "Neighborhood";
            TableConfigSearch = "Neighborhoods";

            Config();
        }
    }
}
