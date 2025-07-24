using System;
using System.IO;
using System.Windows.Forms;
using Operational;

namespace Files
{
    public sealed class DATFile
    {
        private static string DATType(string Type)
        {
            string Result = "";

            Type = Type.ToString().ToUpper();
            if (Type == "SECUR")
                Result = "Segurança";
            else
                Result = "Desconhecido";

            return Result;
        }

        public ConnectionConfig ConnectionConfigOpen()
        {
            ConnectionConfig Result = null;
            string App = Path.GetFileNameWithoutExtension(Application.ExecutablePath),
                   AppPath = SystemFile.Slack(SystemApplication.CompletePath());

            if (File.Exists(String.Concat(AppPath, App, ".dat")) == true)
            {
                FileStream AppFile = new FileStream(String.Concat(AppPath, App, ".dat"), FileMode.Open);
                BinaryReader BinaryFile = new BinaryReader(AppFile);
                string Type = "", Password = "", Crypto = "";

                try
                {
                    if (AppFile.Length > 0)
                    {
                        BinaryFile.BaseStream.Seek(0, SeekOrigin.Begin);

                        Type = BinaryFile.ReadString();
                        if (Type.ToString().ToUpper() == "SECUR")
                        {
                            Result = new ConnectionConfig();
                            Result.Controller = BinaryFile.ReadString();
                            Result.Protocol = BinaryFile.ReadString();
                            Result.Database = BinaryFile.ReadString();
                            Result.Port = BinaryFile.ReadString();
                            Result.Server = BinaryFile.ReadString();
                            Result.Path = BinaryFile.ReadString();
                            Result.User = BinaryFile.ReadString();
                            Result.Password = "";
                            Result.Crypto = "";

                            Password = BinaryFile.ReadString();
                            if (Password.Trim() != "")
                            {
                                Crypto = Cryptography.Crypto(BinaryFile.ReadString(), false, "Date", "Time");
                                Password = Cryptography.Crypto(Password, false, Crypto.Substring(0, 8), Crypto.Substring(8, 6));
                            }

                            Result.Password = Password;
                            Result.Crypto = Crypto;
                        }
                        else
                            MessageBox.Show(String.Concat("The file used to configure the connection is incorrect because it belongs to ", DATType(Type).ToString().ToLower(), " !"), Diagnostic.Method(1), MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception exc)
                {
                    MessageBox.Show(String.Concat("Error in trying to open or read the connection file content.\nOriginal message:\n", exc.Message), Diagnostic.Method(1), MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    BinaryFile.Close();
                    AppFile.Close();
                }
            }

            return Result;
        }

        public bool ConnectionConfigSave(string Controller, string Protocol, string Database,
                                         string Port, string Server, string DatabasePath,
                                         string User, string Password, string Crypto)
        {
            bool Result = false;

            string Type = "SECUR",
                   App = Path.GetFileNameWithoutExtension(Application.ExecutablePath),
                   AppPath = SystemFile.Slack(SystemApplication.CompletePath());

            FileStream AppFile = new FileStream(String.Concat(AppPath, App, ".dat"), FileMode.Create);
            BinaryWriter BinaryFile = new BinaryWriter(AppFile);

            try
            {
                BinaryFile.Write(Type);
                BinaryFile.Write(Controller);
                BinaryFile.Write(Protocol);
                BinaryFile.Write(Database);
                BinaryFile.Write(Port);
                BinaryFile.Write(Server);
                BinaryFile.Write(DatabasePath);
                BinaryFile.Write(User);
                BinaryFile.Write(Password);
                BinaryFile.Write(Crypto);

                Result = true;
            }
            catch (Exception exc)
            {
                MessageBox.Show(String.Concat("Error in trying to save the connection file content.\nOriginal message:\n", exc.Message), Diagnostic.Method(1), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                BinaryFile.Close();
                AppFile.Close();
            }

            return Result;
        }
    }
}
