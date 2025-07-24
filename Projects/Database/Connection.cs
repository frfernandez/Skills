using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using FirebirdSql.Data.FirebirdClient;
using Oracle.DataAccess.Client;
using Database.Entity;
using Database.Enumerator;
using Files;
using Operational;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Database
{
    public class Connection
    {
        public DatabaseEnum DatabaseType { get; protected set; }
        public ConnectionConfig ConnectionConfig { get; protected set; }
        public IDbConnection ConnectionDb;
        public Command CommandDb;
        public string Procedure;

        private ProtocolEnum ProtocolType { get; set; }
        private ConnectionEnum ConnectionPosition { get; set; }
        private DATFile FileDAT { get; set; }

        public Connection()
        {
        }

        public Connection(DatabaseEnum databaseType)
        {
            ConnectionPosition = ConnectionEnum.Disconnected;
            FileDAT = new DATFile();

            DatabaseType = databaseType;
            ConnectionConfig = FileDAT.ConnectionConfigOpen();
        }

        public static IDbConnection ConnectionType(DatabaseEnum Type)
        {
            IDbConnection Result = null;

            try
            {
                switch (Type)
                {
                    case DatabaseEnum.SQLServer:
                        Result = new SqlConnection();
                        break;
                    case DatabaseEnum.FireBird:
                        Result = new FbConnection();
                        break;
                    case DatabaseEnum.Oracle:
                        Result = new OracleConnection();
                        break;
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(String.Concat("Error in trying to create the connection type to the database ", Type, ".\nOriginal message:\n", exc.Message), Diagnostic.Method(1), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return Result;
        }

        public static string Protocol(ProtocolEnum Type)
        {
            string Result = "";

            try
            {
                switch (Type)
                {
                    case ProtocolEnum.LocalHost:
                        Result = "LocalHost";
                        break;
                    case ProtocolEnum.TCP:
                        Result = "TCP";
                        break;
                    case ProtocolEnum.NamedPipe:
                        Result = "NamedPipe";
                        break;
                    case ProtocolEnum.NetBuie:
                        Result = "NetBuie";
                        break;
                    case ProtocolEnum.SPX:
                        Result = "SPX";
                        break;
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(String.Concat("Error in trying to create the protocol to the database ", Type, ".\nOriginal message:\n", exc.Message), Diagnostic.Method(1), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return Result;
        }

        public string Config()
        {
            string Result = "";

            try
            {
                switch (DatabaseType)
                {
                    case DatabaseEnum.SQLServer:
                        if (string.IsNullOrEmpty(ConnectionConfig.Port.ToString().Trim()) == true)
                            ConnectionConfig.Port = "1433";

                        Result = @String.Concat("Server=", ConnectionConfig.Server, ",", ConnectionConfig.Port, ";",
                                                "Database=", ConnectionConfig.Database, ";",
                                                "Trusted_Connection=False;",
                                                "Integrated Security=False;",
                                                "Connect Timeout=30;",
                                                "User Instance=False;",
                                                "User Id=", ConnectionConfig.User, ";",
                                                "Password=", ConnectionConfig.Password, ";");
                        break;
                    case DatabaseEnum.FireBird:
                        if (string.IsNullOrEmpty(ConnectionConfig.Port.ToString().Trim()) == true)
                            ConnectionConfig.Port = "3050";

                        Result = String.Concat("User=", ConnectionConfig.User, ";",
                                               "Password=", ConnectionConfig.Password, ";",
                                               "Database=", ConnectionConfig.Path, ConnectionConfig.Database, ".fdb;",
                                               "DataSource=", ConnectionConfig.Server, ";",
                                               "Port=", ConnectionConfig.Port, ";",
                                               "Dialect=3;",
                                               "Charset=NONE;",
                                               "Connection lifetime=15;",
                                               "Pooling=false;",
                                               "Packet Size=8192;",
                                               "PageSize=4096;",
                                               "ForcedWrite=false;",
                                               "ServerType=0;",
                                               "Isql Script=;",
                                               "BackupRestoreFile=;");
                        break;
                    case DatabaseEnum.Oracle:
                        if (string.IsNullOrEmpty(ConnectionConfig.Port.ToString().Trim()) == true)
                            ConnectionConfig.Port = "1521";

                        Result = String.Concat("Data Source =",
                                               "  (DESCRIPTION =",
                                               "    (ADDRESS_LIST =",
                                               "      (ADDRESS = (PROTOCOL = ", ConnectionConfig.Protocol, ")(HOST = ", ConnectionConfig.Server, ")(PORT = ", ConnectionConfig.Port, "))",
                                               "    )",
                                               "    (CONNECT_DATA =",
                                               "      (SERVER = DEDICATED)",
                                               "      (SERVICE_NAME = ", ConnectionConfig.Database, ")",
                                               "    )",
                                               "  );",
                                               " User Id = ", ConnectionConfig.User, ";",
                                               " Password = ", ConnectionConfig.Password, ";");
                        break;
                    default:
                        Result = "";
                        return null;
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(String.Concat("Error in trying to create the connection type to the database ", DatabaseType, ".\nOriginal message:\n", exc.Message), Diagnostic.Method(1), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return Result;
        }

        public string AdministratorGet()
        {
            string Result;

            switch (DatabaseType)
            {
                case DatabaseEnum.SQLServer:
                    Result = ConnectionConfig.Database;
                    break;
                case DatabaseEnum.FireBird:
                    Result = "sysdba";
                    break;
                case DatabaseEnum.Oracle:
                    Result = ConnectionConfig.Database;
                    break;
                default:
                    Result = "";
                    break;
            }

            return Result;
        }

        public bool Administrator()
        {
            bool Result = false;

            switch (DatabaseType)
            {
                case DatabaseEnum.SQLServer:
                    if (AdministratorGet().ToUpper() == ConnectionConfig.User.ToUpper())
                        Result = true;

                    break;
                case DatabaseEnum.FireBird:
                    if (AdministratorGet().ToUpper() == "sysdba".ToUpper())
                        Result = true;

                    break;
                case DatabaseEnum.Oracle:
                    if (AdministratorGet().ToUpper() == ConnectionConfig.User.ToUpper())
                        Result = true;

                    break;
                default:
                    Result = false;
                    break;
            }

            return Result;
        }

        public ConnectionEnum Open()
        {
            if (ConnectionConfig == null)
                ConnectionPosition = ConnectionEnum.Configuration_Empty;
            else
            {
                if (string.IsNullOrEmpty(ConnectionConfig.User) == true)
                    ConnectionPosition = ConnectionEnum.User_Empty;
                else if (string.IsNullOrEmpty(ConnectionConfig.Password) == true)
                    ConnectionPosition = ConnectionEnum.Password_Empty;
                else
                {
                    DatabaseType = ObjectTypeEnum.DatabaseType(ConnectionConfig.Controller);
                    ProtocolType = ObjectTypeEnum.ProtocolType(ConnectionConfig.Protocol);
                    ConnectionDb = ConnectionType(DatabaseType);
                    ConnectionDb.ConnectionString = Config();

                    try
                    {
                        ConnectionDb.Open();
                        if (ConnectionDb.State == ConnectionState.Open)
                        {
                            ConnectionPosition = ConnectionEnum.Connected;

                            CommandDb = new Command(DatabaseType, ConnectionConfig, ConnectionDb);
                        }
                    }
                    catch (Exception exc)
                    {
                        MessageBox.Show(String.Concat("Error in trying to open the connection type to the database ", DatabaseType, ".\nOriginal message:\n", exc.Message), Diagnostic.Method(1), MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            return ConnectionPosition;
        }

        public void Close()
        {
            if (ConnectionDb != null)
                ConnectionDb.Close();
        }

        private static IDbDataAdapter DataAdapter(DatabaseEnum Type, IDbCommand Command, string CommandType)
        {
            IDbDataAdapter Result = null;

            try
            {
                switch (Type)
                {
                    case DatabaseEnum.SQLServer:
                        Result = new SqlDataAdapter();

                        if (CommandType == "I")
                            Result.InsertCommand = (SqlCommand)Command;
                        else if (CommandType == "U")
                            Result.UpdateCommand = (SqlCommand)Command;
                        else if (CommandType == "D")
                            Result.DeleteCommand = (SqlCommand)Command;
                        else if ((CommandType == "S") ||
                                 (CommandType == "P"))
                            Result.SelectCommand = (SqlCommand)Command;

                        break;
                    case DatabaseEnum.FireBird:
                        Result = new FbDataAdapter();

                        if (CommandType == "I")
                            Result.InsertCommand = (FbCommand)Command;
                        else if (CommandType == "U")
                            Result.UpdateCommand = (FbCommand)Command;
                        else if (CommandType == "D")
                            Result.DeleteCommand = (FbCommand)Command;
                        else if ((CommandType == "S") ||
                                 (CommandType == "P"))
                            Result.SelectCommand = (FbCommand)Command;

                        break;
                    case DatabaseEnum.Oracle:
                        Result = new OracleDataAdapter();

                        if (CommandType == "I")
                            Result.InsertCommand = (OracleCommand)Command;
                        else if (CommandType == "U")
                            Result.UpdateCommand = (OracleCommand)Command;
                        else if (CommandType == "D")
                            Result.DeleteCommand = (OracleCommand)Command;
                        else if ((CommandType == "S") ||
                                 (CommandType == "P"))
                            Result.SelectCommand = (OracleCommand)Command;

                        break;
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(String.Concat("Error in trying to create the adapter to the database ", Type, ".\nOriginal message:\n", exc.Message), Diagnostic.Method(1), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return Result;
        }

        public DataSet DataSetDb(IDbCommand Command, string CommadType)
        {
            DataSet Result = new DataSet();

            IDbDataAdapter Adapter = DataAdapter(DatabaseType, Command, CommadType);
            try
            {
                Adapter.Fill(Result);
            }
            catch (Exception exc)
            {
                MessageBox.Show(String.Concat("Error in trying to fill the adapter data.\nOriginal message:\n", exc.Message), Diagnostic.Method(1), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Adapter = null;
            }

            return Result;
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
