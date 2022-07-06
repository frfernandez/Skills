using System;
using System.Windows.Forms;
using Database;
using Database.Enumerator;
using Map;
using Objects;
using Operational;
using People;

namespace SampleXP
{
    public partial class PrincipalF : Form
    {
        private ConnectionEnum ConnectionPosition;
        private Look LookControls;

        public Connection ConnectionDb;

        public PrincipalF()
        {
            InitializeComponent();
        }

        private void PrincipalF_Shown(object sender, EventArgs e)
        {
            ConnectionDb = new Connection();

            ConnectionPosition = ConnectionDb.Open();
            if (ConnectionPosition == ConnectionEnum.Connected)
                LookControls = new Look();
            else if (ConnectionPosition == ConnectionEnum.Disconnected)
                cadastrosMenu1.Visible = false;
        }

        private void PrincipalF_KeyDown(object sender, KeyEventArgs e)
        {
            if (Key.Pressed(sender, e) == Keys.Escape)
                saidaMenu1_Click(sender, e);
        }

        private void cadastrosPaisesMenu1_Click(object sender, EventArgs e)
        {
            using (PaisesF PaisesForm = new PaisesF())
            {
                try
                {
                    PaisesForm.CommandDb = ConnectionDb.CommandDb;
                    PaisesForm.LookControls = LookControls;
                    PaisesForm.ShowDialog();
                }
                finally
                {
                    PaisesForm.Dispose();
                }
            }
        }

        private void cadastrosEstadosMenu1_Click(object sender, EventArgs e)
        {
            using (EstadosF EstadosForm = new EstadosF())
            {
                try
                {
                    EstadosForm.CommandDb = ConnectionDb.CommandDb;
                    EstadosForm.LookControls = LookControls;
                    EstadosForm.ShowDialog();
                }
                finally
                {
                    EstadosForm.Dispose();
                }
            }
        }

        private void cidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (CidadesF CidadesForm = new CidadesF())
            {
                try
                {
                    CidadesForm.CommandDb = ConnectionDb.CommandDb;
                    CidadesForm.LookControls = LookControls;
                    CidadesForm.ShowDialog();
                }
                finally
                {
                    CidadesForm.Dispose();
                }
            }
        }

        private void cadastrosPessoasMenu1_Click(object sender, EventArgs e)
        {
            using (PessoasF PessoasForm = new PessoasF())
            {
                try
                {
                    PessoasForm.CommandDb = ConnectionDb.CommandDb;
                    PessoasForm.LookControls = LookControls;
                    PessoasForm.ShowDialog();
                }
                finally
                {
                    PessoasForm.Dispose();
                }
            }
        }

        private void saidaMenu1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PrincipalF_FormClosing(object sender, FormClosingEventArgs e)
        {
            ConnectionDb.Close();
        }
    }
}
