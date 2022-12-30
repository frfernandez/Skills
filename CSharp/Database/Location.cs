using System;
using System.Data;
using System.Data.SqlClient;
using Files;

namespace Database
{
    public class Location : Connection
    {
        public Location()
        {
        }

        public Location(IDbConnection connectionDb)
            : base()
        {
            ConnectionDb = connectionDb;
        }

        public string Schema(CommandType ObjectType, string Object)
        {
            string Result = "";

            SqlCommand SQLCommand = ((SqlConnection)ConnectionDb).CreateCommand();
            SQLCommand.CommandType = CommandType.StoredProcedure;

            if (ObjectType == CommandType.StoredProcedure)
                SQLCommand.CommandText = "System.FltSchemaProcedure";
            else if (ObjectType == CommandType.Text)
                SQLCommand.CommandText = "System.FltSchemaTable";

            SQLCommand.Parameters.Clear();
            SqlCommandBuilder.DeriveParameters(SQLCommand);

            SQLCommand.Parameters["@Object"].Value = Object;

            SqlDataReader Leitor = SQLCommand.ExecuteReader();

            if (Leitor.Read())
                Result = Leitor["SchemaName"].ToString();

            Leitor.Close();
            Leitor.Dispose();

            SQLCommand.Dispose();

            if (String.IsNullOrEmpty(Result) == true)
                Result = Object;
            else
            {
                bool Find = false;

                if (Object.IndexOf(".", 0) > -1)
                {
                    if (Result.Trim().ToUpper() == Object.Substring(1, Result.Trim().Length).ToUpper())
                        Find = true;
                }

                if (Find == true)
                    Result = Object;
                else
                    Result = String.Concat(ConnectionConfig.Database, ".", Result, ".", Object);
            }

            return Result;
        }

        public string Position(CommandType ObjectType, string Object)
        {
            return Schema(ObjectType, Object);
        }
    }
}
