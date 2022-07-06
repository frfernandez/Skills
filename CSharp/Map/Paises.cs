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
    public partial class PaisesF : Form
    {
        public Command CommandDb;
        public Look LookControls;

        private RecordEnum CRUDRecord = RecordEnum.Insert;
        private Paises Pais;
        private Continentes Continente;
        private int Current = 0;

        public PaisesF()
        {
            InitializeComponent();
        }

        private void PaisesF_Shown(object sender, EventArgs e)
        {
            EventConfig(false);
            LookControls.CRUDButton(PnlPainel1, CRUDRecord);
            LookControls.TextLabel(this, CRUDRecord, "Países");
            EventConfig(true);

            Pais = new Paises(CommandDb);
            Continente = new Continentes(CommandDb);

            EntityClear();
        }

        private void PaisesF_KeyDown(object sender, KeyEventArgs e)
        {
            if (Key.Pressed(sender, e) == Keys.Escape)
                BtnSaida_Click(sender, e);
        }

        private void BtnIAE_Click(object sender, EventArgs e)
        {
            if (Pais.Save(TxBCodigo.Text, TxBPais.Text, TxBSigla.Text, Continente) == true)
            {
                CRUDConfig();
                BtnCancela_Click(sender, e);
            }
        }

        private void BtnCancela_Click(object sender, EventArgs e)
        {
            Values.PanelClean(PnlPainel2);

            CRUDRecord = RecordEnum.Insert;
            LookControls.CRUDButton(PnlPainel1, CRUDRecord);
            LookControls.TextLabel(this, CRUDRecord, "Países");
            EventConfig(false);
            LookControls.ObjectFocus(TxBPais);
            EventConfig(true);

            EntityClear();
        }

        private void BtnFiltro_Click(object sender, EventArgs e)
        {
            EntityClear();

            using (SearchDataF SearchForm = new SearchDataF())
            {
                try
                {
                    SearchForm.TxBDescricao.CharacterCasing = CharacterCasing.Upper;
                    SearchForm.CommandDb = CommandDb;
                    SearchForm.LookControls = LookControls;
                    SearchForm.CRUDRecord = CRUDRecord;
                    SearchForm.TableConfigSearch = "Paises";
                    SearchForm.TableList = Pais.SelectDataTable("", "");
                    SearchForm.ParameterId = "Codigo";
                    SearchForm.ParameterName = "Pais";
                    SearchForm.Text = "Países";
                    SearchForm.ShowDialog();
                }
                finally
                {
                    if (String.IsNullOrEmpty(SearchForm.IdValue) == false)
                    {
                        Current = SearchForm.Current;
                        Data(SearchForm.TableFilter);

                        CRUDRecord = SearchForm.CRUDRecord;
                        LookControls.CRUDButton(PnlPainel1, CRUDRecord);
                        LookControls.TextLabel(this, CRUDRecord, "Países");
                    }

                    SearchForm.Dispose();
                }
            }
        }

        private void BtnSaida_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TxBCodigoContinente_Leave(object sender, EventArgs e)
        {
            TxBContinente.Text = Continente.SelectName(TxBCodigoContinente.Text);
            if (String.IsNullOrEmpty(TxBContinente.Text) == true)
            {
                TxBCodigoContinente.Text = TxBContinente.Text;
                BtnCodigoContinente_Click(sender, e);
            }
        }

        private void BtnCodigoContinente_Click(object sender, EventArgs e)
        {
            using (SearchDataF SearchForm = new SearchDataF())
            {
                try
                {
                    SearchForm.TxBDescricao.CharacterCasing = CharacterCasing.Upper;
                    SearchForm.CommandDb = CommandDb;
                    SearchForm.LookControls = LookControls;
                    SearchForm.CRUDRecord = RecordEnum.Select;
                    SearchForm.TableConfigSearch = Continente.TableConfigSearch;
                    SearchForm.TableList = Continente.SelectDataTable("");
                    SearchForm.ParameterId = "Codigo";
                    SearchForm.ParameterName = "Continente";
                    SearchForm.Text = Continente.FormText;
                    SearchForm.ShowDialog();
                }
                finally
                {
                    if (String.IsNullOrEmpty(SearchForm.IdValue) == false)
                    {
                        TxBCodigoContinente.Text = SearchForm.IdValue;
                        TxBContinente.Text = SearchForm.NameValue;

                        Continente.Id = SearchForm.IdValue;
                        Continente.Name = SearchForm.NameValue;
                    }

                    SearchForm.Dispose();
                }
            }
        }

        private void continentesMenu_Click(object sender, EventArgs e)
        {
            using (SimpleF SimpleForm = new SimpleF())
            {
                try
                {
                    if (String.IsNullOrEmpty(TxBCodigoContinente.Text) == true)
                        SimpleForm.CRUDRecord = RecordEnum.Insert;
                    else
                    {
                        SimpleForm.CRUDRecord = RecordEnum.Update;
                        SimpleForm.TxBCodigo.Text = TxBCodigoContinente.Text;
                        SimpleForm.TxBDescricao.Text = TxBContinente.Text;
                    }

                    SimpleForm.TxBDescricao.CharacterCasing = CharacterCasing.Upper;
                    SimpleForm.CommandDb = CommandDb;
                    SimpleForm.LookControls = LookControls;
                    SimpleForm.TupleIdName = Continente;
                    SimpleForm.Text = continentesMenu2.Text;
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
                if (BtnIAE.Visible == true)
                {
                    BtnSaida.Left = BtnIAE.Left;
                    BtnIAE.Visible = false;
                }
            }
            else
            {
                if (BtnIAE.Visible == false)
                {
                    BtnSaida.Left = BtnIAE.Left + BtnIAE.Width;
                    BtnIAE.Visible = true;
                }
            }

            PnlPainel2.Enabled = BtnIAE.Visible;
        }

        private void CRUDConfig()
        {
            if (CRUDRecord == RecordEnum.Insert)
                Pais.Insert();
            else if (CRUDRecord == RecordEnum.Update)
                Pais.Update();
            else if (CRUDRecord == RecordEnum.Delete)
                Pais.Delete();
        }

        private void EntityClear()
        {
            Continente.Id = "";
            Continente.Name = "";
        }

        private void EventConfig(bool Config)
        {
            if (Config == true)
                TxBCodigoContinente.Leave += TxBCodigoContinente_Leave;
            else
                TxBCodigoContinente.Leave -= TxBCodigoContinente_Leave;
        }

        private void Data(DataTable Table)
        {
            TxBCodigo.Text = Table.Rows[Current]["Codigo"].ToString();
            TxBPais.Text = Table.Rows[Current]["Pais"].ToString();
            TxBSigla.Text = Table.Rows[Current]["Sigla"].ToString();
            TxBCodigoContinente.Text = Table.Rows[Current]["CodigoContinente"].ToString();
            TxBContinente.Text = Table.Rows[Current]["Continente"].ToString();

            Continente.Id = TxBCodigoContinente.Text;
        }

        private void PaisesF_FormClosing(object sender, FormClosingEventArgs e)
        {
            Pais.Dispose();
            Continente.Dispose();
        }
    }
}
