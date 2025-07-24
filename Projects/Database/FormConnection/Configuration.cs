using System;
using System.IO;
using System.Net;
using System.Windows.Forms;
using Database.Enumerator;
using Files;
using Objects;
using Operational;

namespace Database.FormConnection
{
    public partial class ConnectionF : Form
    {
        private string Date, Time;

        public DatabaseEnum DatabaseType;
        public ConnectionConfig ConnectionConfig;
        public ConnectionEnum ConnectionState;
        public Connection ConnectionDb;
        public Look LookControls;

        public ConnectionF()
        {
            InitializeComponent();
        }

        private void ConexaoF_Shown(object sender, System.EventArgs e)
        {
            if (LookControls != null)
                LookControls.Form(this, Images, TTpTip);

            if (ConnectionConfig == null)
                ConnectionConfig = new ConnectionConfig();
            else
            {
                CbBController.Text = ConnectionConfig.Controller;
                CbBProtocol.Text = ConnectionConfig.Protocol;
                TxBDatabase.Text = ConnectionConfig.Database;
                TxBPort.Text = ConnectionConfig.Port;
                TxBServer.Text = ConnectionConfig.Server;
                TxBFolder.Text = ConnectionConfig.Path;
                TxBUser.Text = ConnectionConfig.User;
                TxBPassword.Text = ConnectionConfig.Password;
            }

            if (ConnectionDb.ConnectionConfig != null)
            {
                if (String.IsNullOrEmpty(TxBUser.Text) == true)
                {
                    if (ConnectionDb.Administrator() == true)
                        TxBUser.Text = ConnectionDb.AdministratorGet();

                    TxBUser.ReadOnly = true;
                    TxBUser.TabStop = false;
                }

                if (String.IsNullOrEmpty(TxBPassword.Text) == false)
                    ChkSaveUserPassword.Checked = true;
            }
        }

        private void ConexaoF_KeyDown(object sender, KeyEventArgs e)
        {
            if (Key.Pressed(sender, e) == Keys.Escape)
                BtnExit_Click(sender, e);
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            if (ConnectionConfig.Check(CbBController.Text,
                                       CbBProtocol.Text,
                                       TxBDatabase.Text,
                                       TxBPort.Text,
                                       TxBServer.Text,
                                       TxBFolder.Text,
                                       TxBUser.Text,
                                       TxBPassword.Text,
                                       "") == true)
            {
                DATFile FileDAT = new DATFile();

                BtnComando_Click(sender, e);

                FileDAT.ConnectionConfigSave(CbBController.Text,
                                             CbBProtocol.Text,
                                             TxBDatabase.Text,
                                             TxBPort.Text,
                                             TxBServer.Text,
                                             TxBFolder.Text,
                                             TxBUser.Text,
                                             Cryptography.Crypto(TxBPassword.Text, true, Date, Time),
                                             Cryptography.Crypto(String.Concat(Date, Time), true, "Date", "Time"));

                ConnectionState = ConnectionDb.Open();
                if (ConnectionState == ConnectionEnum.Connected)
                {
                    if (ChkSaveUserPassword.Checked == false)
                    {
                        TxBUser.Text = "";
                        TxBPassword.Text = "";
                    }

                    BtnExit_Click(sender, e);
                }
            }
        }

