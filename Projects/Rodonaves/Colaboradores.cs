using System;
using System.Data;
using System.Windows.Forms;
using Database;
using Basics;
using Entity;
using Entity.Rodonaves;
using Objects;
using Objects.Enumerator;
using Operational;
using Search;

namespace Map
{
    public partial class ColaboradoresF : Form
    {
        public Command CommandDb;
        public DataTables Configuration;
        public Look LookControls;
        public string ItemPrivilege;
        public DataFilters DataFilter;

        private RecordEnum CRUDRecord = RecordEnum.Insert;
        private Colaboradores Colaborador;
        private Usuarios Usuario;
        private Unidades Unidade;
        private int Current = 0;

        private DataTable TableIdNameTuple = null;

        public ColaboradoresF()
        {
            InitializeComponent();
        }

        private void ColaboradoresF_Shown(object sender, EventArgs e)
        {
            EventConfig(false);
            LookControls.CRUDButton(PnlPanel1, CRUDRecord);
            LookControls.TextLabel(this, CRUDRecord, "Colaboradores");
            LookControls.Form(this, Images, TTpTip);
            EventConfig(true);

            Colaborador = new Colaboradores(CommandDb, Configuration);
            Colaborador.Form = ((Form)sender).Name;
            Colaborador.Task = SystemEnum.Table_Insert;

            Usuario = new Usuarios(CommandDb, Configuration);
            Usuario.Form = ((Form)sender).Name;
            Usuario.Task = SystemEnum.Table_Insert;

            Unidade = new Unidades(CommandDb, Configuration);
            Unidade.Form = ((Form)sender).Name;
            Unidade.Task = SystemEnum.Table_Insert;

            FormConfig();
            EntityClear();
        }

        private void ColaboradoresF_KeyDown(object sender, KeyEventArgs e)
        {
            Keys KeyPressed = Key.Pressed(sender, e);

            if (KeyPressed == Keys.Escape)
                BtnExit_Click(sender, e);
            else if (KeyPressed == Keys.Cancel)
                MessageBox.Show("Sem privilégios de acesso ao item de menu.");
        }

