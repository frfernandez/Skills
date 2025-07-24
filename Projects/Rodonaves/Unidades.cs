using System;
using System.Data;
using System.Windows.Forms;
using Database;
using Basics;
using Entity;
using Objects;
using Objects.Enumerator;
using Operational;
using Entity.Rodonaves;

namespace Identification
{
    public partial class UnidadesF : Form
    {
        public Command CommandDb;
        public DataTables Configuration;
        public Look LookControls;
        public string ItemPrivilege;
        public DataFilters DataFilter;

        private RecordEnum CRUDRecord = RecordEnum.Insert;
        private Unidades Unidade;
        private int Current = 0;

        public UnidadesF()
        {
            InitializeComponent();
        }

        private void UnidadesF_Shown(object sender, EventArgs e)
        {
            LookControls.CRUDButton(PnlPanel1, CRUDRecord);
            LookControls.TextLabel(this, CRUDRecord, "Unidades");
            LookControls.Form(this, Images, TTpTip);

            Unidade = new Unidades(CommandDb, Configuration);
            Unidade.Form = ((Form)sender).Name;
            Unidade.Task = SystemEnum.Table_Insert;

            FormConfig();
            EntityClear();
        }

        private void UnidadesF_KeyDown(object sender, KeyEventArgs e)
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
                if (Unidade.Save(TxBCodigo.Text, TxBUnidade.Text, Values.CheckBoxValue(CkBAtiva)) == true)
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
            LookControls.TextLabel(this, CRUDRecord, "Unidades");
            LookControls.ObjectFocus(TxBUnidade);

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
                    SearchForm.TableConfigSearch = "Unidades";
                    SearchForm.ItemPrivilege = ItemPrivilege;
                    SearchForm.Text = "Unidades";
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
                        LookControls.TextLabel(this, CRUDRecord, "Unidades");
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
                Unidade.Insert();
            else if (CRUDRecord == RecordEnum.Update)
                Unidade.Update();
            else if (CRUDRecord == RecordEnum.Delete)
                Unidade.Delete();
        }

        private void EntityClear()
        {
            Unidade.Codigo = "";
            Unidade.Nome = "";
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
            if (Table.TableName.ToUpper() == "Navigator".ToUpper())
                Current = 0;

            DataFilter.View = "VwUnidades";
            DataFilter.Form = ((Form)this).Name;
            DataFilter.Config();
            Table = DataFilter.TableResult(Table, "FltUnidades");

            TxBCodigo.Text = Table.Rows[Current]["Codigo"].ToString();
            TxBUnidade.Text = Table.Rows[Current]["Nome"].ToString();
            Values.CheckBoxPosition(CkBAtiva, Table.Rows[0]["Ativa"].ToString());

            Unidade.Codigo = TxBCodigo.Text;
        }

        private void RowChanged(object sender, DataRowChangeEventArgs e)
        {
            Data(DataFilter.DataTableNavigator);
        }

        private void Unidades_FormClosing(object sender, FormClosingEventArgs e)
        {
            Unidade.Dispose();
        }
    }
}
