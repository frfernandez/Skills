using System;
using System.Data;
using System.Windows.Forms;
using Database;

namespace Entity.Map
{
    public class Paises : IDisposable
    {
        public string Codigo { get; set; }
        public string Pais { get; set; }
        public string Sigla { get; set; }
        public Continentes Continente { get; private set; }

        public Command CommandDb;

        public Paises()
        {
        }

        public Paises(Command commandDb)
        {
            CommandDb = commandDb;
        }

        public bool Save(string codigo, string pais, string sigla, Continentes continente)
        {
            bool Result = false;

            Codigo = codigo;
            Pais = pais;
            Sigla = sigla;
            Continente = continente;

            if (String.IsNullOrEmpty(Pais) == true)
                MessageBox.Show("O pais deverá ser informado !");
            else if (String.IsNullOrEmpty(Sigla) == true)
                MessageBox.Show("A sigla deverá ser informada !");
            else if (String.IsNullOrEmpty(Continente.Id.ToString()) == true)
                MessageBox.Show("O continente deverá ser informado !");
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
            }
        }

        public DataTable SelectDataTable(string codigo, string pais)
        {
            DataTable Result;
            IDbCommand CommandIDb = CommandDb.CommandConfig("P", "FltPaises");

            Codigo = codigo;
            Pais = pais;

            try
            {
                CommandDb.ParameterInput(CommandIDb, "Codigo", Codigo);
                CommandDb.ParameterInput(CommandIDb, "Nome", Pais.ToUpper());
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
            }

            return Result;
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
