using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using FirebirdSql.Data.FirebirdClient;
using Oracle.DataAccess.Client;
using Database.Enumerator;
using Files;
using Operational;

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

        public Command(DatabaseEnum databaseType, ConnectionConfig connectionConfig, IDbConnection connectionDb)
            : base(databaseType)
        {
            ConnectionDb = connectionDb;
            User = connectionConfig.User;
        }

        private IDbCommand DatabaseDeriveParameters(IDbCommand Result)
        {
            try
            {
                switch (DatabaseType)
                {
                    case DatabaseEnum.SQLServer:
                        SqlCommandBuilder.DeriveParameters((SqlCommand)Result);
                        break;
                    case DatabaseEnum.FireBird:
                        FbCommandBuilder.DeriveParameters((FbCommand)Result);
                        break;
                    case DatabaseEnum.Oracle:
                        OracleCommandBuilder.DeriveParameters((OracleCommand)Result);
                        break;
                    default:
                        Result = null;
                        break;
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(String.Concat("Error in trying to build the object's command to ", Result.CommandText, " of type ", Result.CommandType.ToString(), " and your parameters to the database ", DatabaseType, ".\nOriginal message:\n", exc.Message), Diagnostic.Method(1), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return Result;
        }

        public bool ParameterExist(IDbCommand Command, string Parameter)
        {
            bool Result = false;

            try
            {
                switch (DatabaseType)
                {
                    case DatabaseEnum.SQLServer:
                        if (Command.CommandType == CommandType.StoredProcedure)
                        {
                            if (Command.Parameters.Contains(String.Concat("@", Parameter)) == true)
                                Result = true;
                        }

                        break;
                    case DatabaseEnum.FireBird:
                        if (Command.CommandType == CommandType.StoredProcedure)
                        {
                            if (Command.Parameters.Contains(String.Concat("@", Parameter)) == true)
                                Result = true;
                        }

                        break;
                    case DatabaseEnum.Oracle:
                        if (Command.CommandType == CommandType.StoredProcedure)
                        {
                            if (Command.Parameters.Contains(Parameter) == true)
                                Result = true;
                        }

                        break;
                    default:
                        break;
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(String.Concat("Error in trying to build the entrance parameter ", Parameter, " to the stored procedure ", Procedure, ".\nOriginal message:\n", exc.Message), Diagnostic.Method(1), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return Result;
        }

        public void ParameterInput(IDbCommand Command, string Parameter, string Value)
        {
            try
            {
                switch (DatabaseType)
                {
                    case DatabaseEnum.SQLServer:
                        if (Command.CommandType == CommandType.StoredProcedure)
                        {
                            if (String.IsNullOrEmpty(Value) == true)
                            {
                                if (((SqlCommand)Command).Parameters[String.Concat("@", Parameter)].SqlDbType == SqlDbType.Int)
                                    ((SqlCommand)Command).Parameters[String.Concat("@", Parameter)].Value = DBNull.Value;
                                else if (((SqlCommand)Command).Parameters[String.Concat("@", Parameter)].SqlDbType == SqlDbType.Date)
                                    ((SqlCommand)Command).Parameters[String.Concat("@", Parameter)].Value = DBNull.Value;
                                else if (((SqlCommand)Command).Parameters[String.Concat("@", Parameter)].SqlDbType == SqlDbType.Time)
                                    ((SqlCommand)Command).Parameters[String.Concat("@", Parameter)].Value = DBNull.Value;
                                else if (((SqlCommand)Command).Parameters[String.Concat("@", Parameter)].SqlDbType == SqlDbType.Decimal)
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

                        break;
                    case DatabaseEnum.FireBird:
                        if (Command.CommandType == CommandType.StoredProcedure)
                        {
                            if (String.IsNullOrEmpty(Value) == true)
                            {
                                if (((FbCommand)Command).Parameters[String.Concat("@", Parameter)].FbDbType == FbDbType.Integer)
                                    ((FbCommand)Command).Parameters[String.Concat("@", Parameter)].Value = DBNull.Value;
                                else if (((FbCommand)Command).Parameters[String.Concat("@", Parameter)].FbDbType == FbDbType.Decimal)
                                    ((FbCommand)Command).Parameters[String.Concat("@", Parameter)].Value = DBNull.Value;
                                else
                                    ((FbCommand)Command).Parameters[String.Concat("@", Parameter)].Value = "";
                            }
                            else
                            {
                                if (((FbCommand)Command).Parameters[String.Concat("@", Parameter)].FbDbType == FbDbType.Date)
                                    ((FbCommand)Command).Parameters[String.Concat("@", Parameter)].Value = Convert.ToDateTime(Value.Substring(0, 10));
                                else if (((FbCommand)Command).Parameters[String.Concat("@", Parameter)].FbDbType == FbDbType.Time)
                                    ((FbCommand)Command).Parameters[String.Concat("@", Parameter)].Value = Convert.ToDateTime(Value);
                                else if (((FbCommand)Command).Parameters[String.Concat("@", Parameter)].FbDbType == FbDbType.Decimal)
                                    ((FbCommand)Command).Parameters[String.Concat("@", Parameter)].Value = Convert.ToDecimal(Value);
                                else
                                    ((FbCommand)Command).Parameters[String.Concat("@", Parameter)].Value = Value;
                            }
                        }
                        else if (Command.CommandType == CommandType.Text)
                        {
                            if (Command.CommandText.IndexOf("@") == -1)
                                Command.CommandText = Command.CommandText.Replace(":", "@");

                            if (String.IsNullOrEmpty(Value) == true)
                                ((FbCommand)Command).Parameters.Add(String.Concat("@", Parameter), DBNull.Value);
                            else
                                ((FbCommand)Command).Parameters.Add(String.Concat("@", Parameter), Value);
                        }

                        break;
                    case DatabaseEnum.Oracle:
                        if (Command.CommandType == CommandType.StoredProcedure)
                        {
                            if (String.IsNullOrEmpty(Value) == true)
                            {
                                if (((OracleCommand)Command).Parameters[Parameter].OracleDbType == OracleDbType.Int32)
                                    ((OracleCommand)Command).Parameters[Parameter].Value = DBNull.Value;
                                else if (((OracleCommand)Command).Parameters[Parameter].OracleDbType == OracleDbType.Decimal)
                                    ((OracleCommand)Command).Parameters[Parameter].Value = DBNull.Value;
                                else
                                    ((OracleCommand)Command).Parameters[Parameter].Value = "";
                            }
                            else
                            {
                                if (((OracleCommand)Command).Parameters[Parameter].OracleDbType == OracleDbType.Date)
                                    ((OracleCommand)Command).Parameters[Parameter].Value = Convert.ToDateTime(Value.Substring(0, 10));
                                else if (((OracleCommand)Command).Parameters[Parameter].OracleDbType == OracleDbType.TimeStamp)
                                    ((OracleCommand)Command).Parameters[Parameter].Value = Convert.ToDateTime(Value);
                                else if (((OracleCommand)Command).Parameters[Parameter].OracleDbType == OracleDbType.Decimal)
                                    ((OracleCommand)Command).Parameters[Parameter].Value = Convert.ToDecimal(Value);
                                else
                                    ((OracleCommand)Command).Parameters[Parameter].Value = Value;
                            }
                        }
                        else if (Command.CommandType == CommandType.Text)
                        {
                            if (Command.CommandText.IndexOf("= :") == -1)
                                Command.CommandText = Command.CommandText.Replace("= ", "= :");

                            if (String.IsNullOrEmpty(Value) == true)
                                ((OracleCommand)Command).Parameters.Add(String.Concat(":", Parameter), DBNull.Value);
                            else
                                ((OracleCommand)Command).Parameters.Add(String.Concat(":", Parameter), Value);
                        }

                        break;
                    default:
                        break;
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(String.Concat("Error in trying to build the entrance parameter ", Parameter, " to the stored procedure ", Procedure, ".\nOriginal message:\n", exc.Message), Diagnostic.Method(1), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void ParameterInput(IDbCommand Command, string Parameter, Byte[] Value)
        {
            try
            {
                switch (DatabaseType)
                {
                    case DatabaseEnum.SQLServer:
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

                        break;
                    case DatabaseEnum.FireBird:
                        if (Command.CommandType == CommandType.StoredProcedure)
                        {
                            if (Value == null)
                                ((FbCommand)Command).Parameters[String.Concat("@", Parameter)].Value = DBNull.Value;
                            else
                                ((FbCommand)Command).Parameters[String.Concat("@", Parameter)].Value = Value;
                        }
                        else if (Command.CommandType == CommandType.Text)
                        {
                            if (Command.CommandText.IndexOf("@") == -1)
                                Command.CommandText = Command.CommandText.Replace(":", "@");

                            if (Value == null)
                                ((FbCommand)Command).Parameters.Add(String.Concat("@", Parameter), DBNull.Value);
                            else
                                ((FbCommand)Command).Parameters.Add(String.Concat("@", Parameter), Value);
                        }

                        break;
                    case DatabaseEnum.Oracle:
                        if (Command.CommandType == CommandType.StoredProcedure)
                        {
                            if (Value == null)
                                ((OracleCommand)Command).Parameters[Parameter].Value = DBNull.Value;
                            else
                                ((OracleCommand)Command).Parameters[Parameter].Value = Value;
                        }
                        else if (Command.CommandType == CommandType.Text)
                        {
                            if (Command.CommandText.IndexOf("= :") == -1)
                                Command.CommandText = Command.CommandText.Replace("= ", "= :");

                            if (Value == null)
                                ((OracleCommand)Command).Parameters.Add(String.Concat(":", Parameter), DBNull.Value);
                            else
                                ((OracleCommand)Command).Parameters.Add(String.Concat(":", Parameter), Value);
                        }

                        break;
                    default:
                        break;
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(String.Concat("Error in trying to build the entrance parameter ", Parameter, " to the stored procedure ", Procedure, ".\nOriginal message:\n", exc.Message), Diagnostic.Method(1), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void ParameterInputNull(IDbCommand Command)
        {
            try
            {
                switch (DatabaseType)
                {
                    case DatabaseEnum.SQLServer:
                        if (Command.CommandType == CommandType.StoredProcedure)
                        {
                            foreach (SqlParameter parameter in ((SqlCommand)Command).Parameters)
                            {
                                if (parameter.Value == null)
                                {
                                    if (parameter.SqlDbType == SqlDbType.Int)
                                        parameter.Value = DBNull.Value;
                                    else if (parameter.SqlDbType == SqlDbType.Date)
                                        parameter.Value = DBNull.Value;
                                    else if (parameter.SqlDbType == SqlDbType.Time)
                                        parameter.Value = DBNull.Value;
                                    else if (parameter.SqlDbType == SqlDbType.Decimal)
                                        parameter.Value = DBNull.Value;
                                    else
                                        parameter.Value = "";
                                }
                            }
                        }

                        break;
                    case DatabaseEnum.FireBird:
                        if (Command.CommandType == CommandType.StoredProcedure)
                        {
                            if (Command.CommandType == CommandType.StoredProcedure)
                            {
                                foreach (FbParameter parameter in ((FbCommand)Command).Parameters)
                                {
                                    if (parameter.Value == null)
                                    {
                                        if (parameter.FbDbType == FbDbType.Integer)
                                            parameter.Value = DBNull.Value;
                                        else if (parameter.FbDbType == FbDbType.Decimal)
                                            parameter.Value = DBNull.Value;
                                        else
                                            parameter.Value = "";
                                    }
                                }
                            }
                        }

                        break;
                    case DatabaseEnum.Oracle:
                        if (Command.CommandType == CommandType.StoredProcedure)
                        {
                            if (Command.CommandType == CommandType.StoredProcedure)
                            {
                                foreach (OracleParameter parameter in ((OracleCommand)Command).Parameters)
                                {
                                    if (parameter.Value == null)
                                    {
                                        if (parameter.OracleDbType == OracleDbType.Int32)
                                            parameter.Value = DBNull.Value;
                                        else if (parameter.OracleDbType == OracleDbType.Decimal)
                                            parameter.Value = DBNull.Value;
                                        else
                                            parameter.Value = "";
                                    }
                                }
                            }
                        }

                        break;
                    default:
                        break;
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(String.Concat("Error in trying to build the entrance parameter(s) null(s) to the stored procedure ", Procedure, ".\nOriginal message:\n", exc.Message), Diagnostic.Method(1), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public string ParameterOutput(IDbCommand Command, string Parameter)
        {
            string Result = "";

            try
            {
                switch (DatabaseType)
                {
                    case DatabaseEnum.SQLServer:
                        Result = Convert.ToString(((SqlCommand)Command).Parameters[String.Concat("@", Parameter)].Value);
                        break;
                    case DatabaseEnum.FireBird:
                        Result = Convert.ToString(((FbCommand)Command).Parameters[String.Concat("@", Parameter)].Value);
                        break;
                    case DatabaseEnum.Oracle:
                        Result = Convert.ToString(((OracleCommand)Command).Parameters[Parameter].Value);
                        break;
                    default:
                        break;
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(String.Concat("Error in trying to build the output parameter ", Parameter, " to the stored procedure ", Procedure, ".\nOriginal message:\n", exc.Message), Diagnostic.Method(1), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return Result;
        }

        public Byte[] ParameterOutput(IDbCommand Command, IDataReader Reader, string Parameter)
        {
            Byte[] Result = new Byte[0];

            switch (DatabaseType)
            {
                case DatabaseEnum.SQLServer:
                    Result = (Byte[])(((SqlDataReader)Reader)[Parameter]);

                    break;
                case DatabaseEnum.FireBird:
                    Result = (Byte[])(((FbDataReader)Reader)[Parameter]);

                    break;
                case DatabaseEnum.Oracle:
                    Result = (Byte[])(((OracleDataReader)Reader)[Parameter]);

                    break;
            }

            return Result;
        }

        private IDbCommand DatabaseCommandType(string TextCommand)
        {
            IDbCommand Result = null;

            try
            {
                switch (DatabaseType)
                {
                    case DatabaseEnum.SQLServer:
                        Result = new SqlCommand(TextCommand, (SqlConnection)ConnectionDb);
                        break;
                    case DatabaseEnum.FireBird:
                        Result = new FbCommand(TextCommand, (FbConnection)ConnectionDb);
                        break;
                    case DatabaseEnum.Oracle:
                        Result = new OracleCommand(TextCommand, (OracleConnection)ConnectionDb);
                        break;
                    default:
                        return null;
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(String.Concat("Error in trying to create the command to the database ", DatabaseType, ".\nOriginal message:\n", exc.Message), Diagnostic.Method(1), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

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
                Procedure = TextCommand;

            Result.Parameters.Clear();

            if (TextProcedure == "P")
                Result = DatabaseDeriveParameters(Result);

            return Result;
        }

        public IDataReader DatabaseReader(IDbCommand Command)
        {
            IDataReader Result = null;

            try
            {
                switch (DatabaseType)
                {
                    case DatabaseEnum.SQLServer:
                        Result = ((SqlCommand)Command).ExecuteReader();
                        Result = (SqlDataReader)Result;
                        break;
                    case DatabaseEnum.FireBird:
                        Result = ((FbCommand)Command).ExecuteReader();
                        Result = (FbDataReader)Result;
                        break;
                    case DatabaseEnum.Oracle:
                        Result = ((OracleCommand)Command).ExecuteReader();
                        Result = (OracleDataReader)Result;
                        break;
                    default:
                        return null;
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(String.Concat("Error in trying to create the data reader to the database ", DatabaseType, ".\nOriginal message:\n", exc.Message), Diagnostic.Method(1));
            }

            return Result;
        }
    }
}
