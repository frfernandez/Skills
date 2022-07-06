using System;
using System.Data;
using System.Windows.Forms;
using Database;
using Basics;
using Entity.Map;
using Entity.People;
using Map;
using Objects;
using Objects.Enumerator;
using Operational;

namespace People
{
    public partial class PessoasF : Form
    {
        public Command CommandDb;
        public Look LookControls;

        private RecordEnum CRUDRecord = RecordEnum.Insert;
        private Pessoas Pessoa;
        private PessoasEnderecos PessoaEndereco;
        private TitulosEnderecos TituloEndereco;
        private Enderecos Endereco;
        private Bairros Bairro;
        private Cidades Cidade;

        private DataTable TableCidade = null,
                          TablePessoasEnderecos = null;

        public PessoasF()
        {
            InitializeComponent();
        }

        private void PessoaF_Shown(object sender, EventArgs e)
        {
            EventConfig(false);
            LookControls.CRUDButton(PnlPainel1, CRUDRecord);
            LookControls.TextLabel(this, CRUDRecord, "Pessoas");
            EventConfig(true);

            Pessoa = new Pessoas(CommandDb);

            PessoaEndereco = new PessoasEnderecos(CommandDb);
            TituloEndereco = new TitulosEnderecos(CommandDb);
            Endereco = new Enderecos(CommandDb);
            Bairro = new Bairros(CommandDb);
            Cidade = new Cidades(CommandDb);

            EntityClear();
        }

        private void PessoaF_KeyDown(object sender, KeyEventArgs e)
        {
            if (Key.Pressed(sender, e) == Keys.Escape)
                BtnSaida_Click(sender, e);
        }

        private void BtnIAE_Click(object sender, EventArgs e)
        {
            if (PessoaEndereco.Save(Pessoa, "1", MkBCEP.Text, TxBComplemento.Text,
                                    TituloEndereco, Endereco, TxBNumeroResidencia.Text, Bairro, Cidade) == true)
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
            LookControls.TextLabel(this, CRUDRecord, "Pessoas");
            EventConfig(false);
            LookControls.ObjectFocus(TxBCodigoPessoa);
            EventConfig(true);

            EntityClear();
        }

        private void BtnSaida_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TxBCodigoPessoa_Leave(object sender, EventArgs e)
        {
            TxBPessoa.Text = Pessoa.SelectName(TxBCodigoPessoa.Text);
            if (String.IsNullOrEmpty(TxBPessoa.Text) == true)
            {
                TxBCodigoPessoa.Text = TxBPessoa.Text;
                BtnCodigoPessoa_Click(sender, e);
            }
            else
                Data();
        }

        private void BtnCodigoPessoa_Click(object sender, EventArgs e)
        {
            using (SearchDataF SearchForm = new SearchDataF())
            {
                try
                {
                    SearchForm.TxBDescricao.CharacterCasing = CharacterCasing.Upper;
                    SearchForm.CommandDb = CommandDb;
                    SearchForm.LookControls = LookControls;
                    SearchForm.CRUDRecord = RecordEnum.Select;
                    SearchForm.TableConfigSearch = Pessoa.TableConfigSearch;
                    SearchForm.TableList = Pessoa.SelectDataTable("");
                    SearchForm.ParameterId = "Codigo";
                    SearchForm.ParameterName = "Pessoa";
                    SearchForm.Text = Pessoa.FormText;
                    SearchForm.ShowDialog();
                }
                finally
                {
                    if (String.IsNullOrEmpty(SearchForm.IdValue) == false)
                    {
                        TxBCodigoPessoa.Text = SearchForm.IdValue;
                        TxBPessoa.Text = SearchForm.NameValue;

                        Pessoa.Id = SearchForm.IdValue;
                        Pessoa.Name = SearchForm.NameValue;
                        Data();
                    }

                    SearchForm.Dispose();
                }
            }
        }

        private void TxBCodigoTitulo_Leave(object sender, EventArgs e)
        {
            TxBTitulo.Text = TituloEndereco.SelectName(TxBCodigoTitulo.Text);
            if (String.IsNullOrEmpty(TxBTitulo.Text) == true)
            {
                TxBCodigoTitulo.Text = TxBTitulo.Text;
                BtnCodigoTitulo_Click(sender, e);
            }
        }

