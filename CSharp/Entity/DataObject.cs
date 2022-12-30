using System;
using System.Data;
using Database;

namespace Entity
{
    public class DataObject : IDisposable
    {
        public Command CommandDb;
        public string FormText;
        public string MessageId;
        public string MessageName;
        public string ProcedureInsert;
        public string ProcedureUpdate;
        public string ProcedureDelete;
        public string ProcedureFilter;
        public string ParameterId;
        public string ParameterCRUD;
        public string ParameterFilter;
        public bool UpperCase;
        public string DataGridField;
        public string TableConfigSearch;
        public string CommandText;

        public DataObject()
        {
        }

        public DataObject(Command commandDb)
        {
            CommandDb = commandDb;
        }

        public void Config()
        {
            TableConfigSearch = CommandDb.ObjectLocation.Position(CommandType.Text, TableConfigSearch);

            CommandText = String.Concat(" Select ", DataGridField,
                                        " From ", TableConfigSearch,
                                        " Where ", ParameterId, " = @", ParameterId);
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