        private void BtnIUD_Click(object sender, EventArgs e)
        {
            if (CRUDRecord == RecordEnum.Delete)
            {
                CRUDConfig();
                BtnCancel_Click(sender, e);
            }
            else
            {
                if (Colaborador.Save(TxBId.Text, TxBNome.Text, Usuario, Unidade) == true)
                {
                    CRUDConfig();
                    BtnCancel_Click(sender, e);
                }
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Values.PanelClean(PnlPanel2);

            CRUDRecord = RecordEnum.Insert;
            LookControls.CRUDButton(PnlPanel1, CRUDRecord);
            LookControls.TextLabel(this, CRUDRecord, "Colaboradores");
            EventConfig(false);
            LookControls.ObjectFocus(TxBNome);
            EventConfig(true);

            EntityClear();
            Enable();
        }

        private void BtnFilter_Click(object sender, EventArgs e)
        {
            EntityClear();

            using (SearchDataListF SearchForm = new SearchDataListF())
            {
                try
                {
                    SearchForm.TxBDescription.CharacterCasing = CharacterCasing.Upper;
                    SearchForm.CommandDb = CommandDb;
                    SearchForm.Configuration = Configuration;
                    SearchForm.LookControls = LookControls;
                    SearchForm.CRUDRecord = CRUDRecord;
                    SearchForm.TableConfigSearch = "Colaboradores";
                    SearchForm.ItemPrivilege = ItemPrivilege;
                    SearchForm.Text = "Colaboradores";
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
                        LookControls.TextLabel(this, CRUDRecord, "Colaboradores");
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

        private void TxBCodigoUsuario_Leave(object sender, EventArgs e)
        {
            TableIdNameTuple = null;

            if (String.IsNullOrEmpty(TxBCodigoUsuario.Text) == true)
                TxBUsuario.Text = "";
            else
                TableIdNameTuple = Usuario.SelectDataTable(TxBCodigoUsuario.Text, "", "");

            if ((TableIdNameTuple == null) || (TableIdNameTuple.Rows.Count == 0))
            {
                TxBUsuario.Text = "";
                BtnCodigoUsuario_Click(sender, e);
            }
            else
            {
                TxBCodigoUsuario.Text = TableIdNameTuple.Rows[0]["Codigo"].ToString();
                TxBUsuario.Text = TableIdNameTuple.Rows[0]["Login"].ToString();
            }
        }

        private void BtnCodigoUsuario_Click(object sender, EventArgs e)
        {
            using (SearchDataListF SearchForm = new SearchDataListF())
            {
                try
                {
                    SearchForm.TxBDescription.CharacterCasing = CharacterCasing.Upper;
                    SearchForm.CommandDb = CommandDb;
                    SearchForm.Configuration = Configuration;
                    SearchForm.LookControls = LookControls;
                    SearchForm.CRUDRecord = RecordEnum.Select;
                    SearchForm.TableConfigSearch = "Usuarios";
                    SearchForm.Text = "Usuarios";
                    SearchForm.ShowDialog();
                }
                finally
                {
                    if (String.IsNullOrEmpty(SearchForm.IdValue) == false)
                    {
                        TxBCodigoUsuario.Text = SearchForm.IdValue;
                        TxBUsuario.Text = SearchForm.NameValue;

                        Usuario.Codigo = SearchForm.IdValue;
                        Usuario.Login = SearchForm.NameValue;
                    }

                    SearchForm.Dispose();
                }
            }
        }

        private void TxBCodigoUnidade_Leave(object sender, EventArgs e)
        {
            TableIdNameTuple = null;

            if (String.IsNullOrEmpty(TxBCodigoUnidade.Text) == true)
                TxBUnidade.Text = "";
            else
                TableIdNameTuple = Unidade.SelectDataTable(TxBCodigoUnidade.Text, "", "");

            if ((TableIdNameTuple == null) || (TableIdNameTuple.Rows.Count == 0))
            {
                TxBUnidade.Text = "";
                BtnCodigoUnidade_Click(sender, e);
            }
            else
            {
                TxBCodigoUnidade.Text = TableIdNameTuple.Rows[0]["Codigo"].ToString();
                TxBUnidade.Text = TableIdNameTuple.Rows[0]["Nome"].ToString();
            }
        }

        private void BtnCodigoUnidade_Click(object sender, EventArgs e)
        {
            using (SearchDataListF SearchForm = new SearchDataListF())
            {
                try
                {
                    SearchForm.TxBDescription.CharacterCasing = CharacterCasing.Upper;
                    SearchForm.CommandDb = CommandDb;
                    SearchForm.Configuration = Configuration;
                    SearchForm.LookControls = LookControls;
                    SearchForm.CRUDRecord = RecordEnum.Select;
                    SearchForm.TableConfigSearch = "Unidades";
                    SearchForm.Text = "Unidades";
                    SearchForm.ShowDialog();
                }
                finally
                {
                    if (String.IsNullOrEmpty(SearchForm.IdValue) == false)
                    {
                        TxBCodigoUnidade.Text = SearchForm.IdValue;
                        TxBUnidade.Text = SearchForm.NameValue;

                        Unidade.Codigo = SearchForm.IdValue;
                        Unidade.Nome = SearchForm.NameValue;
                    }

                    SearchForm.Dispose();
                }
            }
        }

        private void FormConfig()
        {
            if (DataFilter.DataTableFilter != null)
            {
                BtnCancel.Visible = false;
                BtnFilter.Visible = false;

                BtnExit.Left = BtnCancel.Left;
            }
        }

        private void CRUDConfig()
        {
            if (CRUDRecord == RecordEnum.Insert)
                Colaborador.Insert();
            else if (CRUDRecord == RecordEnum.Update)
                Colaborador.Update();
            else if (CRUDRecord == RecordEnum.Delete)
                Colaborador.Delete();
        }

        private void EntityClear()
        {
            Usuario.Codigo = "";
            Usuario.Login = "";

            Unidade.Codigo = "";
            Unidade.Nome = "";
        }

        private void EventConfig(bool Config)
        {
            if (Config == true)
            {
                TxBCodigoUsuario.Leave += TxBCodigoUsuario_Leave;
                TxBCodigoUnidade.Leave += TxBCodigoUnidade_Leave;
            }
            else
            {
                TxBCodigoUsuario.Leave -= TxBCodigoUsuario_Leave;
                TxBCodigoUnidade.Leave -= TxBCodigoUnidade_Leave;
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
            DataFilter.View = "VwColaboradores";
            DataFilter.Form = ((Form)this).Name;
            DataFilter.Config();
            Table = DataFilter.TableResult(Table, "FltColaboradores");

            TxBId.Text = Table.Rows[Current]["Codigo"].ToString();
            TxBNome.Text = Table.Rows[Current]["Nome"].ToString();
            TxBCodigoUsuario.Text = Table.Rows[Current]["CodigoUsuario"].ToString();
            TxBUsuario.Text = Table.Rows[Current]["Usuario"].ToString();
            TxBCodigoUnidade.Text = Table.Rows[Current]["CodigoUnidade"].ToString();
            TxBUnidade.Text = Table.Rows[Current]["Unidade"].ToString();

            Colaborador.Codigo = TxBId.Text;
            Usuario.Codigo = TxBCodigoUsuario.Text;
            Unidade.Codigo = TxBCodigoUnidade.Text;
        }

        private void RowChanged(object sender, DataRowChangeEventArgs e)
        {
            Data(DataFilter.DataTableNavigator);
        }

        private void ColaboradoresF_FormClosing(object sender, FormClosingEventArgs e)
        {
            Colaborador.Dispose();
            Usuario.Dispose();
            Unidade.Dispose();
        }
    }
}