        private void BtnCodigoTitulo_Click(object sender, EventArgs e)
        {
            using (SearchDataF SearchForm = new SearchDataF())
            {
                try
                {
                    SearchForm.TxBDescricao.CharacterCasing = CharacterCasing.Upper;
                    SearchForm.CommandDb = CommandDb;
                    SearchForm.LookControls = LookControls;
                    SearchForm.CRUDRecord = RecordEnum.Select;
                    SearchForm.TableConfigSearch = TituloEndereco.TableConfigSearch;
                    SearchForm.TableList = TituloEndereco.SelectDataTable("");
                    SearchForm.ParameterId = "Codigo";
                    SearchForm.ParameterName = "Titulo";
                    SearchForm.Text = TituloEndereco.FormText;
                    SearchForm.ShowDialog();
                }
                finally
                {
                    if (String.IsNullOrEmpty(SearchForm.IdValue) == false)
                    {
                        TxBCodigoTitulo.Text = SearchForm.IdValue;
                        TxBTitulo.Text = SearchForm.NameValue;

                        TituloEndereco.Id = SearchForm.IdValue;
                        TituloEndereco.Name = SearchForm.NameValue;
                    }

                    SearchForm.Dispose();
                }
            }
        }

        private void TxBCodigoEndereco_Leave(object sender, EventArgs e)
        {
            TxBEndereco.Text = Endereco.SelectName(TxBCodigoEndereco.Text);
            if (String.IsNullOrEmpty(TxBEndereco.Text) == true)
            {
                TxBCodigoEndereco.Text = TxBEndereco.Text;
                BtnCodigoEndereco_Click(sender, e);
            }
        }

        private void BtnCodigoEndereco_Click(object sender, EventArgs e)
        {
            using (SearchDataF SearchForm = new SearchDataF())
            {
                try
                {
                    SearchForm.TxBDescricao.CharacterCasing = CharacterCasing.Upper;
                    SearchForm.CommandDb = CommandDb;
                    SearchForm.LookControls = LookControls;
                    SearchForm.CRUDRecord = RecordEnum.Select;
                    SearchForm.TableConfigSearch = Endereco.TableConfigSearch;
                    SearchForm.TableList = Endereco.SelectDataTable("");
                    SearchForm.ParameterId = "Codigo";
                    SearchForm.ParameterName = "Endereco";
                    SearchForm.Text = Endereco.FormText;
                    SearchForm.ShowDialog();
                }
                finally
                {
                    if (String.IsNullOrEmpty(SearchForm.IdValue) == false)
                    {
                        TxBCodigoEndereco.Text = SearchForm.IdValue;
                        TxBEndereco.Text = SearchForm.NameValue;

                        Endereco.Id = SearchForm.IdValue;
                        Endereco.Name = SearchForm.NameValue;
                    }

                    SearchForm.Dispose();
                }
            }
        }

        private void TxBCodigoBairro_Leave(object sender, EventArgs e)
        {
            TxBBairro.Text = Bairro.SelectName(TxBCodigoBairro.Text);
            if (String.IsNullOrEmpty(TxBBairro.Text) == true)
            {
                TxBCodigoBairro.Text = TxBBairro.Text;
                BtnCodigoBairro_Click(sender, e);
            }
        }

        private void BtnCodigoBairro_Click(object sender, EventArgs e)
        {
            using (SearchDataF SearchForm = new SearchDataF())
            {
                try
                {
                    SearchForm.TxBDescricao.CharacterCasing = CharacterCasing.Upper;
                    SearchForm.CommandDb = CommandDb;
                    SearchForm.LookControls = LookControls;
                    SearchForm.CRUDRecord = RecordEnum.Select;
                    SearchForm.TableConfigSearch = Bairro.TableConfigSearch;
                    SearchForm.TableList = Bairro.SelectDataTable("");
                    SearchForm.ParameterId = "Codigo";
                    SearchForm.ParameterName = "Bairro";
                    SearchForm.Text = Bairro.FormText;
                    SearchForm.ShowDialog();
                }
                finally
                {
                    if (String.IsNullOrEmpty(SearchForm.IdValue) == false)
                    {
                        TxBCodigoBairro.Text = SearchForm.IdValue;
                        TxBBairro.Text = SearchForm.NameValue;

                        Bairro.Id = SearchForm.IdValue;
                        Bairro.Name = SearchForm.NameValue;
                    }

                    SearchForm.Dispose();
                }
            }
        }

