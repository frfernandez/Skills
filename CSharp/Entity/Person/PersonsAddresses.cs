using System;
using System.Data;
using System.Windows.Forms;
using Database;
using Entity.Map;
using Objects;
using Objects.Enumerator;

namespace Entity.Person
{
    public class PersonsAddresses : IDisposable
    {
        public string Position { get; set; }
        public string PostalArea { get; set; }
        public string Complement { get; set; }
        public string Number { get; set; }
        public Persons Person { get; private set; }
        public Neighborhoods Neighborhood { get; private set; }
        public Addresses Address { get; private set; }
        public Districts District { get; private set; }
        public Cities City { get; private set; }
        public States State { get; private set; }
        public Countries Country { get; private set; }
        public Continents Continent { get; private set; }

        public Command CommandDb;

        public PersonsAddresses()
        {
        }

        public PersonsAddresses(Command commandDb)
        {
            CommandDb = commandDb;
        }

        public bool Save(Persons person, string position, string postalArea, string complement, Neighborhoods neighborhood,
            Addresses address, string number, Districts district, Cities city)
        {
            bool Result = false;

            Person = person;
            Position = position;
            PostalArea = postalArea;
            Complement = complement;
            Neighborhood = neighborhood;
            Address = address;
            Number = number;
            District = district;
            City = city;

            if (String.IsNullOrEmpty(Person.Id.ToString()) == true)
                MessageBox.Show("The person's identification must be informed !");
            else if (String.IsNullOrEmpty(Position) == true)
                MessageBox.Show("The position must be informed !");
            else if (String.IsNullOrEmpty(Neighborhood.Id.ToString()) == true)
                MessageBox.Show("The neighborhoods must be informed !");
            else if (String.IsNullOrEmpty(Address.Id.ToString()) == true)
                MessageBox.Show("The address must be informed !");
            else if (String.IsNullOrEmpty(District.Id.ToString()) == true)
                MessageBox.Show("The district must be informed !");
            else if (String.IsNullOrEmpty(City.Id.ToString()) == true)
                MessageBox.Show("The city must be informed !");
            else
                Result = true;

            return Result;
        }

        public void Insert()
        {
            IDbCommand CommandIDb = CommandDb.CommandConfig("P", "InsPersonsAddresses");

            try
            {
                CommandDb.ParameterInput(CommandIDb, "IdPerson", Person.Id.ToString());
                CommandDb.ParameterInput(CommandIDb, "Position", Position);
                CommandDb.ParameterInput(CommandIDb, "PostalArea", PostalArea);
                CommandDb.ParameterInput(CommandIDb, "Complement", Complement);
                CommandDb.ParameterInput(CommandIDb, "IdNeighborhood", Neighborhood.Id.ToString());
                CommandDb.ParameterInput(CommandIDb, "IdAddress", Address.Id.ToString());
                CommandDb.ParameterInput(CommandIDb, "Number", Number);
                CommandDb.ParameterInput(CommandIDb, "IdDistrict", District.Id.ToString());
                CommandDb.ParameterInput(CommandIDb, "IdCity", City.Id.ToString());
                CommandIDb.ExecuteNonQuery();
            }
            finally
            {
                CommandIDb.Dispose();
            }
        }

        public void Update()
        {
            IDbCommand CommandIDb = CommandDb.CommandConfig("P", "UpdPersonsAddresses");

            try
            {
                CommandDb.ParameterInput(CommandIDb, "IdPerson", Person.Id.ToString());
                CommandDb.ParameterInput(CommandIDb, "Position", Position);
                CommandDb.ParameterInput(CommandIDb, "PostalArea", PostalArea);
                CommandDb.ParameterInput(CommandIDb, "Complement", Complement);
                CommandDb.ParameterInput(CommandIDb, "IdNeighborhood", Neighborhood.Id.ToString());
                CommandDb.ParameterInput(CommandIDb, "IdAddress", Address.Id.ToString());
                CommandDb.ParameterInput(CommandIDb, "Number", Number);
                CommandDb.ParameterInput(CommandIDb, "IdDistrict", District.Id.ToString());
                CommandDb.ParameterInput(CommandIDb, "IdCity", City.Id.ToString());
                CommandIDb.ExecuteNonQuery();
            }
            finally
            {
                CommandIDb.Dispose();
            }
        }

        public void Delete()
        {
            IDbCommand CommandIDb = CommandDb.CommandConfig("P", "DelPersonsAddresses");

            try
            {
                CommandDb.ParameterInput(CommandIDb, "IdPerson", Person.Id.ToString());
                CommandDb.ParameterInput(CommandIDb, "Position", Position);
                CommandIDb.ExecuteNonQuery();
            }
            finally
            {
                CommandIDb.Dispose();
            }
        }

        public DataTable SelectDataTable(Persons pessoa)
        {
            DataTable Result;
            IDbCommand CommandIDb = CommandDb.CommandConfig("P", "PKePersonsAddresses");

            Person = pessoa;

            try
            {
                CommandDb.ParameterInput(CommandIDb, "IdPerson", Person.Id.ToString());
                Result = CommandDb.DataSetDb(CommandIDb, "P").Tables[0];
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
