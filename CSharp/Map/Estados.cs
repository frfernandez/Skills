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
    public partial class EstadosF : Form
    {
        public Command CommandDb;
        public Look LookControls;

        private RecordEnum CRUDRecord = RecordEnum.Insert;
        private Estados Estado;
        private Paises Pais;
        private int Current = 0;

        public EstadosF()
        {
            InitializeComponent();
        }

        private void EstadosF_Shown(object sender, EventArgs e)
        {
            LookControls.CRUDButton(PnlPainel1, CRUDRecord);
            LookControls.TextLabel(this, CRUDRecord, "Estados");
            EventConfig(true);

            Estado = new Estados(CommandDb);
            Pais = new Paises(CommandDb);

            EntityClear();
        }

        private void EstadosF_KeyDown(object sender, KeyEventArgs e)
        {
            if (Key.Pressed(sender, e) == Keys.Escape)
                BtnSaida_Click(sender, e);
        }

        private void BtnIAE_Click(object sender, EventArgs e)
        {
            if (Estado.Save(TxBCodigo.Text, TxBEstado.Text, TxBSigla.Text, Pais) == true)
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
            LookControls.TextLabel(this, CRUDRecord, "Estados");
            EventConfig(false);
            LookControls.ObjectFocus(TxBEstado);
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
                    SearchForm.TableConfigSearch = "Estados";
                    SearchForm.TableList = Estado.SelectDataTable("", "", Pais);
                    SearchForm.ParameterId = "Codigo";
                    SearchForm.ParameterName = "Estado";
                    SearchForm.Text = "Estados";
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
                        LookControls.TextLabel(this, CRUDRecord, "Estados");
                    }

                    SearchForm.Dispose();
                }
            }
        }

        private void BtnSaida_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TxBCodigoPais_Leave(object sender, EventArgs e)
        {
            TxBPais.Text = Pais.SelectName(TxBCodigoPais.Text);
            if (String.IsNullOrEmpty(TxBPais.Text) == true)
            {
                TxBCodigoPais.Text = TxBPais.Text;
                BtnCodigoPais_Click(sender, e);
            }
        }

        private void BtnCodigoPais_Click(object sender, EventArgs e)
        {
            using (SearchDataF SearchForm = new SearchDataF())
            {
                try
                {
                    SearchForm.TxBDescricao.CharacterCasing = CharacterCasing.Upper;
                    SearchForm.CommandDb = CommandDb;
                    SearchForm.LookControls = LookControls;
                    SearchForm.CRUDRecord = RecordEnum.Select;
                    SearchForm.TableConfigSearch = "Paises";
                    SearchForm.TableList = Pais.SelectDataTable("", "");
                    SearchForm.ParameterId = "Codigo";
                    SearchForm.ParameterName = "Pais";
                    SearchForm.Text = "Paises";
                    SearchForm.ShowDialog();
                }
                finally
                {
                    if (String.IsNullOrEmpty(SearchForm.IdValue) == false)
                    {
                        TxBCodigoPais.Text = SearchForm.IdValue;
                        TxBPais.Text = SearchForm.NameValue;

                        Pais.Codigo = SearchForm.IdValue;
                        Pais.Pais = SearchForm.NameValue;
                    }

                    SearchForm.Dispose();
                }
            }
        }

        private void paisesMenu_Click(object sender, EventArgs e)
        {
            using (PaisesF PaisesForm = new PaisesF())
            {
                try
                {
                    PaisesForm.CommandDb = CommandDb;
                    PaisesForm.LookControls = LookControls;
                    PaisesForm.ShowDialog();
                }
                finally
                {
                    PaisesForm.Dispose();
                }
            }
        }

        private void ButtonVisible()
        {
            if (CRUDRecord == RecordEnum.Select)
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

            if (CRUDRecord == RecordEnum.Update)
                PnlPainel2.Enabled = BtnIAE.Visible;
            else
                PnlPainel2.Enabled = false;
        }

        private void CRUDConfig()
        {
            if (CRUDRecord == RecordEnum.Insert)
                Estado.Insert();
            else if (CRUDRecord == RecordEnum.Update)
                Estado.Update();
            else if (CRUDRecord == RecordEnum.Delete)
                Estado.Delete();
        }

        private void EntityClear()
        {
            Pais.Codigo = "";
            Pais.Pais = "";
        }

        private void EventConfig(bool Config)
        {
            if (Config == true)
                TxBCodigoPais.Leave += TxBCodigoPais_Leave;
            else
                TxBCodigoPais.Leave -= TxBCodigoPais_Leave;
        }

        private void Data(DataTable Table)
        {
            TxBCodigo.Text = Table.Rows[Current]["Codigo"].ToString();
            TxBEstado.Text = Table.Rows[Current]["Estado"].ToString();
            TxBSigla.Text = Table.Rows[Current]["Sigla"].ToString();
            TxBCodigoPais.Text = Table.Rows[Current]["CodigoPais"].ToString();
            TxBPais.Text = Table.Rows[Current]["Pais"].ToString();

            Pais.Codigo = TxBCodigoPais.Text;
        }

        private void EstadosF_FormClosing(object sender, FormClosingEventArgs e)
        {
            Estado.Dispose();
            Pais.Dispose();
        }
    }
}
