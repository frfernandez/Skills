using System;
using System.Windows.Forms;
using Operational;

namespace Files
{
    public sealed class ConnectionConfig
    {
        public string Controller { get; set; }
        public string Protocol { get; set; }
        public string Database { get; set; }
        public string Port { get; set; }
        public string Server { get; set; }
        public string Path { get; set; }
        public string User { get; set; }
        public string Password { get; set; }
        public string Crypto { get; set; }

        public bool Check(string controller, string protocol, string database, string port,
                          string server, string path, string user, string password, string crypto)
        {
            bool Result = false;

            if (String.IsNullOrEmpty(controller) == true)
                MessageBox.Show("The controller parameter must be informed !", Diagnostic.Method(1), MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                Controller = controller;
                Result = true;
            }

            if (Result)
                Protocol = protocol;

            if (Result)
            {
                if (String.IsNullOrEmpty(database) == true)
                    MessageBox.Show("The database parameter must be informed !", Diagnostic.Method(1), MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    Database = database;
                    Result = true;
                }
            }

            if (Result)
            {
                if (String.IsNullOrEmpty(port) == true)
                    MessageBox.Show("The port parameter must be informed !", Diagnostic.Method(1), MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    Port = port;
                    Result = true;
                }
            }

            if (Result)
            {
                if (String.IsNullOrEmpty(server) == true)
                    MessageBox.Show("The server parameter must be informed !", Diagnostic.Method(1), MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    Server = server;
                    Result = true;
                }
            }

            if (Result)
                Path = path;

            if (Result)
                User = user;

            if (Result)
                Password = password;

            return Result;
        }
    }
}
