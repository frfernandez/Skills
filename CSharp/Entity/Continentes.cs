using Entity.Objects;
using Database;
using Objects;

namespace Entity.Map
{
    public class Continentes : IdNameTuple
    {
        public Continentes()
        {
        }

        public Continentes(Command commandDb, Messages messagesDb, DataTables configuration)
            : base(commandDb, messagesDb, configuration)
        {
            FormText = "Continentes";
            IdProject = 2;
            IdMessageId = 0;
            IdMessageName = 27;
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
