using Entity.Objects;
using Database;

namespace Entity.Map
{
    public class Addresses : IdNameTuple
    {
        public Addresses()
        {
        }

        public Addresses(Command commandDb)
            : base(commandDb)
        {
            FormText = "Addresses";
            ProcedureInsert = "InsAddresses";
            ProcedureUpdate = "UpdAddresses";
            ProcedureDelete = "delAddresses";
            ProcedureFilter = "FltAddresses";
            ParameterId = "Id";
            ParameterCRUD = "Text";
            ParameterFilter = "Name";
            UpperCase = true;
            DataGridField = "Address";
            TableConfigSearch = "Addresses";

            Config();
        }
    }
}
