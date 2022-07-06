using Entity.Objects;
using Database;

namespace Entity.Map
{
    public class Bairros : IdNameTuple
    {
        public Bairros()
        {
        }

        public Bairros(Command commandDb)
            : base(commandDb)
        {
            FormText = "Bairros";
            MessageId = "";
            MessageName = "O bairro deverá ser informado !";
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
