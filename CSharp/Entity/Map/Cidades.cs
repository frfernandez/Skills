using System;
using System.Data;
using System.Windows.Forms;
using Database;

namespace Entity.Map
{
    public class Cidades : IDisposable
    {
        public string Codigo { get; set; }
        public string Cidade { get; set; }
        public Estados Estado { get; private set; }
        public Paises Pais { get; private set; }
        public Continentes Continente { get; private set; }

        public Command CommandDb;

        public Cidades()
        {
        }

        public Cidades(Command commandDb)
        {
            CommandDb = commandDb;
        }

        public bool Save(string codigo, string cidade, Estados estado)
        {
            bool Result = false;

            Codigo = codigo;
            Cidade = cidade;
            Estado = estado;

            if (String.IsNullOrEmpty(Cidade) == true)
                MessageBox.Show("A cidade deverá ser informada !");
            else if (String.IsNullOrEmpty(Estado.Codigo.ToString()) == true)
                MessageBox.Show("O estado deverá ser informado !");
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
            }
        }

        public DataTable SelectDataTable(string codigo, string cidade)
        {
            DataTable Result;
            IDbCommand CommandIDb = CommandDb.CommandConfig("P", "FltCidades");

            Codigo = codigo;
            Cidade = cidade;

            try
            {
                CommandDb.ParameterInput(CommandIDb, "Codigo", Codigo);
                CommandDb.ParameterInput(CommandIDb, "Nome", Cidade.ToUpper());
                Result = CommandDb.DataSetDb(CommandIDb, "P").Tables[0];
            }
            finally
            {
                CommandIDb.Dispose();
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
            }

            return Result;
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
