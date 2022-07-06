using Entity.Objects;
using Database;

namespace Entity.Map
{
    public class Enderecos : IdNameTuple
    {
        public Enderecos()
        {
        }

        public Enderecos(Command commandDb)
            : base(commandDb)
        {
            FormText = "Endereços";
            MessageId = "";
            MessageName = "O endereço deverá ser informado !";
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
