using Entity.Objects;
using Database;
using Objects;

namespace Entity.Map
{
    public class TitulosEnderecos : IdNameTuple
    {
        public TitulosEnderecos()
        {
        }

        public TitulosEnderecos(Command commandDb, Messages messagesDb, DataTables configuration)
            : base(commandDb, messagesDb, configuration)
        {
            FormText = "Títulos de Endereços";
            IdProject = 2;
            IdMessageId = 0;
            IdMessageName = 27;
            ProcedureInsert = "IncTitulosEnderecos";
            ProcedureUpdate = "AltTitulosEnderecos";
            ProcedureDelete = "ExcTitulosEnderecos";
            ProcedureFilter = "FltTitulosEnderecos";
            ParameterId = "Codigo";
            ParameterCRUD = "Descricao";
            ParameterFilter = "Nome";
            DataGridField = "Titulo";
            TableConfigSearch = "TitulosEnderecos";

            Config();
        }
    }
}
