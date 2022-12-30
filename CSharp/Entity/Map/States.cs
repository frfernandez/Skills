using System;
using System.Data;
using System.Windows.Forms;
using Database;

namespace Entity.Map
{
    public class States : IDisposable
    {
        public string Id { get; set; }
        public string State { get; set; }
        public string Initial { get; set; }
        public Countries Country { get; private set; }

        public Command CommandDb;

        public States()
        {
        }

        public States(Command commandDb)
        {
            CommandDb = commandDb;
        }

        public bool Save(string id, string state, string initial, Countries country)
        {
            bool Result = false;

            Id = id;
            State = state;
            Initial = initial;
            Country = country;

            if (String.IsNullOrEmpty(State) == true)
                MessageBox.Show("The state must be informed !");
            else if (String.IsNullOrEmpty(Initial) == true)
                MessageBox.Show("The initial must be informed !");
            else if (String.IsNullOrEmpty(Country.Id.ToString()) == true)
                MessageBox.Show("The country must be informed !");
            else
                Result = true;

            return Result;
        }

        public void Insert()
        {
            IDbCommand CommandIDb = CommandDb.CommandConfig("P", "InsStates");

            try
            {
                CommandDb.ParameterInput(CommandIDb, "State", State.ToUpper());
                CommandDb.ParameterInput(CommandIDb, "Initial", Initial.ToUpper());
                CommandDb.ParameterInput(CommandIDb, "IdCountry", Country.Id.ToString());
                CommandIDb.ExecuteNonQuery();
            }
            finally
            {
                CommandIDb.Dispose();
            }
        }

        public void Update()
        {
            IDbCommand CommandIDb = CommandDb.CommandConfig("P", "UpdStates");

            try
            {
                CommandDb.ParameterInput(CommandIDb, "Id", Id);
                CommandDb.ParameterInput(CommandIDb, "State", State.ToUpper());
                CommandDb.ParameterInput(CommandIDb, "Initial", Initial.ToUpper());
                CommandDb.ParameterInput(CommandIDb, "IdCountry", Country.Id.ToString());
                CommandIDb.ExecuteNonQuery();
            }
            finally
            {
                CommandIDb.Dispose();
            }
        }

        public void Delete()
        {
            IDbCommand CommandIDb = CommandDb.CommandConfig("P", "DelStates");

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

        public DataTable SelectDataTable(string id, string state, string initial, Countries country)
        {
            DataTable Result;
            IDbCommand CommandIDb = CommandDb.CommandConfig("P", "FltStates");

            Id = id;
            State = state;
            Initial = initial;
            Country = country;

            try
            {
                CommandDb.ParameterInput(CommandIDb, "Id", Id);
                CommandDb.ParameterInput(CommandIDb, "Name", State.ToUpper());

                if ((Country == null) || (Country.Id == null))
                    CommandDb.ParameterInput(CommandIDb, "IdCountry", "");
                else
                    CommandDb.ParameterInput(CommandIDb, "IdCountry", Country.Id.ToString());

                Result = CommandDb.DataSetDb(CommandIDb, "P").Tables[0];
            }
            finally
            {
                CommandIDb.Dispose();
            }

            return Result;
        }

        public string SelectName(string id, Countries country)
        {
            string Result = "";
            DataTable Table;
            string CommandText = String.Concat(" Select State",
                                               " From ", CommandDb.ObjectLocation.Position(CommandType.Text, "States"),
                                               " Where Id        = @Id",
                                               "   And IdCountry = @IdCountry");

            IDbCommand CommandIDb = CommandDb.CommandConfig("S", CommandText);

            Id = id;
            Country = country;

            try
            {
                CommandDb.ParameterInput(CommandIDb, "Id", Id);

                if ((Country == null) || (Country.Id == null))
                    CommandDb.ParameterInput(CommandIDb, "IdCountry", "");
                else
                    CommandDb.ParameterInput(CommandIDb, "IdCountry", Country.Id.ToString());

                Table = CommandDb.DataSetDb(CommandIDb, "S").Tables[0];

                if (Table.Rows.Count > 0)
                    Result = Table.Rows[0]["State"].ToString();
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