        private void TxBCodigoCidade_Leave(object sender, EventArgs e)
        {
            TxBCidade.Text = Cidade.SelectName(TxBCodigoCidade.Text);
            if (String.IsNullOrEmpty(TxBCidade.Text) == true)
            {
                TxBCodigoCidade.Text = TxBCidade.Text;
                BtnCodigoCidade_Click(sender, e);
            }

            if (String.IsNullOrEmpty(TxBCodigoCidade.Text) == false)
            {
                TableCidade = Cidade.SelectDataTable(TxBCodigoCidade.Text, "");
                TxBCidade.Text = TableCidade.DefaultView[0]["Cidade"].ToString();
                TxBCodigoEstado.Text = TableCidade.DefaultView[0]["CodigoEstado"].ToString();
                TxBEstado.Text = TableCidade.DefaultView[0]["Estado"].ToString();
                TxBEstadoSigla.Text = TableCidade.DefaultView[0]["EstadoSigla"].ToString();
                TxBCodigoPais.Text = TableCidade.DefaultView[0]["CodigoPais"].ToString();
                TxBPais.Text = TableCidade.DefaultView[0]["Pais"].ToString();
                TxBPaisSigla.Text = TableCidade.DefaultView[0]["PaisSigla"].ToString();
                TxBCodigoContinente.Text = TableCidade.DefaultView[0]["CodigoContinente"].ToString();
                TxBContinente.Text = TableCidade.DefaultView[0]["Continente"].ToString();
            }
        }

        private void BtnCodigoCidade_Click(object sender, EventArgs e)
        {
            using (SearchDataF SearchForm = new SearchDataF())
            {
                try
                {
                    SearchForm.TxBDescricao.CharacterCasing = CharacterCasing.Upper;
                    SearchForm.CommandDb = CommandDb;
                    SearchForm.LookControls = LookControls;
                    SearchForm.CRUDRecord = RecordEnum.Select;
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
                        TxBCodigoCidade.Text = SearchForm.IdValue;
                        TxBCidade.Text = SearchForm.NameValue;

                        Cidade.Codigo = SearchForm.IdValue;
                        Cidade.Cidade = SearchForm.NameValue;
                    }

                    SearchForm.Dispose();
                }
            }
        }

        private void pessoasMenu2_Click(object sender, EventArgs e)
        {
            using (SimpleF SimpleForm = new SimpleF())
            {
                try
                {
                    if (String.IsNullOrEmpty(TxBCodigoPessoa.Text) == true)
                        SimpleForm.CRUDRecord = RecordEnum.Insert;
                    else
                    {
                        SimpleForm.CRUDRecord = RecordEnum.Update;
                        SimpleForm.TxBCodigo.Text = TxBCodigoPessoa.Text;
                        SimpleForm.TxBDescricao.Text = TxBPessoa.Text;
                    }

                    SimpleForm.TxBDescricao.CharacterCasing = CharacterCasing.Upper;
                    SimpleForm.CommandDb = CommandDb;
                    SimpleForm.LookControls = LookControls;
                    SimpleForm.TupleIdName = Pessoa;
                    SimpleForm.Text = pessoasMenu2.Text;
                    SimpleForm.ShowDialog();
                }
                finally
                {
                    SimpleForm.Dispose();
                }
            }
        }

