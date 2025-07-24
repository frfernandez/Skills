using System;
using System.Data;
using Database;
using Entity.Rodonaves;
using Objects;
using Objects.Enumerator;

namespace Entity
{
    public class DataEntities : IDisposable
    {
        public Command CommandDb { get; set; }
        public DataTables Configuration { get; set; }
        public bool Initialize { get; set; }

        private Colaboradores Colaborador;
        private Unidades Unidade;
        private Usuarios Usuario;

        public DataEntities()
        {
        }

        public DataEntities(Command commandDb, DataTables configuration)
        {
            CommandDb = commandDb;
            Configuration = configuration;
        }

        public void AbstractEntity(string DataClass, string Form)
        {
            DataClass = DataClassTable(DataClass);

            if (DataClass == "Colaboradores".ToUpper())
            {
                Colaborador = new Colaboradores(CommandDb, Configuration);
                Colaborador.Form = Form;
                Colaborador.Task = SystemEnum.Table_Select;
            }
            else if (DataClass == "Unidades".ToUpper())
            {
                Unidade = new Unidades(CommandDb, Configuration);
                Unidade.Form = Form;
                Unidade.Task = SystemEnum.Table_Select;
            }
            else if (DataClass == "Usuarios".ToUpper())
            {
                Usuario = new Usuarios(CommandDb, Configuration);
                Usuario.Form = Form;
                Usuario.Task = SystemEnum.Table_Select;
            }
        }

        public DataTable SelectDataTable(string DataClass, string Id, string Description)
        {
            DataTable Result = null;

            DataClass = DataClassTable(DataClass);

            if (DataClass == "Colaboradores".ToUpper())
                Result = Colaborador.SelectDataTable(Id, Description, null, null);
            else if (DataClass == "Unidades".ToUpper())
                Result = Unidade.SelectDataTable(Id, Description, "");
            else if (DataClass == "Usuarios".ToUpper())
                Result = Usuario.SelectDataTable(Id, Description, "");

            return Result;
        }

        private string DataClassTable(string DataClass)
        {
            string Result = "";

            Result = DataClass.Replace(String.Concat(CommandDb.ConnectionDb.Database, "."), "");
            Result = Result.Substring(Result.IndexOf(".") + 1);
            Result = Result.ToUpper();

            return Result;
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
