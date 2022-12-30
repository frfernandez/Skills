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
    public partial class StatesF : Form
    {
        public Command CommandDb;
        public Look LookControls;

        private RecordEnum CRUDRecord = RecordEnum.Insert;
        private States State;
        private Countries Country;
        private int Current = 0;

        public StatesF()
        {
            InitializeComponent();
        }

        private void StatesF_Shown(object sender, EventArgs e)
        {
            EventConfig(false);
            LookControls.CRUDButton(PnlPanel1, CRUDRecord);
            LookControls.TextLabel(this, CRUDRecord, "States");
            EventConfig(true);

            State = new States(CommandDb);
            Country = new Countries(CommandDb);

            EntityClear();
        }

        private void StatesF_KeyDown(object sender, KeyEventArgs e)
        {
            Keys KeyPressed = Key.Pressed(sender, e);

            if (KeyPressed == Keys.Escape)
                BtnExit_Click(sender, e);
        }

        private void BtnIUD_Click(object sender, EventArgs e)
        {
            if (State.Save(TxBId.Text, TxBState.Text, TxBInitial.Text, Country) == true)
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
            LookControls.TextLabel(this, CRUDRecord, "States");
            EventConfig(false);
            LookControls.ObjectFocus(TxBState);
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
                    SearchForm.TableConfigSearch = "States";
                    SearchForm.TableList = State.SelectDataTable("", "", "", Country);
                    SearchForm.BtnReport.Visible = BtnReportStatesMenu.Visible;
                    SearchForm.Text = "States";
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
                        LookControls.TextLabel(this, CRUDRecord, "States");
                        Enable();
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

        private void ButtonVisible()
        {
            if (CRUDRecord == RecordEnum.Select)
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
                State.Insert();
            else if (CRUDRecord == RecordEnum.Update)
                State.Update();
            else if (CRUDRecord == RecordEnum.Delete)
                State.Delete();
        }

        private void EntityClear()
        {
            Country.Id = "";
            Country.Country = "";
        }

        private void EventConfig(bool Config)
        {
            if (Config == true)
                TxBIdCountry.Leave += TxBIdCountry_Leave;
            else
                TxBIdCountry.Leave -= TxBIdCountry_Leave;
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
            TxBState.Text = Table.Rows[Current]["State"].ToString();
            TxBInitial.Text = Table.Rows[Current]["Initial"].ToString();
            TxBIdCountry.Text = Table.Rows[Current]["IdCountry"].ToString();
            TxBCountry.Text = Table.Rows[Current]["Country"].ToString();

            State.Id = TxBId.Text;
            Country.Id = TxBIdCountry.Text;
        }

        private void StatesF_FormClosing(object sender, FormClosingEventArgs e)
        {
            State.Dispose();
            Country.Dispose();
        }
    }
}
