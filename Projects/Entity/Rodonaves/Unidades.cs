using System;
using System.Data;
using System.Windows.Forms;
using Database;
using Database.Entity;
using Objects;
using Objects.Enumerator;

namespace Entity.Rodonaves
{
    public class Unidades : IDisposable
    {
        public string Codigo { get; set; }
        public string Nome { get; set; }
        public string Ativa { get; set; }

        public Command CommandDb;
        public DataTables Configuration;
        public string Form;
        public SystemEnum Task;
        public string SelectDataTableId;

        public Unidades()
        {
        }

        public Unidades(Command commandDb, DataTables configuration)
        {
            CommandDb = commandDb;
            Configuration = configuration;

            string TableConfigDuplicate = "Unidades";
            string FormText = "Unidades";
            string ParameterId = "Codigo";
            string DataGridField = "Nome";
            string TypeViewFilter = Configuration.TableCommand.UniqueValue(Configuration.TableConfig, String.Concat(CommandDb.User, "|", "SELECT_LIKE".ToUpper()));

            AppConfigs AppConfig = new AppConfigs(CommandDb, Configuration);
            AppConfig.Save(TableConfigDuplicate, "FormText", FormText);
            AppConfig.Save(TableConfigDuplicate, "ParameterId", ParameterId);
            AppConfig.Save(TableConfigDuplicate, "DataGridField", DataGridField);
            AppConfig.Save(TableConfigDuplicate, "TypeViewFilter", TypeViewFilter);

            if (TypeViewFilter == "N")
                SelectDataTableId = "";
            else
                SelectDataTableId = "0";
        }

        public bool Save(string codigo, string nome, string ativa)
        {
            bool Result = false;

            Codigo = codigo;
            Nome = nome;
            Ativa = ativa;

            if (String.IsNullOrEmpty(Nome) == true)
                MessageBox.Show("O nome da unidade deverá ser informado.");
            else if (String.IsNullOrEmpty(Ativa) == true)
                MessageBox.Show("A atividade da unidade deverá ser informada.");
            else
                Result = true;

            return Result;
        }

        public void Insert()
        {
            IDbCommand CommandIDb = CommandDb.CommandConfig("P", "InsUnidades");

            try
            {
                CommandDb.ParameterInput(CommandIDb, "Nome", Nome.ToUpper());
                CommandDb.ParameterInput(CommandIDb, "Ativa", Ativa.ToUpper());
                CommandIDb.ExecuteNonQuery();
            }
            finally
            {
                CommandIDb.Dispose();
            }
        }

        public void Update()
        {
            IDbCommand CommandIDb = CommandDb.CommandConfig("P", "UpdUnidades");

            try
            {
                CommandDb.ParameterInput(CommandIDb, "Codigo", Codigo);
                CommandDb.ParameterInput(CommandIDb, "Nome", Nome.ToUpper());
                CommandDb.ParameterInput(CommandIDb, "Ativa", Ativa.ToUpper());
                CommandIDb.ExecuteNonQuery();
            }
            finally
            {
                CommandIDb.Dispose();
            }
        }

        public void Delete()
        {
            IDbCommand CommandIDb = CommandDb.CommandConfig("P", "DelUnidades");

            try
            {
                CommandDb.ParameterInput(CommandIDb, "Codigo", Codigo);
                CommandIDb.ExecuteNonQuery();
            }
            finally
            {
                CommandIDb.Dispose();
            }
        }

        public DataTable SelectDataTable(string codigo, string nome, string ativa)
        {
            DataTable Result;
            string TypeViewFilter;
            IDbCommand CommandIDb = CommandDb.CommandConfig("P", "FltUnidades");

            Codigo = codigo;
            Nome = nome;
            Ativa = ativa;

            if (Configuration.TableCommand.Find(Configuration.TableConfig, String.Concat(CommandDb.User, "|", "SELECT_LIKE")) == true)
                TypeViewFilter = Configuration.TableCommand.UniqueValue(Configuration.TableConfig, String.Concat(CommandDb.User, "|", "SELECT_LIKE".ToUpper()));
            else
                TypeViewFilter = "N";

            try
            {
                CommandDb.ParameterInput(CommandIDb, "Codigo", Codigo);
                CommandDb.ParameterInput(CommandIDb, "Nome", Nome.ToUpper());
                CommandDb.ParameterInput(CommandIDb, "Ativa", Ativa.ToUpper());
                CommandDb.ParameterInput(CommandIDb, "Search", TypeViewFilter);
                Result = CommandDb.DataSetDb(CommandIDb, "P").Tables[0];
                Configuration.TableCommand.PrimaryColumnKey(Result, "Unidade");
            }
            finally
            {
                CommandIDb.Dispose();
            }

            return Result;
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
