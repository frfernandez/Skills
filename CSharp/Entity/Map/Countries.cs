using System;
using System.Data;
using System.Windows.Forms;
using Database;

namespace Entity.Map
{
    public class Countries : IDisposable
    {
        public string Id { get; set; }
        public string Country { get; set; }
        public string Initial { get; set; }
        public Continents Continent { get; private set; }

        public Command CommandDb;

        public Countries()
        {
        }

        public Countries(Command commandDb)
        {
            CommandDb = commandDb;
        }

        public bool Save(string id, string country, string initial, Continents continent)
        {
            bool Result = false;

            Id = id;
            Country = country;
            Initial = initial;
            Continent = continent;

            if (String.IsNullOrEmpty(Country) == true)
                MessageBox.Show("The country must be informed !");
            else if (String.IsNullOrEmpty(initial) == true)
                MessageBox.Show("The initial must be informed !");
            else if (String.IsNullOrEmpty(continent.Id.ToString()) == true)
                MessageBox.Show("The continent must be informed !");
            else
                Result = true;

            return Result;
        }

        public void Insert()
        {
            IDbCommand CommandIDb = CommandDb.CommandConfig("P", "InsCountries");

            try
            {
                CommandDb.ParameterInput(CommandIDb, "Country", Country.ToUpper());
                CommandDb.ParameterInput(CommandIDb, "Initial", Initial.ToUpper());
                CommandDb.ParameterInput(CommandIDb, "IdContinent", Continent.Id.ToString());
                CommandIDb.ExecuteNonQuery();
            }
            finally
            {
                CommandIDb.Dispose();
            }
        }

        public void Update()
        {
            IDbCommand CommandIDb = CommandDb.CommandConfig("P", "UpdCountries");

            try
            {
                CommandDb.ParameterInput(CommandIDb, "Id", Id);
                CommandDb.ParameterInput(CommandIDb, "Country", Country.ToUpper());
                CommandDb.ParameterInput(CommandIDb, "Initial", Initial.ToUpper());
                CommandDb.ParameterInput(CommandIDb, "IdContinent", Continent.Id.ToString());
                CommandIDb.ExecuteNonQuery();
            }
            finally
            {
                CommandIDb.Dispose();
            }
        }

        public void Delete()
        {
            IDbCommand CommandIDb = CommandDb.CommandConfig("P", "DelCountries");

            try
            {
                CommandDb.ParameterInput(CommandIDb, "Id", Id);
                CommandIDb.ExecuteNonQuery();
            }
            finally
            {
                CommandIDb.Dispose();
            }
        }

        public DataTable SelectDataTable(string id, string country)
        {
            DataTable Result;
            IDbCommand CommandIDb = CommandDb.CommandConfig("P", "FltCountries");

            Id = id;
            Country = country;

            try
            {
                CommandDb.ParameterInput(CommandIDb, "Id", Id);
                CommandDb.ParameterInput(CommandIDb, "Name", Country.ToUpper());

                Result = CommandDb.DataSetDb(CommandIDb, "P").Tables[0];
            }
            finally
            {
                CommandIDb.Dispose();
            }

            return Result;
        }

        public string SelectName(string id)
        {
            string Result = "";
            DataTable Table;
            string CommandText = String.Concat(" Select Country",
                                               " From ", CommandDb.ObjectLocation.Position(CommandType.Text, "Countries"),
                                               " Where Id = @Id");

            IDbCommand CommandIDb = CommandDb.CommandConfig("S", CommandText);

            Id = id;

            try
            {
                CommandDb.ParameterInput(CommandIDb, "Id", Id);
                Table = CommandDb.DataSetDb(CommandIDb, "S").Tables[0];

                if (Table.Rows.Count > 0)
                    Result = Table.Rows[0]["Country"].ToString();
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
