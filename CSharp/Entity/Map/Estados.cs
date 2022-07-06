using System;
using System.Data;
using System.Windows.Forms;
using Database;

namespace Entity.Map
{
    public class Estados : IDisposable
    {
        public string Codigo { get; set; }
        public string Estado { get; set; }
        public string Sigla { get; set; }
        public Paises Pais { get; private set; }

        public Command CommandDb;

        public Estados()
        {
        }

        public Estados(Command commandDb)
        {
            CommandDb = commandDb;
        }

        public bool Save(string codigo, string estado, string sigla, Paises pais)
        {
            bool Result = false;

            Codigo = codigo;
            Estado = estado;
            Sigla = sigla;
            Pais = pais;

            if (String.IsNullOrEmpty(Estado) == true)
                MessageBox.Show("O estado deverá ser informado !");
            else if (String.IsNullOrEmpty(Sigla) == true)
                MessageBox.Show("A sigla deverá ser informada !");
            else if (String.IsNullOrEmpty(Pais.Codigo.ToString()) == true)
                MessageBox.Show("O pais deverá ser informado !");
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
            }
        }

        public DataTable SelectDataTable(string codigo, string estado, Paises pais)
        {
            DataTable Result;
            IDbCommand CommandIDb = CommandDb.CommandConfig("P", "FltEstados");

            Codigo = codigo;
            Estado = estado;
            Pais = pais;

            try
            {
                CommandDb.ParameterInput(CommandIDb, "Codigo", Codigo);
                CommandDb.ParameterInput(CommandIDb, "Nome", Estado.ToUpper());

                if ((Pais == null) || (Pais.Codigo == null))
                    CommandDb.ParameterInput(CommandIDb, "CodigoPais", "");
                else
                    CommandDb.ParameterInput(CommandIDb, "CodigoPais", Pais.Codigo.ToString());

                Result = CommandDb.DataSetDb(CommandIDb, "P").Tables[0];
            }
            finally
            {
                CommandIDb.Dispose();
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
            }

            return Result;
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
