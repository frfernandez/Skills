using Entity.Objects;
using Database;
using Objects;

namespace Entity.Person
{
    public class Persons : IdNameTuple
    {
        public Persons()
        {
        }

        public Persons(Command commandDb)
            : base(commandDb)
        {
            FormText = "Persons";
            MessageId = "";
            MessageName = "A pessoa deverá ser informada !";
            ProcedureInsert = "InsPersons";
            ProcedureUpdate = "UpdPersons";
            ProcedureDelete = "DelPersons";
            ProcedureFilter = "FltPersons";
            ParameterId = "Id";
            ParameterCRUD = "Text";
            ParameterFilter = "Name";
            UpperCase = true;
            DataGridField = "Person";
            TableConfigSearch = "Persons";

            Config();
        }
    }
}
