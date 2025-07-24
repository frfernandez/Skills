using System;
using System.Data;
using System.Windows.Forms;
using Database;
using Database.Entity;
using Objects;
using Objects.Enumerator;

namespace Entity.Rodonaves
{
    public class Colaboradores : IDisposable
    {
        public string Codigo { get; set; }
        public string Nome { get; set; }
        private Usuarios Usuario { get; set; }
        private Unidades Unidade { get; set; }

        public Command CommandDb;
        public DataTables Configuration;
        public string Form;
        public SystemEnum Task;
        public string SelectDataTableId;

        public Colaboradores()
        {
        }

        public Colaboradores(Command commandDb, DataTables configuration)
        {
            CommandDb = commandDb;
            Configuration = configuration;

            string TableConfigSearch = "Colaboradores";
            string FormText = "Colaboradores";
            string ParameterId = "Id";
            string DataGridField = "Colaborador";
            string TypeViewFilter = Configuration.TableCommand.UniqueValue(Configuration.TableConfig, String.Concat(CommandDb.User, "|", "SELECT_LIKE".ToUpper()));

            AppConfigs AppConfig = new AppConfigs(CommandDb, Configuration);
            AppConfig.Save(TableConfigSearch, "FormText", FormText);
            AppConfig.Save(TableConfigSearch, "ParameterId", ParameterId);
            AppConfig.Save(TableConfigSearch, "DataGridField", DataGridField);
            AppConfig.Save(TableConfigSearch, "TypeViewFilter", TypeViewFilter);

            if (TypeViewFilter == "N")
                SelectDataTableId = "";
            else
                SelectDataTableId = "0";
        }

        public bool Save(string codigo, string nome, Usuarios usuario, Unidades unidade)
        {
            bool Result = false;

            Codigo = codigo;
            Nome = nome;
            Usuario = usuario;
            Unidade = unidade;

            if (String.IsNullOrEmpty(Nome) == true)
                MessageBox.Show("O nome do colaborador deverá ser informado.");
            else if (String.IsNullOrEmpty(Usuario.Codigo.ToString()) == true)
                MessageBox.Show("O código do usuário deverá ser informado.");
            else if (String.IsNullOrEmpty(Unidade.Codigo.ToString()) == true)
                MessageBox.Show("O código da unidade deverá ser informado.");
            else
                Result = true;

            return Result;
        }

        public void Insert()
        {
            IDbCommand CommandIDb = CommandDb.CommandConfig("P", "InsColaboradores");

            try
            {
                CommandDb.ParameterInput(CommandIDb, "Nome", Nome.ToUpper());
                CommandDb.ParameterInput(CommandIDb, "CodigoUsuario", Usuario.Codigo.ToString());
                CommandDb.ParameterInput(CommandIDb, "CodigoUnidade", Unidade.Codigo.ToString());
                CommandIDb.ExecuteNonQuery();
            }
            finally
            {
                CommandIDb.Dispose();
            }
        }

        public void Update()
        {
            IDbCommand CommandIDb = CommandDb.CommandConfig("P", "UpdColaboradores");

            try
            {
                CommandDb.ParameterInput(CommandIDb, "Codigo", Codigo);
                CommandDb.ParameterInput(CommandIDb, "Nome", Nome.ToUpper());
                CommandDb.ParameterInput(CommandIDb, "CodigoUsuario", Usuario.Codigo.ToString());
                CommandDb.ParameterInput(CommandIDb, "CodigoUnidade", Unidade.Codigo.ToString());
                CommandIDb.ExecuteNonQuery();
            }
            finally
            {
                CommandIDb.Dispose();
            }
        }

        public void Delete()
        {
            IDbCommand CommandIDb = CommandDb.CommandConfig("P", "DelColaboradores");

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

        public DataTable SelectDataTable(string codigo, string nome, Usuarios usuario, Unidades unidade)
        {
            DataTable Result;
            string TypeViewFilter;
            IDbCommand CommandIDb = CommandDb.CommandConfig("P", "FltColaboradores");

            Codigo = codigo;
            Nome = nome;
            Usuario = usuario;
            Unidade = unidade;

            if (Configuration.TableCommand.Find(Configuration.TableConfig, String.Concat(CommandDb.User, "|", "SELECT_LIKE")) == true)
                TypeViewFilter = Configuration.TableCommand.UniqueValue(Configuration.TableConfig, String.Concat(CommandDb.User, "|", "SELECT_LIKE".ToUpper()));
            else
                TypeViewFilter = "N";

            try
            {
                CommandDb.ParameterInput(CommandIDb, "Codigo", Codigo);
                CommandDb.ParameterInput(CommandIDb, "Nome", Nome.ToUpper());

                if ((Usuario is null) || (String.IsNullOrEmpty(Usuario.Codigo.ToString()) == true))
                    CommandDb.ParameterInput(CommandIDb, "CodigoUsuario", "");
                else
                    CommandDb.ParameterInput(CommandIDb, "CodigoUsuario", Usuario.Codigo.ToString());

                if ((Unidade is null) || (String.IsNullOrEmpty(Unidade.Codigo.ToString()) == true))
                    CommandDb.ParameterInput(CommandIDb, "CodigoUnidade", "");
                else
                    CommandDb.ParameterInput(CommandIDb, "CodigoUnidade", Unidade.Codigo.ToString());

                CommandDb.ParameterInput(CommandIDb, "Search", TypeViewFilter);
                Result = CommandDb.DataSetDb(CommandIDb, "P").Tables[0];
                Configuration.TableCommand.PrimaryColumnKey(Result, "Codigo");
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
