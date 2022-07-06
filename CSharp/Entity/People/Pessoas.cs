using Entity.Objects;
using Database;

namespace Entity.People
{
    public class Pessoas : IdNameTuple
    {
        public Pessoas()
        {
        }

        public Pessoas(Command commandDb)
            : base(commandDb)
        {
            FormText = "Pessoas";
            MessageId = "";
            MessageName = "A pessoa deverá ser informada !";
            ProcedureInsert = "IncPessoas";
            ProcedureUpdate = "AltPessoas";
            ProcedureDelete = "ExcPessoas";
            ProcedureFilter = "FltPessoas";
            ParameterId = "Codigo";
            ParameterCRUD = "Descricao";
            ParameterFilter = "Nome";
            DataGridField = "Pessoa";
            TableConfigSearch = "Pessoas";

            Config();
        }
    }
}
