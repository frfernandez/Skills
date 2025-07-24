using System.Windows.Forms;
using Database.Enumerator;
using Objects;
using Operational;

namespace Database.FormConnection
{
    public partial class ConnectF : Form
    {
        public ConnectionEnum ConnectionState;
        public Connection ConnectionDb;
        public Look LookControls;

        public ConnectF()
        {
            InitializeComponent();
        }

        private void ConnectF_Shown(object sender, System.EventArgs e)
        {
            if (LookControls != null)
                LookControls.Form(this, Images, TTpTip);
        }

        private void ConnectF_KeyDown(object sender, KeyEventArgs e)
        {
            if (Key.Pressed(sender, e) == Keys.Escape)
                BtnExit_Click(sender, e);
        }

        private void BtnConnect_Click(object sender, System.EventArgs e)
        {
            ConnectionDb.ConnectionConfig.User = TxBUser.Text;
            ConnectionDb.ConnectionConfig.Password = TxBPassword.Text;

            ConnectionState = ConnectionDb.Open();
            if (ConnectionState == ConnectionEnum.Connected)
                BtnExit_Click(sender, e);
        }

        private void BtnClean_Click(object sender, System.EventArgs e)
        {
            Values.PanelClean(PnlPanel1);
        }

        private void BtnExit_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }
    }
}
