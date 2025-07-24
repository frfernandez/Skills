using System;
using System.Windows.Forms;
using Database;
using Database.Entity;
using Database.Enumerator;
using Database.FormConnection;
using Entity;
using Files;
using Identification;
using Map;
using Objects;
using Objects.Enumerator;
using Operational;
using Search;

namespace Rodonaves
{
    public partial class MainF : Form
    {
        private DatabaseEnum DatabaseType;
        private ConnectionConfig ConnectionConfig;
        private ConnectionEnum ConnectionPosition;
        private DataTables Configuration;
        private Look LookControls;
        private DataFilters DataFilter;
        private String Username;

        public Connection ConnectionDb;

        public MainF()
        {
            InitializeComponent();
        }

        private void ConfigurationDb()
        {
            DataTableCommand TableCommand = new DataTableCommand();
            Configuration = new DataTables(TableCommand);

            Configuration.TableCommand = TableCommand;
        }

        private void UserConnected()
        {
            Username = "";

            if (ConnectionConfig != null)
            {
                if (ConnectionPosition == ConnectionEnum.Connected)
                {
                    Username = String.Concat(" [ ", ConnectionConfig.User, " ] ");
                    TableConfigConnection();
                }
            }
        }

        private void TableConfigConnection()
        {
            Configuration.TableCommand.UniqueRegister(Configuration.TableConfig, String.Concat(ConnectionConfig.User, "|Application|", Application.ProductName));

            if (ConnectionConfig.User.ToUpper() == ConnectionDb.AdministratorGet().ToUpper())
                Configuration.TableCommand.UniqueRegister(Configuration.TableConfig, String.Concat(ConnectionConfig.User, "|Administrator|Y"));
            else
                Configuration.TableCommand.UniqueRegister(Configuration.TableConfig, String.Concat(ConnectionConfig.User, "|Administrator|N"));
        }