        private void titulosEnderecosMenu2_Click(object sender, EventArgs e)
        {
            using (SimpleF SimpleForm = new SimpleF())
            {
                try
                {
                    if (String.IsNullOrEmpty(TxBCodigoTitulo.Text) == true)
                        SimpleForm.CRUDRecord = RecordEnum.Insert;
                    else
                    {
                        SimpleForm.CRUDRecord = RecordEnum.Update;
                        SimpleForm.TxBCodigo.Text = TxBCodigoTitulo.Text;
                        SimpleForm.TxBDescricao.Text = TxBTitulo.Text;
                    }

                    SimpleForm.TxBDescricao.CharacterCasing = CharacterCasing.Upper;
                    SimpleForm.CommandDb = CommandDb;
                    SimpleForm.LookControls = LookControls;
                    SimpleForm.TupleIdName = TituloEndereco;
                    SimpleForm.Text = titulosEnderecosMenu2.Text;
                    SimpleForm.ShowDialog();
                }
                finally
                {
                    SimpleForm.Dispose();
                }
            }
        }

        private void enderecosMenu2_Click(object sender, EventArgs e)
        {
            using (SimpleF SimpleForm = new SimpleF())
            {
                try
                {
                    if (String.IsNullOrEmpty(TxBCodigoEndereco.Text) == true)
                        SimpleForm.CRUDRecord = RecordEnum.Insert;
                    else
                    {
                        SimpleForm.CRUDRecord = RecordEnum.Update;
                        SimpleForm.TxBCodigo.Text = TxBCodigoEndereco.Text;
                        SimpleForm.TxBDescricao.Text = TxBEndereco.Text;
                    }

                    SimpleForm.TxBDescricao.CharacterCasing = CharacterCasing.Upper;
                    SimpleForm.CommandDb = CommandDb;
                    SimpleForm.LookControls = LookControls;
                    SimpleForm.TupleIdName = Endereco;
                    SimpleForm.Text = enderecosMenu2.Text;
                    SimpleForm.ShowDialog();
                }
                finally
                {
                    SimpleForm.Dispose();
                }
            }
        }

        private void bairrosMenu2_Click(object sender, EventArgs e)
        {
            using (SimpleF SimpleForm = new SimpleF())
            {
                try
                {
                    if (String.IsNullOrEmpty(TxBCodigoBairro.Text) == true)
                        SimpleForm.CRUDRecord = RecordEnum.Insert;
                    else
                    {
                        SimpleForm.CRUDRecord = RecordEnum.Update;
                        SimpleForm.TxBCodigo.Text = TxBCodigoBairro.Text;
                        SimpleForm.TxBDescricao.Text = TxBBairro.Text;
                    }

                    SimpleForm.TxBDescricao.CharacterCasing = CharacterCasing.Upper;
                    SimpleForm.CommandDb = CommandDb;
                    SimpleForm.LookControls = LookControls;
                    SimpleForm.TupleIdName = Bairro;
                    SimpleForm.Text = bairrosMenu2.Text;
                    SimpleForm.ShowDialog();
                }
                finally
                {
                    SimpleForm.Dispose();
                }
            }
        }

        private void cidadesMenu2_Click(object sender, EventArgs e)
        {
            using (CidadesF CidadesForm = new CidadesF())
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
                PessoaEndereco.Insert();
            else if (CRUDRecord == RecordEnum.Update)
                PessoaEndereco.Update();
            else if (CRUDRecord == RecordEnum.Delete)
                Pessoa.Delete();
        }

        private void EntityClear()
        {
            Pessoa.Id = "";
            Pessoa.Name = "";

            PessoaEndereco.Posicao = "";
            PessoaEndereco.CEP = "";
            PessoaEndereco.NumeroResidencia = "";

            TituloEndereco.Id = "";
            TituloEndereco.Name = "";

            Endereco.Id = "";
            Endereco.Name = "";

            Bairro.Id = "";
            Bairro.Name = "";

            Cidade.Codigo = "";

            TableCidade = null;
            TablePessoasEnderecos = null;
        }

        private void EventConfig(bool Config)
        {
            if (Config == true)
            {
                TxBCodigoPessoa.Leave += TxBCodigoPessoa_Leave;
                TxBCodigoTitulo.Leave += TxBCodigoTitulo_Leave;
                TxBCodigoEndereco.Leave += TxBCodigoEndereco_Leave;
                TxBCodigoBairro.Leave += TxBCodigoBairro_Leave;
                TxBCodigoCidade.Leave += TxBCodigoCidade_Leave;
            }
            else
            {
                TxBCodigoPessoa.Leave -= TxBCodigoPessoa_Leave;
                TxBCodigoTitulo.Leave -= TxBCodigoTitulo_Leave;
                TxBCodigoEndereco.Leave -= TxBCodigoEndereco_Leave;
                TxBCodigoBairro.Leave -= TxBCodigoBairro_Leave;
                TxBCodigoCidade.Leave -= TxBCodigoCidade_Leave;
            }
        }

