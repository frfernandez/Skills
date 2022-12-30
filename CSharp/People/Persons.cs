using System;
using System.Data;
using System.Windows.Forms;
using Database;
using Basics;
using Entity.Map;
using Entity.Person;
using Map;
using Objects;
using Objects.Enumerator;
using Operational;

namespace People
{
    public partial class PersonsF : Form
    {
        public Command CommandDb;
        public Look LookControls;

        private RecordEnum CRUDRecord = RecordEnum.Insert;
        private Persons Person;
        private PersonsAddresses PersonAddress;
        private Neighborhoods Neighborhood;
        private Addresses Address;
        private Districts District;
        private Cities City;

        private DataTable TableCity = null,
                          TablePersonAddress = null;

        public PersonsF()
        {
            InitializeComponent();
        }

        private void PersonF_Shown(object sender, EventArgs e)
        {
            EventConfig(false);
            LookControls.CRUDButton(PnlPanel1, CRUDRecord);
            LookControls.TextLabel(this, CRUDRecord, "Persons");
            EventConfig(true);

            Person = new Persons(CommandDb);
            PersonAddress = new PersonsAddresses(CommandDb);
            Neighborhood = new Neighborhoods(CommandDb);
            Address = new Addresses(CommandDb);
            District = new Districts(CommandDb);
            City = new Cities(CommandDb);

            EntityClear();
        }

        private void PersonF_KeyDown(object sender, KeyEventArgs e)
        {
            Keys KeyPressed = Key.Pressed(sender, e);

            if (KeyPressed == Keys.Escape)
                BtnExit_Click(sender, e);
        }

