using System;
using System.Data;
using System.Windows.Forms;
using Database;
using Basics;
using Entity.Map;
using Objects;
using Objects.Enumerator;
using Operational;

namespace Map
{
    public partial class CitiesF : Form
    {
        public Command CommandDb;
        public Look LookControls;

        private RecordEnum CRUDRecord = RecordEnum.Insert;
        private Cities City;
        private Countries Country;
        private States State;
        private int Current = 0;

        public CitiesF()
        {
            InitializeComponent();
        }

        private void CitiesF_Shown(object sender, EventArgs e)
        {
            EventConfig(false);
            LookControls.CRUDButton(PnlPanel1, CRUDRecord);
            LookControls.TextLabel(this, CRUDRecord, "Cities");
            EventConfig(true);

            City = new Cities(CommandDb);
            Country = new Countries(CommandDb);
            State = new States(CommandDb);

            EntityClear();
        }

        private void CitiesF_KeyDown(object sender, KeyEventArgs e)
        {
            Keys KeyPressed = Key.Pressed(sender, e);

            if (KeyPressed == Keys.Escape)
                BtnExit_Click(sender, e);
        }

        private void BtnIUD_Click(object sender, EventArgs e)
        {
            if (City.Save(TxBId.Text, TxBCity.Text, State) == true)
            {
                CRUDConfig();
                BtnCancel_Click(sender, e);
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Values.PanelClean(PnlPanel2);

            CRUDRecord = RecordEnum.Insert;
            LookControls.CRUDButton(PnlPanel1, CRUDRecord);
            LookControls.TextLabel(this, CRUDRecord, "Cities");
            EventConfig(false);
            LookControls.ObjectFocus(TxBCity);
            EventConfig(true);

            EntityClear();
        }

        private void BtnFilter_Click(object sender, EventArgs e)
        {
            EntityClear();

            using (SearchDataF SearchForm = new SearchDataF())
            {
                try
                {
                    SearchForm.TxBDescription.CharacterCasing = CharacterCasing.Upper;
                    SearchForm.CommandDb = CommandDb;
                    SearchForm.LookControls = LookControls;
                    SearchForm.CRUDRecord = CRUDRecord;
                    SearchForm.TableConfigSearch = "Cities";
                    SearchForm.TableList = City.SelectDataTable("", "", State, Country, null);
                    SearchForm.Text = "Cities";
                    SearchForm.ShowDialog();
                }
                finally
                {
                    if (String.IsNullOrEmpty(SearchForm.IdValue) == false)
                    {
                        Current = SearchForm.Current;
                        Data(SearchForm.TableFilter);

                        CRUDRecord = SearchForm.CRUDRecord;
                        LookControls.CRUDButton(PnlPanel1, CRUDRecord);
                        LookControls.TextLabel(this, CRUDRecord, "Cities");
                    }

                    SearchForm.Dispose();
                }
            }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TxBIdCountry_Leave(object sender, EventArgs e)
        {
            TxBCountry.Text = Country.SelectName(TxBIdCountry.Text);
            if (String.IsNullOrEmpty(TxBCountry.Text) == true)
            {
                TxBIdCountry.Text = TxBCountry.Text;
                BtnIdCountry_Click(sender, e);
            }
        }

        private void BtnIdCountry_Click(object sender, EventArgs e)
        {
            using (SearchDataF SearchForm = new SearchDataF())
            {
                try
                {
                    SearchForm.TxBDescription.CharacterCasing = CharacterCasing.Upper;
                    SearchForm.CommandDb = CommandDb;
                    SearchForm.LookControls = LookControls;
                    SearchForm.CRUDRecord = RecordEnum.Select;
                    SearchForm.TableConfigSearch = "Countries";
                    SearchForm.TableList = Country.SelectDataTable("", "");
                    SearchForm.ParameterId = "Id";
                    SearchForm.ParameterName = "Country";
                    SearchForm.Text = "Countries";
                    SearchForm.ShowDialog();
                }
                finally
                {
                    if (String.IsNullOrEmpty(SearchForm.IdValue) == false)
                    {
                        TxBIdCountry.Text = SearchForm.IdValue;
                        TxBCountry.Text = SearchForm.NameValue;

                        Country.Id = SearchForm.IdValue;
                        Country.Country = SearchForm.NameValue;
                    }

                    SearchForm.Dispose();
                }
            }
        }

        private void TxBIdState_Leave(object sender, EventArgs e)
        {
            TxBState.Text = State.SelectName(TxBIdState.Text, Country);
            if (String.IsNullOrEmpty(TxBState.Text) == true)
            {
                TxBIdState.Text = TxBState.Text;
                BtnIdState_Click(sender, e);
            }
        }

        private void BtnIdState_Click(object sender, EventArgs e)
        {
            using (SearchDataF SearchForm = new SearchDataF())
            {
                try
                {
                    SearchForm.TxBDescription.CharacterCasing = CharacterCasing.Upper;
                    SearchForm.CommandDb = CommandDb;
                    SearchForm.LookControls = LookControls;
                    SearchForm.CRUDRecord = RecordEnum.Select;
                    SearchForm.TableConfigSearch = "States";
                    SearchForm.TableList = State.SelectDataTable("", "", "", Country);
                    SearchForm.ParameterId = "Id";
                    SearchForm.ParameterName = "State";
                    SearchForm.Text = "States";
                    SearchForm.ShowDialog();
                }
                finally
                {
                    if (String.IsNullOrEmpty(SearchForm.IdValue) == false)
                    {
                        TxBIdState.Text = SearchForm.IdValue;
                        TxBState.Text = SearchForm.NameValue;

                        State.Id = SearchForm.IdValue;
                        State.State = SearchForm.NameValue;
                    }

                    SearchForm.Dispose();
                }
            }
        }

        private void databaseCountriesMenu2_Click(object sender, EventArgs e)
        {
            using (CountriesF CountriesForm = new CountriesF())
            {
                try
                {
                    CountriesForm.CommandDb = CommandDb;
                    CountriesForm.LookControls = LookControls;
                    CountriesForm.ShowDialog();
                }
                finally
                {
                    CountriesForm.Dispose();
                }
            }
        }

        private void databaseStatesMenu2_Click(object sender, EventArgs e)
        {
            using (StatesF StatesForm = new StatesF())
            {
                try
                {
                    StatesForm.CommandDb = CommandDb;
                    StatesForm.LookControls = LookControls;
                    StatesForm.ShowDialog();
                }
                finally
                {
                    StatesForm.Dispose();
                }
            }
        }

        private void ButtonVisible()
        {
            if ((CRUDRecord == RecordEnum.Delete) || (CRUDRecord == RecordEnum.Select))
            {
                if (BtnIUD.Visible == true)
                {
                    BtnExit.Left = BtnIUD.Left;
                    BtnIUD.Visible = false;
                }
            }
            else
            {
                if (BtnIUD.Visible == false)
                {
                    BtnExit.Left = BtnIUD.Left + BtnIUD.Width;
                    BtnIUD.Visible = true;
                }
            }

            PnlPanel2.Enabled = BtnIUD.Visible;
        }

        private void CRUDConfig()
        {
            if (CRUDRecord == RecordEnum.Insert)
                City.Insert();
            else if (CRUDRecord == RecordEnum.Update)
                City.Update();
            else if (CRUDRecord == RecordEnum.Delete)
                City.Delete();
        }

        private void EntityClear()
        {
            Country.Id = "";
            Country.Country = "";

            State.Id = "";
            State.State = "";
        }

        private void EventConfig(bool Config)
        {
            if (Config == true)
            {
                TxBIdCountry.Leave += TxBIdCountry_Leave;
                TxBIdState.Leave += TxBIdState_Leave;
            }
            else
            {
                TxBIdCountry.Leave -= TxBIdCountry_Leave;
                TxBIdState.Leave -= TxBIdState_Leave;
            }
        }

        private void Enable()
        {
            BtnIUD.Enabled = true;

            if (CRUDRecord == RecordEnum.Delete)
                PnlPanel2.Enabled = false;
            else
                PnlPanel2.Enabled = true;
        }

        private void Data(DataTable Table)
        {
            TxBId.Text = Table.Rows[Current]["Id"].ToString();
            TxBCity.Text = Table.Rows[Current]["City"].ToString();
            TxBIdCountry.Text = Table.Rows[Current]["IdCountry"].ToString();
            TxBCountry.Text = Table.Rows[Current]["Country"].ToString();
            TxBIdState.Text = Table.Rows[Current]["IdState"].ToString();
            TxBState.Text = Table.Rows[Current]["State"].ToString();

            City.Id = TxBId.Text;
            Country.Id = TxBIdCountry.Text;
            State.State = TxBIdState.Text;
        }

        private void CitiesF_FormClosing(object sender, FormClosingEventArgs e)
        {
            City.Dispose();
            Country.Dispose();
            State.Dispose();
        }
    }
}
