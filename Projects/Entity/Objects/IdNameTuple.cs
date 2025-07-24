using System;
using System.Data;
using System.Windows.Forms;
using Database;
using Objects;
using Objects.Enumerator;

namespace Entity.Objects
{
    public class IdNameTuple : DataObject
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string UserFilter { get; set; }

        public IdNameTuple()
        {
        }

        public IdNameTuple(Command commandDb, DataTables configuration)
            : base(commandDb, configuration)
        {
        }

        public bool Save(string id, string name)
        {
            bool Result = false;

            Id = id;
            Name = name;

            if (String.IsNullOrEmpty(Id) == true)
                MessageBox.Show("O código deverá ser informado.");
            else if (String.IsNullOrEmpty(Name) == true)
                MessageBox.Show("O nome deverá ser informado.");
            else
                Result = true;

            return Result;
        }

        public void Insert()
        {
            IDbCommand CommandIDb = CommandDb.CommandConfig("P", ProcedureInsert);

            try
            {
                if (IdMessageId > 0)
                {
                    if (UpperCase == true)
                        CommandDb.ParameterInput(CommandIDb, ParameterId, Id.ToUpper());
                    else
                        CommandDb.ParameterInput(CommandIDb, ParameterId, Id);
                }

                if (UpperCase == true)
                    CommandDb.ParameterInput(CommandIDb, ParameterCRUD, Name.ToUpper());
                else
                    CommandDb.ParameterInput(CommandIDb, ParameterCRUD, Name);

                CommandIDb.ExecuteNonQuery();
            }
            finally
            {
                CommandIDb.Dispose();
            }
        }

        public void Update()
        {
            IDbCommand CommandIDb = CommandDb.CommandConfig("P", ProcedureUpdate);

            try
            {
                if (UpperCase == true)
                {
                    CommandDb.ParameterInput(CommandIDb, ParameterId, Id.ToUpper());
                    CommandDb.ParameterInput(CommandIDb, ParameterCRUD, Name.ToUpper());
                }
                else
                {
                    CommandDb.ParameterInput(CommandIDb, ParameterId, Id);
                    CommandDb.ParameterInput(CommandIDb, ParameterCRUD, Name);
                }

                CommandIDb.ExecuteNonQuery();
            }
            finally
            {
                CommandIDb.Dispose();
            }
        }

        public void Delete()
        {
            IDbCommand CommandIDb = CommandDb.CommandConfig("P", ProcedureDelete);

            try
            {
                if (UpperCase == true)
                    CommandDb.ParameterInput(CommandIDb, ParameterId, Id.ToUpper());
                else
                    CommandDb.ParameterInput(CommandIDb, ParameterId, Id);

                CommandIDb.ExecuteNonQuery();
            }
            finally
            {
                CommandIDb.Dispose();
            }
        }

        public DataTable SelectDataTable(string id, string name, string userFilter)
        {
            DataTable Result;
            IDbCommand CommandIDb = CommandDb.CommandConfig("P", ProcedureFilter);

            Id = id;
            Name = name;
            UserFilter = userFilter;

            try
            {
                if (Id == "0")
                    Id = "";

                CommandDb.ParameterInput(CommandIDb, ParameterId, Id);

                if (UpperCase == true)
                    CommandDb.ParameterInput(CommandIDb, ParameterFilter, Name.ToUpper());
                else
                    CommandDb.ParameterInput(CommandIDb, ParameterFilter, Name);

                if (CommandDb.ParameterExist(CommandIDb, "UserFilter") == true)
                    CommandDb.ParameterInput(CommandIDb, "UserFilter", UserFilter);

                CommandDb.ParameterInput(CommandIDb, "Search", TypeViewFilter);
                Result = CommandDb.DataSetDb(CommandIDb, "P").Tables[0];
                Configuration.TableCommand.PrimaryColumnKey(Result, DataGridField);
            }
            finally
            {
                CommandIDb.Dispose();
            }

            return Result;
        }
    }
}