        private void BtnClean_Click(object sender, EventArgs e)
        {
            Values.PanelClean(PnlPanel1);
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CbBControlador_SelectedIndexChanged(object sender, EventArgs e)
        {
            LblProtocol.Visible = true;
            CbBProtocol.Visible = true;

            LblFolder.Visible = true;
            TxBFolder.Visible = true;
            BtnFolder.Visible = true;
            BtnFolder.Visible = true;

            if (Enum.TryParse<DatabaseEnum>(CbBController.Text, true, out DatabaseType))
            {
                switch (DatabaseType)
                {
                    case DatabaseEnum.SQLServer:
                        LblProtocol.Visible = false;
                        CbBProtocol.Visible = false;

                        LblFolder.Visible = false;
                        TxBFolder.Visible = false;
                        BtnFolder.Visible = false;

                        TxBServer.Enabled = true;
                        TxBServer.Text = Environment.MachineName;

                        TxBPort.Text = "1433";

                        break;
                    case DatabaseEnum.FireBird:
                        CbBProtocolo_SelectedIndexChanged(sender, e);

                        LblFolder.Text = "Folder:";

                        TxBPort.Text = "3050";

                        break;
                    case DatabaseEnum.Oracle:
                        CbBProtocolo_SelectedIndexChanged(sender, e);

                        LblFolder.Text = "Tablespace:";
                        BtnFolder.Visible = false;

                        TxBPort.Text = "1521";

                        break;
                    default:
                        break;
                }

                if (String.IsNullOrEmpty(CbBController.Text) == false)
                {
                    if (TxBUser.Text.ToUpper() == "Database".ToUpper())
                        TxBUser.Text = TxBDatabase.Text;

                    TxBPassword.Text = "";
                }
            }
        }

        private void CbBProtocolo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((CbBProtocol.Visible == true) &&
                (CbBProtocol.SelectedIndex == 0))
            {
                TxBServer.Enabled = false;
                TxBServer.Text = CbBProtocol.Text;
            }
            else
            {
                TxBServer.Enabled = true;
                TxBServer.Text = "";
            }
        }

        private void TxBDiretorio_TextChanged(object sender, EventArgs e)
        {
            if (CbBController.Text.ToUpper() == "Oracle".ToUpper())
                TxBUser.Text = TxBFolder.Text;
        }

        private void BtnDiretorio_Click(object sender, EventArgs e)
        {
            OpenFileDialog AbrirDiretorio = new OpenFileDialog();
            AbrirDiretorio.Title = "Folder and Database";
            AbrirDiretorio.FileName = null;
            AbrirDiretorio.Filter = String.Concat(Path.GetFileNameWithoutExtension(Application.ExecutablePath), ".fdb - Banco de Dados do FireBird| *.fdb");
            AbrirDiretorio.InitialDirectory = SystemApplication.CompletePath();
            if (AbrirDiretorio.ShowDialog() != DialogResult.Cancel)
            {
                TxBDatabase.Text = Path.GetFileNameWithoutExtension(AbrirDiretorio.FileName);
                TxBFolder.Text = Path.GetDirectoryName(AbrirDiretorio.FileName);

                Uri Servidor = new Uri(AbrirDiretorio.FileName);
                TxBServer.Text = Servidor.Host;

                if (String.IsNullOrEmpty(TxBServer.Text) == true)
                    TxBServer.Text = Environment.MachineName;
                else
                    TxBFolder.Text = TxBFolder.Text.Substring(TxBServer.Text.Length + 3);
            }
        }

        private void TxBPorta_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxBPort.Text.Trim()) == false)
            {
                try
                {
                    int Inteiro = Convert.ToInt32(TxBPort.Text);

                    if (Inteiro < IPEndPoint.MinPort || Inteiro > IPEndPoint.MaxPort)
                    {
                        MessageBox.Show(String.Concat("The port number must be between the values ", IPEndPoint.MinPort.ToString(), " and ", IPEndPoint.MaxPort.ToString(), "."), Diagnostic.Method(1), MessageBoxButtons.OK, MessageBoxIcon.Error);
                        TxBPort.Focus();
                    }
                }
                catch (Exception exc)
                {
                    MessageBox.Show(String.Concat("Enter only an integer number in the port field.\nOriginal message:\n", exc), Diagnostic.Method(1), MessageBoxButtons.OK, MessageBoxIcon.Error);
                    TxBPort.Focus();
                }
            }
        }

        private void BtnComando_Click(object sender, EventArgs e)
        {
            Date = SystemFile.Date().Replace("/", "");
            Time = SystemFile.Time().Replace(":", "");

            ConnectionConfig.Controller = CbBController.Text;
            ConnectionConfig.Protocol = CbBProtocol.Text;
            ConnectionConfig.Database = TxBDatabase.Text;
            ConnectionConfig.Port = TxBPort.Text;
            ConnectionConfig.Server = TxBServer.Text;
            ConnectionConfig.Path = TxBFolder.Text;
            ConnectionConfig.User = TxBUser.Text;
            ConnectionConfig.Password = TxBPassword.Text;
            ConnectionConfig.Crypto = String.Concat(Date, Time);

            if (ConnectionDb.ConnectionConfig != null)
                TxBCommand.Text = ConnectionDb.Config();
        }
    }
}
