using System;
using System.Data;
using Database;
using Database.Entity;
using Objects;
using Objects.Enumerator;

namespace Entity.Map
{
    public class Cidades : IDisposable
    {
        public string Codigo { get; set; }
        public string Cidade { get; set; }
        public DataTables Configuration { get; set; }
        public Estados Estado { get; private set; }
        public Paises Pais { get; private set; }
        public Continentes Continente { get; private set; }

        public Command CommandDb;
        public Messages MessagesDb;
        public string Formulario;
        public string Equipamento;
        public SystemEnum Task;

        public Cidades()
        {
        }

        public Cidades(Command commandDb, Messages messagesDb, DataTables configuration)
        {
            CommandDb = commandDb;
            MessagesDb = messagesDb;
            Configuration = configuration;

            string TableConfigSearch = "Cidades";
            string FormText = "Cidades";
            string ParameterId = "Codigo";
            string DataGridField = "Cidade";
            string TypeViewFilter = Configuration.TableCommand.UniqueValue(Configuration.TableConfig, String.Concat(CommandDb.User, "|", "SELECT_LIKE".ToUpper()));

            AppConfigs AppConfig = new AppConfigs(CommandDb, Configuration);
            AppConfig.Save(TableConfigSearch, "FormText", FormText);
            AppConfig.Save(TableConfigSearch, "ParameterId", ParameterId);
            AppConfig.Save(TableConfigSearch, "DataGridField", DataGridField);
            AppConfig.Save(TableConfigSearch, "TypeViewFilter", TypeViewFilter);
        }

        public bool Save(string codigo, string cidade, Estados estado)
        {
            bool Result = false;

            Codigo = codigo;
            Cidade = cidade;
            Estado = estado;

            if (String.IsNullOrEmpty(Cidade) == true)
                MessagesDb.GetMessage(Formulario, Equipamento, Task, 2, 11);
            else if (String.IsNullOrEmpty(Estado.Codigo.ToString()) == true)
                MessagesDb.GetMessage(Formulario, Equipamento, Task, 2, 10);
            else
                Result = true;

            return Result;
        }

        public void Insert()
        {
            IDbCommand CommandIDb = CommandDb.CommandConfig("P", "IncCidades");

            try
            {
                CommandDb.ParameterInput(CommandIDb, "Cidade", Cidade.ToUpper());
                CommandDb.ParameterInput(CommandIDb, "CodigoEstado", Estado.Codigo.ToString());
                CommandIDb.ExecuteNonQuery();
            }
            finally
            {
                CommandIDb.Dispose();
                CommandDb.AccessSystem.AccessDataIns(Formulario, SystemEnum.Table_Insert, CommandDb.Procedure, "Cidade", Cidade.ToUpper());
            }
        }

        public void Update()
        {
            IDbCommand CommandIDb = CommandDb.CommandConfig("P", "AltCidades");

            try
            {
                CommandDb.ParameterInput(CommandIDb, "Codigo", Codigo);
                CommandDb.ParameterInput(CommandIDb, "Cidade", Cidade.ToUpper());
                CommandDb.ParameterInput(CommandIDb, "CodigoEstado", Estado.Codigo.ToString());
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
            IDbCommand CommandIDb = CommandDb.CommandConfig("P", "ExcCidades");

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

        public DataTable SelectDataTable(string codigo, string cidade, Estados estado, Paises pais, Continentes continente)
        {
            DataTable Result;
            string TypeViewFilter;
            IDbCommand CommandIDb = CommandDb.CommandConfig("P", "FltCidades");

            Codigo = codigo;
            Cidade = cidade;
            Estado = estado;
            Pais = pais;
            Continente = continente;

            if (Configuration.TableCommand.Find(Configuration.TableConfig, String.Concat(CommandDb.User, "|", "SELECT_LIKE")) == true)
                TypeViewFilter = Configuration.TableCommand.UniqueValue(Configuration.TableConfig, String.Concat(CommandDb.User, "|", "SELECT_LIKE".ToUpper()));
            else
                TypeViewFilter = "R";

            try
            {
                CommandDb.ParameterInput(CommandIDb, "Codigo", Codigo);
                CommandDb.ParameterInput(CommandIDb, "Nome", Cidade.ToUpper());

                if ((Estado == null) || (Estado.Codigo == null))
                    CommandDb.ParameterInput(CommandIDb, "CodigoEstado", "");
                else
                    CommandDb.ParameterInput(CommandIDb, "CodigoEstado", Estado.Codigo.ToString());

                if ((Pais == null) || (Pais.Codigo == null))
                    CommandDb.ParameterInput(CommandIDb, "CodigoPais", "");
                else
                    CommandDb.ParameterInput(CommandIDb, "CodigoPais", Pais.Codigo.ToString());

                if ((Continente == null) || (Continente.Id == null))
                    CommandDb.ParameterInput(CommandIDb, "CodigoContinente", "");
                else
                    CommandDb.ParameterInput(CommandIDb, "CodigoContinente", Continente.Id.ToString());

                CommandDb.ParameterInput(CommandIDb, "Consulta", TypeViewFilter);
                Result = CommandDb.DataSetDb(CommandIDb, "P").Tables[0];
                Configuration.TableCommand.PrimaryColumnKey(Result, "Cidade;CodigoEstado;CodigoPais");
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
            string CommandText = String.Concat(" Select Cidade",
                                               " From ", CommandDb.ObjectLocation.Position(CommandType.Text, "Cidades"),
                                               " Where Codigo = @Codigo");

            IDbCommand CommandIDb = CommandDb.CommandConfig("C", CommandText);

            Codigo = codigo;

            try
            {
                CommandDb.ParameterInput(CommandIDb, "Codigo", Codigo);
                Table = CommandDb.DataSetDb(CommandIDb, "C").Tables[0];

                if (Table.Rows.Count > 0)
                    Result = Table.Rows[0]["Cidade"].ToString();
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
