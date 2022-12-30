using System;
using System.Data;
using System.Windows.Forms;
using Database;

namespace Entity.Map
{
    public class Cities : IDisposable
    {
        public string Id { get; set; }
        public string City { get; set; }
        public States State { get; private set; }
        public Countries Country { get; private set; }
        public Continents Continent { get; private set; }

        public Command CommandDb;

        public Cities()
        {
        }

        public Cities(Command commandDb)
        {
            CommandDb = commandDb;
        }

        public bool Save(string id, string city, States state)
        {
            bool Result = false;

            Id = id;
            City = city;
            State = state;

            if (String.IsNullOrEmpty(City) == true)
                MessageBox.Show("The city must be informed !");
            else if (String.IsNullOrEmpty(State.Id.ToString()) == true)
                MessageBox.Show("The state must be informed !");
            else
                Result = true;

            return Result;
        }

        public void Insert()
        {
            IDbCommand CommandIDb = CommandDb.CommandConfig("P", "InsCities");

            try
            {
                CommandDb.ParameterInput(CommandIDb, "City", City.ToUpper());
                CommandDb.ParameterInput(CommandIDb, "IdState", State.Id.ToString());
                CommandIDb.ExecuteNonQuery();
            }
            finally
            {
                CommandIDb.Dispose();
            }
        }

        public void Update()
        {
            IDbCommand CommandIDb = CommandDb.CommandConfig("P", "UpdCities");

            try
            {
                CommandDb.ParameterInput(CommandIDb, "Id", Id);
                CommandDb.ParameterInput(CommandIDb, "City", City.ToUpper());
                CommandDb.ParameterInput(CommandIDb, "IdState", State.Id.ToString());
                CommandIDb.ExecuteNonQuery();
            }
            finally
            {
                CommandIDb.Dispose();
            }
        }

        public void Delete()
        {
            IDbCommand CommandIDb = CommandDb.CommandConfig("P", "DelCities");

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

        public DataTable SelectDataTable(string id, string city, States estado, Countries country, Continents continent)
        {
            DataTable Result;
            IDbCommand CommandIDb = CommandDb.CommandConfig("P", "FltCities");

            Id = id;
            City = city;
            State = estado;
            Country = country;
            Continent = continent;

            try
            {
                CommandDb.ParameterInput(CommandIDb, "Id", Id);
                CommandDb.ParameterInput(CommandIDb, "Name", City.ToUpper());

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
            string CommandText = String.Concat(" Select City",
                                               " From ", CommandDb.ObjectLocation.Position(CommandType.Text, "Cities"),
                                               " Where Id = @Id");

            IDbCommand CommandIDb = CommandDb.CommandConfig("S", CommandText);

            Id = id;

            try
            {
                CommandDb.ParameterInput(CommandIDb, "Id", Id);
                Table = CommandDb.DataSetDb(CommandIDb, "S").Tables[0];

                if (Table.Rows.Count > 0)
                    Result = Table.Rows[0]["City"].ToString();
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
