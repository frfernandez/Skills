using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace Files
{
    public class INIFile
    {
        private readonly string App = Path.GetFileNameWithoutExtension(Application.ExecutablePath),
                                AppPath = String.Concat(Path.GetDirectoryName(Application.ExecutablePath), "\\");

        [DllImport("kernel32", CharSet = CharSet.Unicode)]
        private static extern int GetPrivateProfileString(string section, string key, string defaultValue, StringBuilder value, int size, string filePath);  

        private static void DATType()
        {
        }

        public ConnectionConfig ConnectionConfigOpen()
        {
            ConnectionConfig Result = null;

            if (File.Exists(String.Concat(AppPath, App, ".ini")) == true)
            {
                try
                {
                    Result = new ConnectionConfig();
                    Result.Database = ReadValue("connection", "database", "");
                    Result.Port = ReadValue("connection", "port", "");
                    Result.Server = ReadValue("connection", "server", "");
                    Result.User = ReadValue("connection", "user", "");
                    Result.Password = ReadValue("connection", "password", "");
                }
                catch (Exception exc)
                {
                    MessageBox.Show(String.Concat("Erro ao tentar abrir ou ler o conteúdo no arquivo de conexão.\nMensagem original:\n", exc.Message), "INIFile", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return Result;
        }

        private string ReadValue(string section, string key, string defaultValue)
        {
            var Result = new StringBuilder(512);
            GetPrivateProfileString(section, key, defaultValue, Result, Result.Capacity, String.Concat(AppPath, App, ".ini"));

            return Result.ToString();
        }
    }
}
