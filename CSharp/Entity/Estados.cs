using System;
using System.Data;
using Database;
using Database.Entity;
using Objects;
using Objects.Enumerator;

namespace Entity.Map
{
    public class Estados : IDisposable
    {
        public string Codigo { get; set; }
        public string Estado { get; set; }
        public string Sigla { get; set; }
        public DataTables Configuration { get; set; }
        public Paises Pais { get; private set; }

        public Command CommandDb;
        public Messages MessagesDb;
        public string Formulario;
        public string Equipamento;
        public SystemEnum Task;

        public Estados()
        {
        }

        public Estados(Command commandDb, Messages messagesDb, DataTables configuration)
        {
            CommandDb = commandDb;
            MessagesDb = messagesDb;
            Configuration = configuration;

            string TableConfigSearch = "Estados";
            string FormText = "Estados";
            string ParameterId = "Codigo";
            string DataGridField = "Estado";
            string TypeViewFilter = Configuration.TableCommand.UniqueValue(Configuration.TableConfig, String.Concat(CommandDb.User, "|", "SELECT_LIKE".ToUpper()));

            AppConfigs AppConfig = new AppConfigs(CommandDb, Configuration);
            AppConfig.Save(TableConfigSearch, "FormText", FormText);
            AppConfig.Save(TableConfigSearch, "ParameterId", ParameterId);
            AppConfig.Save(TableConfigSearch, "DataGridField", DataGridField);
            AppConfig.Save(TableConfigSearch, "TypeViewFilter", TypeViewFilter);
        }

        public bool Save(string codigo, string estado, string sigla, Paises pais)
        {
            bool Result = false;

            Codigo = codigo;
            Estado = estado;
            Sigla = sigla;
            Pais = pais;

            if (String.IsNullOrEmpty(Estado) == true)
                MessagesDb.GetMessage(Formulario, Equipamento, Task, 2, 10);
            else if (String.IsNullOrEmpty(Sigla) == true)
                MessagesDb.GetMessage(Formulario, Equipamento, Task, 2, 12);
            else if (String.IsNullOrEmpty(Pais.Codigo.ToString()) == true)
                MessagesDb.GetMessage(Formulario, Equipamento, Task, 2, 9);
            else
                Result = true;

            return Result;
        }

        public void Insert()
        {
            IDbCommand CommandIDb = CommandDb.CommandConfig("P", "IncEstados");

            try
            {
                CommandDb.ParameterInput(CommandIDb, "Estado", Estado.ToUpper());
                CommandDb.ParameterInput(CommandIDb, "Sigla", Sigla.ToUpper());
                CommandDb.ParameterInput(CommandIDb, "CodigoPais", Pais.Codigo.ToString());
                CommandIDb.ExecuteNonQuery();
            }
            finally
            {
                CommandIDb.Dispose();
                CommandDb.AccessSystem.AccessDataIns(Formulario, SystemEnum.Table_Insert, CommandDb.Procedure, "Estado", Estado.ToUpper());
            }
        }

        public void Update()
        {
            IDbCommand CommandIDb = CommandDb.CommandConfig("P", "AltEstados");

            try
            {
                CommandDb.ParameterInput(CommandIDb, "Codigo", Codigo);
                CommandDb.ParameterInput(CommandIDb, "Estado", Estado.ToUpper());
                CommandDb.ParameterInput(CommandIDb, "Sigla", Sigla.ToUpper());
                CommandDb.ParameterInput(CommandIDb, "CodigoPais", Pais.Codigo.ToString());
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
            IDbCommand CommandIDb = CommandDb.CommandConfig("P", "ExcEstados");

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

        public DataTable SelectDataTable(string codigo, string estado, string sigla, Paises pais)
        {
            DataTable Result;
            string TypeViewFilter;
            IDbCommand CommandIDb = CommandDb.CommandConfig("P", "FltEstados");

            Codigo = codigo;
            Estado = estado;
            Sigla = sigla;
            Pais = pais;

            if (Configuration.TableCommand.Find(Configuration.TableConfig, String.Concat(CommandDb.User, "|", "SELECT_LIKE")) == true)
                TypeViewFilter = Configuration.TableCommand.UniqueValue(Configuration.TableConfig, String.Concat(CommandDb.User, "|", "SELECT_LIKE".ToUpper()));
            else
                TypeViewFilter = "R";

            try
            {
                CommandDb.ParameterInput(CommandIDb, "Codigo", Codigo);
                CommandDb.ParameterInput(CommandIDb, "Nome", Estado.ToUpper());
                CommandDb.ParameterInput(CommandIDb, "Sigla", Sigla.ToUpper());

                if ((Pais == null) || (Pais.Codigo == null))
                    CommandDb.ParameterInput(CommandIDb, "CodigoPais", "");
                else
                    CommandDb.ParameterInput(CommandIDb, "CodigoPais", Pais.Codigo.ToString());

                CommandDb.ParameterInput(CommandIDb, "Consulta", TypeViewFilter);
                Result = CommandDb.DataSetDb(CommandIDb, "P").Tables[0];
                Configuration.TableCommand.PrimaryColumnKey(Result, "Estado;Sigla;CodigoPais");
            }
            finally
            {
                CommandIDb.Dispose();
                CommandDb.AccessSystem.AccessIns(Formulario, SystemEnum.Table_Select);
            }

            return Result;
        }

        public string SelectName(string codigo, Paises pais)
        {
            string Result = "";
            DataTable Table;
            string CommandText = String.Concat(" Select Estado",
                                               " From ", CommandDb.ObjectLocation.Position(CommandType.Text, "Estados"),
                                               " Where Codigo     = @Codigo",
                                               "   And CodigoPais = @CodigoPais");

            IDbCommand CommandIDb = CommandDb.CommandConfig("C", CommandText);

            Codigo = codigo;
            Pais = pais;

            try
            {
                CommandDb.ParameterInput(CommandIDb, "Codigo", Codigo);

                if ((Pais == null) || (Pais.Codigo == null))
                    CommandDb.ParameterInput(CommandIDb, "CodigoPais", "");
                else
                    CommandDb.ParameterInput(CommandIDb, "CodigoPais", Pais.Codigo.ToString());

                Table = CommandDb.DataSetDb(CommandIDb, "C").Tables[0];

                if (Table.Rows.Count > 0)
                    Result = Table.Rows[0]["Estado"].ToString();
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
