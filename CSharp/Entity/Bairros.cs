using Entity.Objects;
using Database;
using Objects;

namespace Entity.Map
{
    public class Bairros : IdNameTuple
    {
        public Bairros()
        {
        }

        public Bairros(Command commandDb, Messages messagesDb, DataTables configuration)
            : base(commandDb, messagesDb, configuration)
        {
            FormText = "Bairros";
            IdProject = 2;
            IdMessageId = 0;
            IdMessageName = 27;
            ProcedureInsert = "IncBairros";
            ProcedureUpdate = "AltBairros";
            ProcedureDelete = "ExcBairros";
            ProcedureFilter = "FltBairros";
            ParameterId = "Codigo";
            ParameterCRUD = "Descricao";
            ParameterFilter = "Nome";
            DataGridField = "Bairro";
            TableConfigSearch = "Bairros";

            Config();
        }
    }
}
