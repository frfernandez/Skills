using Entity.Objects;
using Database;
using Objects;

namespace Entity.Map
{
    public class Enderecos : IdNameTuple
    {
        public Enderecos()
        {
        }

        public Enderecos(Command commandDb, Messages messagesDb, DataTables configuration)
            : base(commandDb, messagesDb, configuration)
        {
            FormText = "Endereços";
            IdProject = 2;
            IdMessageId = 0;
            IdMessageName = 27;
            ProcedureInsert = "IncEnderecos";
            ProcedureUpdate = "AltEnderecos";
            ProcedureDelete = "ExcEnderecos";
            ProcedureFilter = "FltEnderecos";
            ParameterId = "Codigo";
            ParameterCRUD = "Descricao";
            ParameterFilter = "Nome";
            DataGridField = "Endereco";
            TableConfigSearch = "Enderecos";

            Config();
        }
    }
}