        private void DynamicSearch(string View, string ProcedureOrder, EventHandler ItemMenuClick)
        {
            using (DynamicSearchF FilterForm = new DynamicSearchF())
            {
                try
                {
                    FilterForm.CommandDb = ConnectionDb.CommandDb;
                    FilterForm.Configuration = Configuration;
                    FilterForm.LookControls = LookControls;
                    FilterForm.View = View;
                    FilterForm.ProcedureOrder = ProcedureOrder;
                    FilterForm.DataFilter = DataFilter;
                    FilterForm.ItemMenuClick += ItemMenuClick;
                    FilterForm.ShowDialog();
                }
                finally
                {
                    FilterForm.ItemMenuClick -= ItemMenuClick;
                    FilterForm.Dispose();
                }
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            this.Text = String.Concat("[ Rodonaves ] ",
                                      DateTime.Now.ToString("   dd/MM/yyyy - HH:mm:ss   "),
                                      Username);
        }

        private void MainF_Shown(object sender, EventArgs e)
        {
            ConnectionDb = new Connection(DatabaseType);

            ConnectionPosition = ConnectionDb.Open();
            DatabaseType = ConnectionDb.DatabaseType;
            ConnectionConfig = ConnectionDb.ConnectionConfig;

            ConfigurationDb();

            if (ConnectionConfig == null)
                connectionConfigurationsMenu1_Click(sender, e);
            else
            {
                if ((ConnectionPosition == ConnectionEnum.User_Empty) || (ConnectionPosition == ConnectionEnum.Password_Empty))
                    connectionConnectMenu1_Click(sender, e);
                else if (ConnectionPosition == ConnectionEnum.Disconnected)
                    connectionConnectWithMenu1_Click(sender, e);
                else if (ConnectionPosition == ConnectionEnum.Configuration_Empty)
                    connectionConfigurationsMenu1_Click(sender, e);

                if (ConnectionPosition == ConnectionEnum.Connected)
                {
                    TableConfigConnection();

                    DataFilter = new DataFilters(ConnectionDb.CommandDb, Configuration);

                    LookControls = new Look(ConnectionConfig.User, Configuration);
                }
            }

            UserConnected();
        }

        private void MainF_KeyDown(object sender, KeyEventArgs e)
        {
            if (Key.Pressed(sender, e) == Keys.Escape)
                exitMenu1_Click(sender, e);
        }

        private void connectionConnectMenu1_Click(object sender, EventArgs e)
        {
            if (ConnectionPosition == ConnectionEnum.Connected)
                connectionConnectWithMenu1_Click(sender, e);
            else
                ConnectionPosition = ConnectionDb.Open();

            UserConnected();
        }

        private void connectionConnectWithMenu1_Click(object sender, EventArgs e)
        {
            using (ConnectF ConnectForm = new ConnectF())
            {
                ConnectForm.ConnectionState = ConnectionPosition;
                ConnectForm.ConnectionDb = ConnectionDb;
                ConnectForm.LookControls = LookControls;
                ConnectForm.ShowDialog();

                ConnectionPosition = ConnectForm.ConnectionState;

                ConnectForm.Dispose();
            }

            UserConnected();
        }

        private void connectionDisconnectMenu1_Click(object sender, EventArgs e)
        {
            ConnectionDb.Close();
            ConnectionPosition = ConnectionEnum.Disconnected;

            UserConnected();
        }

        private void connectionConfigurationsMenu1_Click(object sender, EventArgs e)
        {
            using (ConnectionF ConexaoForm = new ConnectionF())
            {
                ConexaoForm.DatabaseType = DatabaseType;
                ConexaoForm.ConnectionConfig = ConnectionConfig;
                ConexaoForm.ConnectionState = ConnectionPosition;
                ConexaoForm.ConnectionDb = ConnectionDb;
                ConexaoForm.LookControls = LookControls;
                ConexaoForm.ShowDialog();
                ConnectionPosition = ConexaoForm.ConnectionState;
                ConexaoForm.Dispose();
            }

            UserConnected();
        }

        private void exitMenu1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MainF_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (ConnectionPosition == ConnectionEnum.Connected)
                DataFilter.Dispose();

            ConnectionDb.Close();
        }

        private void databaseUnidadesMenu1_Click(object sender, EventArgs e)
        {
            using (UnidadesF StatesForm = new UnidadesF())
            {
                try
                {
                    StatesForm.CommandDb = ConnectionDb.CommandDb;
                    StatesForm.Configuration = Configuration;
                    StatesForm.LookControls = LookControls;
                    StatesForm.DataFilter = DataFilter;
                    StatesForm.ShowDialog();
                }
                finally
                {
                    StatesForm.Dispose();
                }
            }
        }

        private void databaseUsuariosMenu1_Click(object sender, EventArgs e)
        {
            using (UsuariosF UsuariosForm = new UsuariosF())
            {
                try
                {
                    UsuariosForm.CommandDb = ConnectionDb.CommandDb;
                    UsuariosForm.Configuration = Configuration;
                    UsuariosForm.LookControls = LookControls;
                    UsuariosForm.DataFilter = DataFilter;
                    UsuariosForm.ShowDialog();
                }
                finally
                {
                    UsuariosForm.Dispose();
                }
            }
        }

        private void databaseColaboradoresMenu1_Click(object sender, EventArgs e)
        {
            using (ColaboradoresF ColaboradoresForm = new ColaboradoresF())
            {
                try
                {
                    ColaboradoresForm.CommandDb = ConnectionDb.CommandDb;
                    ColaboradoresForm.Configuration = Configuration;
                    ColaboradoresForm.LookControls = LookControls;
                    ColaboradoresForm.DataFilter = DataFilter;
                    ColaboradoresForm.ShowDialog();
                }
                finally
                {
                    ColaboradoresForm.Dispose();
                }
            }
        }
    }
}
