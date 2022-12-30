using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Database.Enumerator;
using Files;

namespace Database
{
    public class Connection
    {
        public ConnectionConfig ConnectionConfig { get; protected set; }
        public Location ObjectLocation;
        public IDbConnection ConnectionDb;
        public Command CommandDb;
        public string Procedure;

        private ConnectionEnum ConnectionPosition { get; set; }
        private INIFile FileINI { get; set; }

        public Connection()
        {
            ConnectionPosition = ConnectionEnum.Disconnected;
            FileINI = new INIFile();

            ConnectionConfig = FileINI.ConnectionConfigOpen();
        }

        public static IDbConnection ConnectionType()
        {
            IDbConnection Result = new SqlConnection();

            return Result;
        }

        public string Config()
        {
            string Result = "";

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
                    ConnectionDb = new SqlConnection();
                    ConnectionDb.ConnectionString = Config();

                    try
                    {
                        ConnectionDb.Open();
                        if (ConnectionDb.State == ConnectionState.Open)
                        {
                            ConnectionPosition = ConnectionEnum.Connected;

                            ObjectLocation = new Location(ConnectionDb);
                            CommandDb = new Command(ConnectionDb);
                            CommandDb.ObjectLocation = ObjectLocation;
                        }
                    }
                    catch (Exception exc)
                    {
                        MessageBox.Show(String.Concat("Error to try to open the connection type to the database.\nOriginal message:\n", exc.Message), "Connection Open", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private static IDbDataAdapter DataAdapter(IDbCommand Command, string CommandType)
        {
            IDbDataAdapter Result = new SqlDataAdapter();

            if (CommandType == "I")
                Result.InsertCommand = (SqlCommand)Command;
            else if (CommandType == "U")
                Result.UpdateCommand = (SqlCommand)Command;
            else if (CommandType == "D")
                Result.DeleteCommand = (SqlCommand)Command;
            else if ((CommandType == "S") ||
                     (CommandType == "P"))
                Result.SelectCommand = (SqlCommand)Command;

            return Result;
        }

        public DataSet DataSetDb(IDbCommand Command, string CommadType)
        {
            DataSet Result = new DataSet();

            IDbDataAdapter Adapter = DataAdapter(Command, CommadType);
            try
            {
                Adapter.Fill(Result);
            }
            catch (Exception exc)
            {
                MessageBox.Show(String.Concat("Error to try to fill the adapter data.\nOriginal message:\n", exc.Message), "Connection DataSetDb", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