        private void Data()
        {
            EntityClear();

            if (String.IsNullOrEmpty(TxBCodigoPessoa.Text) == true)
                Pessoa.Id = "0";
            else
                Pessoa.Id = TxBCodigoPessoa.Text;

            TxBPessoa.Text = Pessoa.SelectName(TxBCodigoPessoa.Text);
            Pessoa.Name = TxBPessoa.Text;

            TablePessoasEnderecos = PessoaEndereco.SelectDataTable(Pessoa);
            if (TablePessoasEnderecos.Rows.Count == 0)
                CRUDRecord = RecordEnum.Insert;
            else
            {
                CRUDRecord = RecordEnum.Update;

                MkBCEP.Text = TablePessoasEnderecos.DefaultView[0]["CEP"].ToString();
                TxBCodigoTitulo.Text = TablePessoasEnderecos.DefaultView[0]["CodigoTitulo"].ToString();
                TxBTitulo.Text = TablePessoasEnderecos.DefaultView[0]["Titulo"].ToString();
                TxBCodigoEndereco.Text = TablePessoasEnderecos.DefaultView[0]["CodigoEndereco"].ToString();
                TxBEndereco.Text = TablePessoasEnderecos.DefaultView[0]["Endereco"].ToString();
                TxBNumeroResidencia.Text = TablePessoasEnderecos.DefaultView[0]["NumeroResidencia"].ToString();
                TxBCodigoBairro.Text = TablePessoasEnderecos.DefaultView[0]["CodigoBairro"].ToString();
                TxBBairro.Text = TablePessoasEnderecos.DefaultView[0]["Bairro"].ToString();
                TxBCodigoCidade.Text = TablePessoasEnderecos.DefaultView[0]["CodigoCidade"].ToString();
                TxBCidade.Text = TablePessoasEnderecos.DefaultView[0]["Cidade"].ToString();
                TxBCodigoEstado.Text = TablePessoasEnderecos.DefaultView[0]["CodigoEstado"].ToString();
                TxBEstado.Text = TablePessoasEnderecos.DefaultView[0]["Estado"].ToString();
                TxBEstadoSigla.Text = TablePessoasEnderecos.DefaultView[0]["EstadoSigla"].ToString();
                TxBCodigoPais.Text = TablePessoasEnderecos.DefaultView[0]["CodigoPais"].ToString();
                TxBPais.Text = TablePessoasEnderecos.DefaultView[0]["Pais"].ToString();
                TxBPaisSigla.Text = TablePessoasEnderecos.DefaultView[0]["PaisSigla"].ToString();
                TxBCodigoContinente.Text = TablePessoasEnderecos.DefaultView[0]["CodigoContinente"].ToString();
                TxBContinente.Text = TablePessoasEnderecos.DefaultView[0]["Continente"].ToString();
                TxBComplemento.Text = TablePessoasEnderecos.DefaultView[0]["Complemento"].ToString();
            }

            PessoaEndereco.Posicao = "1";
            TituloEndereco.Id = TxBCodigoTitulo.Text;
            Endereco.Id = TxBCodigoEndereco.Text;
            Bairro.Id = TxBCodigoBairro.Text;
            Cidade.Codigo = TxBCodigoCidade.Text;

            LookControls.CRUDButton(PnlPainel1, CRUDRecord);
            LookControls.TextLabel(this, CRUDRecord, "Pessoas");
        }

        private void PessoaF_FormClosing(object sender, FormClosingEventArgs e)
        {
            Pessoa.Dispose();
            PessoaEndereco.Dispose();
            TituloEndereco.Dispose();
            Endereco.Dispose();
            Bairro.Dispose();
            Cidade.Dispose();
        }
    }
}