        private void BtnIUD_Click(object sender, EventArgs e)
        {
            if (PersonAddress.Save(Person, "1", MkBPostalArea.Text, TxBComplement.Text,
                                   Neighborhood, Address, TxBNumber.Text, District, City) == true)
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
            LookControls.TextLabel(this, CRUDRecord, "Persons");
            EventConfig(false);
            LookControls.ObjectFocus(TxBIdPerson);
            EventConfig(true);

            EntityClear();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TxBIdPerson_Leave(object sender, EventArgs e)
        {
            TxBPerson.Text = Person.SelectName(TxBIdPerson.Text);
            if (String.IsNullOrEmpty(TxBPerson.Text) == true)
            {
                TxBIdPerson.Text = TxBPerson.Text;
                BtnIdPerson_Click(sender, e);
            }
            else
                Data();
        }

        private void BtnIdPerson_Click(object sender, EventArgs e)
        {
            using (SearchDataF SearchForm = new SearchDataF())
            {
                try
                {
                    SearchForm.TxBDescription.CharacterCasing = CharacterCasing.Upper;
                    SearchForm.CommandDb = CommandDb;
                    SearchForm.LookControls = LookControls;
                    SearchForm.CRUDRecord = RecordEnum.Select;
                    SearchForm.TableConfigSearch = Person.TableConfigSearch;
                    SearchForm.TableList = Person.SelectDataTable("");
                    SearchForm.ParameterId = "Id";
                    SearchForm.ParameterName = "Person";
                    SearchForm.Text = Person.FormText;
                    SearchForm.ShowDialog();
                }
                finally
                {
                    if (String.IsNullOrEmpty(SearchForm.IdValue) == false)
                    {
                        TxBIdPerson.Text = SearchForm.IdValue;
                        TxBPerson.Text = SearchForm.NameValue;

                        Person.Id = SearchForm.IdValue;
                        Person.Name = SearchForm.NameValue;
                        Data();
                    }

                    SearchForm.Dispose();
                }
            }
        }

        private void TxBIdDistrict_Leave(object sender, EventArgs e)
        {
            TxBDistrict.Text = District.SelectName(TxBIdDistrict.Text);
            if (String.IsNullOrEmpty(TxBDistrict.Text) == true)
            {
                TxBIdDistrict.Text = TxBDistrict.Text;
                BtnIdDistrict_Click(sender, e);
            }
        }

        private void BtnIdDistrict_Click(object sender, EventArgs e)
        {
            using (SearchDataF SearchForm = new SearchDataF())
            {
                try
                {
                    SearchForm.TxBDescription.CharacterCasing = CharacterCasing.Upper;
                    SearchForm.CommandDb = CommandDb;
                    SearchForm.LookControls = LookControls;
                    SearchForm.CRUDRecord = RecordEnum.Select;
                    SearchForm.TableConfigSearch = District.TableConfigSearch;
                    SearchForm.TableList = District.SelectDataTable("");
                    SearchForm.ParameterId = "Id";
                    SearchForm.ParameterName = "District";
                    SearchForm.Text = District.FormText;
                    SearchForm.ShowDialog();
                }
                finally
                {
                    if (String.IsNullOrEmpty(SearchForm.IdValue) == false)
                    {
                        TxBIdDistrict.Text = SearchForm.IdValue;
                        TxBDistrict.Text = SearchForm.NameValue;

                        District.Id = SearchForm.IdValue;
                        District.Name = SearchForm.NameValue;
                    }

                    SearchForm.Dispose();
                }
            }
        }

        private void TxBIdCity_Leave(object sender, EventArgs e)
        {
            TxBCity.Text = City.SelectName(TxBIdCity.Text);
            if (String.IsNullOrEmpty(TxBCity.Text) == true)
            {
                TxBIdCity.Text = TxBCity.Text;
                BtnIdCity_Click(sender, e);
            }

            if (String.IsNullOrEmpty(TxBIdCity.Text) == false)
            {
                TableCity = City.SelectDataTable(TxBIdCity.Text, "", null, null, null);
                TxBCity.Text = TableCity.DefaultView[0]["City"].ToString();
                TxBIdState.Text = TableCity.DefaultView[0]["IdState"].ToString();
                TxBState.Text = TableCity.DefaultView[0]["State"].ToString();
                TxBStateInitial.Text = TableCity.DefaultView[0]["StateInitial"].ToString();
                TxBIdCountry.Text = TableCity.DefaultView[0]["IdCountry"].ToString();
                TxBCountry.Text = TableCity.DefaultView[0]["Country"].ToString();
                TxBCountryInitial.Text = TableCity.DefaultView[0]["CountryInitial"].ToString();
                TxBIdContinent.Text = TableCity.DefaultView[0]["IdContinent"].ToString();
                TxBContinent.Text = TableCity.DefaultView[0]["Continent"].ToString();
            }
        }

        private void BtnIdCity_Click(object sender, EventArgs e)
        {
            using (SearchDataF SearchForm = new SearchDataF())
            {
                try
                {
                    SearchForm.TxBDescription.CharacterCasing = CharacterCasing.Upper;
                    SearchForm.CommandDb = CommandDb;
                    SearchForm.LookControls = LookControls;
                    SearchForm.CRUDRecord = RecordEnum.Select;
                    SearchForm.TableConfigSearch = "Cities";
                    SearchForm.TableList = City.SelectDataTable("", "", null, null, null);
                    SearchForm.ParameterId = "Id";
                    SearchForm.ParameterName = "City";
                    SearchForm.Text = "Cities";
                    SearchForm.ShowDialog();
                }
                finally
                {
                    if (String.IsNullOrEmpty(SearchForm.IdValue) == false)
                    {
                        TxBIdCity.Text = SearchForm.IdValue;
                        TxBCity.Text = SearchForm.NameValue;

                        City.Id = SearchForm.IdValue;
                        City.City = SearchForm.NameValue;
                    }

                    SearchForm.Dispose();
                }
            }
        }

        private void TxBIdNeighborhood_Leave(object sender, EventArgs e)
        {
            TxBNeighborhood.Text = Neighborhood.SelectName(TxBIdNeighborhood.Text);
            if (String.IsNullOrEmpty(TxBNeighborhood.Text) == true)
            {
                TxBIdNeighborhood.Text = TxBNeighborhood.Text;
                BtnIdNeighborhood_Click(sender, e);
            }
        }

        private void BtnIdNeighborhood_Click(object sender, EventArgs e)
        {
            using (SearchDataF SearchForm = new SearchDataF())
            {
                try
                {
                    SearchForm.TxBDescription.CharacterCasing = CharacterCasing.Upper;
                    SearchForm.CommandDb = CommandDb;
                    SearchForm.LookControls = LookControls;
                    SearchForm.CRUDRecord = RecordEnum.Select;
                    SearchForm.TableConfigSearch = Neighborhood.TableConfigSearch;
                    SearchForm.TableList = Neighborhood.SelectDataTable("");
                    SearchForm.ParameterId = "Id";
                    SearchForm.ParameterName = "Neighborhood";
                    SearchForm.Text = Neighborhood.FormText;
                    SearchForm.ShowDialog();
                }
                finally
                {
                    if (String.IsNullOrEmpty(SearchForm.IdValue) == false)
                    {
                        TxBIdNeighborhood.Text = SearchForm.IdValue;
                        TxBNeighborhood.Text = SearchForm.NameValue;

                        Neighborhood.Id = SearchForm.IdValue;
                        Neighborhood.Name = SearchForm.NameValue;
                    }

                    SearchForm.Dispose();
                }
            }
        }

        private void TxBIdAddress_Leave(object sender, EventArgs e)
        {
            TxBAddress.Text = Address.SelectName(TxBIdAddress.Text);
            if (String.IsNullOrEmpty(TxBAddress.Text) == true)
            {
                TxBIdAddress.Text = TxBAddress.Text;
                BtnIdAddress_Click(sender, e);
            }
        }

        private void BtnIdAddress_Click(object sender, EventArgs e)
        {
            using (SearchDataF SearchForm = new SearchDataF())
            {
                try
                {
                    SearchForm.TxBDescription.CharacterCasing = CharacterCasing.Upper;
                    SearchForm.CommandDb = CommandDb;
                    SearchForm.LookControls = LookControls;
                    SearchForm.CRUDRecord = RecordEnum.Select;
                    SearchForm.TableConfigSearch = Address.TableConfigSearch;
                    SearchForm.TableList = Address.SelectDataTable("");
                    SearchForm.ParameterId = "Id";
                    SearchForm.ParameterName = "Address";
                    SearchForm.Text = Address.FormText;
                    SearchForm.ShowDialog();
                }
                finally
                {
                    if (String.IsNullOrEmpty(SearchForm.IdValue) == false)
                    {
                        TxBIdAddress.Text = SearchForm.IdValue;
                        TxBAddress.Text = SearchForm.NameValue;

                        Address.Id = SearchForm.IdValue;
                        Address.Name = SearchForm.NameValue;
                    }

                    SearchForm.Dispose();
                }
            }
        }

        private void databasePersonsMenu2_Click(object sender, EventArgs e)
        {
            using (SimpleF SimpleForm = new SimpleF())
            {
                try
                {
                    if (String.IsNullOrEmpty(TxBIdPerson.Text) == true)
                        SimpleForm.CRUDRecord = RecordEnum.Insert;
                    else
                    {
                        SimpleForm.CRUDRecord = RecordEnum.Update;
                        SimpleForm.TxBId.Text = TxBIdPerson.Text;
                        SimpleForm.TxBDescription.Text = TxBPerson.Text;
                    }

                    SimpleForm.TxBDescription.CharacterCasing = CharacterCasing.Upper;
                    SimpleForm.CommandDb = CommandDb;
                    SimpleForm.LookControls = LookControls;
                    SimpleForm.TupleIdName = Person;
                    SimpleForm.Text = databasePersonsMenu2.Text;
                    SimpleForm.ShowDialog();
                }
                finally
                {
                    SimpleForm.Dispose();
                }
            }
        }

        private void databaseNeighborhoodsMenu2_Click(object sender, EventArgs e)
        {
            using (SimpleF SimpleForm = new SimpleF())
            {
                try
                {
                    if (String.IsNullOrEmpty(TxBIdNeighborhood.Text) == true)
                        SimpleForm.CRUDRecord = RecordEnum.Insert;
                    else
                    {
                        SimpleForm.CRUDRecord = RecordEnum.Update;
                        SimpleForm.TxBId.Text = TxBIdNeighborhood.Text;
                        SimpleForm.TxBDescription.Text = TxBNeighborhood.Text;
                    }

                    SimpleForm.TxBDescription.CharacterCasing = CharacterCasing.Upper;
                    SimpleForm.CommandDb = CommandDb;
                    SimpleForm.LookControls = LookControls;
                    SimpleForm.TupleIdName = Neighborhood;
                    SimpleForm.Text = databaseNeighborhoodsMenu2.Text;
                    SimpleForm.ShowDialog();
                }
                finally
                {
                    SimpleForm.Dispose();
                }
            }
        }

        private void databaseAddressesMenu2_Click(object sender, EventArgs e)
        {
            using (SimpleF SimpleForm = new SimpleF())
            {
                try
                {
                    if (String.IsNullOrEmpty(TxBIdAddress.Text) == true)
                        SimpleForm.CRUDRecord = RecordEnum.Insert;
                    else
                    {
                        SimpleForm.CRUDRecord = RecordEnum.Update;
                        SimpleForm.TxBId.Text = TxBIdAddress.Text;
                        SimpleForm.TxBDescription.Text = TxBAddress.Text;
                    }

                    SimpleForm.TxBDescription.CharacterCasing = CharacterCasing.Upper;
                    SimpleForm.CommandDb = CommandDb;
                    SimpleForm.LookControls = LookControls;
                    SimpleForm.TupleIdName = Address;
                    SimpleForm.Text = databaseAddressesMenu2.Text;
                    SimpleForm.ShowDialog();
                }
                finally
                {
                    SimpleForm.Dispose();
                }
            }
        }

        private void databaseDistrictsMenu2_Click(object sender, EventArgs e)
        {
            using (SimpleF SimpleForm = new SimpleF())
            {
                try
                {
                    if (String.IsNullOrEmpty(TxBIdDistrict.Text) == true)
                        SimpleForm.CRUDRecord = RecordEnum.Insert;
                    else
                    {
                        SimpleForm.CRUDRecord = RecordEnum.Update;
                        SimpleForm.TxBId.Text = TxBIdDistrict.Text;
                        SimpleForm.TxBDescription.Text = TxBDistrict.Text;
                    }

                    SimpleForm.TxBDescription.CharacterCasing = CharacterCasing.Upper;
                    SimpleForm.CommandDb = CommandDb;
                    SimpleForm.LookControls = LookControls;
                    SimpleForm.TupleIdName = District;
                    SimpleForm.Text = databaseDistrictsMenu2.Text;
                    SimpleForm.ShowDialog();
                }
                finally
                {
                    SimpleForm.Dispose();
                }
            }
        }

        private void databaseCitiesMenu2_Click(object sender, EventArgs e)
        {
            using (CitiesF CidadesForm = new CitiesF())
            {
                try
                {
                    CidadesForm.CommandDb = CommandDb;
                    CidadesForm.LookControls = LookControls;
                    CidadesForm.ShowDialog();
                }
                finally
                {
                    CidadesForm.Dispose();
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
                PersonAddress.Insert();
            else if (CRUDRecord == RecordEnum.Update)
                PersonAddress.Update();
            else if (CRUDRecord == RecordEnum.Delete)
                Person.Delete();
        }

        private void EntityClear()
        {
            Person.Id = "";
            Person.Name = "";

            PersonAddress.Position = "";
            PersonAddress.PostalArea = "";
            PersonAddress.Number = "";

            Neighborhood.Id = "";
            Neighborhood.Name = "";

            Address.Id = "";
            Address.Name = "";

            District.Id = "";
            District.Name = "";

            City.Id = "";

            TableCity = null;
            TablePersonAddress = null;
        }

        private void EventConfig(bool Config)
        {
            if (Config == true)
            {
                TxBIdPerson.Leave += TxBIdPerson_Leave;
                TxBIdNeighborhood.Leave += TxBIdNeighborhood_Leave;
                TxBIdAddress.Leave += TxBIdAddress_Leave;
                TxBIdDistrict.Leave += TxBIdDistrict_Leave;
                TxBIdCity.Leave += TxBIdCity_Leave;
            }
            else
            {
                TxBIdPerson.Leave -= TxBIdPerson_Leave;
                TxBIdNeighborhood.Leave -= TxBIdNeighborhood_Leave;
                TxBIdAddress.Leave -= TxBIdAddress_Leave;
                TxBIdDistrict.Leave -= TxBIdDistrict_Leave;
                TxBIdCity.Leave -= TxBIdCity_Leave;
            }
        }

        private void Data()
        {
            EntityClear();

            if (String.IsNullOrEmpty(TxBIdPerson.Text) == true)
                Person.Id = "0";
            else
                Person.Id = TxBIdPerson.Text;

            TxBPerson.Text = Person.SelectName(TxBIdPerson.Text);
            Person.Name = TxBPerson.Text;

            TablePersonAddress = PersonAddress.SelectDataTable(Person);
            if (TablePersonAddress.Rows.Count == 0)
                CRUDRecord = RecordEnum.Insert;
            else
            {
                CRUDRecord = RecordEnum.Update;

                MkBPostalArea.Text = TablePersonAddress.DefaultView[0]["PostalArea"].ToString();
                TxBIdNeighborhood.Text = TablePersonAddress.DefaultView[0]["IdNeighborhood"].ToString();
                TxBNeighborhood.Text = TablePersonAddress.DefaultView[0]["Neighborhood"].ToString();
                TxBIdAddress.Text = TablePersonAddress.DefaultView[0]["IdAddress"].ToString();
                TxBAddress.Text = TablePersonAddress.DefaultView[0]["Address"].ToString();
                TxBNumber.Text = TablePersonAddress.DefaultView[0]["Number"].ToString();
                TxBIdDistrict.Text = TablePersonAddress.DefaultView[0]["IdDistrict"].ToString();
                TxBDistrict.Text = TablePersonAddress.DefaultView[0]["District"].ToString();
                TxBIdCity.Text = TablePersonAddress.DefaultView[0]["IdCity"].ToString();
                TxBCity.Text = TablePersonAddress.DefaultView[0]["City"].ToString();
                TxBIdState.Text = TablePersonAddress.DefaultView[0]["IdState"].ToString();
                TxBState.Text = TablePersonAddress.DefaultView[0]["State"].ToString();
                TxBStateInitial.Text = TablePersonAddress.DefaultView[0]["StateInitial"].ToString();
                TxBIdCountry.Text = TablePersonAddress.DefaultView[0]["IdCountry"].ToString();
                TxBCountry.Text = TablePersonAddress.DefaultView[0]["Country"].ToString();
                TxBCountryInitial.Text = TablePersonAddress.DefaultView[0]["CountryInitial"].ToString();
                TxBIdContinent.Text = TablePersonAddress.DefaultView[0]["IdContinent"].ToString();
                TxBContinent.Text = TablePersonAddress.DefaultView[0]["Continent"].ToString();
                TxBComplement.Text = TablePersonAddress.DefaultView[0]["Complement"].ToString();
            }

            PersonAddress.Position = "1";
            Neighborhood.Id = TxBIdNeighborhood.Text;
            Address.Id = TxBIdAddress.Text;
            District.Id = TxBIdDistrict.Text;
            City.Id = TxBIdCity.Text;

            LookControls.CRUDButton(PnlPanel1, CRUDRecord);
            LookControls.TextLabel(this, CRUDRecord, "Person");
        }

        private void PersonF_FormClosing(object sender, FormClosingEventArgs e)
        {
            Person.Dispose();
            PersonAddress.Dispose();
            Neighborhood.Dispose();
            Address.Dispose();
            District.Dispose();
            City.Dispose();
        }
    }
}
