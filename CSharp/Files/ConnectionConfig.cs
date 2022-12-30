using System;
using System.Windows.Forms;

namespace Files
{
    public sealed class ConnectionConfig
    {
        public string Database { get; set; }
        public string Port { get; set; }
        public string Server { get; set; }
        public string User { get; set; }
        public string Password { get; set; }

        public bool Check(string database, string port, string server, string user, string password)
        {
            bool Result = false;

            if (String.IsNullOrEmpty(database) == true)
                MessageBox.Show("The database parameter must be informed !", "Connection Config", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                Database = database;
                Result = true;
            }

            if (Result)
            {
                if (String.IsNullOrEmpty(port) == true)
                    MessageBox.Show("The port parameter must be informed !", "Connection Config", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    Port = port;
                    Result = true;
                }
            }

            if (Result)
            {
                if (String.IsNullOrEmpty(server) == true)
                    MessageBox.Show("The server parameter must be informed !", "Connection Config", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    Server = server;
                    Result = true;
                }
            }

            if (Result)
                User = user;

            if (Result)
                Password = password;

            return Result;
        }
    }
}
