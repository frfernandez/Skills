using System;
using System.Data;
using System.Windows.Forms;
using Database;

namespace Entity.Objects
{
    public class IdNameTuple : DataObject
    {
        public string Id { get; set; }
        public string Name { get; set; }

        public IdNameTuple()
        {
        }

        public IdNameTuple(Command commandDb)
            : base(commandDb)
        {
        }

        public bool Save(string id, string name)
        {
            bool Result = false;

            Id = id;
            Name = name;

            if ((String.IsNullOrEmpty(MessageId) == false) && (String.IsNullOrEmpty(Id) == true))
                MessageBox.Show(MessageId);
            else if (String.IsNullOrEmpty(Name) == true)
                MessageBox.Show(MessageName);
            else
                Result = true;

            return Result;
        }

        public void Insert()
        {
            IDbCommand CommandIDb = CommandDb.CommandConfig("P", ProcedureInsert);

            try
            {
                if (String.IsNullOrEmpty(MessageId) == false)
                    CommandDb.ParameterInput(CommandIDb, ParameterId, Id.ToUpper());

                CommandDb.ParameterInput(CommandIDb, ParameterCRUD, Name.ToUpper());
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
                CommandDb.ParameterInput(CommandIDb, ParameterId, Id.ToUpper());
                CommandDb.ParameterInput(CommandIDb, ParameterCRUD, Name.ToUpper());
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
                CommandDb.ParameterInput(CommandIDb, ParameterId, Id.ToUpper());
                CommandIDb.ExecuteNonQuery();
            }
            finally
            {
                CommandIDb.Dispose();
            }
        }

        public DataTable SelectDataTable(string name)
        {
            DataTable Result;
            IDbCommand CommandIDb = CommandDb.CommandConfig("P", ProcedureFilter);

            Name = name;

            try
            {
                CommandDb.ParameterInput(CommandIDb, ParameterFilter, Name.ToUpper());
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
            IDbCommand CommandIDb = CommandDb.CommandConfig("C", CommandText);

            Id = id;

            try
            {
                CommandDb.ParameterInput(CommandIDb, ParameterId, Id.ToUpper());
                Table = CommandDb.DataSetDb(CommandIDb, "C").Tables[0];

                if (Table.Rows.Count > 0)
                    Result = Table.Rows[0][DataGridField].ToString();
            }
            finally
            {
                CommandIDb.Dispose();
            }

            return Result;
        }
    }
}
