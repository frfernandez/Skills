using System;
using System.Data;
using System.Data.SqlClient;

namespace Database
{
    public class Command : Connection
    {
        public string IdUser { get; set; }
        public string IdDate { get; set; }
        public string IdTime { get; set; }
        public string User;

        public Command()
        {
        }

        public Command(IDbConnection connectionDb)
            : base()
        {
            ConnectionDb = connectionDb;
        }

        private IDbCommand DatabaseDeriveParameters(IDbCommand Result)
        {
            SqlCommandBuilder.DeriveParameters((SqlCommand)Result);
            return Result;
        }

        public bool ParameterExist(IDbCommand Command, string Parameter)
        {
            bool Result = false;

            if (Command.CommandType == CommandType.StoredProcedure)
            {
                if (Command.Parameters.Contains(String.Concat("@", Parameter)) == true)
                    Result = true;
            }

            return Result;
        }

        public void ParameterInput(IDbCommand Command, string Parameter, string Value)
        {
            if (Command.CommandType == CommandType.StoredProcedure)
            {
                if (String.IsNullOrEmpty(Value) == true)
                {
                    if (((SqlCommand)Command).Parameters[String.Concat("@", Parameter)].SqlDbType == SqlDbType.Int)
                        ((SqlCommand)Command).Parameters[String.Concat("@", Parameter)].Value = DBNull.Value;
                    else
                        ((SqlCommand)Command).Parameters[String.Concat("@", Parameter)].Value = "";
                }
                else
                    ((SqlCommand)Command).Parameters[String.Concat("@", Parameter)].Value = Value;
            }
            else if (Command.CommandType == CommandType.Text)
            {
                if (String.IsNullOrEmpty(Value) == true)
                    ((SqlCommand)Command).Parameters.AddWithValue(Parameter, DBNull.Value);
                else
                    ((SqlCommand)Command).Parameters.AddWithValue(Parameter, Value);
            }
        }

        public void ParameterInput(IDbCommand Command, string Parameter, Byte[] Value)
        {
            if (Command.CommandType == CommandType.StoredProcedure)
            {
                if (Value == null)
                    ((SqlCommand)Command).Parameters[String.Concat("@", Parameter)].Value = DBNull.Value;
                else
                    ((SqlCommand)Command).Parameters[String.Concat("@", Parameter)].Value = Value;
            }
            else if (Command.CommandType == CommandType.Text)
            {
                if (Value == null)
                    ((SqlCommand)Command).Parameters.AddWithValue(Parameter, DBNull.Value);
                else
                    ((SqlCommand)Command).Parameters.AddWithValue(Parameter, Value);
            }
        }

        public void ParameterInputNull(IDbCommand Command)
        {
            if (Command.CommandType == CommandType.StoredProcedure)
            {
                foreach (SqlParameter parameter in ((SqlCommand)Command).Parameters)
                {
                    if (parameter.Value == null)
                    {
                        if (parameter.SqlDbType == SqlDbType.Int)
                            parameter.Value = DBNull.Value;
                        else
                            parameter.Value = "";
                    }
                }
            }
        }

        public string ParameterOutput(IDbCommand Command, string Parameter)
        {
            string Result = Convert.ToString(((SqlCommand)Command).Parameters[String.Concat("@", Parameter)].Value);

            return Result;
        }

        public Byte[] ParameterOutput(IDbCommand Command, IDataReader Reader, string Parameter)
        {
            Byte[] Result = new Byte[0];
            Result = (Byte[])(((SqlDataReader)Reader)[Parameter]);

            return Result;
        }

        private IDbCommand DatabaseCommandType(string TextCommand)
        {
            IDbCommand Result = null;
            Result = new SqlCommand(TextCommand, (SqlConnection)ConnectionDb);

            return Result;
        }

        public IDbCommand CommandConfig(string TextProcedure, string TextCommand)
        {
            IDbCommand Result = DatabaseCommandType(TextCommand);

            if (TextProcedure == "P")
                Result.CommandType = CommandType.StoredProcedure;
            else if ((TextProcedure == "T") ||
                     (TextProcedure == "S"))
                Result.CommandType = CommandType.Text;

            if (TextProcedure != "S")
            {
                Result.CommandText = ObjectLocation.Position(Result.CommandType, TextCommand);
                Procedure = TextCommand;
            }

            Result.Parameters.Clear();

            if (TextProcedure == "P")
                Result = DatabaseDeriveParameters(Result);

            return Result;
        }

        public IDataReader DatabaseReader(IDbCommand Command)
        {
            IDataReader Result = null;
            Result = ((SqlCommand)Command).ExecuteReader();
            Result = (SqlDataReader)Result;

            return Result;
        }
    }
}
