using Entity.Objects;
using Database;

namespace Entity.Map
{
    public class TitulosEnderecos : IdNameTuple
    {
        public TitulosEnderecos()
        {
        }

        public TitulosEnderecos(Command commandDb)
            : base(commandDb)
        {
            FormText = "Títulos de Endereços";
            MessageId = "";
            MessageName = "O título do endereço deverá ser informado !";
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
