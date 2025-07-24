using System;
using System.Data;
using System.Windows.Forms;
using Database;
using Database.Entity;
using Objects;
using Objects.Enumerator;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Entity.Rodonaves
{
    public class Usuarios : IDisposable
    {
        public string Codigo { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public string Status { get; set; }

        public Command CommandDb;
        public DataTables Configuration;
        public string Form;
        public SystemEnum Task;
        public string SelectDataTableId;

        public Usuarios()
        {
        }

        public Usuarios(Command commandDb, DataTables configuration)
        {
            CommandDb = commandDb;
            Configuration = configuration;

            string TableConfigDuplicate = "Usuarios";
            string FormText = "Usuarios";
            string ParameterId = "Codigo";
            string DataGridField = "Login";
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

        public bool Save(string codigo, string login, string senha, string status)
        {
            bool Result = false;

            Codigo = codigo;
            Login = login;
            Senha = senha;
            Status = status;

            if (String.IsNullOrEmpty(Login) == true)
                MessageBox.Show("O login do usuário deverá ser informado.");
            else if (String.IsNullOrEmpty(Senha) == true)
                MessageBox.Show("A senha do usuário deverá ser informada.");
            else if (String.IsNullOrEmpty(Status) == true)
                MessageBox.Show("O status do usuário deverá ser informado.");
            else
                Result = true;

            return Result;
        }

        public void Insert()
        {
            IDbCommand CommandIDb = CommandDb.CommandConfig("P", "InsUsuarios");

            try
            {
                CommandDb.ParameterInput(CommandIDb, "Login", Login.ToUpper());
                CommandDb.ParameterInput(CommandIDb, "Senha", Senha);
                CommandDb.ParameterInput(CommandIDb, "Status", Status.ToUpper());
                CommandIDb.ExecuteNonQuery();
            }
            finally
            {
                CommandIDb.Dispose();
            }
        }

        public void Update()
        {
            IDbCommand CommandIDb = CommandDb.CommandConfig("P", "UpdUsuarios");

            try
            {
                CommandDb.ParameterInput(CommandIDb, "Codigo", Codigo);
                CommandDb.ParameterInput(CommandIDb, "Login", Login.ToUpper());
                CommandDb.ParameterInput(CommandIDb, "Senha", Senha);
                CommandDb.ParameterInput(CommandIDb, "Status", Status.ToUpper());
                CommandIDb.ExecuteNonQuery();
            }
            finally
            {
                CommandIDb.Dispose();
            }
        }

        public void Delete()
        {
            IDbCommand CommandIDb = CommandDb.CommandConfig("P", "DelUsuarios");

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

        public DataTable SelectDataTable(string codigo, string login, string status)
        {
            DataTable Result;
            string TypeViewFilter;
            IDbCommand CommandIDb = CommandDb.CommandConfig("P", "FltUsuarios");

            Codigo = codigo;
            Login = login;
            Status = status;

            if (Configuration.TableCommand.Find(Configuration.TableConfig, String.Concat(CommandDb.User, "|", "SELECT_LIKE")) == true)
                TypeViewFilter = Configuration.TableCommand.UniqueValue(Configuration.TableConfig, String.Concat(CommandDb.User, "|", "SELECT_LIKE".ToUpper()));
            else
                TypeViewFilter = "N";

            try
            {
                CommandDb.ParameterInput(CommandIDb, "Codigo", Codigo);
                CommandDb.ParameterInput(CommandIDb, "Login", Login.ToUpper());
                CommandDb.ParameterInput(CommandIDb, "Status", Status.ToUpper());
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
