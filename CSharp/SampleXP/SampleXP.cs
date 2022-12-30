using System;
using System.Windows.Forms;
using Database;
using Database.Enumerator;
using Map;
using Objects;
using Operational;
using People;

namespace EmpireXP
{
    public partial class MainF : Form
    {
        private ConnectionEnum ConnectionPosition;
        private Look LookControls;

        public Connection ConnectionDb;

        public MainF()
        {
            InitializeComponent();
        }

        private void MainF_Shown(object sender, EventArgs e)
        {
            ConnectionDb = new Connection();

            ConnectionPosition = ConnectionDb.Open();
            if (ConnectionPosition == ConnectionEnum.Connected)
                LookControls = new Look();
        }

        private void MainF_KeyDown(object sender, KeyEventArgs e)
        {
            if (Key.Pressed(sender, e) == Keys.Escape)
                exitMenu1_Click(sender, e);
        }

        private void databaseCountriesMenu1_Click(object sender, EventArgs e)
        {
            using (CountriesF CountriesForm = new CountriesF())
            {
                try
                {
                    CountriesForm.CommandDb = ConnectionDb.CommandDb;
                    CountriesForm.LookControls = LookControls;
                    CountriesForm.ShowDialog();
                }
                finally
                {
                    CountriesForm.Dispose();
                }
            }
        }

        private void databaseStatesMenu1_Click(object sender, EventArgs e)
        {
            using (StatesF StatesForm = new StatesF())
            {
                try
                {
                    StatesForm.CommandDb = ConnectionDb.CommandDb;
                    StatesForm.LookControls = LookControls;
                    StatesForm.ShowDialog();
                }
                finally
                {
                    StatesForm.Dispose();
                }
            }
        }

        private void databaseCitiesMenu1_Click(object sender, EventArgs e)
        {
            using (CitiesF CitiesForm = new CitiesF())
            {
                try
                {
                    CitiesForm.CommandDb = ConnectionDb.CommandDb;
                    CitiesForm.LookControls = LookControls;
                    CitiesForm.ShowDialog();
                }
                finally
                {
                    CitiesForm.Dispose();
                }
            }
        }

        private void databasePersonsMenu1_Click(object sender, EventArgs e)
        {
            using (PersonsF PersonsForm = new PersonsF())
            {
                try
                {
                    PersonsForm.CommandDb = ConnectionDb.CommandDb;
                    PersonsForm.LookControls = LookControls;
                    PersonsForm.ShowDialog();
                }
                finally
                {
                    PersonsForm.Dispose();
                }
            }
        }

        private void exitMenu1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MainF_FormClosing(object sender, FormClosingEventArgs e)
        {
            ConnectionDb.Close();
        }
    }
}
