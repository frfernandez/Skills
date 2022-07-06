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
    public partial class CidadesF : Form
    {
        public Command CommandDb;
        public Look LookControls;

        private RecordEnum CRUDRecord = RecordEnum.Insert;
        private Cidades Cidade;
        private Paises Pais;
        private Estados Estado;
        private int Current = 0;

        public CidadesF()
        {
            InitializeComponent();
        }

        private void CidadesF_Shown(object sender, EventArgs e)
        {
            EventConfig(false);
            LookControls.CRUDButton(PnlPainel1, CRUDRecord);
            LookControls.TextLabel(this, CRUDRecord, "Cidades");
            EventConfig(true);

            Cidade = new Cidades(CommandDb);
            Pais = new Paises(CommandDb);
            Estado = new Estados(CommandDb);

            EntityClear();
        }

        private void CidadesF_KeyDown(object sender, KeyEventArgs e)
        {
            if (Key.Pressed(sender, e) == Keys.Escape)
                BtnSaida_Click(sender, e);
        }

        private void BtnIAE_Click(object sender, EventArgs e)
        {
            if (Cidade.Save(TxBCodigo.Text, TxBCidade.Text, Estado) == true)
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
            LookControls.TextLabel(this, CRUDRecord, "Cidades");
            EventConfig(false);
            LookControls.ObjectFocus(TxBCidade);
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
                    SearchForm.TableConfigSearch = "Cidades";
                    SearchForm.TableList = Cidade.SelectDataTable("", "");
                    SearchForm.ParameterId = "Codigo";
                    SearchForm.ParameterName = "Cidade";
                    SearchForm.Text = "Cidades";
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
                        LookControls.TextLabel(this, CRUDRecord, "Cidades");
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

        private void TxBCodigoEstado_Leave(object sender, EventArgs e)
        {
            TxBEstado.Text = Estado.SelectName(TxBCodigoEstado.Text, Pais);
            if (String.IsNullOrEmpty(TxBEstado.Text) == true)
            {
                TxBCodigoEstado.Text = TxBEstado.Text;
                BtnCodigoEstado_Click(sender, e);
            }
        }

        private void BtnCodigoEstado_Click(object sender, EventArgs e)
        {
            using (SearchDataF SearchForm = new SearchDataF())
            {
                try
                {
                    SearchForm.TxBDescricao.CharacterCasing = CharacterCasing.Upper;
                    SearchForm.CommandDb = CommandDb;
                    SearchForm.LookControls = LookControls;
                    SearchForm.CRUDRecord = RecordEnum.Select;
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
                        TxBCodigoEstado.Text = SearchForm.IdValue;
                        TxBEstado.Text = SearchForm.NameValue;

                        Estado.Codigo = SearchForm.IdValue;
                        Estado.Estado = SearchForm.NameValue;
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

        private void estadosMenu_Click(object sender, EventArgs e)
        {
            using (EstadosF EstadosForm = new EstadosF())
            {
                try
                {
                    EstadosForm.CommandDb = CommandDb;
                    EstadosForm.LookControls = LookControls;
                    EstadosForm.ShowDialog();
                }
                finally
                {
                    EstadosForm.Dispose();
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
                Cidade.Insert();
            else if (CRUDRecord == RecordEnum.Update)
                Cidade.Update();
            else if (CRUDRecord == RecordEnum.Delete)
                Cidade.Delete();
        }

        private void EntityClear()
        {
            Pais.Codigo = "";
            Pais.Pais = "";

            Estado.Codigo = "";
            Estado.Estado = "";
        }

        private void EventConfig(bool Config)
        {
            if (Config == true)
            {
                TxBCodigoPais.Leave += TxBCodigoPais_Leave;
                TxBCodigoEstado.Leave += TxBCodigoEstado_Leave;
            }
            else
            {
                TxBCodigoPais.Leave -= TxBCodigoPais_Leave;
                TxBCodigoEstado.Leave -= TxBCodigoEstado_Leave;
            }
        }

        private void Data(DataTable Table)
        {
            TxBCodigo.Text = Table.Rows[Current]["Codigo"].ToString();
            TxBCidade.Text = Table.Rows[Current]["Cidade"].ToString();
            TxBCodigoPais.Text = Table.Rows[Current]["CodigoPais"].ToString();
            TxBPais.Text = Table.Rows[Current]["Pais"].ToString();
            TxBCodigoEstado.Text = Table.Rows[Current]["CodigoEstado"].ToString();
            TxBEstado.Text = Table.Rows[Current]["Estado"].ToString();

            Pais.Codigo = TxBCodigoPais.Text;
            Estado.Codigo = TxBCodigoEstado.Text;
        }

        private void CidadesF_FormClosing(object sender, FormClosingEventArgs e)
        {
            Cidade.Dispose();
            Pais.Dispose();
            Estado.Dispose();
        }
    }
}
