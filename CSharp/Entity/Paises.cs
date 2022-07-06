using System;
using System.Data;
using Database;
using Database.Entity;
using Objects;
using Objects.Enumerator;

namespace Entity.Map
{
    public class Paises : IDisposable
    {
        public string Codigo { get; set; }
        public string Pais { get; set; }
        public string Sigla { get; set; }
        public DataTables Configuration { get; set; }
        public Continentes Continente { get; private set; }

        public Command CommandDb;
        public Messages MessagesDb;
        public string Formulario;
        public string Equipamento;
        public SystemEnum Task;

        public Paises()
        {
        }

        public Paises(Command commandDb, Messages messagesDb, DataTables configuration)
        {
            CommandDb = commandDb;
            MessagesDb = messagesDb;
            Configuration = configuration;

            string TableConfigSearch = "Paises";
            string FormText = "Países";
            string ParameterId = "Codigo";
            string DataGridField = "Pais";
            string TypeViewFilter = Configuration.TableCommand.UniqueValue(Configuration.TableConfig, String.Concat(CommandDb.User, "|", "SELECT_LIKE".ToUpper()));

            AppConfigs AppConfig = new AppConfigs(CommandDb, Configuration);
            AppConfig.Save(TableConfigSearch, "FormText", FormText);
            AppConfig.Save(TableConfigSearch, "ParameterId", ParameterId);
            AppConfig.Save(TableConfigSearch, "DataGridField", DataGridField);
            AppConfig.Save(TableConfigSearch, "TypeViewFilter", TypeViewFilter);
        }

        public bool Save(string codigo, string pais, string sigla, Continentes continente)
        {
            bool Result = false;

            Codigo = codigo;
            Pais = pais;
            Sigla = sigla;
            Continente = continente;

            if (String.IsNullOrEmpty(Pais) == true)
                MessagesDb.GetMessage(Formulario, Equipamento, Task, 2, 9);
            else if (String.IsNullOrEmpty(Sigla) == true)
                MessagesDb.GetMessage(Formulario, Equipamento, Task, 2, 12);
            else if (String.IsNullOrEmpty(Continente.Id.ToString()) == true)
                MessagesDb.GetMessage(Formulario, Equipamento, Task, 2, 8);
            else
                Result = true;

            return Result;
        }

        public void Insert()
        {
            IDbCommand CommandIDb = CommandDb.CommandConfig("P", "IncPaises");

            try
            {
                CommandDb.ParameterInput(CommandIDb, "Pais", Pais.ToUpper());
                CommandDb.ParameterInput(CommandIDb, "Sigla", Sigla.ToUpper());
                CommandDb.ParameterInput(CommandIDb, "CodigoContinente", Continente.Id.ToString());
                CommandIDb.ExecuteNonQuery();
            }
            finally
            {
                CommandIDb.Dispose();
                CommandDb.AccessSystem.AccessDataIns(Formulario, SystemEnum.Table_Insert, CommandDb.Procedure, "Pais", Pais.ToUpper());
            }
        }

        public void Update()
        {
            IDbCommand CommandIDb = CommandDb.CommandConfig("P", "AltPaises");

            try
            {
                CommandDb.ParameterInput(CommandIDb, "Codigo", Codigo);
                CommandDb.ParameterInput(CommandIDb, "Pais", Pais.ToUpper());
                CommandDb.ParameterInput(CommandIDb, "Sigla", Sigla.ToUpper());
                CommandDb.ParameterInput(CommandIDb, "CodigoContinente", Continente.Id.ToString());
                CommandIDb.ExecuteNonQuery();
            }
            finally
            {
                CommandIDb.Dispose();
                CommandDb.AccessSystem.AccessDataIns(Formulario, SystemEnum.Table_Update, CommandDb.Procedure, "Codigo", Codigo);
            }
        }

        public void Delete()
        {
            IDbCommand CommandIDb = CommandDb.CommandConfig("P", "ExcPaises");

            try
            {
                CommandDb.ParameterInput(CommandIDb, "Codigo", Codigo);
                CommandIDb.ExecuteNonQuery();
            }
            finally
            {
                CommandIDb.Dispose();
                CommandDb.AccessSystem.AccessDataIns(Formulario, SystemEnum.Table_Delete, CommandDb.Procedure, "Codigo", Codigo);
            }
        }

        public DataTable SelectDataTable(string codigo, string pais, string sigla, Continentes continente)
        {
            DataTable Result;
            string TypeViewFilter;
            IDbCommand CommandIDb = CommandDb.CommandConfig("P", "FltPaises");

            Codigo = codigo;
            Pais = pais;
            Sigla = sigla;
            Continente = continente;

            if (Configuration.TableCommand.Find(Configuration.TableConfig, String.Concat(CommandDb.User, "|", "SELECT_LIKE")) == true)
                TypeViewFilter = Configuration.TableCommand.UniqueValue(Configuration.TableConfig, String.Concat(CommandDb.User, "|", "SELECT_LIKE".ToUpper()));
            else
                TypeViewFilter = "R";

            try
            {
                CommandDb.ParameterInput(CommandIDb, "Codigo", Codigo);
                CommandDb.ParameterInput(CommandIDb, "Nome", Pais.ToUpper());
                CommandDb.ParameterInput(CommandIDb, "Sigla", Sigla.ToUpper());

                if ((Continente == null) || (Continente.Id == null))
                    CommandDb.ParameterInput(CommandIDb, "CodigoContinente", "");
                else
                    CommandDb.ParameterInput(CommandIDb, "CodigoContinente", Continente.Id.ToString());

                CommandDb.ParameterInput(CommandIDb, "Consulta", TypeViewFilter);
                Result = CommandDb.DataSetDb(CommandIDb, "P").Tables[0];
                Configuration.TableCommand.PrimaryColumnKey(Result, "Pais");
            }
            finally
            {
                CommandIDb.Dispose();
                CommandDb.AccessSystem.AccessIns(Formulario, SystemEnum.Table_Select);
            }

            return Result;
        }

        public string SelectName(string codigo)
        {
            string Result = "";
            DataTable Table;
            string CommandText = String.Concat(" Select Pais",
                                               " From ", CommandDb.ObjectLocation.Position(CommandType.Text, "Paises"),
                                               " Where Codigo = @Codigo");

            IDbCommand CommandIDb = CommandDb.CommandConfig("C", CommandText);

            Codigo = codigo;

            try
            {
                CommandDb.ParameterInput(CommandIDb, "Codigo", Codigo);
                Table = CommandDb.DataSetDb(CommandIDb, "C").Tables[0];

                if (Table.Rows.Count > 0)
                    Result = Table.Rows[0]["Pais"].ToString();
            }
            finally
            {
                CommandIDb.Dispose();
                CommandDb.AccessSystem.AccessIns(Formulario, SystemEnum.Table_Select);
            }

            return Result;
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
