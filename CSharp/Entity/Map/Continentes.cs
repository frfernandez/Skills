using Entity.Objects;
using Database;

namespace Entity.Map
{
    public class Continentes : IdNameTuple
    {
        public Continentes()
        {
        }

        public Continentes(Command commandDb)
            : base(commandDb)
        {
            FormText = "Continentes";
            MessageId = "";
            MessageName = "O bairro deverá ser informado !";
            ProcedureInsert = "IncContinentes";
            ProcedureUpdate = "AltContinentes";
            ProcedureDelete = "ExcContinentes";
            ProcedureFilter = "FltContinentes";
            ParameterId = "Codigo";
            ParameterCRUD = "Descricao";
            ParameterFilter = "Nome";
            DataGridField = "Continente";
            TableConfigSearch = "Continentes";

            Config();
        }
    }
}
