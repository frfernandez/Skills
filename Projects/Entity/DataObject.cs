using System;
using Database;
using Database.Entity;
using Objects;
using Objects.Enumerator;

namespace Entity
{
    public class DataObject : IDisposable
    {
        public Command CommandDb;
        public DataTables Configuration;
        public string FormText;
        public int IdProject;
        public int IdMessageId;
        public int IdMessageName;
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
        public string TypeViewFilter = "N";
        public string Form;
        public SystemEnum Task;
        public string SelectDataTableId;
        public string CommandText;

        public DataObject()
        {
        }

        public DataObject(Command commandDb, DataTables configuration)
        {
            CommandDb = commandDb;
            Configuration = configuration;

            if (Configuration.TableCommand.Find(Configuration.TableConfig, String.Concat(CommandDb.User, "|", "SELECT_LIKE")) == true)
                TypeViewFilter = Configuration.TableCommand.UniqueValue(Configuration.TableConfig, String.Concat(CommandDb.User, "|", "SELECT_LIKE".ToUpper()));
        }

        public void Config()
        {
            AppConfigs AppConfig = new AppConfigs(CommandDb, Configuration);
            AppConfig.Save(TableConfigSearch, "FormText", FormText);
            AppConfig.Save(TableConfigSearch, "ParameterId", ParameterId);
            AppConfig.Save(TableConfigSearch, "DataGridField", DataGridField);
            AppConfig.Save(TableConfigSearch, "TypeViewFilter", TypeViewFilter);

            if (TypeViewFilter == "N")
                SelectDataTableId = "";
            else
                SelectDataTableId = "0";

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
