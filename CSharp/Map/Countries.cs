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
    public partial class CountriesF : Form
    {
        public Command CommandDb;
        public Look LookControls;

        private RecordEnum CRUDRecord = RecordEnum.Insert;
        private Countries Country;
        private Continents Continent;
        private int Current = 0;

        public CountriesF()
        {
            InitializeComponent();
        }

        private void CountriesF_Shown(object sender, EventArgs e)
        {
            EventConfig(false);
            LookControls.CRUDButton(PnlPanel1, CRUDRecord);
            LookControls.TextLabel(this, CRUDRecord, "Countries");
            EventConfig(true);

            Country = new Countries(CommandDb);
            Continent = new Continents(CommandDb);

            EntityClear();
        }

        private void CountriesF_KeyDown(object sender, KeyEventArgs e)
        {
            Keys KeyPressed = Key.Pressed(sender, e);

            if (KeyPressed == Keys.Escape)
                BtnExit_Click(sender, e);
        }

        private void BtnIUD_Click(object sender, EventArgs e)
        {
            if (Country.Save(TxBId.Text, TxBCountry.Text, TxBInitial.Text, Continent) == true)
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
            LookControls.TextLabel(this, CRUDRecord, "Countries");
            EventConfig(false);
            LookControls.ObjectFocus(TxBCountry);
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
                    SearchForm.TableConfigSearch = "Countries";
                    SearchForm.TableList = Country.SelectDataTable("", "");
                    SearchForm.BtnReport.Visible = BtnReportCountriesMenu.Visible;
                    SearchForm.Text = "Countries";
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
                        LookControls.TextLabel(this, CRUDRecord, "Countries");
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

        private void TxBIdContinent_Leave(object sender, EventArgs e)
        {
            TxBContinent.Text = Continent.SelectName(TxBIdContinent.Text);
            if (String.IsNullOrEmpty(TxBContinent.Text) == true)
            {
                TxBIdContinent.Text = TxBContinent.Text;
                BtnIdContinent_Click(sender, e);
            }
        }

        private void BtnIdContinent_Click(object sender, EventArgs e)
        {
            using (SearchDataF SearchForm = new SearchDataF())
            {
                try
                {
                    SearchForm.TxBDescription.CharacterCasing = CharacterCasing.Upper;
                    SearchForm.CommandDb = CommandDb;
                    SearchForm.LookControls = LookControls;
                    SearchForm.CRUDRecord = RecordEnum.Select;
                    SearchForm.TableConfigSearch = Continent.TableConfigSearch;
                    SearchForm.TableList = Continent.SelectDataTable("");
                    SearchForm.ParameterId = "Id";
                    SearchForm.ParameterName = "Continent";
                    SearchForm.Text = Continent.FormText;
                    SearchForm.ShowDialog();
                }
                finally
                {
                    if (String.IsNullOrEmpty(SearchForm.IdValue) == false)
                    {
                        TxBIdContinent.Text = SearchForm.IdValue;
                        TxBContinent.Text = SearchForm.NameValue;

                        Continent.Id = SearchForm.IdValue;
                        Continent.Name = SearchForm.NameValue;
                    }

                    SearchForm.Dispose();
                }
            }
        }

        private void databaseContinentsMenu2_Click(object sender, EventArgs e)
        {
            using (SimpleF SimpleForm = new SimpleF())
            {
                try
                {
                    if (String.IsNullOrEmpty(TxBIdContinent.Text) == true)
                        SimpleForm.CRUDRecord = RecordEnum.Insert;
                    else
                    {
                        SimpleForm.CRUDRecord = RecordEnum.Update;
                        SimpleForm.TxBId.Text = TxBIdContinent.Text;
                        SimpleForm.TxBDescription.Text = TxBContinent.Text;
                    }

                    SimpleForm.TxBDescription.CharacterCasing = CharacterCasing.Upper;
                    SimpleForm.CommandDb = CommandDb;
                    SimpleForm.LookControls = LookControls;
                    SimpleForm.TupleIdName = Continent;
                    SimpleForm.Text = databaseContinentsMenu2.Text;
                    SimpleForm.ShowDialog();
                }
                finally
                {
                    SimpleForm.Dispose();
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
                Country.Insert();
            else if (CRUDRecord == RecordEnum.Update)
                Country.Update();
            else if (CRUDRecord == RecordEnum.Delete)
                Country.Delete();
        }

        private void EntityClear()
        {
            Continent.Id = "";
            Continent.Name = "";
        }

        private void EventConfig(bool Config)
        {
            if (Config == true)
                TxBIdContinent.Leave += TxBIdContinent_Leave;
            else
                TxBIdContinent.Leave -= TxBIdContinent_Leave;
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
            TxBCountry.Text = Table.Rows[Current]["Country"].ToString();
            TxBInitial.Text = Table.Rows[Current]["Initial"].ToString();
            TxBIdContinent.Text = Table.Rows[Current]["IdContinent"].ToString();
            TxBContinent.Text = Table.Rows[Current]["Continent"].ToString();

            Country.Id = TxBId.Text;
            Continent.Id = TxBIdContinent.Text;
        }

        private void CountriesF_FormClosing(object sender, FormClosingEventArgs e)
        {
            Country.Dispose();
            Continent.Dispose();
        }
    }
}
